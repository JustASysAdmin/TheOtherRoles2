using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
		public bool isGuessable;
        public bool isModifier;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false, bool isGuessable = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
			this.isGuessable = isGuessable;
        }

        public static RoleInfo jester = new RoleInfo(Helpers.transl("Jester"), Jester.color, Helpers.transl("Get voted out"), Helpers.transl("Get voted out"), RoleId.Jester, true);
        public static RoleInfo werewolf = new RoleInfo(Helpers.transl("Werewolf"), Werewolf.color, Helpers.transl("Rampage and kill everyone"), Helpers.transl("Rampage and kill everyone"), RoleId.Werewolf, true);
        public static RoleInfo prosecutor = new RoleInfo(Helpers.transl("Executioner"), Prosecutor.color, Helpers.transl("Vote out your target"), Helpers.transl("Vote out your target"), RoleId.Prosecutor, true);
		public static RoleInfo swooper = new RoleInfo(Helpers.transl("Swooper"), Swooper.color, Helpers.transl("Turn Invisable and kill everyone"), Helpers.transl("Turn Invisable"), RoleId.Swooper, true);
        public static RoleInfo mayor = new RoleInfo(Helpers.transl("Mayor"), Mayor.color, Helpers.transl("Your vote counts twice"), Helpers.transl("Your vote counts twice"), RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo(Helpers.transl("Portalmaker"), Portalmaker.color, Helpers.transl("You can create portals"), Helpers.transl("You can create portals"), RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo(Helpers.transl("Engineer"),  Engineer.color, Helpers.transl("Maintain important systems on the ship"), Helpers.transl("Repair the ship"), RoleId.Engineer);
        public static RoleInfo privateInvestigator = new RoleInfo(Helpers.transl("PrivateInvestigator"),  PrivateInvestigator.color, Helpers.transl("See who is interacting with others"), Helpers.transl("Spy on the ship."), RoleId.PrivateInvestigator);
        public static RoleInfo sheriff = new RoleInfo(Helpers.transl("Sheriff"), Sheriff.color, Helpers.transl("Shoot the <color=#FF1919FF>Impostors</color>"), Helpers.transl("Shoot the Impostors"), RoleId.Sheriff);
        public static RoleInfo bodyguard  = new RoleInfo(Helpers.transl("BodyGuard"), BodyGuard.color, Helpers.transl("Protect someone with your own life"), Helpers.transl("You are the shield that guards the realms of men!"), RoleId.BodyGuard, false);
        public static RoleInfo deputy = new RoleInfo(Helpers.transl("Deputy"), Sheriff.color, Helpers.transl("Handcuff the <color=#FF1919FF>Impostors</color>"), Helpers.transl("Handcuff the Impostors"), RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo(Helpers.transl("Lighter"), Lighter.color, Helpers.transl("Your light never goes out"), Helpers.transl("Your light never goes out"), RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo(Helpers.transl("Godfather"), Godfather.color, Helpers.transl("Kill all Crewmates"), Helpers.transl("Kill all Crewmates"), RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo(Helpers.transl("Mafioso"), Mafioso.color, Helpers.transl("Work with the <color=#FF1919FF>Mafia</color> to kill the Crewmates"), Helpers.transl("Kill all Crewmates"), RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo(Helpers.transl("Janitor"), Janitor.color, Helpers.transl("Work with the <color=#FF1919FF>Mafia</color> by hiding dead bodies"), Helpers.transl("Hide dead bodies"), RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo(Helpers.transl("Morphling"), Morphling.color, Helpers.transl("Change your look to not get caught"), Helpers.transl("Change your look"), RoleId.Morphling);
        public static RoleInfo bomber = new RoleInfo(Helpers.transl("Bomber"), Bomber.color, Helpers.transl("Give bombs to players"), Helpers.transl("Bomb Everyone"), RoleId.Bomber);
		public static RoleInfo poucher = new RoleInfo(Helpers.transl("Poucher"), Poucher.color, Helpers.transl("Keep info on the players you kill"), Helpers.transl("Investigate the kills"), RoleId.Poucher);
		public static RoleInfo mimic = new RoleInfo(Helpers.transl("Mimic"), Mimic.color, Helpers.transl("Pose as a crewmate by killing one"), Helpers.transl("Pose as a crewmate"), RoleId.Mimic);
        public static RoleInfo camouflager = new RoleInfo(Helpers.transl("Camouflager"), Camouflager.color, Helpers.transl("Camouflage and kill the Crewmates"), Helpers.transl("Hide among others"), RoleId.Camouflager);
        public static RoleInfo miner = new RoleInfo(Helpers.transl("Miner"), Miner.color, Helpers.transl("Make new Vents"), Helpers.transl("Create Vents"), RoleId.Miner);
        public static RoleInfo vampire = new RoleInfo(Helpers.transl("Vampire"), Vampire.color, Helpers.transl("Kill the Crewmates with your bites"), Helpers.transl("Bite your enemies"), RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo(Helpers.transl("Eraser"), Eraser.color, Helpers.transl("Kill the Crewmates and erase their roles"), Helpers.transl("Erase the roles of your enemies"), RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo(Helpers.transl("Trickster"), Trickster.color, Helpers.transl("Use your jack-in-the-boxes to surprise others"), Helpers.transl("Surprise your enemies"), RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo(Helpers.transl("Cleaner"), Cleaner.color, Helpers.transl("Kill everyone and leave no traces"), Helpers.transl("Clean up dead bodies"), RoleId.Cleaner);
        public static RoleInfo undertaker = new RoleInfo(Helpers.transl("Undertaker"), Undertaker.color, Helpers.transl("Kill everyone and leave no traces"), Helpers.transl("Drag up dead bodies to hide them"), RoleId.Undertaker);
        public static RoleInfo warlock = new RoleInfo(Helpers.transl("Warlock"), Warlock.color, Helpers.transl("Curse other players and kill everyone"), Helpers.transl("Curse and kill everyone"), RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo(Helpers.transl("BountyHunter"), BountyHunter.color, Helpers.transl("Hunt your bounty down"), Helpers.transl("Hunt your bounty down"), RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo(Helpers.transl("Detective"), Detective.color, Helpers.transl("Find the <color=#FF1919FF>Impostors</color> by examining footprints"), Helpers.transl("Examine footprints"), RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo(Helpers.transl("TimeMaster"), TimeMaster.color, Helpers.transl("Save yourself with your time shield"), Helpers.transl("Use your time shield"), RoleId.TimeMaster);
        public static RoleInfo veteren = new RoleInfo(Helpers.transl("Veteran"), Veteren.color, Helpers.transl("Protect yourself from other"), Helpers.transl("Protect yourself from others"), RoleId.Veteren);
        public static RoleInfo medic = new RoleInfo(Helpers.transl("Medic"), Medic.color, Helpers.transl("Protect someone with your shield"), Helpers.transl("Protect other players"), RoleId.Medic);
        public static RoleInfo swapper = new RoleInfo(Helpers.transl("Swapper"), Swapper.color, Helpers.transl("Swap votes to exile the <color=#FF1919FF>Impostors</color>"), Helpers.transl("Swap votes"), RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo(Helpers.transl("Seer"), Seer.color, Helpers.transl("You will see players die"), Helpers.transl("You will see players die"), RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo(Helpers.transl("Hacker"), Hacker.color, Helpers.transl("Hack systems to find the <color=#FF1919FF>Impostors</color>"), Helpers.transl("Hack to find the Impostors"), RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo(Helpers.transl("Tracker"), Tracker.color, Helpers.transl("Track the <color=#FF1919FF>Impostors</color> down"), Helpers.transl("Track the Impostors down"), RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo(Helpers.transl("Snitch"), Snitch.color, Helpers.transl("Finish your tasks to find the <color=#FF1919FF>Impostors</color>"), Helpers.transl("Finish your tasks"), RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo(Helpers.transl("Jackal"), Jackal.color, Helpers.transl("Kill all Crewmates and <color=#FF1919FF>Impostors</color> to win"), Helpers.transl("Kill everyone"), RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo(Helpers.transl("Sidekick"), Sidekick.color, Helpers.transl("Help your Jackal to kill everyone"), Helpers.transl("Help your Jackal to kill everyone"), RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo(Helpers.transl("Spy"), Spy.color, Helpers.transl("Confuse the <color=#FF1919FF>Impostors</color>"), Helpers.transl("Confuse the Impostors"), RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo(Helpers.transl("SecurityGuard"), SecurityGuard.color, Helpers.transl("Seal vents and place cameras"), Helpers.transl("Seal vents and place cameras"), RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo(Helpers.transl("Arsonist"), Arsonist.color, Helpers.transl("Let them burn"), Helpers.transl("Let them burn"), RoleId.Arsonist, true);
        public static RoleInfo amnisiac = new RoleInfo(Helpers.transl("Amnesiac"), Amnisiac.color, Helpers.transl("Steal roles from the dead"), Helpers.transl("You forgor"), RoleId.Amnisiac, true);
        public static RoleInfo vulture = new RoleInfo(Helpers.transl("Vulture"), Vulture.color, Helpers.transl("Eat corpses to win"), Helpers.transl("Eat dead bodies"), RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo(Helpers.transl("Medium"), Medium.color, Helpers.transl("Question the souls of the dead to gain information"), Helpers.transl("Question the souls"), RoleId.Medium);
        public static RoleInfo trapper = new RoleInfo(Helpers.transl("Trapper"), Trapper.color, Helpers.transl("Place traps to find the Impostors"), Helpers.transl("Place traps"), RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo(Helpers.transl("Lawyer"), Lawyer.color, Helpers.transl("Defend your client"), Helpers.transl("Defend your client"), RoleId.Lawyer, true);
        // public static RoleInfo prosecutor = new RoleInfo(Helpers.transl("Prosecutor"), Lawyer.color, Helpers.transl("Vote out your target"), Helpers.transl("Vote our your target"), RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo(Helpers.transl("Pursuer"), Pursuer.color, Helpers.transl("Blank the Impostors"), Helpers.transl("Blank the Impostors"), RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo(Helpers.transl("Impostor"), Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, Helpers.transl("Sabotage and kill everyone")), Helpers.transl("Sabotage and kill everyone"), RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo(Helpers.transl("Crewmate"), Color.white, Helpers.transl("Find the Impostors"), Helpers.transl("Find the Impostors"), RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo(Helpers.transl("Witch"), Witch.color, Helpers.transl("Cast a spell upon your foes"), Helpers.transl("Cast a spell upon your foes"), RoleId.Witch);
        public static RoleInfo cultist = new RoleInfo(Helpers.transl("Cultist"), Cultist.color, Helpers.transl("Recruit for your cause"), Helpers.transl("Recruit for your cause"), RoleId.Cultist);
        public static RoleInfo ninja = new RoleInfo(Helpers.transl("Ninja"), Ninja.color, Helpers.transl("Surprise and assassinate your foes"), Helpers.transl("Surprise and assassinate your foes"), RoleId.Ninja);
        public static RoleInfo blackmailer = new RoleInfo(Helpers.transl("Blackmailer"), Blackmailer.color, Helpers.transl("Blackmail those who seek to hurt you"), Helpers.transl("Blackmail those who seek to hurt you"), RoleId.Blackmailer);
        public static RoleInfo thief = new RoleInfo(Helpers.transl("Thief"), Thief.color, Helpers.transl("Steal a killers role by killing them"), Helpers.transl("Steal a killers role"), RoleId.Thief, true);

        public static RoleInfo hunter = new RoleInfo(Helpers.transl("Hunter"), Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, Helpers.transl("Seek and kill everyone")), Helpers.transl("Seek and kill everyone"), RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo(Helpers.transl("Hunted"), Color.white, Helpers.transl("Hide"), Helpers.transl("Hide"), RoleId.Crewmate);



        // Modifier
        public static RoleInfo bloody = new RoleInfo(Helpers.transl("Bloody"), Color.yellow, Helpers.transl("Your killer leaves a bloody trail"), Helpers.transl("Your killer leaves a bloody trail"), RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo(Helpers.transl("Anti tp"), Color.yellow, Helpers.transl("You will not get teleported"), Helpers.transl("You will not get teleported"), RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo(Helpers.transl("Tiebreaker"), Color.yellow, Helpers.transl("Your vote breaks the tie"), Helpers.transl("Break the tie"), RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo(Helpers.transl("Bait"), Color.yellow, Helpers.transl("Bait your enemies"), Helpers.transl("Bait your enemies"), RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo(Helpers.transl("Sunglasses"), Color.yellow, Helpers.transl("You got the sunglasses"), Helpers.transl("Your vision is reduced"), RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo(Helpers.transl("Lover"), Lovers.color, Helpers.transl($"You are in love"), Helpers.transl($"You are in love"), RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo(Helpers.transl("Mini"), Color.yellow, Helpers.transl("No one will harm you until you grow up"), Helpers.transl("No one will harm you"), RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo(Helpers.transl("VIP"), Color.yellow, Helpers.transl("You are the VIP"), Helpers.transl("Everyone is notified when you die"), RoleId.Vip, false, true);
        public static RoleInfo indomitable  = new RoleInfo(Helpers.transl("Indomitable"), Color.yellow, Helpers.transl("Your role cannot be guessed"), Helpers.transl("You are Indomitable!"), RoleId.Indomitable, false, true);
        public static RoleInfo slueth  = new RoleInfo(Helpers.transl("Slueth"), Color.yellow, Helpers.transl("Learn the roles of bodies you report"), Helpers.transl("Who dat?"), RoleId.Indomitable, false, true);
        public static RoleInfo cursed  = new RoleInfo(Helpers.transl("Fanatic"), Color.yellow, Helpers.transl("You are crewmate....for now"), Helpers.transl("Discover your true potential"), RoleId.Cursed, false, true, true);
        public static RoleInfo invert = new RoleInfo(Helpers.transl("Invert"), Color.yellow, Helpers.transl("Your movement is inverted"), Helpers.transl("Your movement is inverted"), RoleId.Invert, false, true);
        public static RoleInfo blind  = new RoleInfo(Helpers.transl("Blind"), Color.yellow, Helpers.transl("You cannot see your report button!"), Helpers.transl("Was that a dead body?"), RoleId.Blind, false, true);
        public static RoleInfo tunneler  = new RoleInfo(Helpers.transl("Tunneler"), Color.yellow, Helpers.transl("Complete your tasks to gain the ability to vent"), Helpers.transl("Finish work so you can play"), RoleId.Tunneler, false, true);
        public static RoleInfo disperser = new RoleInfo(Helpers.transl("Disperser"), Color.red, Helpers.transl("Separate the Crew"), Helpers.transl("Separate the Crew"), RoleId.Disperser, false, true);
        public static RoleInfo goodGuesser = new RoleInfo(Helpers.transl("Guesser"), Color.yellow, Helpers.transl("Guess and shoot"), Helpers.transl("Guess and shoot"), RoleId.NiceGuesser, false, true);
        public static RoleInfo paranoid  = new RoleInfo(Helpers.transl("Paranoid"), Color.yellow, Helpers.transl("Watch your six!"), Helpers.transl("Use your paranoia to your advantage and see through tasks!"), RoleId.Paranoid, false, true);
        public static RoleInfo badGuesser = new RoleInfo(Helpers.transl("Guesser"), Color.yellow, Helpers.transl("Guess and shoot"), Helpers.transl("Guess and shoot"), RoleId.EvilGuesser, false, true);

        public static RoleInfo chameleon = new RoleInfo(Helpers.transl("Chameleon"), Color.yellow, Helpers.transl("You're hard to see when not moving"), Helpers.transl("You're hard to see when not moving"), RoleId.Chameleon, false, true);
        public static RoleInfo shifter = new RoleInfo(Helpers.transl("Shifter"), Color.yellow, Helpers.transl("Shift your role"), Helpers.transl("Shift your role"), RoleId.Shifter, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            bomber,
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
            veteren,
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
            shifter
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
                if (p == Disperser.disperser) infos.Add(disperser);
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
            if (p == Bomber.bomber) infos.Add(bomber);
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
            if (p == Veteren.veteren) infos.Add(veteren);
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

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(MapOptionsTor.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(MapOptionsTor.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : RoleInfo.crewmate);
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
            return roleName;
        }
    }
}

