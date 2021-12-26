﻿using System.Net;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;
using Hazel;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using UnityEngine;
using TheOtherRoles.Objects;
using static TheOtherRoles.GameHistory;
using static TheOtherRoles.TheOtherRoles;
using static TheOtherRoles.TheOtherRolesGM;
using TheOtherRoles.Patches;

namespace TheOtherRoles
{
    public class Couple
    {
        public PlayerControl lover1;
        public PlayerControl lover2;

        public Couple(PlayerControl lover1, PlayerControl lover2)
        {
            this.lover1 = lover1;
            this.lover2 = lover2;
        }

        public bool existing
        {
            get
            {
                return lover1 != null && lover2 != null && !lover1.Data.Disconnected && !lover2.Data.Disconnected;
            }
        }

        public bool alive
        {
            get
            {
                return lover1 != null && lover2 != null && lover1.isAlive() && lover2.isAlive();
            }
        }

        public bool existingAndAlive
        {
            get
            {
                return existing && alive;
            }
        }

        public bool existingWithKiller
        {
            get
            {
                return existing && (lover1 == Jackal.jackal || lover2 == Jackal.jackal
                           || lover1 == Sidekick.sidekick || lover2 == Sidekick.sidekick
                           || lover1.Data.Role.IsImpostor || lover2.Data.Role.IsImpostor);
            }
        }

        public bool hasAliveKillingLover
        {
            get
            {
                return existingAndAlive && existingWithKiller;
            }
        }
    }

    [HarmonyPatch]
    public static class Lovers
    {
        public static List<Couple> couples = new List<Couple>();
        public static Color color = new Color32(232, 57, 185, byte.MaxValue);

        public static List<Color> loverIconColors = new List<Color>
            {
                Lovers.color,
                Palette.ImpostorRed,
                Palette.Orange,
                new Color(0.0f, 1f, 1f),
                Palette.AcceptedGreen,
                Palette.Blue,
                Palette.Purple,
            };

        public static bool bothDie = true;

        // Making this closer to the au.libhalt.net version of Lovers
        public static bool separateTeam = true;
        public static bool tasksCount = false;

        public static bool hasTasks
        {
            get
            {
                return !separateTeam || tasksCount;
            }
        }

        public static string getIcon(PlayerControl player)
        {
            if (isLovers(player))
            {
                var coupleId = couples.FindIndex(x => x.lover1 == player || x.lover2 == player);
                return Helpers.cs(loverIconColors[coupleId], " ♥");
            }
            return "";
        }

        public static void addCouple(PlayerControl player1, PlayerControl player2)
        {
            couples.Add(new Couple(player1, player2));
        }

        public static void eraseCouple(PlayerControl player)
        {
            couples.RemoveAll(x => x.lover1 == player || x.lover2 == player);
        }

        public static void swapLovers(PlayerControl player1, PlayerControl player2)
        {
            var couple1 = couples.FindIndex(x => x.lover1 == player1 || x.lover2 == player1);
            var couple2 = couples.FindIndex(x => x.lover1 == player2 || x.lover2 == player2);

            // trying to swap within the same couple, just ignore
            if (couple1 == couple2) return;

            if (couple1 >= 0)
            {
                if (couples[couple1].lover1 == player1) couples[couple1].lover1 = player2;
                if (couples[couple1].lover2 == player1) couples[couple1].lover2 = player2;
            }

            if (couple2 >= 0)
            {
                if (couples[couple2].lover1 == player2) couples[couple2].lover1 = player1;
                if (couples[couple2].lover2 == player2) couples[couple2].lover2 = player1;
            }
        }

        public static void killLovers(PlayerControl player)
        {
            if (separateTeam && tasksCount)
                player.clearAllTasks();

            if (!bothDie) return;

            var partner = getPartner(player);
            if (partner != null)
            {
                if (!partner.Data.IsDead)
                {
                    partner.MurderPlayer(partner);
                    finalStatuses[partner.PlayerId] = FinalStatus.Suicide;
                }

                if (separateTeam && tasksCount)
                    partner.clearAllTasks();
            }
        }

        public static void exileLovers(PlayerControl player)
        {
            if (separateTeam && tasksCount)
                player.clearAllTasks();

            if (!bothDie) return;

            var partner = getPartner(player);
            if (partner != null)
            {
                if (!partner.Data.IsDead)
                {
                    partner.Exiled();
                    finalStatuses[partner.PlayerId] = FinalStatus.Suicide;
                }

                if (separateTeam && tasksCount)
                    partner.clearAllTasks();
            }
        }

        public static PlayerControl getPartner(PlayerControl player)
        {
            var couple = getCouple(player);
            if (couple != null)
            {
                return player?.PlayerId == couple.lover1?.PlayerId ? couple.lover2 : couple.lover1;
            }
            return null;
        }

        public static bool isLovers(PlayerControl player)
        {
            return getCouple(player) != null;
        }

        public static Couple getCouple(PlayerControl player)
        {
            foreach (var pair in couples)
            {
                if (pair.lover1?.PlayerId == player?.PlayerId || pair.lover2?.PlayerId == player?.PlayerId) return pair;
            }
            return null;
        }

        public static bool existing(PlayerControl player)
        {
            return getCouple(player)?.existing == true;
        }

        public static bool anyAlive()
        {
            foreach (var couple in couples)
            {
                if (couple.alive) return true;
            }
            return false;
        }

        public static bool anyNonKillingCouples()
        {
            foreach (var couple in couples)
            {
                if (!couple.hasAliveKillingLover) return true;
            }
            return false;
        }

        public static bool existingAndAlive(PlayerControl player)
        {
            return getCouple(player)?.existingAndAlive == true;
        }

        public static bool existingWithKiller(PlayerControl player)
        {
            return getCouple(player)?.existingWithKiller == true;
        }

        public static void clearAndReload()
        {
            couples = new List<Couple>();
            bothDie = CustomOptionHolder.loversBothDie.getBool();
            separateTeam = CustomOptionHolder.loversSeparateTeam.getBool();
            tasksCount = CustomOptionHolder.loversTasksCount.getBool();
        }
    }
}