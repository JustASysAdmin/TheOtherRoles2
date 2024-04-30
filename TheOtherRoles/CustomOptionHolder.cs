using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3"};
        public static string[] presets = new string[]{"Preset 1", "Preset 2", "Random Preset Skeld", "Random Preset Mira HQ", "Random Preset Polus", "Random Preset Airship", "Random Preset Submerged" };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption enableEventMode;

        public static CustomOption cultistSpawnRate;

        public static CustomOption swooperSpawnRate;
        public static CustomOption swooperCooldown;
        public static CustomOption swooperAsWell;
        public static CustomOption swooperDuration;
        public static CustomOption swooperHasImpVision;
        
        public static CustomOption minerSpawnRate;
		public static CustomOption minerCooldown;
		
        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;
        
        public static CustomOption modifierParanoid;
		
        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberDelay;
        public static CustomOption bomberTimer;

        public static CustomOption undertakerSpawnRate;
        public static CustomOption undertakerDragingDelaiAfterKill;
        public static CustomOption undertakerCanDragAndVent;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireGarlicButton;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption guesserShowInfoInGhostChat;

        public static CustomOption poucherSpawnRate;
        public static CustomOption mimicSpawnRate;


        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterCanVent;
        public static CustomOption jesterHasImpostorVision;
		
        public static CustomOption prosecutorSpawnRate;
        public static CustomOption prosecutorPreferAmnesiac;

        public static CustomOption amnisiacSpawnRate;
        public static CustomOption amnisiacShowArrows;
        public static CustomOption amnisiacResetRole;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalKillFakeImpostor;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanUseSabo;
        //public static CustomOption jackalhasChat;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption blackmailerSpawnRate;
        public static CustomOption blackmailerCooldown;

        public static CustomOption shifterSpawnRate;
        public static CustomOption shifterShiftsModifiers;
        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;
     
		public static CustomOption privateInvestigatorSpawnRate;
        public static CustomOption privateInvestigatorSeeColor;



        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterCooldown;
        public static CustomOption lighterDuration;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;


        public static CustomOption veterenSpawnRate;
        public static CustomOption veterenCooldown;
        public static CustomOption veterenAlertDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchIncludeTeamJackal;
        public static CustomOption snitchSeeMeeting;

        public static CustomOption snitchTeamJackalUseDifferentArrowColor;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption bodyGuardSpawnRate;
        public static CustomOption bodyGuardResetTargetAfterMeeting;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerIsProsecutorChance;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption lawyerCanCallEmergency;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption werewolfSpawnRate;
        public static CustomOption werewolfRampageCooldown;
        public static CustomOption werewolfRampageDuration;
        public static CustomOption werewolfKillCooldown;
        
        public static CustomOption thiefSpawnRate;
        public static CustomOption thiefCooldown;
        public static CustomOption thiefHasImpVision;
        public static CustomOption thiefCanUseVents;
        public static CustomOption thiefCanKillSheriff;


        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierDisperser;
        public static CustomOption modifierDisperserCooldown;
        public static CustomOption modifierDisperserNumberOfUses;
        public static CustomOption modifierDisperserDispersesToVent;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;
        public static CustomOption modifierMiniGrowingUpInMeeting;

        public static CustomOption modifierIndomitable;
        public static CustomOption modifierTunneler;
        public static CustomOption modifierBlind;
        public static CustomOption modifierSlueth;
		public static CustomOption modifierCursed;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;

        public static CustomOption modifierChameleon;
        public static CustomOption modifierChameleonQuantity;
        public static CustomOption modifierChameleonHoldDuration;
        public static CustomOption modifierChameleonFadeDuration;
        public static CustomOption modifierChameleonMinVisibility;

        public static CustomOption modifierShifter;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption camsNoNightVisionIfImpVision;
        public static CustomOption camsNightVision;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption showButtonTarget;
        public static CustomOption blockGameEnd;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;

        public static CustomOption randomGameStartPosition;
        public static CustomOption allowModGuess;
        public static CustomOption resetRoundStartCooldown;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableFungle;
        public static CustomOption dynamicMapEnableSubmerged;
		
		public static CustomOption movePolusVents;
		public static CustomOption swapNavWifi;
		public static CustomOption movePolusVitals;
		public static CustomOption enableBetterPolus;
		public static CustomOption moveColdTemp;
		
		
		public static CustomOption enableCamoComms;
		
        public static CustomOption disableMedbayWalk;

        public static CustomOption restrictDevices;
        public static CustomOption disableCamsRound1;
        public static CustomOption restrictAdmin;
        public static CustomOption restrictCameras;
        public static CustomOption restrictVents;
        public static CustomOption dynamicMapSeparateSettings;

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;

        // Hide N Seek Gamemode
        public static CustomOption hideNSeekHunterCount;
        public static CustomOption hideNSeekKillCooldown;
        public static CustomOption hideNSeekHunterVision;
        public static CustomOption hideNSeekHuntedVision;
        public static CustomOption hideNSeekTimer;
        public static CustomOption hideNSeekCommonTasks;
        public static CustomOption hideNSeekShortTasks;
        public static CustomOption hideNSeekLongTasks;
        public static CustomOption hideNSeekTaskWin;
        public static CustomOption hideNSeekTaskPunish;
        public static CustomOption hideNSeekCanSabotage;
        public static CustomOption hideNSeekMap;
        public static CustomOption hideNSeekHunterWaiting;

        public static CustomOption hunterLightCooldown;
        public static CustomOption hunterLightDuration;
        public static CustomOption hunterLightVision;
        public static CustomOption hunterLightPunish;
        public static CustomOption hunterAdminCooldown;
        public static CustomOption hunterAdminDuration;
        public static CustomOption hunterAdminPunish;
        public static CustomOption hunterArrowCooldown;
        public static CustomOption hunterArrowDuration;
        public static CustomOption hunterArrowPunish;

        public static CustomOption huntedShieldCooldown;
        public static CustomOption huntedShieldDuration;
        public static CustomOption huntedShieldRewindTime;
        public static CustomOption huntedShieldNumber;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {

            CustomOption.vanillaSettings = TheOtherRolesPlugin.Instance.Config.Bind("Preset0", "VanillaOptions", "");

            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("presetSelection")), presets, null, true);
            activateRoles = CustomOption.Create(1, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("activateRoles")), true, null, true);

            if (Utilities.EventUtility.canBeEnabled) enableEventMode = CustomOption.Create(10423, Types.General, cs(Color.green, Helpers.transl("enableEventMode")), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("crewmateRolesCountMin")), 15f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("crewmateRolesCountMax")), 15f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("neutralRolesCountMin")), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("neutralRolesCountMax")), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("impostorRolesCountMin")), 15f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("impostorRolesCountMax")), 15f, 0f, 15f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("modifiersCountMin")), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), Helpers.transl("modifiersCountMax")), 15f, 0f, 15f, 1f);

            mafiaSpawnRate = CustomOption.Create(10, Types.Impostor, cs(Janitor.color, Helpers.transl("Mafia")), rates, null, true);
            janitorCooldown = CustomOption.Create(11, Types.Impostor, Helpers.transl("janitorCooldown"), 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, cs(Morphling.color, Helpers.transl("Morphling")), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, Helpers.transl("morphlingCooldown"), 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, Helpers.transl("morphlingDuration"), 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

        // public static CustomOption bomberSpawnRate;
        // public static CustomOption bomberBombCooldown;
        // public static CustomOption bomberDelay;
        // public static CustomOption bomberTimer;
        
            bomberSpawnRate = CustomOption.Create(8840, Types.Impostor, cs(Bomber.color, Helpers.transl("Bomber")), rates, null, true);
            bomberBombCooldown = CustomOption.Create(8841, Types.Impostor, Helpers.transl("bomberBombCooldown"), 30f, 25f, 60f, 2.5f, bomberSpawnRate);
            bomberDelay = CustomOption.Create(8842, Types.Impostor, Helpers.transl("bomberDelay"), 10f, 1f, 20f, 0.5f, bomberSpawnRate);
            bomberTimer = CustomOption.Create(8843, Types.Impostor, Helpers.transl("bomberTimer"), 10f, 5f, 30f, 5f, bomberSpawnRate);



            undertakerSpawnRate = CustomOption.Create(1201, Types.Impostor, cs(Undertaker.color, Helpers.transl("Undertaker")), rates, null, true);
            undertakerDragingDelaiAfterKill = CustomOption.Create(1202, Types.Impostor, Helpers.transl("undertakerDragingDelaiAfterKill"), 0f, 0f, 15, 1f, undertakerSpawnRate);                     
            undertakerCanDragAndVent = CustomOption.Create(1203, Types.Impostor, Helpers.transl("undertakerCanDragAndVent"), true, undertakerSpawnRate);


            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, cs(Camouflager.color, Helpers.transl("Camouflager")), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, Helpers.transl("camouflagerCooldown"), 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, Helpers.transl("camouflagerDuration"), 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, cs(Vampire.color, Helpers.transl("Vampire")), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, Helpers.transl("vampireKillDelay"), 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, Helpers.transl("vampireCooldown"), 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireGarlicButton = CustomOption.Create(43, Types.Impostor, Helpers.transl("vampireGarlicButton"), true, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(44, Types.Impostor, Helpers.transl("vampireCanKillNearGarlics"), true, vampireGarlicButton);

            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, cs(Eraser.color, Helpers.transl("Eraser")), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, Helpers.transl("eraserCooldown"), 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, Helpers.transl("eraserCanEraseAnyone"), false, eraserSpawnRate);
			
			poucherSpawnRate = CustomOption.Create(8833, Types.Impostor, cs(Poucher.color, Helpers.transl("Poucher")), rates, null, true);
			mimicSpawnRate = CustomOption.Create(8835, Types.Impostor, cs(Mimic.color, Helpers.transl("Mimic")), rates, null, true);

            
            //cultistSpawnRate =  CustomOption.Create(3801, Types.Impostor, cs(Cultist.color, Helpers.transl("Cultist")), rates, null, true);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, cs(Trickster.color, Helpers.transl("Trickster")), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, Helpers.transl("tricksterPlaceBoxCooldown"), 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, Helpers.transl("tricksterLightsOutCooldown"), 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, Helpers.transl("tricksterLightsOutDuration"), 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, cs(Cleaner.color, Helpers.transl("Cleaner")), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, Helpers.transl("cleanerCooldown"), 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, cs(Cleaner.color, Helpers.transl("Warlock")), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, Helpers.transl("warlockCooldown"), 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, Helpers.transl("warlockRootTime"), 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, cs(BountyHunter.color, Helpers.transl("bountyhunter")), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, Helpers.transl("bountyHunterBountyDuration"),  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, Helpers.transl("bountyHunterReducedCooldown"), 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, Helpers.transl("bountyHunterPunishmentTime"), 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, Helpers.transl("bountyHunterShowArrow"), true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, Helpers.transl("bountyHunterArrowUpdateIntervall"), 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, cs(Witch.color, Helpers.transl("Witch")), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, Helpers.transl("witchCooldown"), 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, Helpers.transl("witchAdditionalCooldown"), 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, Helpers.transl("witchCanSpellAnyone"), false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, Helpers.transl("witchSpellCastingDuration"), 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, Helpers.transl("witchTriggerBothCooldowns"), true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, Helpers.transl("witchVoteSavesTargets"), true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, Helpers.transl("Ninja")), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, Helpers.transl("ninjaCooldown"), 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, Helpers.transl("ninjaKnowsTargetLocation"), true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, Helpers.transl("ninjaTraceTime"), 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, Helpers.transl("ninjaTraceColorTime"), 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, Helpers.transl("ninjaInvisibleDuration"), 3f, 0f, 20f, 1f, ninjaSpawnRate);

            blackmailerSpawnRate = CustomOption.Create(710, Types.Impostor, cs(Blackmailer.color, Helpers.transl("Blackmailer")), rates, null, true);
            blackmailerCooldown = CustomOption.Create(711, Types.Impostor, Helpers.transl("blackmailerCooldown"), 30f, 5f, 120f, 5f, blackmailerSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, cs(Jester.color, Helpers.transl("Jester")), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, Helpers.transl("jesterCanCallEmergency"), true, jesterSpawnRate);
            jesterCanVent = CustomOption.Create(1901, Types.Neutral, Helpers.transl("jesterCanVent"), true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, Helpers.transl("jesterHasImpostorVision"), false, jesterSpawnRate);
			
            prosecutorSpawnRate = CustomOption.Create(615, Types.Neutral, cs(Prosecutor.color, Helpers.transl("Executioner")),   rates, null, true);


            amnisiacSpawnRate = CustomOption.Create(616, Types.Neutral, cs(Amnisiac.color, Helpers.transl("Amnesiac")), rates, null, true);
            amnisiacShowArrows = CustomOption.Create(617, Types.Neutral, Helpers.transl("amnisiacShowArrows"), true, amnisiacSpawnRate);
            amnisiacResetRole = CustomOption.Create(618, Types.Neutral, Helpers.transl("amnisiacResetRole"), true, amnisiacSpawnRate);


            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, cs(Arsonist.color, Helpers.transl("Arsonist")), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, Helpers.transl("arsonistCooldown"), 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, Helpers.transl("arsonistDuration"), 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, cs(Jackal.color, Helpers.transl("Jackal")), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, Helpers.transl("jackalKillCooldown"), 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, Helpers.transl("jackalCreateSidekickCooldown"), 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            //jackalhasChat = CustomOption.Create(1197, Types.Neutral, Helpers.transl("jackalhasChat"), false, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, Helpers.transl("jackalCanUseVents"), true, jackalSpawnRate);
            jackalCanUseSabo = CustomOption.Create(8876, Types.Neutral, Helpers.transl("jackalCanUseSabo"), false, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, Helpers.transl("jackalCanCreateSidekick"), false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, Helpers.transl("sidekickPromotesToJackal"), false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, Helpers.transl("sidekickCanKill"), false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, Helpers.transl("sidekickCanUseVents"), true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, Helpers.transl("jackalPromotedFromSidekickCanCreateSidekick"), true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, Helpers.transl("jackalCanCreateSidekickFromImpostor"), true, jackalCanCreateSidekick);
			jackalKillFakeImpostor = CustomOption.Create(7885, Types.Neutral, Helpers.transl("jackalKillFakeImpostor"), true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, Helpers.transl("jackalAndSidekickHaveImpostorVision"), false, jackalSpawnRate);

            swooperSpawnRate = CustomOption.Create(1110, Types.Neutral, cs(Swooper.color, Helpers.transl("Swooper")), rates, null, true); //jackalSpawnRate);
            swooperAsWell = CustomOption.Create(1113, Types.Neutral, Helpers.transl("swooperAsWell"), false, swooperSpawnRate);
            swooperCooldown = CustomOption.Create(1111, Types.Neutral, Helpers.transl("swooperCooldown"), 30f, 10f, 60f, 2.5f, swooperSpawnRate);
            swooperDuration = CustomOption.Create(1112, Types.Neutral, Helpers.transl("swooperDuration"), 10f, 1f, 20f, 0.5f, swooperSpawnRate);
            swooperHasImpVision = CustomOption.Create(1114, Types.Neutral, Helpers.transl("swooperHasImpVision"), true, swooperSpawnRate);
			
            minerSpawnRate = CustomOption.Create(1120, Types.Impostor, cs(Miner.color, Helpers.transl("Miner")), rates, null, true); //jackalSpawnRate);
            minerCooldown = CustomOption.Create(1121, Types.Impostor, Helpers.transl("minerCooldown"), 25f, 10f, 60f, 2.5f, minerSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, cs(Vulture.color, Helpers.transl("Vulture")), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, Helpers.transl("vultureCooldown"), 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, Helpers.transl("vultureNumberToWin"), 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, Helpers.transl("vultureCanUseVents"), true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, Helpers.transl("vultureShowArrows"), true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, cs(Lawyer.color, Helpers.transl("Lawyer")), rates, null, true);
            lawyerVision = CustomOption.Create(354, Types.Neutral, Helpers.transl("Vision"), 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, Helpers.transl("lawyerKnowsRole"), false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, Types.Neutral, Helpers.transl("lawyerCanCallEmergency"), true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, Helpers.transl("lawyerTargetCanBeJester"), false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, Helpers.transl("pursuerCooldown"), 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, Helpers.transl("pursuerBlanksNumber"), 5f, 1f, 20f, 1f, lawyerSpawnRate);
            
            werewolfSpawnRate = CustomOption.Create(1501, Types.Neutral, cs(Werewolf.color, Helpers.transl("Werewolf")), rates, null, true);
            werewolfRampageCooldown  = CustomOption.Create(1502, Types.Neutral, Helpers.transl("werewolfRampageCooldown"), 30f, 10f, 60f, 2.5f, werewolfSpawnRate);
            werewolfRampageDuration = CustomOption.Create(1503, Types.Neutral, Helpers.transl("werewolfRampageDuration"), 15f, 1f, 20f, 0.5f, werewolfSpawnRate);
            werewolfKillCooldown = CustomOption.Create(1504, Types.Neutral, Helpers.transl("werewolfKillCooldown"), 3f, 1f, 60f, 1f, werewolfSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, cs(Mayor.color, Helpers.transl("Mayor")), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, Helpers.transl("mayorCanSeeVoteColor"), false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, Helpers.transl("mayorTasksNeededToSeeVoteColors"), 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, Helpers.transl("mayorMeetingButton"), true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, Helpers.transl("mayorMaxRemoteMeetings"), 1f, 1f, 5f, 1f, mayorMeetingButton);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, cs(Engineer.color, Helpers.transl("Engineer")), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, Helpers.transl("engineerNumberOfFixes"), 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, Helpers.transl("engineerHighlightForImpostors"), true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, Helpers.transl("engineerHighlightForTeamJackal"), true, engineerSpawnRate);

            privateInvestigatorSpawnRate = CustomOption.Create(8839, Types.Crewmate, cs(PrivateInvestigator.color, Helpers.transl("PrivateInvestigator")), rates, null, true);
			privateInvestigatorSeeColor = CustomOption.Create(8844, Types.Crewmate, Helpers.transl("privateInvestigatorSeeColor"), true, privateInvestigatorSpawnRate);


            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, cs(Sheriff.color, Helpers.transl("Sheriff")), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, Helpers.transl("sheriffCooldown"), 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, Helpers.transl("sheriffCanKillNeutrals"), false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, Helpers.transl("sheriffDeputy"), rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, Helpers.transl("deputyNumberOfHandcuffs"), 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, Helpers.transl("deputyHandcuffCooldown"), 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, Helpers.transl("deputyHandcuffDuration"), 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, Helpers.transl("deputyKnowsSheriff"), true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, Helpers.transl("deputyGetsPromoted"), new string[] { Helpers.transl("deputyOff"), Helpers.transl("deputyOnImmediately"), Helpers.transl("deputyOnAfterMeeting") }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, Helpers.transl("deputyKeepsHandcuffs"), true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, cs(Lighter.color, Helpers.transl("Lighter")), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, Helpers.transl("lighterModeLightsOnVision"), 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, Helpers.transl("lighterModeLightsOffVision"), 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113, Types.Crewmate, Helpers.transl("lighterCooldown"), 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114, Types.Crewmate, Helpers.transl("lighterDuration"), 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, cs(Detective.color, Helpers.transl("Detective")), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, Helpers.transl("detectiveAnonymousFootprints"), false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, Helpers.transl("detectiveFootprintInterval"), 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, Helpers.transl("detectiveFootprintDuration"), 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, Helpers.transl("detectiveReportNameDuration"), 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, Helpers.transl("detectiveReportColorDuration"), 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, cs(TimeMaster.color, Helpers.transl("TimeMaster")), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, Helpers.transl("timeMasterCooldown"), 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, Helpers.transl("timeMasterRewindTime"), 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, Helpers.transl("timeMasterShieldDuration"), 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            veterenSpawnRate = CustomOption.Create(4450, Types.Crewmate, cs(Veteren.color, Helpers.transl("Veteran")), rates, null, true);
            veterenCooldown = CustomOption.Create(4451, Types.Crewmate, Helpers.transl("veterenCooldown"), 30f, 10f, 120f, 2.5f, veterenSpawnRate);
	        veterenAlertDuration = CustomOption.Create(4452, Types.Crewmate, Helpers.transl("veterenAlertDuration"), 3f, 1f, 20f, 1f, veterenSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, cs(Medic.color, Helpers.transl("Medic")), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, Helpers.transl("medicShowShielded"), new string[] { Helpers.transl("medicShowShieldedAll"), Helpers.transl("medicShowShieldedBoth"), Helpers.transl("medicShowShieldedMedic") }, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, Helpers.transl("medicShowAttemptToShielded"), false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, Helpers.transl("medicSetOrShowShieldAfterMeeting"), new string[] { Helpers.transl("medicInstantly"), Helpers.transl("medicVisibleAfterMeeting"), Helpers.transl("medicAftermeeting") }, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, Helpers.transl("medicShowAttemptToMedic"), false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, cs(Swapper.color, Helpers.transl("Swapper")), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, Helpers.transl("swapperCanCallEmergency"), false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, Helpers.transl("swapperCanOnlySwapOthers"), false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, Helpers.transl("swapperSwapsNumber"), 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, Helpers.transl("swapperRechargeTasksNumber"), 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, cs(Seer.color, Helpers.transl("Seer")), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, Helpers.transl("seerMode"), new string[] { Helpers.transl("seerModeBoth"), Helpers.transl("seerModeFlash"), Helpers.transl("seerModeSouls") }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, Helpers.transl("seerLimitSoulDuration"), false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, Helpers.transl("seerSoulDuration"), 15f, 0f, 120f, 5f, seerLimitSoulDuration);

            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, cs(Hacker.color, Helpers.transl("Hacker")), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, Helpers.transl("hackerCooldown"), 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, Helpers.transl("hackerHackeringDuration"), 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, Helpers.transl("hackerOnlyColorType"), false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, Helpers.transl("hackerToolsNumber"), 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, Helpers.transl("hackerRechargeTasksNumber"), 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, Helpers.transl("hackerNoMove"), true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, cs(Tracker.color, Helpers.transl("Tracker")), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, Helpers.transl("trackerUpdateInterval"), 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, Helpers.transl("trackerResetTargetAfterMeeting"), false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, Helpers.transl("trackerCanTrackCorpses"), true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, Helpers.transl("trackerCorpsesTrackingCooldown"), 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, Helpers.transl("trackerCorpsesTrackingDuration"), 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);

            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, cs(Snitch.color, Helpers.transl("Snitch")), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(211, Types.Crewmate, Helpers.transl("snitchLeftTasksForReveal"), 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212, Types.Crewmate, Helpers.transl("snitchIncludeTeamJackal"), false, snitchSpawnRate);
            snitchSeeMeeting = CustomOption.Create(8836, Types.Crewmate, Helpers.transl("snitchSeeMeeting"), false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, Types.Crewmate, Helpers.transl("snitchTeamJackalUseDifferentArrowColor"), true, snitchIncludeTeamJackal);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, cs(Spy.color, Helpers.transl("Spy")), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, Helpers.transl("spyCanDieToSheriff"), false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, Helpers.transl("spyImpostorsCanKillAnyone"), true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, Helpers.transl("spyCanEnterVents"), false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, Helpers.transl("spyHasImpostorVision"), false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, Helpers.transl("Portalmaker")), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, Helpers.transl("portalmakerCooldown"), 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, Helpers.transl("portalmakerUsePortalCooldown"), 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, Helpers.transl("portalmakerLogOnlyColorType"), true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, Helpers.transl("portalmakerLogHasTime"), true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, cs(SecurityGuard.color, Helpers.transl("SecurityGuard")), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, Helpers.transl("securityGuardCooldown"), 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, Helpers.transl("securityGuardTotalScrews"), 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, Helpers.transl("securityGuardCamPrice"), 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, Helpers.transl("securityGuardVentPrice"), 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, Helpers.transl("securityGuardCamDuration"), 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, Helpers.transl("securityGuardCamMaxCharges"), 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, Helpers.transl("securityGuardCamRechargeTasksNumber"), 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, Helpers.transl("securityGuardNoMove"), true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, cs(Medium.color, Helpers.transl("Medium")), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, Helpers.transl("mediumCooldown"), 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, Helpers.transl("mediumDuration"), 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, Helpers.transl("mediumOneTimeUse"), false, mediumSpawnRate);

            bodyGuardSpawnRate = CustomOption.Create(8820, Types.Crewmate, cs(BodyGuard.color, Helpers.transl("Bodyguard")), rates, null, true);
            bodyGuardResetTargetAfterMeeting = CustomOption.Create(8821, Types.Crewmate, Helpers.transl("bodyGuardResetTargetAfterMeeting"), true, bodyGuardSpawnRate);



            thiefSpawnRate = CustomOption.Create(400, Types.Neutral, cs(Thief.color, Helpers.transl("Thief")), rates, null, true);
            thiefCooldown = CustomOption.Create(401, Types.Neutral, Helpers.transl("thiefCooldown"), 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, Types.Neutral, Helpers.transl("thiefCanKillSheriff"), true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, Types.Neutral, Helpers.transl("thiefHasImpVision"), true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, Types.Neutral, Helpers.transl("thiefCanUseVents"), true, thiefSpawnRate);

            trapperSpawnRate = CustomOption.Create(410, Types.Crewmate, cs(Trapper.color, Helpers.transl("Trapper")), rates, null, true);
            trapperCooldown = CustomOption.Create(420, Types.Crewmate, Helpers.transl("trapperCooldown"), 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, Types.Crewmate, Helpers.transl("trapperMaxCharges"), 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, Types.Crewmate, Helpers.transl("trapperRechargeTasksNumber"), 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, Types.Crewmate, Helpers.transl("trapperTrapNeededTriggerToReveal"), 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, Types.Crewmate, Helpers.transl("trapperAnonymousMap"), false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, Types.Crewmate, Helpers.transl("trapperInfoType"), new string[] { Helpers.transl("TrapperRole"), Helpers.transl("TrapperGoodEvil Role"), Helpers.transl("TrapperName") }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, Types.Crewmate, Helpers.transl("trapperTrapDuration"), 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1099, Types.Modifier, cs(Color.yellow, Helpers.transl("modifiersAreHidden")), true, null, true);

            modifierDisperser = CustomOption.Create(1110, Types.Modifier, cs(Color.red, Helpers.transl("Disperser")), rates, null, true);
            modifierDisperserCooldown = CustomOption.Create(1112, Types.Modifier, Helpers.transl("Disperser Cooldown"), 30f, 10f, 60f, 2.5f, modifierDisperser);
            modifierDisperserNumberOfUses = CustomOption.Create(1114, Types.Modifier, Helpers.transl("Number Of Uses"), 1, 1, 5, 1, modifierDisperser);
            modifierDisperserDispersesToVent = CustomOption.Create(1113, Types.Modifier, Helpers.transl("Disperse To Vent"), true, modifierDisperser);

            modifierParanoid = CustomOption.Create(8831, Types.Modifier, cs(Color.yellow, Helpers.transl("Paranoid")), rates, null, true);

            guesserSpawnRate = CustomOption.Create(310, Types.Modifier, cs(Guesser.color, Helpers.transl("Guesser")), false, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, Types.Modifier, Helpers.transl("Evil Spawn Rate"), rates, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, Types.Modifier, Helpers.transl("Other Spawn Rate"), rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, Types.Modifier, Helpers.transl("Guesser Number Of Shots"), 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Modifier, Helpers.transl("Guesser Can Shoot Multiple Times Per Meeting"), false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(314, Types.Modifier, Helpers.transl("Guesses Visible In Ghost Chat"), true, guesserSpawnRate);
            guesserKillsThroughShield = CustomOption.Create(315, Types.Modifier, Helpers.transl("Guesses Ignore The Medic Shield"), true, guesserSpawnRate);
            guesserEvilCanKillSpy = CustomOption.Create(316, Types.Modifier, Helpers.transl("Evil Guesser Can Guess The Spy"), true, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Modifier, Helpers.transl("Guesser Can't Guess Snitch When Tasks Completed"), true, guesserSpawnRate);

            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, Helpers.transl("Bloody")), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, Helpers.transl("Bloody Quantity")), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, Helpers.transl("Trail Duration"), 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, Helpers.transl("Anti Teleport")), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, Helpers.transl("Anti Teleport Quantity")), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, Helpers.transl("Tie Breaker")), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, Helpers.transl("Bait")), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, Helpers.transl("Bait Quantity")), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, Helpers.transl("Bait Report Delay Min"), 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, Helpers.transl("Bait Report Delay Max"), 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, Helpers.transl("Warn The Killer With A Flash"), true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, Helpers.transl("Lovers")), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, Helpers.transl("Chance That One Lover Is Impostor"), rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, Helpers.transl("Both Lovers Die"), true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, Helpers.transl("Enable Lover Chat"), true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, Helpers.transl("Sunglasses")), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, Helpers.transl("Sunglasses Quantity")), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, Helpers.transl("Vision With Sunglasses"), new string[] { "-10%", "-20%","-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, Helpers.transl("Mini")), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, Helpers.transl("Mini Growing Up Duration"), 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, Types.Modifier, Helpers.transl("Mini Grows Up In Meeting"), true, modifierMini);

            modifierIndomitable = CustomOption.Create(1276, Types.Modifier, cs(Color.yellow, Helpers.transl("Indomitable")), rates, null, true);

            modifierBlind = CustomOption.Create(8810, Types.Modifier, cs(Color.yellow, Helpers.transl("Blind")), rates, null, true);
            modifierTunneler = CustomOption.Create(8819, Types.Modifier, cs(Color.yellow, Helpers.transl("Tunneler")), rates, null, true);
            modifierSlueth = CustomOption.Create(8830, Types.Modifier, cs(Color.yellow, Helpers.transl("Slueth")), rates, null, true);
            modifierCursed = CustomOption.Create(1277, Types.Modifier, cs(Color.yellow, Helpers.transl("Fanatic")), rates, null, true);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, Helpers.transl("VIP")), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, Helpers.transl("VIP Quantity")), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, Helpers.transl("Show Team Color"), true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, Helpers.transl("Invert")), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, Helpers.transl("Modifier Quantity")), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, Helpers.transl("Number Of Meetings Inverted"), 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, Types.Modifier, cs(Color.yellow, Helpers.transl("Chameleon")), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, Types.Modifier, cs(Color.yellow, Helpers.transl("Chameleon Quantity")), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, Types.Modifier, Helpers.transl("Time Until Fading Starts"), 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, Types.Modifier, Helpers.transl("Fade Duration"), 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, Types.Modifier, Helpers.transl("Minimum Visibility"), new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, Types.Modifier, cs(Color.yellow, Helpers.transl("Shifter")), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, Types.Guesser, cs(Guesser.color, Helpers.transl("Number of Crew Guessers")), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, Types.Guesser, cs(Guesser.color, Helpers.transl("Number of Neutral Guessers")), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeImpNumber = CustomOption.Create(2003, Types.Guesser, cs(Guesser.color, Helpers.transl("Number of Impostor Guessers")), 15f, 1f, 15f, 1f, null, true);
            guesserForceJackalGuesser = CustomOption.Create(2007, Types.Guesser, Helpers.transl("Force Jackal Guesser"), false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, Types.Guesser, Helpers.transl("Guessers Can Have A Modifier"), true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, Types.Guesser, Helpers.transl("Guesser Number Of Shots"), 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, Types.Guesser, Helpers.transl("Guesser Can Shoot Multiple Times Per Meeting"), false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, Types.Guesser, Helpers.transl("Guesses Ignore The Medic Shield"), true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, Types.Guesser, Helpers.transl("Evil Guesser Can Guess The Spy"), true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, Types.Guesser, Helpers.transl("Guesser Can't Guess Snitch When Tasks Completed"), true, null);

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Map")), new string[] { Helpers.transl("The Skeld"), Helpers.transl("Mira"), Helpers.transl("Polus"), Helpers.transl("Airship"), Helpers.transl("Fungle"), Helpers.transl("Submerged"), Helpers.transl("LI Map") }, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            hideNSeekHunterCount = CustomOption.Create(3000, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Number Of Hunters")), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Kill Cooldown")), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Hunter Vision")), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Hunted Vision")), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Common Tasks")), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Short Tasks")), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Long Tasks")), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Timer In Min")), 5f, 1f, 30f, 1f);
            hideNSeekTaskWin = CustomOption.Create(3004, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Task Win Is Possible")), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Finish Tasks Punish In Sec")), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Enable Sabotages")), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, Types.HideNSeekMain, cs(Color.yellow, Helpers.transl("Time The Hunter Needs To Wait")), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Light Cooldown")), 30f, 5f, 60f, 1f, null, true);
            hunterLightDuration = CustomOption.Create(3006, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Light Duration")), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Light Vision")), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Light Punish In Sec")), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Admin Cooldown")), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Admin Duration")), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Admin Punish In Sec")), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Arrow Cooldown")), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Arrow Duration")), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, Types.HideNSeekRoles, cs(Color.red, Helpers.transl("Hunter Arrow Punish In Sec")), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, Types.HideNSeekRoles, cs(Color.gray, Helpers.transl("Hunted Shield Cooldown")), 30f, 5f, 60f, 1f, null, true);
            huntedShieldDuration = CustomOption.Create(3016, Types.HideNSeekRoles, cs(Color.gray, Helpers.transl("Hunted Shield Duration")), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, Types.HideNSeekRoles, cs(Color.gray, Helpers.transl("Hunted Rewind Time")), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, Types.HideNSeekRoles, cs(Color.gray, Helpers.transl("Hunted Shield Number")), 3f, 1f, 15f, 1f);

            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, Helpers.transl("Number Of Meetings (excluding Mayor meeting)"), 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, Helpers.transl("Block Skipping In Emergency Meetings"), false);
            camsNightVision = CustomOption.Create(11, Types.General, Helpers.transl("camsNightVision"), false, null, true);
            camsNoNightVisionIfImpVision = CustomOption.Create(12, Types.General, Helpers.transl("camsNoNightVisionIfImpVision"), false, camsNightVision, false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, Helpers.transl("No Vote Is Self Vote"), false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, Helpers.transl("Hide Player Names"), false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, Helpers.transl("Allow Parallel MedBay Scans"), false);
            shieldFirstKill = CustomOption.Create(8, Types.General, Helpers.transl("Shield Last Game First Kill"), false);

            dynamicMap = CustomOption.Create(500, Types.General, Helpers.transl("Play On A Random Map"), false, null, false);
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, Helpers.transl("Skeld"), rates, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, Helpers.transl("Mira"), rates, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, Helpers.transl("Polus"), rates, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, Helpers.transl("Airship"), rates, dynamicMap, false);
            dynamicMapEnableFungle = CustomOption.Create(506, Types.General, Helpers.transl("Fungle"), rates, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, Helpers.transl("Submerged"), rates, dynamicMap, false);
			enableBetterPolus = CustomOption.Create(7878, Types.General, Helpers.transl("Enable Better Polus"), false, null, false);
            movePolusVents = CustomOption.Create(7879, Types.General, Helpers.transl("Adjust Vents"), false, enableBetterPolus, false);
            movePolusVitals = CustomOption.Create(7880, Types.General, Helpers.transl("Move Vitals to Labs"), false, enableBetterPolus, false);
			swapNavWifi = CustomOption.Create(7881, Types.General, Helpers.transl("Swap Reboot and Chart Course"), false, enableBetterPolus, false);
			moveColdTemp = CustomOption.Create(7882, Types.General, Helpers.transl("Move Cold temp to Death Vally"), false, enableBetterPolus, false);



			enableCamoComms = CustomOption.Create(1105, Types.General, Helpers.transl("Enable Camouflage Comms"), false,  null, false);
			disableMedbayWalk = CustomOption.Create(8847, Types.General, Helpers.transl("Disable Medbay Walk"), false, null, false);

            restrictDevices = CustomOption.Create(1101, Types.General, Helpers.transl("Restrict Map Information"), new string[] { Helpers.transl("Off"), Helpers.transl("Per Round"), Helpers.transl("Per Game") },  null, false);
            restrictAdmin = CustomOption.Create(1102, Types.General, Helpers.transl("Restrict Admin Table"), 30f, 0f, 600f, 5f, restrictDevices);
            restrictCameras = CustomOption.Create(1103, Types.General, Helpers.transl("Restrict Cameras"), 30f, 0f, 600f, 5f, restrictDevices);
            restrictVents = CustomOption.Create(1104, Types.General, Helpers.transl("Restrict Vitals"), 30f, 0f, 600f, 5f, restrictDevices);
			disableCamsRound1 = CustomOption.Create(8834, Types.General, Helpers.transl("Disable Cameras round 1"), false, null, false);

            showButtonTarget = CustomOption.Create(9994, Types.General, Helpers.transl("Show Button Target"), true);
            blockGameEnd = CustomOption.Create(9995, Types.General, Helpers.transl("Block Game End if Power Crew is Alive"), false);


            randomGameStartPosition = CustomOption.Create(9041, Types.General, Helpers.transl("Random Spawn Location"), false);
            allowModGuess = CustomOption.Create(9043, Types.General, Helpers.transl("Allow Guessing Some Modifiers"), false);
            resetRoundStartCooldown = CustomOption.Create(9042, Types.General, Helpers.transl("Reset Spawn Cooldown"), false);
            dynamicMapSeparateSettings = CustomOption.Create(509, Types.General, Helpers.transl("Use Random Map Setting Presets"), true, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});

			// Prosecutor
			blockedRolePairings.Add((byte)RoleId.Lawyer, new[] { (byte)RoleId.Prosecutor });
            blockedRolePairings.Add((byte)RoleId.Prosecutor, new[] { (byte)RoleId.Lawyer });            
        }
    }
}
