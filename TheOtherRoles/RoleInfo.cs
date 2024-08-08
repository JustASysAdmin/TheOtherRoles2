using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;
using System.Threading.Tasks;
using System.Net.Http;

namespace TheOtherRoles
{
    public class RoleInfo {
        public Color color { get; private set; }
        public RoleId roleId { get; private set; }
        public bool isNeutral { get; private set; }
        public bool isModifier { get; private set; }
        public string name { get { return name_ != null ? name_.GetString() : ""; } }
        public string introDescription { get { return introDescription_ != null ? introDescription_.GetString() : ""; } }
        public string shortDescription { get { return shortDescription_ != null ? shortDescription_.GetString() : ""; } }

        public RoleInfo(Color color, RoleId roleId, bool isNeutral = false, bool isModifier = false, bool isGuessable = false, TranslationInfo name = null, TranslationInfo introDescription = null, TranslationInfo shortDescription = null)
        {
            this.color = color;
            this.name_ = name != null ? name : ModTranslation.GetRoleName(roleId, color);
            this.introDescription_ = introDescription != null ? introDescription : ModTranslation.GetRoleIntroDesc(roleId, color);
            this.shortDescription_ = shortDescription != null ? shortDescription : ModTranslation.GetRoleShortDesc(roleId, color);
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        TranslationInfo name_ = null;
        TranslationInfo introDescription_ = null;
        TranslationInfo shortDescription_ = null;

        public static RoleInfo jester = new RoleInfo(Jester.color, RoleId.Jester, true);
        public static RoleInfo werewolf = new RoleInfo(Werewolf.color, RoleId.Werewolf, true);
        public static RoleInfo prosecutor = new RoleInfo(Prosecutor.color, RoleId.Prosecutor, true);
		public static RoleInfo swooper = new RoleInfo(Swooper.color, RoleId.Swooper, true);
        public static RoleInfo mayor = new RoleInfo(Mayor.color, RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo(Portalmaker.color, RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo(Engineer.color, RoleId.Engineer);
        public static RoleInfo privateInvestigator = new RoleInfo(PrivateInvestigator.color, RoleId.PrivateInvestigator);
        public static RoleInfo sheriff = new RoleInfo(Sheriff.color, RoleId.Sheriff);
        public static RoleInfo bodyguard  = new RoleInfo(BodyGuard.color, RoleId.BodyGuard, false);
        public static RoleInfo deputy = new RoleInfo(Sheriff.color, RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo(Lighter.color, RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo(Godfather.color, RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo(Mafioso.color, RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo(Janitor.color, RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo(Morphling.color, RoleId.Morphling);
        public static RoleInfo bomber2 = new RoleInfo(Bomber2.color, RoleId.Bomber2);
        public static RoleInfo bomber = new RoleInfo(Bomber.color, RoleId.Bomber);
        public static RoleInfo yoyo = new RoleInfo(Yoyo.color, RoleId.Yoyo);
        public static RoleInfo poucher = new RoleInfo(Poucher.color, RoleId.Poucher);
		public static RoleInfo mimic = new RoleInfo(Mimic.color, RoleId.Mimic);
        public static RoleInfo camouflager = new RoleInfo(Camouflager.color, RoleId.Camouflager);
        public static RoleInfo miner = new RoleInfo(Miner.color, RoleId.Miner);
        public static RoleInfo vampire = new RoleInfo(Vampire.color, RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo(Eraser.color, RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo(Trickster.color, RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo(Cleaner.color, RoleId.Cleaner);
        public static RoleInfo undertaker = new RoleInfo(Undertaker.color, RoleId.Undertaker);
        public static RoleInfo warlock = new RoleInfo(Warlock.color, RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo(BountyHunter.color, RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo(Detective.color, RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo(TimeMaster.color, RoleId.TimeMaster);
        public static RoleInfo veteran = new RoleInfo(Veteran.color, RoleId.Veteran);
        public static RoleInfo medic = new RoleInfo(Medic.color, RoleId.Medic);
        public static RoleInfo swapper = new RoleInfo(Swapper.color, RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo(Seer.color, RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo(Hacker.color, RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo(Tracker.color, RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo(Snitch.color, RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo(Jackal.color, RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo(Sidekick.color, RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo(Spy.color, RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo(SecurityGuard.color, RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo(Arsonist.color, RoleId.Arsonist, true);
        public static RoleInfo amnisiac = new RoleInfo(Amnisiac.color, RoleId.Amnisiac, true);
        public static RoleInfo vulture = new RoleInfo(Vulture.color, RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo(Medium.color, RoleId.Medium);
        public static RoleInfo trapper = new RoleInfo(Trapper.color, RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo(Lawyer.color, RoleId.Lawyer, true);
        // public static RoleInfo prosecutor = new RoleInfo("Prosecutor", Lawyer.color, "Vote out your target", "Vote our your target", RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo(Pursuer.color, RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo(Palette.ImpostorRed, RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo(Palette.CrewmateBlue, RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo(Witch.color, RoleId.Witch);
        public static RoleInfo cultist = new RoleInfo(Cultist.color, RoleId.Cultist);
        public static RoleInfo ninja = new RoleInfo(Ninja.color, RoleId.Ninja);
        public static RoleInfo blackmailer = new RoleInfo(Blackmailer.color, RoleId.Blackmailer);
        public static RoleInfo thief = new RoleInfo(Thief.color, RoleId.Thief, true);
        public static RoleInfo doomsayer = new RoleInfo(Doomsayer.color, RoleId.Doomsayer, true);

        public static RoleInfo hunter = new RoleInfo(Palette.ImpostorRed, RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo(Palette.CrewmateBlue, RoleId.Crewmate);

        public static RoleInfo prop = new RoleInfo(Palette.CrewmateBlue, RoleId.Crewmate);



        // Modifier
        public static RoleInfo bloody = new RoleInfo(Color.yellow, RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo(Color.yellow, RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo(Color.yellow, RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo(Color.yellow, RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo(Color.yellow, RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo(Lovers.color, RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo(Color.yellow, RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo(Color.yellow, RoleId.Vip, false, true);
        public static RoleInfo indomitable  = new RoleInfo(Color.yellow, RoleId.Indomitable, false, true);
        public static RoleInfo slueth  = new RoleInfo(Color.yellow, RoleId.Slueth, false, true);
        public static RoleInfo cursed  = new RoleInfo(Color.yellow, RoleId.Cursed, false, true, true);
        public static RoleInfo invert = new RoleInfo(Color.yellow, RoleId.Invert, false, true);
        public static RoleInfo blind  = new RoleInfo(Color.yellow, RoleId.Blind, false, true);
        public static RoleInfo tunneler  = new RoleInfo(Color.yellow, RoleId.Tunneler, false, true);
        public static RoleInfo goodGuesser = new RoleInfo(Color.yellow, RoleId.NiceGuesser, false, true);
        public static RoleInfo paranoid  = new RoleInfo(Color.yellow, RoleId.Paranoid, false, true);
        public static RoleInfo disperser = new RoleInfo(Color.red, RoleId.Disperser, false, true);
        public static RoleInfo badGuesser = new RoleInfo(Color.yellow, RoleId.EvilGuesser, false, true);
        public static RoleInfo chameleon = new RoleInfo(Color.yellow, RoleId.Chameleon, false, true);
        public static RoleInfo shifter = new RoleInfo(Color.yellow, RoleId.Shifter, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            bomber,
            yoyo,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            undertaker,
            warlock,
            werewolf,
			cursed,
            bountyHunter,
            witch,
            ninja,
            bomber,
            bodyguard,
            blackmailer,
            miner,
			swooper,
            goodGuesser,
			privateInvestigator,
			mimic,
			poucher,
            badGuesser,
            lover,
            jester,
            prosecutor,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            thief,
            crewmate,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            amnisiac,
            veteran,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            trapper,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            indomitable,
            slueth,
            blind,
            tunneler,
			paranoid,
            invert,
            chameleon,
            shifter,
            disperser,
            doomsayer
};

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true, bool onlyMods = false) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead || AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Ended)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                    if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                    if (p == Indomitable.indomitable) infos.Add(indomitable);
                }
                if (PlayerControl.LocalPlayer.Data.IsDead) {
                    if (p == Cursed.cursed) infos.Add(cursed);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (p == Blind.blind) infos.Add(blind);
                if (p == Tunneler.tunneler) infos.Add(tunneler);
                if (p == Paranoid.paranoid) infos.Add(paranoid);
                if (p == Slueth.slueth) infos.Add(slueth);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
                if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
                if (p == Guesser.evilGuesser) infos.Add(badGuesser);

                if (p == Shifter.shifter) infos.Add(shifter);
            }
            if (onlyMods) return infos;

            int count = infos.Count;  // Save count after modifiers are added so that the role count can be checked

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Werewolf.werewolf) infos.Add(werewolf);
            if (p == Prosecutor.prosecutor) infos.Add(prosecutor);
            if (p == Swooper.swooper) infos.Add(swooper);
            if (p == Disperser.disperser) infos.Add(disperser);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Miner.miner) infos.Add(miner);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Undertaker.undertaker) infos.Add(undertaker);
            if (p == Bomber2.bomber) infos.Add(bomber);
            if (p == Bomber.bomber) infos.Add(bomber);
            if (p == Yoyo.yoyo) infos.Add(yoyo);
            if (p == Mimic.mimic) infos.Add(mimic);
            if (p == Poucher.poucher) infos.Add(poucher);
            if (p == PrivateInvestigator.privateInvestigator) infos.Add(privateInvestigator);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Blackmailer.blackmailer) infos.Add(blackmailer);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Cultist.cultist) infos.Add(cultist);
            if (p == Amnisiac.amnisiac) infos.Add(amnisiac);
            if (p == Veteran.veteran) infos.Add(veteran);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == BodyGuard.bodyguard) infos.Add(bodyguard);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) {
                if (p == Jackal.jackal && Jackal.jackal != Swooper.swooper) infos.Add(jackal);
                else if (p != Jackal.jackal) infos.Add(jackal);
            }
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer && !Lawyer.isProsecutor) infos.Add(lawyer);
            if (p == Lawyer.lawyer && Lawyer.isProsecutor) infos.Add(prosecutor);
            if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Pursuer.pursuer) infos.Add(pursuer);
            if (p == Thief.thief) infos.Add(thief);
            if (p == Doomsayer.doomsayer) infos.Add(doomsayer);

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek, prop hunt prop ...
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(MapOptionsTor.gameMode == CustomGamemodes.HideNSeek || MapOptionsTor.gameMode == CustomGamemodes.PropHunt ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(MapOptionsTor.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : MapOptionsTor.gameMode == CustomGamemodes.PropHunt ? RoleInfo.prop : RoleInfo.crewmate);
            }

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true, bool suppressGhostInfo = false)
        {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) 
                roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId)) roleName += " (Guesser)";
            if (!suppressGhostInfo && p != null)
            {
                if (p == Shifter.shifter && (CachedPlayer.LocalPlayer.PlayerControl == Shifter.shifter || Helpers.shouldShowGhostInfo()) && Shifter.futureShift != null)
                    roleName += Helpers.cs(Color.yellow, " ← " + Shifter.futureShift.Data.PlayerName);
                if (p == Vulture.vulture && (CachedPlayer.LocalPlayer.PlayerControl == Vulture.vulture || Helpers.shouldShowGhostInfo()))
                    roleName = roleName + Helpers.cs(Vulture.color, $" ({Vulture.vultureNumberToWin - Vulture.eatenBodies} left)");
                if (Helpers.shouldShowGhostInfo())
                {
                    if (Eraser.futureErased.Contains(p))
                        roleName = Helpers.cs(Color.gray, "(erased) ") + roleName;
                    if (Vampire.vampire != null && !Vampire.vampire.Data.IsDead && Vampire.bitten == p && !p.Data.IsDead)
                        roleName = Helpers.cs(Vampire.color, $"(bitten {(int)HudManagerStartPatch.vampireKillButton.Timer + 1}) ") + roleName;
                    if (Deputy.handcuffedPlayers.Contains(p.PlayerId))
                        roleName = Helpers.cs(Color.gray, "(cuffed) ") + roleName;
                    if (Deputy.handcuffedKnows.ContainsKey(p.PlayerId))  // Active cuff
                        roleName = Helpers.cs(Deputy.color, "(cuffed) ") + roleName;
                    if (p == Warlock.curseVictim)
                        roleName = Helpers.cs(Warlock.color, "(cursed) ") + roleName;
                    if (p == Ninja.ninjaMarked)
                        roleName = Helpers.cs(Ninja.color, "(marked) ") + roleName;
                    if (Pursuer.blankedList.Contains(p) && !p.Data.IsDead)
                        roleName = Helpers.cs(Pursuer.color, "(blanked) ") + roleName;
                    if (Witch.futureSpelled.Contains(p) && !MeetingHud.Instance) // This is already displayed in meetings!
                        roleName = Helpers.cs(Witch.color, "☆ ") + roleName;
                    if (BountyHunter.bounty == p)
                        roleName = Helpers.cs(BountyHunter.color, "(bounty) ") + roleName;
                    if (Arsonist.dousedPlayers.Contains(p))
                        roleName = Helpers.cs(Arsonist.color, "♨ ") + roleName;
                    if (p == Arsonist.arsonist)
                        roleName = roleName + Helpers.cs(Arsonist.color, $" ({CachedPlayer.AllPlayers.Count(x => { return x.PlayerControl != Arsonist.arsonist && !x.Data.IsDead && !x.Data.Disconnected && !Arsonist.dousedPlayers.Any(y => y.PlayerId == x.PlayerId); })} left)");
                    if (p == Jackal.fakeSidekick)
                        roleName = Helpers.cs(Sidekick.color, $" (fake SK)") + roleName;
                    // Death Reason on Ghosts
                    if (p.Data.IsDead)
                    {
                        string deathReasonString = "";
                        var deadPlayer = GameHistory.deadPlayers.FirstOrDefault(x => x.player.PlayerId == p.PlayerId);

                        Color killerColor = new();
                        if (deadPlayer != null && deadPlayer.killerIfExisting != null)
                        {
                            killerColor = RoleInfo.getRoleInfoForPlayer(deadPlayer.killerIfExisting, false).FirstOrDefault().color;
                        }

                        if (deadPlayer != null)
                        {
                            switch (deadPlayer.deathReason)
                            {
                                case DeadPlayer.CustomDeathReason.Disconnect:
                                    deathReasonString = " - disconnected";
                                    break;
                                case DeadPlayer.CustomDeathReason.Exile:
                                    deathReasonString = " - voted out";
                                    break;
                                case DeadPlayer.CustomDeathReason.Kill:
                                    deathReasonString = $" - killed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Guess:
                                    if (deadPlayer.killerIfExisting.Data.PlayerName == p.Data.PlayerName)
                                        deathReasonString = $" - failed guess";
                                    else
                                        deathReasonString = $" - guessed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Shift:
                                    deathReasonString = $" - {Helpers.cs(Color.yellow, "shifted")} {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.WitchExile:
                                    deathReasonString = $" - {Helpers.cs(Witch.color, "witched")} by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LoverSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lovers.color, "lover died")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LawyerSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lawyer.color, "bad Lawyer")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Bomb:
                                    deathReasonString = $" - bombed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Arson:
                                    deathReasonString = $" - burnt by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                            }
                            roleName = roleName + deathReasonString;
                        }
                    }
                }
            }
            return roleName;
        }


        static string ReadmePage = "";
        public static async Task loadReadme()
        {
            if (ReadmePage == "")
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/TheOtherRolesAU/TheOtherRoles/main/README.md");
                response.EnsureSuccessStatusCode();
                string httpres = await response.Content.ReadAsStringAsync();
                ReadmePage = httpres;
            }
        }
        public static string GetRoleDescription(RoleInfo roleInfo)
        {
            while (ReadmePage == "")
            {
            }

            int index = ReadmePage.IndexOf($"## {roleInfo.name}");
            int endindex = ReadmePage.Substring(index).IndexOf("### Game Options");
            return ReadmePage.Substring(index, endindex);

        }
    }
}

