﻿/*
 * Copyright (C) 2012-2020 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Framework.Constants;
using Game.AI;
using Game.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Game.Movement
{
    public class WaypointMovementGenerator : MovementGeneratorMedium<Creature>
    {
        public WaypointMovementGenerator(uint pathId = 0, bool repeating = true)
        {
            _nextMoveTime = new TimeTracker(0);
            _pathId = pathId;
            _repeating = repeating;
            _loadedFromDB = true;

            Mode = MovementGeneratorMode.Default;
            Priority = MovementGeneratorPriority.Normal;
            Flags = MovementGeneratorFlags.InitializationPending;
            BaseUnitState = UnitState.Roaming;
        }

        public WaypointMovementGenerator(WaypointPath path, bool repeating = true)
        {
            _nextMoveTime = new TimeTracker(0);
            _repeating = repeating;
            _path = path;

            Mode = MovementGeneratorMode.Default;
            Priority = MovementGeneratorPriority.Normal;
            Flags = MovementGeneratorFlags.InitializationPending;
            BaseUnitState = UnitState.Roaming;
        }

        public override void Pause(uint timer = 0)
        {
            if (timer != 0)
            {
                // Don't try to paused an already paused generator
                if (HasFlag(MovementGeneratorFlags.Paused))
                    return;

                AddFlag(MovementGeneratorFlags.TimedPaused);
                _nextMoveTime.Reset(timer);
                RemoveFlag(MovementGeneratorFlags.Paused);
            }
            else
            {
                AddFlag(MovementGeneratorFlags.Paused);
                _nextMoveTime.Reset(1); // Needed so that Update does not behave as if node was reached
                RemoveFlag(MovementGeneratorFlags.TimedPaused);
            }
        }

        public override void Resume(uint overrideTimer = 0)
        {
            if (overrideTimer != 0)
                _nextMoveTime.Reset(overrideTimer);

            if (_nextMoveTime.Passed())
                _nextMoveTime.Reset(1); // Needed so that Update does not behave as if node was reached

            RemoveFlag(MovementGeneratorFlags.Paused);
        }

        public override bool GetResetPosition(Unit owner, out float x, out float y, out float z)
        {
            x = y = z = 0;

            // prevent a crash at empty waypoint path.
            if (_path == null || _path.nodes.Empty())
                return false;

            Cypher.Assert(_currentNode < _path.nodes.Count, $"WaypointMovementGenerator::GetResetPosition: tried to reference a node id ({_currentNode}) which is not included in path ({_path.id})");
            WaypointNode waypoint = _path.nodes.ElementAt(_currentNode);

            x = waypoint.x;
            y = waypoint.y;
            z = waypoint.z;
            return true;
        }

        public override void DoInitialize(Creature owner)
        {
            RemoveFlag(MovementGeneratorFlags.InitializationPending | MovementGeneratorFlags.Transitory | MovementGeneratorFlags.Deactivated);

            if (_loadedFromDB)
            {
                if (_pathId == 0)
                    _pathId = owner.GetWaypointPath();

                _path = Global.WaypointMgr.GetPath(_pathId);
            }

            if (_path == null)
            {
                Log.outError(LogFilter.Sql, $"WaypointMovementGenerator::DoInitialize: couldn't load path for creature ({owner.GetGUID()}) (_pathId: {_pathId})");
                return;
            }

            owner.StopMoving();

            _nextMoveTime.Reset(1000);
        }

        public override void DoReset(Creature owner)
        {
            RemoveFlag(MovementGeneratorFlags.Transitory | MovementGeneratorFlags.Deactivated);

            owner.StopMoving();

            if (!HasFlag(MovementGeneratorFlags.Finalized) && _nextMoveTime.Passed())
                _nextMoveTime.Reset(1); // Needed so that Update does not behave as if node was reached
        }

        public override bool DoUpdate(Creature owner, uint diff)
        {
            if (!owner || !owner.IsAlive())
                return true;

            if (HasFlag(MovementGeneratorFlags.Finalized | MovementGeneratorFlags.Paused) || _path == null || _path.nodes.Empty())
                return true;

            if (owner.HasUnitState(UnitState.NotMove | UnitState.LostControl) || owner.IsMovementPreventedByCasting())
            {
                AddFlag(MovementGeneratorFlags.Interrupted);
                owner.StopMoving();
                return true;
            }

            if (HasFlag(MovementGeneratorFlags.Interrupted))
            {
                /*
                 *  relaunch only if
                 *  - has a tiner? -> was it interrupted while not waiting aka moving? need to check both:
                 *      -> has a timer - is it because its waiting to start next node?
                 *      -> has a timer - is it because something set it while moving (like timed pause)?
                 *
                 *  - doesnt have a timer? -> is movement valid?
                 *
                 *  TODO: ((_nextMoveTime.Passed() && VALID_MOVEMENT) || (!_nextMoveTime.Passed() && !HasFlag(MOVEMENTGENERATOR_FLAG_INFORM_ENABLED)))
                 */
                if (HasFlag(MovementGeneratorFlags.Initialized) && (_nextMoveTime.Passed() || !HasFlag(MovementGeneratorFlags.InformEnabled)))
                {
                    StartMove(owner, true);
                    return true;
                }

                RemoveFlag(MovementGeneratorFlags.Interrupted);
            }

            // if it's moving
            if (!owner.MoveSpline.Finalized())
            {
                // set home position at place (every MotionMaster::UpdateMotion)
                if (owner.GetTransGUID().IsEmpty())
                    owner.SetHomePosition(owner.GetPosition());

                // relaunch movement if its speed has changed
                if (HasFlag(MovementGeneratorFlags.SpeedUpdatePending))
                    StartMove(owner, true);
            }
            else if (!_nextMoveTime.Passed()) // it's not moving, is there a timer?
            {
                if (UpdateTimer(diff))
                {
                    if (!HasFlag(MovementGeneratorFlags.Initialized)) // initial movement call
                    {
                        StartMove(owner);
                        return true;
                    }
                    else if (!HasFlag(MovementGeneratorFlags.InformEnabled)) // timer set before node was reached, resume now
                    {
                        StartMove(owner, true);
                        return true;
                    }
                }
                else
                    return true; // keep waiting
            }
            else // not moving, no timer
            {
                if (HasFlag(MovementGeneratorFlags.Initialized) && !HasFlag(MovementGeneratorFlags.InformEnabled))
                {
                    OnArrived(owner); // hooks and wait timer reset (if necessary)
                    AddFlag(MovementGeneratorFlags.InformEnabled); // signals to future StartMove that it reached a node
                }

                if (_nextMoveTime.Passed()) // OnArrived might have set a timer
                    StartMove(owner); // check path status, get next point and move if necessary & can
            }

            return true;
        }

        public override void DoDeactivate(Creature owner)
        {
            AddFlag(MovementGeneratorFlags.Deactivated);
            owner.ClearUnitState(UnitState.RoamingMove);
        }

        public override void DoFinalize(Creature owner, bool active, bool movementInform)
        {
            AddFlag(MovementGeneratorFlags.Finalized);
            if (active)
            {
                owner.ClearUnitState(UnitState.RoamingMove);

                // TODO: Research if this modification is needed, which most likely isnt
                owner.SetWalk(false);
            }
        }

        void MovementInform(Creature owner)
        {
            CreatureAI ai = owner.GetAI();
            if (ai != null)
                ai.MovementInform(MovementGeneratorType.Waypoint, (uint)_currentNode);
        }

        void OnArrived(Creature owner)
        {
            if (_path == null || _path.nodes.Empty())
                return;

            Cypher.Assert(_currentNode < _path.nodes.Count, $"WaypointMovementGenerator.OnArrived: tried to reference a node id ({_currentNode}) which is not included in path ({_path.id})");
            WaypointNode waypoint = _path.nodes.ElementAt((int)_currentNode);
            if (waypoint.delay != 0)
            {
                owner.ClearUnitState(UnitState.RoamingMove);
                _nextMoveTime.Reset(waypoint.delay);
            }

            if (waypoint.eventId != 0 && RandomHelper.URand(0, 99) < waypoint.eventChance)
            {
                Log.outDebug(LogFilter.MapsScript, $"Creature movement start script {waypoint.eventId} at point {_currentNode} for {owner.GetGUID()}.");
                owner.ClearUnitState(UnitState.RoamingMove);
                owner.GetMap().ScriptsStart(ScriptsType.Waypoint, waypoint.eventId, owner, null);
            }

            // inform AI
            CreatureAI ai = owner.GetAI();
            if (ai != null)
            {
                ai.MovementInform(MovementGeneratorType.Waypoint, (uint)_currentNode);
                ai.WaypointReached(waypoint.id, _path.id);
            }

            owner.UpdateCurrentWaypointInfo(waypoint.id, _path.id);
        }

        void StartMove(Creature owner, bool relaunch = false)
        {
            // sanity checks
            if (owner == null || !owner.IsAlive() || HasFlag(MovementGeneratorFlags.Finalized) || _path == null || _path.nodes.Empty() || (relaunch && (HasFlag(MovementGeneratorFlags.InformEnabled) || !HasFlag(MovementGeneratorFlags.Initialized))))
                return;

            if (owner.HasUnitState(UnitState.NotMove) || owner.IsMovementPreventedByCasting() || (owner.IsFormationLeader() && !owner.IsFormationLeaderMoveAllowed())) // if cannot move OR cannot move because of formation
            {
                _nextMoveTime.Reset(1000); // delay 1s
                return;
            }

            bool transportPath = !owner.GetTransGUID().IsEmpty();

            if (HasFlag(MovementGeneratorFlags.InformEnabled) && HasFlag(MovementGeneratorFlags.Initialized))
            {
                if (ComputeNextNode())
                {
                    Cypher.Assert(_currentNode < _path.nodes.Count, $"WaypointMovementGenerator.StartMove: tried to reference a node id ({_currentNode}) which is not included in path ({_path.id})");
                    // inform AI
                    CreatureAI ai = owner.GetAI();
                    if (ai != null)
                        ai.WaypointStarted(_path.nodes[_currentNode].id, _path.id);
                }
                else
                {
                    WaypointNode currentWaypoint = _path.nodes[_currentNode];
                    float x = currentWaypoint.x;
                    float y = currentWaypoint.y;
                    float z = currentWaypoint.z;
                    float o = owner.GetOrientation();

                    if (!transportPath)
                        owner.SetHomePosition(x, y, z, o);
                    else
                    {
                        ITransport trans = owner.GetTransport();
                        if (trans != null)
                        {
                            o -= trans.GetTransportOrientation();
                            owner.SetTransportHomePosition(x, y, z, o);
                            trans.CalculatePassengerPosition(ref x, ref y, ref z, ref o);
                            owner.SetHomePosition(x, y, z, o);
                        }
                        // else if (vehicle) - this should never happen, vehicle offsets are const
                    }

                    AddFlag(MovementGeneratorFlags.Finalized);
                    owner.UpdateCurrentWaypointInfo(0, 0);

                    // inform AI
                    CreatureAI ai = owner.GetAI();
                    if (ai != null)
                        ai.WaypointPathEnded(currentWaypoint.id, _path.id);
                    return;
                }
            }
            else if (!HasFlag(MovementGeneratorFlags.Initialized))
            {
                AddFlag(MovementGeneratorFlags.Initialized);

                // inform AI
                CreatureAI ai = owner.GetAI();
                if (ai != null)
                    ai.WaypointStarted(_path.nodes[_currentNode].id, _path.id);
            }

            Cypher.Assert(_currentNode < _path.nodes.Count, $"WaypointMovementGenerator.StartMove: tried to reference a node id ({_currentNode}) which is not included in path ({_path.id})");
            WaypointNode waypoint = _path.nodes[_currentNode];

            RemoveFlag(MovementGeneratorFlags.Transitory | MovementGeneratorFlags.InformEnabled | MovementGeneratorFlags.TimedPaused);

            owner.AddUnitState(UnitState.RoamingMove);

            MoveSplineInit init = new(owner);

            //! If creature is on transport, we assume waypoints set in DB are already transport offsets
            if (transportPath)
                init.DisableTransportPathTransformations();

            //! Do not use formationDest here, MoveTo requires transport offsets due to DisableTransportPathTransformations() call
            //! but formationDest contains global coordinates
            init.MoveTo(waypoint.x, waypoint.y, waypoint.z);

            if (waypoint.orientation.HasValue && waypoint.delay != 0)
                init.SetFacing(waypoint.orientation.Value);

            switch (waypoint.moveType)
            {
                case WaypointMoveType.Land:
                    init.SetAnimation(AnimTier.Ground);
                    break;
                case WaypointMoveType.Takeoff:
                    init.SetAnimation(AnimTier.Hover);
                    break;
                case WaypointMoveType.Run:
                    init.SetWalk(false);
                    break;
                case WaypointMoveType.Walk:
                    init.SetWalk(true);
                    break;
            }

            init.Launch();

            // inform formation
            owner.SignalFormationMovement();
        }

        bool ComputeNextNode()
        {
            if ((_currentNode == _path.nodes.Count - 1) && !_repeating)
                return false;

            _currentNode = (_currentNode + 1) % _path.nodes.Count;
            return true;
        }

        public override string GetDebugInfo()
        {
            return $"Current Node: {_currentNode}\n{base.GetDebugInfo()}";
        }
        
        bool UpdateTimer(uint diff)
        {
            _nextMoveTime.Update(diff);
            if (_nextMoveTime.Passed())
            {
                _nextMoveTime.Reset(0);
                return true;
            }
            return false;
        }

        public override MovementGeneratorType GetMovementGeneratorType() { return MovementGeneratorType.Waypoint; }

        public override void UnitSpeedChanged() { AddFlag(MovementGeneratorFlags.SpeedUpdatePending); }

        TimeTracker _nextMoveTime;
        uint _pathId;
        bool _repeating;
        bool _loadedFromDB;

        WaypointPath _path;
        int _currentNode;
    }
}