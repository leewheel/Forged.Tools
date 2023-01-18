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
using System;

namespace Framework.Constants
{
    public enum CreatureLinkedRespawnType
    {
        CreatureToCreature = 0,
        CreatureToGO = 1,         // Creature is dependant on GO
        GOToGO = 2,
        GOToCreature = 3          // GO is dependant on creature
    }

    public enum AiReaction
    {
        Alert = 0,                               // pre-aggro (used in client packet handler)
        Friendly = 1,                               // (NOT used in client packet handler)
        Hostile = 2,                               // sent on every attack, triggers aggro sound (used in client packet handler)
        Afraid = 3,                               // seen for polymorph (when AI not in control of self?) (NOT used in client packet handler)
        Destory = 4                                // used on object destroy (NOT used in client packet handler)
    }

    public enum CreatureEliteType
    {
        Normal = 0,
        Elite = 1,
        RareElite = 2,
        WorldBoss = 3,
        Rare = 4,
        EliteTrivial = 5                      // found in 2.2.3 for 2 mobs
    }

    [Flags]
    public enum UnitFlags : uint
    {
        ServerControlled = 0x01,
        NonAttackable = 0x02, // not attackable, set when creature starts to cast spells with SPELL_EFFECT_SPAWN and cast time, removed when spell hits caster, original name is UNIT_FLAG_SPAWNING. Rename when it will be removed from all scripts
        RemoveClientControl = 0x04, // This is a legacy flag used to disable movement player's movement while controlling other units, SMSG_CLIENT_CONTROL replaces this functionality clientside now. CONFUSED and FLEEING flags have the same effect on client movement asDISABLE_MOVE_CONTROL in addition to preventing spell casts/autoattack (they all allow climbing steeper hills and emotes while moving)
        PlayerControlled = 0x08, //controlled by player, use _IMMUNE_TO_PC instead of _IMMUNE_TO_NPC
        Rename = 0x10,
        Preparation = 0x20,
        Unk6 = 0x40,
        NotAttackable1 = 0x80,
        ImmuneToPc = 0x100,
        ImmuneToNpc = 0x200,
        Looting = 0x400,
        PetInCombat = 0x800,
        PvpEnabling = 0x1000,
        Silenced = 0x2000,
        CantSwim = 0x4000,
        CanSwim = 0x8000, // shows swim animation in water
        NonAttackable2 = 0x10000,
        Pacified = 0x20000,
        Stunned = 0x40000,
        InCombat = 0x80000,
        OnTaxi = 0x100000,
        Disarmed = 0x200000,
        Confused = 0x400000,
        Fleeing = 0x800000,
        Possessed = 0x1000000, // under direct client control by a player (possess or vehicle)
        Uninteractible = 0x2000000,
        Skinnable = 0x4000000,
        Mount = 0x8000000,
        Unk28 = 0x10000000,
        PreventEmotesFromChatText = 0x20000000, // Prevent automatically playing emotes from parsing chat text, for example "lol" in /say, ending message with ? or !, or using /yell
        Sheathe = 0x40000000,
        Immune = 0x80000000,

        Disallowed = (ServerControlled | NonAttackable | RemoveClientControl |
                                   PlayerControlled | Rename | Preparation | /* UNIT_FLAG_UNK_6 | */
                                   NotAttackable1 | Looting | PetInCombat | PvpEnabling |
                                   Silenced | NonAttackable2 | Pacified | Stunned |
                                   InCombat | OnTaxi | Disarmed | Confused | Fleeing |
                                   Possessed | Skinnable | Mount | Unk28 |
                                   PreventEmotesFromChatText | Sheathe | Immune),

        Allowed = (0xFFFFFFFF & ~Disallowed)
    }

    public enum UnitFlags2 : uint
    {
        FeignDeath = 0x01,
        HideBody = 0x02,
        IgnoreReputation = 0x04,
        ComprehendLang = 0x08,
        MirrorImage = 0x10,
        DontFadeIn = 0x20,
        ForceMovement = 0x40,
        DisarmOffhand = 0x80,
        DisablePredStats = 0x100,
        AllowChangingTalents = 0x200,
        DisarmRanged = 0x400,
        RegeneratePower = 0x800,
        RestrictPartyInteraction = 0x1000,
        PreventSpellClick = 0x2000,
        InteractWhileHostile = 0x4000,
        CannotTurn = 0x8000,
        Unk2 = 0x10000,
        PlayDeathAnim = 0x20000,
        AllowCheatSpells = 0x40000,
        SuppressHighlightWhenTargetedOrMousedOver = 0x00080000,
        TreatAsRaidUnitForHelpfulSpells = 0x100000,
        LargeAoi = 0x00200000,
        GiganticAoi = 0x400000,
        NoActions = 0x800000,
        AiWillOnlySwimIfTargetSwims = 0x1000000,
        DontGenerateCombatLogWhenEngagedWithNpcs = 0x2000000,
        UntargetableByClient = 0x4000000,
        AttackerIgnoresMinimumRanges = 0x8000000,
        UninteractibleIfHostile = 0x10000000,
        Unsued11 = 0x20000000,
        InfiniteAoi = 0x40000000,
        Unused13 = 0x80000000,

