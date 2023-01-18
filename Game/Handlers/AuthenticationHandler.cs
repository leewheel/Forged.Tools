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
using Game.Networking.Packets;

namespace Game
{
    public partial class WorldSession
    {
        public void SendAuthResponse(BattlenetRpcErrorCode code, bool queued, uint queuePos = 0)
        {
            AuthResponse response = new();
            response.Result = code;

            if (code == BattlenetRpcErrorCode.Ok)
            {
                response.SuccessInfo = new();

                response.SuccessInfo = new AuthResponse.AuthSuccessInfo();
                response.SuccessInfo.ActiveExpansionLevel = (byte)GetExpansion();
                response.SuccessInfo.AccountExpansionLevel = (byte)GetAccountExpansion();
                response.SuccessInfo.VirtualRealmAddress = Global.WorldMgr.GetVirtualRealmAddress();
                response.SuccessInfo.Time = (uint)GameTime.GetGameTime();

                var realm = Global.WorldMgr.GetRealm();

                // Send current home realm. Also there is no need to send it later in realm queries.
                response.SuccessInfo.VirtualRealms.Add(new VirtualRealmInfo(realm.Id.GetAddress(), true, false, realm.Name, realm.NormalizedName));

                if (HasPermission(RBACPermissions.UseCharacterTemplates))
                    foreach (var templ in Global.CharacterTemplateDataStorage.GetCharacterTemplates().Values)
                        response.SuccessInfo.Templates.Add(templ);

                response.SuccessInfo.AvailableClasses = Global.ObjectMgr.GetClassExpansionRequirements();
            }

            if (queued)
            {
                AuthWaitInfo waitInfo = new();
                waitInfo.WaitCount = queuePos;
                response.WaitInfo = waitInfo;
            }

            SendPacket(response);
        }

        public void SendAuthWaitQueue(uint position)
        {
            if (position != 0)
            {
                WaitQueueUpdate waitQueueUpdate = new();
                waitQueueUpdate.WaitInfo.WaitCount = position;
                waitQueueUpdate.WaitInfo.WaitTime = 0;
                waitQueueUpdate.WaitInfo.HasFCM = false;
                SendPacket(waitQueueUpdate);
            }
            else
                SendPacket(new WaitQueueFinish());
        }

        public void SendClientCacheVersion(uint version)
        {
            ClientCacheVersion cache = new();
            cache.CacheVersion = version;
            SendPacket(cache);//enabled it
        }

        public void SendSetTimeZoneInformation()
        {
            // @todo: replace dummy values
            SetTimeZoneInformation packet = new();
            packet.ServerTimeTZ = "Europe/Paris";
            packet.GameTimeTZ = "Europe/Paris";

            SendPacket(packet);//enabled it
        }

        public void SendFeatureSystemStatusGlueScreen()
        {
            FeatureSystemStatusGlueScreen features = new();
            features.BpayStoreAvailable = WorldConfig.GetBoolValue(WorldCfg.FeatureSystemBpayStoreEnabled);
            features.BpayStoreDisabledByParentalControls = false;
            features.CommerceSystemEnabled = true;
            features.TokenBalanceEnabled = true;
            features.CharUndeleteEnabled = WorldConfig.GetBoolValue(WorldCfg.FeatureSystemCharacterUndeleteEnabled);
            features.BpayStoreEnabled = WorldConfig.GetBoolValue(WorldCfg.FeatureSystemBpayStoreEnabled);
            features.MaxCharactersPerRealm = WorldConfig.GetIntValue(WorldCfg.CharactersPerRealm);
            features.MinimumExpansionLevel = (int)Expansion.Classic;
            features.MaximumExpansionLevel = WorldConfig.GetIntValue(WorldCfg.Expansion);
            features.TokenBalanceAmount = 10000;

            var europaTicketConfig = new EuropaTicketConfig();
            europaTicketConfig.ThrottleState.MaxTries = 10;
            europaTicketConfig.ThrottleState.PerMilliseconds = 60000;
            europaTicketConfig.ThrottleState.TryCount = 1;
            europaTicketConfig.ThrottleState.LastResetTimeBeforeNow = 111111;
            europaTicketConfig.TicketsEnabled = WorldConfig.GetBoolValue(WorldCfg.SupportTicketsEnabled);
            europaTicketConfig.BugsEnabled = WorldConfig.GetBoolValue(WorldCfg.SupportBugsEnabled);
            europaTicketConfig.ComplaintsEnabled = WorldConfig.GetBoolValue(WorldCfg.SupportComplaintsEnabled);
            europaTicketConfig.SuggestionsEnabled = WorldConfig.GetBoolValue(WorldCfg.SupportSuggestionsEnabled);

            features.EuropaTicketSystemStatus = europaTicketConfig;

            SendPacket(features);
        }
    }
}