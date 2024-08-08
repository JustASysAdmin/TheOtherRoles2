using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static TranslationInfo[] rates = new[] { new TranslationInfo("0%"), new TranslationInfo("10%"), new TranslationInfo("20%"), new TranslationInfo("30%"), new TranslationInfo("40%"), new TranslationInfo("50%"), new TranslationInfo("60%"), new TranslationInfo("70%"), new TranslationInfo("80%"), new TranslationInfo("90%"), new TranslationInfo("100%") };
        public static TranslationInfo[] ratesModifier = new[] { new TranslationInfo("1"), new TranslationInfo("2"), new TranslationInfo("3") };
        public static TranslationInfo[] presets = new[] { new TranslationInfo("Opt-General", 45), new TranslationInfo("Opt-General", 46), new TranslationInfo("Opt-General", 47), new TranslationInfo("Opt-General", 48), new TranslationInfo("Opt-General", 45), new TranslationInfo("Opt-General", 49), new TranslationInfo("Opt-General", 50), new TranslationInfo("Opt-General", 51) };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption crewmateRolesFill;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption anyPlayerCanStopStart;
        public static CustomOption enableEventMode;
        public static CustomOption deadImpsBlockSabotage;

        public static CustomOption cultistSpawnRate;

        public static CustomOption swooperSpawnRate;
        public static CustomOption swooperCooldown;
        public static CustomOption swooperAsWell;
        public static CustomOption swooperDuration;
        public static CustomOption swooperHasImpVision;
        
        public static CustomOption minerSpawnRate;
		public static CustomOption minerCooldown;
        public static CustomOption minerUseNumber;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;
        
        public static CustomOption modifierParanoid;
		
        public static CustomOption bomber2SpawnRate;
        public static CustomOption bomber2BombCooldown;
        public static CustomOption bomber2Delay;
        public static CustomOption bomber2Timer;

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
        //public static CustomOption jackalCanSabotageLights;
        public static CustomOption jackalKillFakeImpostor;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanUseSabo;
        public static CustomOption jackalhasChat;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        //public static CustomOption sidekickCanSabotageLights;
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
        public static CustomOption mayorChooseSingleVote;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;
        public static CustomOption portalmakerCanPortalFromAnywhere;

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


        public static CustomOption veteranSpawnRate;
        public static CustomOption veteranCooldown;
        public static CustomOption veteranAlertDuration;

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
        public static CustomOption trackerTrackingCooldown;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;
        public static CustomOption trackerTrackingMethod;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchMode;
        public static CustomOption snitchTargets;

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
        public static CustomOption mediumChanceAdditionalInfo;

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
        public static CustomOption thiefCanStealWithGuess;

        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombDestructionTime;
        public static CustomOption bomberBombDestructionRange;
        public static CustomOption bomberBombHearRange;
        public static CustomOption bomberDefuseDuration;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberBombActiveAfter;

        public static CustomOption yoyoSpawnRate;
        public static CustomOption yoyoBlinkDuration;
        public static CustomOption yoyoMarkCooldown;
        public static CustomOption yoyoMarkStaysOverMeeting;
        public static CustomOption yoyoHasAdminTable;
        public static CustomOption yoyoAdminTableCooldown;
        public static CustomOption yoyoSilhouetteVisibility;

        public static CustomOption doomsayerSpawnRate;
        public static CustomOption doomsayerCooldown;
        public static CustomOption doomsayerHasMultipleShotsPerMeeting;
        public static CustomOption doomsayerCanGuessNeutral;
        public static CustomOption doomsayerCanGuessImpostor;
        public static CustomOption doomsayerOnlineTarger;
        public static CustomOption doomsayerGuesserCantGuessSnitch;
        public static CustomOption doomsayerObtainRoles;
        public static CustomOption doomsayerDormationNum;


        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierDisperser;
        public static CustomOption modifierDisperserCooldown;
        //public static CustomOption modifierDisperserNumberOfUses;

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
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption showButtonTarget;
        public static CustomOption blockGameEnd;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;
        public static CustomOption finishTasksBeforeHauntingOrZoomingOut;
        public static CustomOption camsNightVision;
        public static CustomOption camsNoNightVisionIfImpVision;

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
        public static CustomOption dynamicMapSeparateSettings;

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

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserForceThiefGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;
        public static CustomOption guesserGamemodeSidekickIsAlwaysGuesser;

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

        // Prop Hunt Settings
        public static CustomOption propHuntMap;
        public static CustomOption propHuntTimer;
        public static CustomOption propHuntNumberOfHunters;
        public static CustomOption hunterInitialBlackoutTime;
        public static CustomOption hunterMissCooldown;
        public static CustomOption hunterHitCooldown;
        public static CustomOption hunterMaxMissesBeforeDeath;
        public static CustomOption propBecomesHunterWhenFound;
        public static CustomOption propHunterVision;
        public static CustomOption propVision;
        public static CustomOption propHuntRevealCooldown;
        public static CustomOption propHuntRevealDuration;
        public static CustomOption propHuntRevealPunish;
        public static CustomOption propHuntUnstuckCooldown;
        public static CustomOption propHuntUnstuckDuration;
        public static CustomOption propHuntInvisCooldown;
        public static CustomOption propHuntInvisDuration;
        public static CustomOption propHuntSpeedboostCooldown;
        public static CustomOption propHuntSpeedboostDuration;
        public static CustomOption propHuntSpeedboostSpeed;
        public static CustomOption propHuntSpeedboostEnabled;
        public static CustomOption propHuntInvisEnabled;
        public static CustomOption propHuntAdminCooldown;
        public static CustomOption propHuntFindCooldown;
        public static CustomOption propHuntFindDuration;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }
        public static bool isMapSelectionOption(CustomOption option)
        {
            return option == CustomOptionHolder.propHuntMap && option == CustomOptionHolder.hideNSeekMap;
        }
        public static bool loading = false;
        public static void Load() {

            loading = true;

            CustomOption.vanillaSettings = TheOtherRolesPlugin.Instance.Config.Bind("Preset0", "VanillaOptions", "");

            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, new TranslationInfo("Opt-General", 11, new Color(204f / 255f, 204f / 255f, 0, 1f)), presets, null, true);

            if (Utilities.EventUtility.canBeEnabled) enableEventMode = CustomOption.Create(10423, Types.General, new TranslationInfo("Opt-General", 35, Color.green), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, new TranslationInfo("Opt-General", 36, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f, null, true, heading: new TranslationInfo("Opt-General", 33));
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, new TranslationInfo("Opt-General", 37, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, Types.General, new TranslationInfo("Opt-General", 39, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, new TranslationInfo("Opt-General", 40, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, new TranslationInfo("Opt-General", 41, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, new TranslationInfo("Opt-General", 42, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, new TranslationInfo("Opt-General", 43, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, new TranslationInfo("Opt-General", 44, new Color(204f / 255f, 204f / 255f, 0, 1f)), 15f, 0f, 15f, 1f);
            crewmateRolesFill = CustomOption.Create(308, Types.General, new TranslationInfo("Opt-General", 38, new Color(204f / 255f, 204f / 255f, 0, 1f)), false);

            mafiaSpawnRate = CustomOption.Create(10, Types.Impostor, new TranslationInfo(RoleId.Mafioso, Janitor.color), rates, null, true);
            janitorCooldown = CustomOption.Create(11, Types.Impostor, new TranslationInfo("Opt-Janitor", 1), 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, new TranslationInfo(RoleId.Morphling, Morphling.color), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, new TranslationInfo("Opt-Morphling", 1), 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, new TranslationInfo("Opt-Morphling", 2), 10f, 1f, 20f, 0.5f, morphlingSpawnRate);
        
            bomber2SpawnRate = CustomOption.Create(8840, Types.Impostor, new TranslationInfo(RoleId.Bomber2, Bomber2.color), rates, null, true);
            bomber2BombCooldown = CustomOption.Create(8841, Types.Impostor, new TranslationInfo("Opt-Bomber2", 1), 30f, 25f, 60f, 2.5f, bomber2SpawnRate);
            bomber2Delay = CustomOption.Create(8842, Types.Impostor, new TranslationInfo("Opt-Bomber2", 2), 10f, 1f, 20f, 0.5f, bomber2SpawnRate);
            bomber2Timer = CustomOption.Create(8843, Types.Impostor, new TranslationInfo("Opt-Bomber2", 3), 10f, 5f, 30f, 5f, bomber2SpawnRate);

            undertakerSpawnRate = CustomOption.Create(1201, Types.Impostor, new TranslationInfo(RoleId.Undertaker, Undertaker.color), rates, null, true);
            undertakerDragingDelaiAfterKill = CustomOption.Create(1202, Types.Impostor, new TranslationInfo("Opt-Undertaker", 1), 0f, 0f, 15, 1f, undertakerSpawnRate);                     
            undertakerCanDragAndVent = CustomOption.Create(1203, Types.Impostor, new TranslationInfo("Opt-Undertaker", 2), true, undertakerSpawnRate);


            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, new TranslationInfo(RoleId.Camouflager, Camouflager.color), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, new TranslationInfo("Opt-Camouflager", 1), 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, new TranslationInfo("Opt-Camouflager", 2), 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, new TranslationInfo(RoleId.Vampire, Vampire.color), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, new TranslationInfo("Opt-Vampire", 1), 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, new TranslationInfo("Opt-Vampire", 2), 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireGarlicButton = CustomOption.Create(43, Types.Impostor, new TranslationInfo("Opt-Vampire", 3), true, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(44, Types.Impostor, new TranslationInfo("Opt-Vampire", 4), true, vampireGarlicButton);

            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, new TranslationInfo(RoleId.Eraser, Eraser.color), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, new TranslationInfo("Opt-Eraser", 1), 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, new TranslationInfo("Opt-Eraser", 2), false, eraserSpawnRate);
			
			poucherSpawnRate = CustomOption.Create(8833, Types.Impostor, new TranslationInfo(RoleId.Poucher, Poucher.color), rates, null, true);

			mimicSpawnRate = CustomOption.Create(8835, Types.Impostor, new TranslationInfo(RoleId.Mimic, Mimic.color), rates, null, true);

            
            //cultistSpawnRate =  CustomOption.Create(3801, Types.Impostor, cs(Cultist.color, "Cultist"), rates, null, true);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, new TranslationInfo(RoleId.Trickster, Trickster.color), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, new TranslationInfo("Opt-Trickster", 1), 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, new TranslationInfo("Opt-Trickster", 2), 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, new TranslationInfo("Opt-Trickster", 3), 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, new TranslationInfo(RoleId.Cleaner, Cleaner.color), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, new TranslationInfo("Opt-Cleaner", 1), 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, new TranslationInfo(RoleId.Warlock, Warlock.color), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, new TranslationInfo("Opt-Warlock", 1), 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, new TranslationInfo("Opt-Warlock", 2), 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, new TranslationInfo(RoleId.BountyHunter, BountyHunter.color), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, new TranslationInfo("Opt-BountyHunter", 1),  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, new TranslationInfo("Opt-BountyHunter", 2), 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, new TranslationInfo("Opt-BountyHunter", 3), 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, new TranslationInfo("Opt-BountyHunter", 4), true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, new TranslationInfo("Opt-BountyHunter", 5), 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, new TranslationInfo(RoleId.Witch, Witch.color), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, new TranslationInfo("Opt-Witch", 1), 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, new TranslationInfo("Opt-Witch", 2), 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, new TranslationInfo("Opt-Witch", 3), false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, new TranslationInfo("Opt-Witch", 4), 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, new TranslationInfo("Opt-Witch", 5), true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, new TranslationInfo("Opt-Witch", 6), true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, new TranslationInfo(RoleId.Ninja, Ninja.color), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, new TranslationInfo("Opt-Ninja", 1), 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, new TranslationInfo("Opt-Ninja", 2), true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, new TranslationInfo("Opt-Ninja", 3), 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, new TranslationInfo("Opt-Ninja", 4), 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, new TranslationInfo("Opt-Ninja", 5), 3f, 0f, 20f, 1f, ninjaSpawnRate);

            bomberSpawnRate = CustomOption.Create(460, Types.Impostor, new TranslationInfo(RoleId.Bomber, Bomber.color), rates, null, true);
            bomberBombDestructionTime = CustomOption.Create(461, Types.Impostor, new TranslationInfo("Opt-Bomber", 1), 20f, 2.5f, 120f, 2.5f, bomberSpawnRate);
            bomberBombDestructionRange = CustomOption.Create(462, Types.Impostor, new TranslationInfo("Opt-Bomber", 2), 50f, 5f, 150f, 5f, bomberSpawnRate);
            bomberBombHearRange = CustomOption.Create(463, Types.Impostor, new TranslationInfo("Opt-Bomber", 3), 60f, 5f, 150f, 5f, bomberSpawnRate);
            bomberDefuseDuration = CustomOption.Create(464, Types.Impostor, new TranslationInfo("Opt-Bomber", 4), 3f, 0.5f, 30f, 0.5f, bomberSpawnRate);
            bomberBombCooldown = CustomOption.Create(465, Types.Impostor, new TranslationInfo("Opt-Bomber", 5), 15f, 2.5f, 30f, 2.5f, bomberSpawnRate);
            bomberBombActiveAfter = CustomOption.Create(466, Types.Impostor, new TranslationInfo("Opt-Bomber", 6), 3f, 0.5f, 15f, 0.5f, bomberSpawnRate);

            yoyoSpawnRate = CustomOption.Create(470, Types.Impostor, new TranslationInfo(RoleId.Yoyo, Yoyo.color), rates, null, true);
            yoyoBlinkDuration = CustomOption.Create(471, Types.Impostor, new TranslationInfo("Opt-Yoyo", 1), 20f, 2.5f, 120f, 2.5f, yoyoSpawnRate);
            yoyoMarkCooldown = CustomOption.Create(472, Types.Impostor, new TranslationInfo("Opt-Yoyo", 2), 20f, 2.5f, 120f, 2.5f, yoyoSpawnRate);
            yoyoMarkStaysOverMeeting = CustomOption.Create(473, Types.Impostor, new TranslationInfo("Opt-Yoyo", 3), true, yoyoSpawnRate);
            yoyoHasAdminTable = CustomOption.Create(474, Types.Impostor, new TranslationInfo("Opt-Yoyo", 4), true, yoyoSpawnRate);
            yoyoAdminTableCooldown = CustomOption.Create(475, Types.Impostor, new TranslationInfo("Opt-Yoyo", 5), 20f, 2.5f, 120f, 2.5f, yoyoHasAdminTable);
            yoyoSilhouetteVisibility = CustomOption.Create(476, Types.Impostor, new TranslationInfo("Opt-Yoyo", 6), new[] { new TranslationInfo("0%"), new TranslationInfo("10%"), new TranslationInfo("20%"), new TranslationInfo("30%"), new TranslationInfo("40%"), new TranslationInfo("50%") }, yoyoSpawnRate);

            minerSpawnRate = CustomOption.Create(1120, Types.Impostor, new TranslationInfo(RoleId.Miner, Miner.color), rates, null, true); //jackalSpawnRate);
            minerCooldown = CustomOption.Create(1121, Types.Impostor, new TranslationInfo("Opt-Miner", 1), 25f, 10f, 60f, 2.5f, minerSpawnRate);
            minerUseNumber = CustomOption.Create(1122, Types.Impostor, new TranslationInfo("Opt-Miner", 2), 1, 1, 20, 1, minerSpawnRate);

            blackmailerSpawnRate = CustomOption.Create(710, Types.Impostor, new TranslationInfo(RoleId.Blackmailer, Blackmailer.color), rates, null, true);
            blackmailerCooldown = CustomOption.Create(711, Types.Impostor, new TranslationInfo("Opt-Blackmailer", 1), 30f, 5f, 120f, 5f, blackmailerSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, new TranslationInfo(RoleId.Jester, Jester.color), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, new TranslationInfo("Opt-Jester", 1), true, jesterSpawnRate);
            jesterCanVent = CustomOption.Create(1901, Types.Neutral, new TranslationInfo("Opt-Jester", 2), true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, new TranslationInfo("Opt-Jester", 3), false, jesterSpawnRate);
			
            amnisiacSpawnRate = CustomOption.Create(616, Types.Neutral, new TranslationInfo(RoleId.Amnisiac, Amnisiac.color), rates, null, true);
            amnisiacShowArrows = CustomOption.Create(617, Types.Neutral, new TranslationInfo("Opt-Amnesiac", 1), true, amnisiacSpawnRate);
            amnisiacResetRole = CustomOption.Create(618, Types.Neutral, new TranslationInfo("Opt-Amnesiac", 2), true, amnisiacSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, new TranslationInfo(RoleId.Arsonist, Arsonist.color), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, new TranslationInfo("Opt-Arsonist", 1), 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, new TranslationInfo("Opt-Arsonist", 2), 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, new TranslationInfo(RoleId.Jackal, Jackal.color), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, new TranslationInfo("Opt-Jackal", 1), 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            //jackalhasChat = CustomOption.Create(1197, Types.Neutral, "Jackal team has Chat", false, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, new TranslationInfo("Opt-Jackal", 2), true, jackalSpawnRate);
            jackalCanUseSabo = CustomOption.Create(8876, Types.Neutral, new TranslationInfo("Opt-Jackal", 3), false, jackalSpawnRate);
            //jackalCanSabotageLights = CustomOption.Create(431, Types.Neutral, "Jackal Can Sabotage Lights(Except Fungle)", true, jackalSpawnRate);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, new TranslationInfo("Opt-Jackal", 4), false, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, new TranslationInfo("Opt-Jackal", 5), false, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, new TranslationInfo("Opt-Jackal", 6), 30f, 10f, 60f, 2.5f, jackalCanCreateSidekick);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, new TranslationInfo("Opt-Jackal", 7), false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, new TranslationInfo("Opt-Jackal", 8), false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, new TranslationInfo("Opt-Jackal", 9), true, jackalCanCreateSidekick);
            //sidekickCanSabotageLights = CustomOption.Create(432, Types.Neutral, "Sidekick Can Sabotage Lights(Except Fungle)", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, new TranslationInfo("Opt-Jackal", 10), true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, new TranslationInfo("Opt-Jackal", 11), true, jackalCanCreateSidekick);
			jackalKillFakeImpostor = CustomOption.Create(7885, Types.Neutral, new TranslationInfo("Opt-Jackal", 12), true, jackalCanCreateSidekick);

            swooperSpawnRate = CustomOption.Create(1110, Types.Neutral, new TranslationInfo(RoleId.Swooper, Swooper.color), rates, null, true); //jackalSpawnRate);
            swooperAsWell = CustomOption.Create(1113, Types.Neutral, new TranslationInfo("Opt-Swooper", 1), false, swooperSpawnRate);
            swooperCooldown = CustomOption.Create(1111, Types.Neutral, new TranslationInfo("Opt-Swooper", 2), 30f, 10f, 60f, 2.5f, swooperSpawnRate);
            swooperDuration = CustomOption.Create(1112, Types.Neutral, new TranslationInfo("Opt-Swooper", 3), 10f, 2.5f, 20f, 0.5f, swooperSpawnRate);
            swooperHasImpVision = CustomOption.Create(1114, Types.Neutral, new TranslationInfo("Opt-Swooper", 4), true, swooperSpawnRate);
			
            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, new TranslationInfo(RoleId.Vulture, Vulture.color), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, new TranslationInfo("Opt-Vulture", 1), 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, new TranslationInfo("Opt-Vulture", 2), 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, new TranslationInfo("Opt-Vulture", 3), true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, new TranslationInfo("Opt-Vulture", 4), true, vultureSpawnRate);

            doomsayerSpawnRate = CustomOption.Create(490, Types.Neutral, new TranslationInfo(RoleId.Doomsayer, Doomsayer.color), rates, null, true);
            doomsayerCooldown = CustomOption.Create(491, Types.Neutral, new TranslationInfo("Opt-Doomsayer", 1), 20f, 2.5f, 60f, 2.5f, doomsayerSpawnRate);
            doomsayerHasMultipleShotsPerMeeting = CustomOption.Create(492, Types.Neutral, new TranslationInfo("Opt-Doomsayer", 2), true, doomsayerSpawnRate);
            doomsayerCanGuessImpostor = CustomOption.Create(493, Types.Neutral, new TranslationInfo($"{new TranslationInfo("Opt-Doomsayer", 3)}{cs(Palette.ImpostorRed, ModTranslation.GetString("Opt-Doomsayer", 4))}"), true, doomsayerSpawnRate);
            doomsayerCanGuessNeutral = CustomOption.Create(494, Types.Neutral, new TranslationInfo($"{new TranslationInfo("Opt-Doomsayer", 3)}{cs(Color.grey, ModTranslation.GetString("Opt-Doomsayer", 5))}"), true, doomsayerSpawnRate);
            doomsayerOnlineTarger = CustomOption.Create(495, Types.Neutral, new TranslationInfo("Opt-Doomsayer", 6), false, doomsayerSpawnRate);
            doomsayerObtainRoles = CustomOption.Create(496, Types.Neutral, new TranslationInfo("Opt-Doomsayer", 7), 3f, 1f, 10f, 1f, doomsayerSpawnRate);
            doomsayerDormationNum = CustomOption.Create(497, Types.Neutral, new TranslationInfo("Opt-Doomsayer", 8), 5f, 1f, 10f, 1f, doomsayerSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, new TranslationInfo(RoleId.Lawyer, Lawyer.color), rates, null, true);
            prosecutorSpawnRate = CustomOption.Create(615, Types.Neutral, new TranslationInfo("Opt-Lawyer", 7, Prosecutor.color), rates, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, Types.Neutral, new TranslationInfo("Opt-Lawyer", 1), 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, new TranslationInfo("Opt-Lawyer", 2), false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, Types.Neutral, new TranslationInfo("Opt-Lawyer", 3), true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, new TranslationInfo("Opt-Lawyer", 4), false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, new TranslationInfo("Opt-Lawyer", 5), 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, new TranslationInfo("Opt-Lawyer", 6), 5f, 1f, 20f, 1f, lawyerSpawnRate);

            thiefSpawnRate = CustomOption.Create(400, Types.Neutral, new TranslationInfo(RoleId.Thief, Thief.color), rates, null, true);
            thiefCooldown = CustomOption.Create(401, Types.Neutral, new TranslationInfo("Opt-Thief", 1), 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, Types.Neutral, new TranslationInfo("Opt-Thief", 2), true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, Types.Neutral, new TranslationInfo("Opt-Thief", 3), true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, Types.Neutral, new TranslationInfo("Opt-Thief", 4), true, thiefSpawnRate);
            thiefCanStealWithGuess = CustomOption.Create(405, Types.Neutral, new TranslationInfo("Opt-Thief", 5), false, thiefSpawnRate);

            werewolfSpawnRate = CustomOption.Create(1501, Types.Neutral, new TranslationInfo(RoleId.Werewolf, Werewolf.color), rates, null, true);
            werewolfRampageCooldown  = CustomOption.Create(1502, Types.Neutral, new TranslationInfo("Opt-Werewolf", 1), 30f, 10f, 60f, 2.5f, werewolfSpawnRate);
            werewolfRampageDuration = CustomOption.Create(1503, Types.Neutral, new TranslationInfo("Opt-Werewolf", 2), 15f, 1f, 20f, 0.5f, werewolfSpawnRate);
            werewolfKillCooldown = CustomOption.Create(1504, Types.Neutral, new TranslationInfo("Opt-Werewolf", 3), 3f, 1f, 60f, 1f, werewolfSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, new TranslationInfo(RoleId.Mayor, Mayor.color), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, new TranslationInfo("Opt-Mayor", 1), false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, new TranslationInfo("Opt-Mayor", 2), 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, new TranslationInfo("Opt-Mayor", 3), true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, new TranslationInfo("Opt-Mayor", 4), 1f, 1f, 5f, 1f, mayorMeetingButton);
            mayorChooseSingleVote = CustomOption.Create(85, Types.Crewmate, new TranslationInfo("Opt-Mayor", 5), new[] { new TranslationInfo("Opt-General", 9), new TranslationInfo("Opt-Mayor", 6), new TranslationInfo("Opt-Mayor", 7) }, mayorSpawnRate);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, new TranslationInfo(RoleId.Engineer, Engineer.color), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, new TranslationInfo("Opt-Engineer", 1), 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, new TranslationInfo("Opt-Engineer", 2), true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, new TranslationInfo("Opt-Engineer", 3), true, engineerSpawnRate);

            privateInvestigatorSpawnRate = CustomOption.Create(8839, Types.Crewmate, new TranslationInfo(RoleId.PrivateInvestigator, PrivateInvestigator.color), rates, null, true);
			privateInvestigatorSeeColor = CustomOption.Create(8844, Types.Crewmate, new TranslationInfo("Opt-PrivateInvestigator", 1), true, privateInvestigatorSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, new TranslationInfo(RoleId.Sheriff, Sheriff.color), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 1), 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 2), false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 3), rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 4), 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 5), 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 6), 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 7), true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 8), new[] { new TranslationInfo("Opt-General", 9), new TranslationInfo("Opt-Sheriff", 9), new TranslationInfo("Opt-Sheriff", 10) }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, new TranslationInfo("Opt-Sheriff", 11), true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, new TranslationInfo(RoleId.Lighter, Lighter.color), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, new TranslationInfo("Opt-Lighter", 1), 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, new TranslationInfo("Opt-Lighter", 2), 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113, Types.Crewmate, new TranslationInfo("Opt-Lighter", 3), 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114, Types.Crewmate, new TranslationInfo("Opt-Lighter", 4), 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, new TranslationInfo(RoleId.Detective, Detective.color), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, new TranslationInfo("Opt-Detective", 1), false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, new TranslationInfo("Opt-Detective", 2), 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, new TranslationInfo("Opt-Detective", 3), 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, new TranslationInfo("Opt-Detective", 4), 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, new TranslationInfo("Opt-Detective", 5), 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, new TranslationInfo(RoleId.TimeMaster, TimeMaster.color), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, new TranslationInfo("Opt-TimeMaster", 1), 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, new TranslationInfo("Opt-TimeMaster", 2), 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, new TranslationInfo("Opt-TimeMaster", 3), 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            veteranSpawnRate = CustomOption.Create(4450, Types.Crewmate, new TranslationInfo(RoleId.Veteran, Veteran.color), rates, null, true);
            veteranCooldown = CustomOption.Create(4451, Types.Crewmate, new TranslationInfo("Opt-Veteran", 1), 30f, 10f, 120f, 2.5f, veteranSpawnRate);
	        veteranAlertDuration = CustomOption.Create(4452, Types.Crewmate, new TranslationInfo("Opt-Veteran", 2), 3f, 1f, 20f, 1f, veteranSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, new TranslationInfo(RoleId.Medic, Medic.color), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, new TranslationInfo("Opt-Medic", 1), new TranslationInfo[] { new TranslationInfo("Opt-Medic", 2), new TranslationInfo("Opt-Medic", 3), new TranslationInfo("Opt-Medic", 4) }, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, new TranslationInfo("Opt-Medic", 5), false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, new TranslationInfo("Opt-Medic", 6), new TranslationInfo[] { new TranslationInfo("Opt-Medic", 7), new TranslationInfo("Opt-Medic", 8), new TranslationInfo("Opt-Medic", 9) }, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, new TranslationInfo("Opt-Medic", 10), false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, new TranslationInfo(RoleId.Swapper, Swapper.color), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, new TranslationInfo("Opt-Swapper", 1), false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, new TranslationInfo("Opt-Swapper", 2), false, swapperSpawnRate);
            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, new TranslationInfo("Opt-Swapper", 3), 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, new TranslationInfo("Opt-Swapper", 4), 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, new TranslationInfo(RoleId.Seer, Seer.color), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, new TranslationInfo("Opt-Seer", 1), new TranslationInfo[]{ new TranslationInfo("Opt-Seer", 2), new TranslationInfo("Opt-Seer", 3), new TranslationInfo("Opt-Seer", 4) }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, new TranslationInfo("Opt-Seer", 5), false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, new TranslationInfo("Opt-Seer", 6), 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, new TranslationInfo(RoleId.Hacker, Hacker.color), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, new TranslationInfo("Opt-Hacker", 1), 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, new TranslationInfo("Opt-Hacker", 2), 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, new TranslationInfo("Opt-Hacker", 3), false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, new TranslationInfo("Opt-Hacker", 4), 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, new TranslationInfo("Opt-Hacker", 5), 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, new TranslationInfo("Opt-Hacker", 6), true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, new TranslationInfo(RoleId.Tracker, Tracker.color), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, new TranslationInfo("Opt-Tracker", 1), 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, new TranslationInfo("Opt-Tracker", 2), false, trackerSpawnRate);
            trackerTrackingCooldown = CustomOption.Create(203, Types.Crewmate, new TranslationInfo("Opt-Tracker", 3), 30f, 5f, 60f, 5f, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, new TranslationInfo("Opt-Tracker", 4), true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, new TranslationInfo("Opt-Tracker", 5), 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, new TranslationInfo("Opt-Tracker", 6), 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
            trackerTrackingMethod = CustomOption.Create(206, Types.Crewmate, new TranslationInfo("Opt-Tracker", 7), new TranslationInfo[] { new TranslationInfo("Opt-Tracker", 8), new TranslationInfo("Opt-Tracker", 9), new TranslationInfo("Opt-Tracker", 10) }, trackerSpawnRate);

            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, new TranslationInfo(RoleId.Snitch, Snitch.color), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(219, Types.Crewmate, new TranslationInfo("Opt-Snitch", 1), 5f, 0f, 25f, 1f, snitchSpawnRate);
            snitchMode = CustomOption.Create(211, Types.Crewmate, new TranslationInfo("Opt-Snitch", 2), new TranslationInfo[] { new TranslationInfo("Opt-Snitch", 3), new TranslationInfo("Opt-Snitch", 4), new TranslationInfo("Opt-Snitch", 5) }, snitchSpawnRate);
            snitchTargets = CustomOption.Create(212, Types.Crewmate, new TranslationInfo("Opt-Snitch", 6), new TranslationInfo[] { new TranslationInfo("Opt-Snitch", 7), new TranslationInfo("Opt-Snitch", 8) }, snitchSpawnRate);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, new TranslationInfo(RoleId.Spy, Spy.color), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, new TranslationInfo("Opt-Spy", 1), false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, new TranslationInfo("Opt-Spy", 2), true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, new TranslationInfo("Opt-Spy", 3), false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, new TranslationInfo("Opt-Spy", 4), false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, new TranslationInfo(RoleId.Portalmaker, Portalmaker.color), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, new TranslationInfo("Opt-Portalmaker",1), 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, new TranslationInfo("Opt-Portalmaker", 2), 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, new TranslationInfo("Opt-Portalmaker", 3), true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, new TranslationInfo("Opt-Portalmaker", 4), true, portalmakerSpawnRate);
            portalmakerCanPortalFromAnywhere = CustomOption.Create(395, Types.Crewmate, new TranslationInfo("Opt-Portalmaker", 5), true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, new TranslationInfo(RoleId.SecurityGuard, SecurityGuard.color), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 1), 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 2), 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 3), 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 4), 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 5), 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 6), 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 7), 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, new TranslationInfo("Opt-SecurityGuard", 8), true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, new TranslationInfo(RoleId.Medium, Medium.color), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, new TranslationInfo("Opt-Medium", 1), 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, new TranslationInfo("Opt-Medium", 2), 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, new TranslationInfo("Opt-Medium", 3), false, mediumSpawnRate);
            mediumChanceAdditionalInfo = CustomOption.Create(364, Types.Crewmate, new TranslationInfo("Opt-Medium", 4), rates, mediumSpawnRate);

            bodyGuardSpawnRate = CustomOption.Create(8820, Types.Crewmate, new TranslationInfo(RoleId.BodyGuard, BodyGuard.color), rates, null, true);
            bodyGuardResetTargetAfterMeeting = CustomOption.Create(8821, Types.Crewmate, new TranslationInfo("Opt-Bodyguard", 1), true, bodyGuardSpawnRate);

            trapperSpawnRate = CustomOption.Create(410, Types.Crewmate, new TranslationInfo(RoleId.Trapper, Trapper.color), rates, null, true);
            trapperCooldown = CustomOption.Create(420, Types.Crewmate, new TranslationInfo("Opt-Trapper", 1), 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, Types.Crewmate, new TranslationInfo("Opt-Trapper", 2), 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, Types.Crewmate, new TranslationInfo("Opt-Trapper", 3), 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, Types.Crewmate, new TranslationInfo("Opt-Trapper", 4), 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, Types.Crewmate, new TranslationInfo("Opt-Trapper", 5), false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, Types.Crewmate, new TranslationInfo("Opt-Trapper", 6), new TranslationInfo[] { new TranslationInfo("Opt-Trapper", 7), new TranslationInfo("Opt-Trapper", 8), new TranslationInfo("Opt-Trapper", 9) }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, Types.Crewmate, new TranslationInfo("Opt-Trapper", 10), 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1009, Types.Modifier, new TranslationInfo("Opt-General", 34, Color.yellow), true, null, true, heading: new TranslationInfo("Opt-General", 53, Color.yellow));

            modifierDisperser = CustomOption.Create(2200, Types.Modifier, new TranslationInfo(RoleId.Disperser, Color.red), rates, null, true);
            modifierDisperserCooldown = CustomOption.Create(2201, Types.Modifier, new TranslationInfo("Opt-Disperser", 1), 30f, 10f, 60f, 2.5f, modifierDisperser);
            //modifierDisperserNumberOfUses = CustomOption.Create(2202, Types.Modifier, "Number Of Uses", 1, 1, 20, 1, modifierDisperser);

            modifierParanoid = CustomOption.Create(8831, Types.Modifier, new TranslationInfo(RoleId.Paranoid, Color.yellow), rates, null, true);

            guesserSpawnRate = CustomOption.Create(310, Types.Modifier, new TranslationInfo("Opt-Guesser", 9, Guesser.color), false, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, Types.Modifier, new TranslationInfo("Opt-Guesser", 1), rates, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, Types.Modifier, new TranslationInfo("Opt-Guesser", 2), rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, Types.Modifier, new TranslationInfo("Opt-Guesser", 3), 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Modifier, new TranslationInfo("Opt-Guesser", 4), false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(314, Types.Modifier, new TranslationInfo("Opt-Guesser", 5), true, guesserSpawnRate);
            guesserKillsThroughShield = CustomOption.Create(315, Types.Modifier, new TranslationInfo("Opt-Guesser", 6), true, guesserSpawnRate);
            guesserEvilCanKillSpy = CustomOption.Create(316, Types.Modifier, new TranslationInfo("Opt-Guesser", 7), true, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Modifier, new TranslationInfo("Opt-Guesser", 8), true, guesserSpawnRate);

            modifierBloody = CustomOption.Create(1000, Types.Modifier, new TranslationInfo(RoleId.Bloody, Color.yellow), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, new TranslationInfo("Opt-Bloody", 1, Color.yellow), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, new TranslationInfo("Opt-Bloody", 2), 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, new TranslationInfo(RoleId.AntiTeleport, Color.yellow), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, new TranslationInfo("Opt-AntiTeleport", 1, Color.yellow), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, new TranslationInfo(RoleId.Tiebreaker, Color.yellow), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, new TranslationInfo(RoleId.Bait, Color.yellow), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, new TranslationInfo("Opt-Bait", 1, Color.yellow), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, new TranslationInfo("Opt-Bait", 2), 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, new TranslationInfo("Opt-Bait", 3), 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, new TranslationInfo("Opt-Bait", 4), true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, new TranslationInfo(RoleId.Lover, Lovers.color), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, new TranslationInfo("Opt-Lovers", 1), rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, new TranslationInfo("Opt-Lovers", 2), true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, new TranslationInfo("Opt-Lovers", 4), true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, new TranslationInfo(RoleId.Sunglasses, Color.yellow), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, new TranslationInfo("Opt-Sunglasses", 1, Color.yellow), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, new TranslationInfo("Opt-Sunglasses", 2), new TranslationInfo[] { new TranslationInfo("-10%"), new TranslationInfo("-20%"), new TranslationInfo("-30%"), new TranslationInfo("-40%"), new TranslationInfo("-50%") }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, new TranslationInfo(RoleId.Mini, Color.yellow), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, new TranslationInfo("Opt-Mini", 1), 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, Types.Modifier, new TranslationInfo("Opt-Mini", 2), true, modifierMini);

            modifierIndomitable = CustomOption.Create(1276, Types.Modifier, new TranslationInfo(RoleId.Indomitable, Color.yellow), rates, null, true);

            modifierBlind = CustomOption.Create(8810, Types.Modifier, new TranslationInfo(RoleId.Blind, Color.yellow), rates, null, true);

            modifierTunneler = CustomOption.Create(8819, Types.Modifier, new TranslationInfo(RoleId.Tunneler, Color.yellow), rates, null, true);

            modifierSlueth = CustomOption.Create(8830, Types.Modifier, new TranslationInfo(RoleId.Slueth, Color.yellow), rates, null, true);

            modifierCursed = CustomOption.Create(1277, Types.Modifier, new TranslationInfo(RoleId.Cursed, Color.yellow), rates, null, true);

            modifierVip = CustomOption.Create(1070, Types.Modifier, new TranslationInfo(RoleId.Vip, Color.yellow), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, new TranslationInfo("Opt-Vip", 1, Color.yellow), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, new TranslationInfo("Opt-Vip", 2), true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, new TranslationInfo(RoleId.Invert, Color.yellow), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, new TranslationInfo("Opt-Invert", 1, Color.yellow), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, new TranslationInfo("Opt-Invert"), 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, Types.Modifier, new TranslationInfo(RoleId.Chameleon, Color.yellow), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, Types.Modifier, new TranslationInfo("Opt-Chameleon", 1, Color.yellow), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, Types.Modifier, new TranslationInfo("Opt-Chameleon", 2), 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, Types.Modifier, new TranslationInfo("Opt-Chameleon", 3), 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, Types.Modifier, new TranslationInfo("Opt-Chameleon", 4), new TranslationInfo[] { new TranslationInfo("0%"), new TranslationInfo("10%"), new TranslationInfo("20%"), new TranslationInfo("30%"), new TranslationInfo("40%"), new TranslationInfo("50%") }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, Types.Modifier, new TranslationInfo(RoleId.Shifter, Color.yellow), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 1, Guesser.color), 15f, 1f, 15f, 1f, null, true, heading: new TranslationInfo("Opt-General", 18));
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 2, Guesser.color), 15f, 1f, 15f, 1f, null);
            guesserGamemodeImpNumber = CustomOption.Create(2003, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 3, Guesser.color), 15f, 1f, 15f, 1f, null);
            guesserForceJackalGuesser = CustomOption.Create(2007, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 4), false, null, true, heading: new TranslationInfo("Opt-General", 19));
            guesserGamemodeSidekickIsAlwaysGuesser = CustomOption.Create(2012, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 5), false, null);
            guesserForceThiefGuesser = CustomOption.Create(2011, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 6), false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 7), true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 8), 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 9), false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 10), true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 11), true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, Types.Guesser, new TranslationInfo("Opt-Guessers-General", 12), true, null);

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 1, Color.yellow), new TranslationInfo[] { new TranslationInfo("The Skeld"), new TranslationInfo("Mira"), new TranslationInfo("Polus"), new TranslationInfo("Airship"), new TranslationInfo("Fungle"), new TranslationInfo("Submerged"), new TranslationInfo("LI Map") }, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            hideNSeekHunterCount = CustomOption.Create(3000, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 2, Color.yellow), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 3, Color.yellow), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 4, Color.yellow), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 5, Color.yellow), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 6, Color.yellow), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 7, Color.yellow), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 8, Color.yellow), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 9, Color.yellow), 5f, 1f, 30f, 0.5f);
            hideNSeekTaskWin = CustomOption.Create(3004, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 10, Color.yellow), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 11, Color.yellow), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 12, Color.yellow), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 13, Color.yellow), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 1, Color.red), 30f, 5f, 60f, 1f, null, true, heading: new TranslationInfo("Opt-General", 20));
            hunterLightDuration = CustomOption.Create(3006, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 2, Color.red), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 3, Color.red), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 4, Color.red), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 5, Color.red), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 6, Color.red), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 7, Color.red), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 8, Color.red), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 9, Color.red), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 10, Color.red), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 11, Color.gray), 30f, 5f, 60f, 1f, null, true, heading: new TranslationInfo("Opt-General", 21));
            huntedShieldDuration = CustomOption.Create(3016, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 12, Color.gray), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 13, Color.gray), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, Types.HideNSeekRoles, new TranslationInfo("Opt-HideNSeek-Roles", 14, Color.gray), 3f, 1f, 15f, 1f);

            // Prop Hunt General Options
            propHuntMap = CustomOption.Create(3020, Types.HideNSeekMain, new TranslationInfo("Opt-HideNSeek-Main", 1, Color.yellow), new TranslationInfo[] { new TranslationInfo("The Skeld"), new TranslationInfo("Mira"), new TranslationInfo("Polus"), new TranslationInfo("Airship"), new TranslationInfo("Fungle"), new TranslationInfo("Submerged"), new TranslationInfo("LI Map") }, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            propHuntTimer = CustomOption.Create(4021, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Main" ,1, Color.yellow), 5f, 1f, 30f, 0.5f, null, true, heading: new TranslationInfo("Opt-General", 22));
            propHuntUnstuckCooldown = CustomOption.Create(4011, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Main", 2, Color.yellow), 30f, 2.5f, 60f, 2.5f);
            propHuntUnstuckDuration = CustomOption.Create(4012, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Main", 3, Color.yellow), 2f, 1f, 60f, 1f);
            propHunterVision = CustomOption.Create(4006, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Main", 4, Color.yellow), 0.5f, 0.25f, 2f, 0.25f);
            propVision = CustomOption.Create(4007, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Main", 5, Color.yellow), 2f, 0.25f, 5f, 0.25f);
            // Hunter Options
            propHuntNumberOfHunters = CustomOption.Create(4000, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 1, Color.red), 1f, 1f, 5f, 1f, null, true, heading: new TranslationInfo("Opt-General", 23));
            hunterInitialBlackoutTime = CustomOption.Create(4001, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 2, Color.red), 10f, 5f, 20f, 1f);
            hunterMissCooldown = CustomOption.Create(4004, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 3, Color.red), 10f, 2.5f, 60f, 2.5f);
            hunterHitCooldown = CustomOption.Create(4005, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 4, Color.red), 10f, 2.5f, 60f, 2.5f);
            propHuntRevealCooldown = CustomOption.Create(4008, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 5, Color.red), 30f, 10f, 90f, 2.5f);
            propHuntRevealDuration = CustomOption.Create(4009, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 6, Color.red), 5f, 1f, 60f, 1f);
            propHuntRevealPunish = CustomOption.Create(4010, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 7, Color.red), 10f, 0f, 1800f, 5f);
            propHuntAdminCooldown = CustomOption.Create(4022, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 8, Color.red), 30f, 2.5f, 1800f, 2.5f);
            propHuntFindCooldown = CustomOption.Create(4023, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 9, Color.red), 60f, 2.5f, 1800f, 2.5f);
            propHuntFindDuration = CustomOption.Create(4024, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 10, Color.red), 5f, 1f, 15f, 1f);
            // Prop Options
            propBecomesHunterWhenFound = CustomOption.Create(4003, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 11, Palette.CrewmateBlue), false, null, true, heading: new TranslationInfo("Opt-General", 24));
            propHuntInvisEnabled = CustomOption.Create(4013, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 12, Palette.CrewmateBlue), true, null, true);
            propHuntInvisCooldown = CustomOption.Create(4014, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 13, Palette.CrewmateBlue), 120f, 10f, 1800f, 2.5f, propHuntInvisEnabled);
            propHuntInvisDuration = CustomOption.Create(4015, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 14, Palette.CrewmateBlue), 5f, 1f, 30f, 1f, propHuntInvisEnabled);
            propHuntSpeedboostEnabled = CustomOption.Create(4016, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 15, Palette.CrewmateBlue), true, null, true);
            propHuntSpeedboostCooldown = CustomOption.Create(4017, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 16, Palette.CrewmateBlue), 60f, 2.5f, 1800f, 2.5f, propHuntSpeedboostEnabled);
            propHuntSpeedboostDuration = CustomOption.Create(4018, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 17, Palette.CrewmateBlue), 5f, 1f, 15f, 1f, propHuntSpeedboostEnabled);
            propHuntSpeedboostSpeed = CustomOption.Create(4019, Types.PropHunt, new TranslationInfo("Opt-PropHunt-Roles", 18, Palette.CrewmateBlue), 2f, 1.25f, 5f, 0.25f, propHuntSpeedboostEnabled);

            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, new TranslationInfo("Opt-General", 54), 10, 0, 15, 1, null, true, heading: new TranslationInfo("Opt-General", 25));
            anyPlayerCanStopStart = CustomOption.Create(2, Types.General, new TranslationInfo("Opt-General", 26, new Color(204f / 255f, 204f / 255f, 0, 1f)), false, null, false);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, new TranslationInfo("Opt-General", 55), false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, new TranslationInfo("Opt-General", 56), false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, new TranslationInfo("Opt-General", 57), false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, new TranslationInfo("Opt-General", 58), false);
            shieldFirstKill = CustomOption.Create(8, Types.General, new TranslationInfo("Opt-General", 59), false);
            finishTasksBeforeHauntingOrZoomingOut = CustomOption.Create(9, Types.General, new TranslationInfo("Opt-General", 60), true);
            deadImpsBlockSabotage = CustomOption.Create(13, Types.General, new TranslationInfo("Opt-General", 63), false, null, false);
            camsNightVision = CustomOption.Create(14, Types.General, new TranslationInfo("Opt-General", 61), false, null, true, heading: new TranslationInfo("Opt-General", 27));
            camsNoNightVisionIfImpVision = CustomOption.Create(12, Types.General, new TranslationInfo("Opt-General", 62), false, camsNightVision, false);

            dynamicMap = CustomOption.Create(500, Types.General, new TranslationInfo("Opt-General", 64), false, null, true, heading: new TranslationInfo("Opt-General", 85));
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, new TranslationInfo("Skeld"), rates, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, new TranslationInfo("Mira"), rates, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, new TranslationInfo("Polus"), rates, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, new TranslationInfo("Airship"), rates, dynamicMap, false);
            dynamicMapEnableFungle = CustomOption.Create(506, Types.General, new TranslationInfo("Fungle"), rates, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, new TranslationInfo("Submerged"), rates, dynamicMap, false);
			enableBetterPolus = CustomOption.Create(7878, Types.General, new TranslationInfo("Opt-General", 65), false, null, false);
            movePolusVents = CustomOption.Create(7879, Types.General, new TranslationInfo("Opt-General", 66), false, enableBetterPolus, false);
            movePolusVitals = CustomOption.Create(7880, Types.General, new TranslationInfo("Opt-General", 67), false, enableBetterPolus, false);
			swapNavWifi = CustomOption.Create(7881, Types.General, new TranslationInfo("Opt-General", 68), false, enableBetterPolus, false);
			moveColdTemp = CustomOption.Create(7882, Types.General, new TranslationInfo("Opt-General", 69), false, enableBetterPolus, false);



			enableCamoComms = CustomOption.Create(1105, Types.General, new TranslationInfo("Opt-General", 70), false,  null, false);
			disableMedbayWalk = CustomOption.Create(8847, Types.General, new TranslationInfo("Opt-General", 71), false, null, false);

            restrictDevices = CustomOption.Create(1101, Types.General, new TranslationInfo("Opt-General", 72), new[] { new TranslationInfo("Opt-General", 8), new TranslationInfo("Opt-General", 73), new TranslationInfo("Opt-General", 74) },  null, false);
            restrictAdmin = CustomOption.Create(1102, Types.General, new TranslationInfo("Opt-General", 75), 30f, 0f, 600f, 5f, restrictDevices);
            restrictCameras = CustomOption.Create(1103, Types.General, new TranslationInfo("Opt-General", 76), 30f, 0f, 600f, 5f, restrictDevices);
            restrictVents = CustomOption.Create(1104, Types.General, new TranslationInfo("Opt-General", 77), 30f, 0f, 600f, 5f, restrictDevices);
			disableCamsRound1 = CustomOption.Create(8834, Types.General, new TranslationInfo("Opt-General", 78), false, null, false);

            showButtonTarget = CustomOption.Create(9994, Types.General, new TranslationInfo("Opt-General", 79), true);
            blockGameEnd = CustomOption.Create(9995, Types.General, new TranslationInfo("Opt-General", 80), false);


            randomGameStartPosition = CustomOption.Create(9041, Types.General, new TranslationInfo("Opt-General", 81), false);
            allowModGuess = CustomOption.Create(9043, Types.General, new TranslationInfo("Opt-General", 82), false);
            resetRoundStartCooldown = CustomOption.Create(9042, Types.General, new TranslationInfo("Opt-General", 83), false);
            dynamicMapSeparateSettings = CustomOption.Create(509, Types.General, new TranslationInfo("Opt-General", 84), false, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new[] { (byte)RoleId.Mini });
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});

			// Prosecutor
			blockedRolePairings.Add((byte)RoleId.Lawyer, new[] { (byte)RoleId.Prosecutor });
            blockedRolePairings.Add((byte)RoleId.Prosecutor, new[] { (byte)RoleId.Lawyer });            
        }
    }
}