        Disallowed = (FeignDeath | IgnoreReputation | ComprehendLang |
            MirrorImage | ForceMovement | DisarmOffhand |
            DisablePredStats | AllowChangingTalents | DisarmRanged |
            /* UNIT_FLAG2_REGENERATE_POWER | */ RestrictPartyInteraction |
            PreventSpellClick | InteractWhileHostile | /* UNIT_FLAG2_CANNOT_TURN | */
            /* UNIT_FLAG2_PLAY_DEATH_ANIM | */ AllowCheatSpells | SuppressHighlightWhenTargetedOrMousedOver |
            TreatAsRaidUnitForHelpfulSpells | LargeAoi | GiganticAoi | NoActions |
            AiWillOnlySwimIfTargetSwims | DontGenerateCombatLogWhenEngagedWithNpcs | UntargetableByClient | AttackerIgnoresMinimumRanges |
            UninteractibleIfHostile | Unsued11 | InfiniteAoi | Unused13),

        Allowed = (0xFFFFFFFF & ~Disallowed)
    }

    public enum UnitFlags3 : uint
    {
        Unk0 = 0x01,
        UnconsciousOnDeath = 0x02,   // Title Unconscious On Death Description Shows "Unconscious" In Unit Tooltip Instead Of "Dead"
        AllowMountedCombat = 0x04,   // Title Allow Mounted Combat
        GarrisonPet = 0x08,   // Title Garrison Pet Description Special Garrison Pet Creatures That Display One Of Favorite Player Battle Pets - This Flag Allows Querying Name And Turns Off Default Battle Pet Behavior
        UiCanGetPosition = 0x10,   // Title Ui Can Get Position Description Allows Lua Functions Like Unitposition To Always Get The Position Even For Npcs Or Non-Grouped Players
        AiObstacle = 0x20,
        AlternativeDefaultLanguage = 0x40,
        SuppressAllNpcFeedback = 0x80,   // Title Suppress All Npc Feedback Description Skips Playing Sounds On Left Clicking Npc For All Npcs As Long As Npc With This Flag Is Visible
        IgnoreCombat = 0x100,   // Title Ignore Combat Description Same As SpellAuraIgnoreCombat
        SuppressNpcFeedback = 0x200,   // Title Suppress Npc Feedback Description Skips Playing Sounds On Left Clicking Npc
        Unk10 = 0x400,
        Unk11 = 0x800,
        Unk12 = 0x1000,
        FakeDead = 0x2000,   // Title Show As Dead
        NoFacingOnInteractAndFastFacingChase = 0x4000,   // Causes The Creature To Both Not Change Facing On Interaction And Speeds Up Smooth Facing Changes While Attacking (Clientside)
        UntargetableFromUi = 0x8000,   // Title Untargetable From Ui Description Cannot Be Targeted From Lua Functions Startattack, Targetunit, Petattack
        NoFacingOnInteractWhileFakeDead = 0x10000,   // Prevents Facing Changes While Interacting If Creature Has Flag FakeDead
        AlreadySkinned = 0x20000,
        SuppressAllNpcSounds = 0x40000,   // Title Suppress All Npc Sounds Description Skips Playing Sounds On Beginning And End Of Npc Interaction For All Npcs As Long As Npc With This Flag Is Visible
        SuppressNpcSounds = 0x80000,   // Title Suppress Npc Sounds Description Skips Playing Sounds On Beginning And End Of Npc Interaction
        Unk20 = 0x100000,
        Unk21 = 0x200000,
        DontFadeOut = 0x400000,
        Unk23 = 0x800000,
        Unk24 = 0x1000000,
        Unk25 = 0x2000000,
        Unk26 = 0x4000000,
        Unk27 = 0x8000000,
        Unk28 = 0x10000000,
        Unk29 = 0x20000000,
        Unk30 = 0x40000000,
        Unk31 = 0x80000000,

