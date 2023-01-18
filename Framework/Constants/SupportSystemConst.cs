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

namespace Framework.Constants
{
    public enum ReportType
    {
        Chat = 0,
        InWorld = 1,
        ClubFinderPosting = 2,
        ClubFinderApplicant = 3,
        GroupFinderPosting = 4,
        GroupFinderApplicant = 5,
        ClubMember = 6,
        GroupMember = 7,
        Friend = 8,
        Pet = 9,
        BattlePet = 10,
        Calendar = 11,
        Mail = 12,
        PvP = 13,
    }

    public enum ReportMajorCategory
    {
        InappropriateCommunication = 0,
        GameplaySabotage = 1,
        Cheating = 2,
        InappropriateName = 3,
    }

    public enum ReportMinorCategory
    {
        TextChat = 0x0001,
        Boosting = 0x0002,
        Spam = 0x0004,
        Afk = 0x0008,
        IntentionallyFeeding = 0x0010,
        BlockingProgress = 0x0020,
        Hacking = 0x0040,
        Botting = 0x0080,
        Advertisement = 0x0100,
        BTag = 0x0200,
        GroupName = 0x0400,
        CharacterName = 0x0800,
        GuildName = 0x1000,
        Description = 0x2000,
        Name = 0x4000,
    }

    public enum GMTicketSystemStatus
    {
        Disabled = 0,
        Enabled = 1
    }

    public enum SupportSpamType
    {
        Mail = 0,
        Chat = 1,
        Calendar = 2
    }
}