        Disallowed = (Unk0 | /* UnconsciousOnDeath | */ /* AllowMountedCombat | */ GarrisonPet |
                                                                   /* UiCanGetPosition | */ /* AiObstacle | */ AlternativeDefaultLanguage | /* SuppressAllNpcFeedback | */
                                                                   IgnoreCombat | SuppressNpcFeedback | Unk10 | Unk11 |
                                                                   Unk12 | /* FakeDead | */ /* NoFacingOnInteractAndFastFacingChase | */ /* UntargetableFromUi | */
                                                                   /* NoFacingOnInteractWhileFakeDead | */ AlreadySkinned | /* SuppressAllNpcSounds | */ /* SuppressNpcSounds | */
                                                                   Unk20 | Unk21 | /* DontFadeOut | */ Unk23 |
                                                                   Unk24 | Unk25 | Unk26 | Unk27 |
                                                                   Unk28 | Unk29 | Unk30 | Unk31), // Skip
        Allowed = (0xffffffff & ~Disallowed) // Skip
    }

    public enum NPCFlags : uint
    {
        None = 0x00,
        Gossip = 0x01,     // 100%
        QuestGiver = 0x02,     // 100%
        Unk1 = 0x04,
        Unk2 = 0x08,
        Trainer = 0x10,     // 100%
        TrainerClass = 0x20,     // 100%
        TrainerProfession = 0x40,     // 100%
        Vendor = 0x80,     // 100%
        VendorAmmo = 0x100,     // 100%, General Goods Vendor
        VendorFood = 0x200,     // 100%
        VendorPoison = 0x400,     // Guessed
        VendorReagent = 0x800,     // 100%
        Repair = 0x1000,     // 100%
        FlightMaster = 0x2000,     // 100%
        SpiritHealer = 0x4000,     // Guessed
        SpiritGuide = 0x8000,     // Guessed
        Innkeeper = 0x10000,     // 100%
        Banker = 0x20000,     // 100%
        Petitioner = 0x40000,     // 100% 0xc0000 = Guild Petitions, 0x40000 = Arena Team Petitions
        TabardDesigner = 0x80000,     // 100%
        BattleMaster = 0x100000,     // 100%
        Auctioneer = 0x200000,     // 100%
        StableMaster = 0x400000,     // 100%
        GuildBanker = 0x800000,     //
        SpellClick = 0x1000000,     //
        PlayerVehicle = 0x2000000,     // Players With Mounts That Have Vehicle Data Should Have It Set
        Mailbox = 0x4000000,     // Mailbox
        ArtifactPowerRespec = 0x8000000,     // Artifact Powers Reset
        Transmogrifier = 0x10000000,     // Transmogrification
        VaultKeeper = 0x20000000,     // Void Storage
        WildBattlePet = 0x40000000,     // Pet That Player Can Fight (Battle Pet)
        BlackMarket = 0x80000000,     // Black Market
    }

    public enum NPCFlags2
    {
        None = 0x00,
        ItemUpgradeMaster = 0x01,
        GarrisonArchitect = 0x02,
        Steering = 0x04,
        ShipmentCrafter = 0x10,
        GarrisonMissionNpc = 0x20,
        TradeskillNpc = 0x40,
        BlackMarketView = 0x80,
        GarrisonTalentNpc = 0x200,
        ContributionCollector = 0x400,
        AzeriteRespec = 0x4000,
        IslandsQueue = 0x8000,
        SuppressNpcSoundsExceptEndOfInteraction = 0x00010000,
    }

    [Flags]
    public enum CreatureTypeFlags : uint
    {
        Tameable = 0x00000001, // Makes The Mob Tameable (Must Also Be A Beast And Have Family Set)
        VisibleToGhosts = 0x00000002, // Creature Is Also Visible For Not Alive Player. Allows Gossip Interaction If Npcflag Allows?
        BossMob = 0x00000004, // Changes Creature'S Visible Level To "??" In The Creature'S Portrait - Immune Knockback.
        DoNotPlayWoundAnim = 0x00000008,
        NoFactionTooltip = 0x00000010,
        MoreAudible = 0x00000020, // Sound Related
        SpellAttackable = 0x00000040,
        InteractWhileDead = 0x00000080, // Player Can Interact With The Creature If Creature Is Dead (Not If Player Is Dead)
        SkinWithHerbalism = 0x00000100, // Can Be Looted By Herbalist
        SkinWithMining = 0x00000200, // Can Be Looted By Miner
        NoDeathMessage = 0x00000400, // Death Event Will Not Show Up In Combat Log
        AllowMountedCombat = 0x00000800, // Creature Can Remain Mounted When Entering Combat
        CanAssist = 0x00001000, // ? Can Aid Any Player In Combat If In Range?
        NoPetBar = 0x00002000,
        MaskUid = 0x00004000,
        SkinWithEngineering = 0x00008000, // Can Be Looted By Engineer
        TameableExotic = 0x00010000, // Can Be Tamed By Hunter As Exotic Pet
        UseModelCollisionSize = 0x00020000, // Collision Related. (Always Using Default Collision Box?)
        AllowInteractionWhileInCombat = 0x00040000,
        CollideWithMissiles = 0x00080000, // Projectiles Can Collide With This Creature - Interacts With TargetDestTraj
        NoNamePlate = 0x00100000,
        DoNotPlayMountedAnimations = 0x00200000,
        LinkAll = 0x00400000,
        InteractOnlyWithCreator = 0x00800000,
        DoNotPlayUnitEventSounds = 0x01000000,
        HasNoShadowBlob = 0x02000000,
        TreatAsRaidUnit = 0x04000000, //! Creature Can Be Targeted By Spells That Require Target To Be In Caster'S Party/Raid
        ForceGossip = 0x08000000,   // Allows The Creature To Display A Single Gossip Option.
        DoNotSheathe = 0x10000000,
        DoNotTargetOnInteraction = 0x20000000,
        DoNotRenderObjectName = 0x40000000,
        QuestBoss = 0x80000000  // Not Verified
    }

    [Flags]
    public enum CreatureFlagsExtra : uint
    {
        InstanceBind = 0x01,       // Creature Kill Bind Instance With Killer And Killer'S Group
        Civilian = 0x02,       // Not Aggro (Ignore Faction/Reputation Hostility)
        NoParry = 0x04,       // Creature Can'T Parry
        NoParryHasten = 0x08,       // Creature Can'T Counter-Attack At Parry
        NoBlock = 0x10,       // Creature Can'T Block
        NoCrushingBlows = 0x20,       // Creature Can'T Do Crush Attacks
        NoXP = 0x40,       // creature kill does not provide XP
        Trigger = 0x80,       // Trigger Creature
        NoTaunt = 0x100,       // Creature Is Immune To Taunt Auras And 'attack me' effects
        NoMoveFlagsUpdate = 0x200, // Creature won't update movement flags
        GhostVisibility = 0x400,       // creature will only be visible to dead players
        UseOffhandAttack = 0x800, // creature will use offhand attacks
        NoSellVendor = 0x1000,       // players can't sell items to this vendor
        CannotEnterCombat = 0x2000,         // creature is not allowed to enter combat
        Worldevent = 0x4000,       // Custom Flag For World Event Creatures (Left Room For Merging)
        Guard = 0x8000,       // Creature Is Guard
        IgnoreFeighDeath = 0x10000, // creature ignores feign death
        NoCrit = 0x20000,       // Creature Can'T Do Critical Strikes
        NoSkillGains = 0x40000,       // creature won't increase weapon skills
        ObeysTauntDiminishingReturns = 0x80000,       // Taunt is subject to diminishing returns on this creature
        AllDiminish = 0x100000,       // creature is subject to all diminishing returns as players are
        NoPlayerDamageReq = 0x200000,       // creature does not need to take player damage for kill credit
        Unused22 = 0x400000,
        Unused23 = 0x800000,
        Unused24 = 0x1000000,
        Unused25 = 0x2000000,
        Unused26 = 0x4000000,
        Unused27 = 0x8000000,
        DungeonBoss = 0x10000000,        // Creature Is A Dungeon Boss (Set Dynamically, Do Not Add In Db)
        IgnorePathfinding = 0x20000000,        // creature ignore pathfinding
        ImmunityKnockback = 0x40000000,        // creature is immune to knockback effects
        Unused31 = 0x80000000,

        // Masks
        AllUnused = (Unused22 | Unused23 | Unused24 | Unused25 | Unused26 | Unused27 | Unused31),

        DBAllowed = (0xFFFFFFFF & ~(AllUnused | DungeonBoss))
    }

    public enum CreatureType
    {
        Beast = 1,
        Dragonkin = 2,
        Demon = 3,
        Elemental = 4,
        Giant = 5,
        Undead = 6,
        Humanoid = 7,
        Critter = 8,
        Mechanical = 9,
        NotSpecified = 10,
        Totem = 11,
        NonCombatPet = 12,
        GasCloud = 13,
        WildPet = 14,
        Aberration = 15,

        MaskDemonOrUndead = (1 << (Demon - 1)) | (1 << (Undead - 1)),
        MaskHumanoidOrUndead = (1 << (Humanoid - 1)) | (1 << (Undead - 1)),
        MaskMechanicalOrElemental = (1 << (Mechanical - 1)) | (1 << (Elemental - 1))
    }

    public enum CreatureFamily
    {
        None = 0,
        Wolf = 1,
        Cat = 2,
        Spider = 3,
        Bear = 4,
        Boar = 5,
        Crocolisk = 6,
        CarrionBird = 7,
        Crab = 8,
        Gorilla = 9,
        Raptor = 11,
        Tallstrider = 12,
        Felhunter = 15,
        Voidwalker = 16,
        Succubus = 17,
        Doomguard = 19,
        Scorpid = 20,
        Turtle = 21,
        Imp = 23,
        Bat = 24,
        Hyena = 25,
        BirdOfPrey = 26,
        WindSerpent = 27,
        RemoteControl = 28,
        Felguard = 29,
        Dragonhawk = 30,
        Ravager = 31,
        WarpStalker = 32,
        Sporebat = 33,
        Ray = 34,
        Serpent = 35,
        Moth = 37,
        Chimaera = 38,
        Devilsaur = 39,
        Ghoul = 40,
        Aqiri = 41,
        Worm = 42,
        Clefthoof = 43,
        Wasp = 44,
        CoreHound = 45,
        SpiritBeast = 46,
        WaterElemental = 49,
        Fox = 50,
        Monkey = 51,
        Hound = 52,
        Beetle = 53,
        ShaleBeast = 55,
        Zombie = 56,
        QaTest = 57,
        Hydra = 68,
        Felimp = 100,
        Voidlord = 101,
        Shivara = 102,
        Observer = 103,
        Wrathguard = 104,
        Infernal = 108,
        Fireelemental = 116,
        Earthelemental = 117,
        Crane = 125,
        Waterstrider = 126,
        Rodent = 127,
        StoneHound = 128,
        Gruffhorn = 129,
        Basilisk = 130,
        Direhorn = 138,
        Stormelemental = 145,
        Torrorguard = 147,
        Abyssal = 148,
        Riverbeast = 150,
        Stag = 151,
        Mechanical = 154,
        Abomination = 155,
        Scalehide = 156,
        Oxen = 157,
        Feathermane = 160,
        Lizard = 288,
        Pterrordax = 290,
        Toad = 291,
        Carapid = 292,
        BloodBeast = 296,
        Camel = 298,
        Courser = 299,
        Mammoth = 300,
        Incubus = 302
    }

    public enum InhabitType
    {
        Ground = 1,
        Water = 2,
        Air = 4,
        Root = 8,
        Anywhere = Ground | Water | Air | Root
    }

    public enum EvadeReason
    {
        NoHostiles,       // the creature's threat list is empty
        Boundary,          // the creature has moved outside its evade boundary
        NoPath,           // the creature was unable to reach its target for over 5 seconds
        SequenceBreak,    // this is a boss and the pre-requisite encounters for engaging it are not defeated yet
        Other
    }

    [Flags]
    public enum GroupAIFlags
    {
        None = 0,          // No creature group behavior
        MembersAssistLeader = 0x01, // The member aggroes if the leader aggroes
        LeaderAssistsMember = 0x02, // The leader aggroes if the member aggroes
        MembersAssistMember = (MembersAssistLeader | LeaderAssistsMember), // every member will assist if any member is attacked
        IdleInFormation = 0x200, // The member will follow the leader when pathing idly
    }

    public enum CreatureGroundMovementType
    {
        None,
        Run,
        Hover,

        Max
    }

    public enum CreatureFlightMovementType
    {
        None,
        DisableGravity,
        CanFly,

        Max
    }

    public enum CreatureChaseMovementType
    {
        Run,
        CanWalk,
        AlwaysWalk,

        Max
    }

    public enum CreatureRandomMovementType
    {
        Walk,
        CanRun,
        AlwaysRun,

        Max
    }

    public enum VendorInventoryReason
    {
        None = 0,
        Empty = 1
    }
}