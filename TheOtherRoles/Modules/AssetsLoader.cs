using System.Reflection;
using UnityEngine;
using Sentry.Internal.Extensions;
using TheOtherRoles;
using Reactor.Utilities.Extensions;

namespace TownOfRoles.Modules
{
    public static class AssetsLoad
    {
        public static readonly Assembly dll = Assembly.GetExecutingAssembly();
        private static bool flag = false;

        public static void Load()
        {
            if (flag) return;
            flag = true;
            LoadTORCommunityEditionAssets();
        }

        public static void LoadTORCommunityEditionAssets()
        {
            var resourceAudioAssetBundleStream = dll.GetManifestResourceStream("TheOtherRoles.Resources.AssetBundle.TheOtherRolesCommunityEdition.AssetBundle");
            var AssetBundleStream = AssetBundle.LoadFromMemory(resourceAudioAssetBundleStream.ReadFully());
            CustomMain.customAssets.arsonistDouse = AssetBundleStream.LoadAsset<AudioClip>("arsonistDouse.mp3").DontUnload();
            CustomMain.customAssets.bombDefused = AssetBundleStream.LoadAsset<AudioClip>("bombDefused.mp3").DontUnload();
            CustomMain.customAssets.bombExplosion = AssetBundleStream.LoadAsset<AudioClip>("bombExplosion.mp3").DontUnload();
            CustomMain.customAssets.bombFuseBurning = AssetBundleStream.LoadAsset<AudioClip>("bombFuseBurning.mp3").DontUnload();
            CustomMain.customAssets.bombTick = AssetBundleStream.LoadAsset<AudioClip>("bombTick.mp3").DontUnload();
            CustomMain.customAssets.cleanerClean = AssetBundleStream.LoadAsset<AudioClip>("cleanerClean.mp3").DontUnload();
            CustomMain.customAssets.deputyHandcuff = AssetBundleStream.LoadAsset<AudioClip>("deputyHandcuff.mp3").DontUnload();
            CustomMain.customAssets.engineerRepair = AssetBundleStream.LoadAsset<AudioClip>("engineerRepair.mp3").DontUnload();
            CustomMain.customAssets.eraserErase = AssetBundleStream.LoadAsset<AudioClip>("eraserErase.mp3").DontUnload();
            CustomMain.customAssets.fail = AssetBundleStream.LoadAsset<AudioClip>("fail.mp3").DontUnload();
            CustomMain.customAssets.garlic = AssetBundleStream.LoadAsset<AudioClip>("garlic.mp3").DontUnload();
            CustomMain.customAssets.hackerHack = AssetBundleStream.LoadAsset<AudioClip>("hackerHack.mp3").DontUnload();
            CustomMain.customAssets.jackalSidekick = AssetBundleStream.LoadAsset<AudioClip>("jackalSidekick.mp3").DontUnload();
            CustomMain.customAssets.knockKnock = AssetBundleStream.LoadAsset<AudioClip>("knockKnock.mp3").DontUnload();
            CustomMain.customAssets.lighterLight = AssetBundleStream.LoadAsset<AudioClip>("lighterLight.mp3").DontUnload();
            CustomMain.customAssets.medicShield = AssetBundleStream.LoadAsset<AudioClip>("medicShield.mp3").DontUnload();
            CustomMain.customAssets.mediumAsk = AssetBundleStream.LoadAsset<AudioClip>("mediumAsk.mp3").DontUnload();
            CustomMain.customAssets.morphlingMorph = AssetBundleStream.LoadAsset<AudioClip>("morphlingMorph.mp3").DontUnload();
            CustomMain.customAssets.morphlingSample = AssetBundleStream.LoadAsset<AudioClip>("morphlingSample.mp3").DontUnload();
            CustomMain.customAssets.portalUse = AssetBundleStream.LoadAsset<AudioClip>("portalUse.mp3").DontUnload();
            CustomMain.customAssets.pursuerBlank = AssetBundleStream.LoadAsset<AudioClip>("pursuerBlank.mp3").DontUnload();
            CustomMain.customAssets.securityGuardPlaceCam = AssetBundleStream.LoadAsset<AudioClip>("securityGuardPlaceCam.mp3").DontUnload();
            CustomMain.customAssets.shifterShift = AssetBundleStream.LoadAsset<AudioClip>("shifterShift.mp3").DontUnload();
            CustomMain.customAssets.timemasterShield = AssetBundleStream.LoadAsset<AudioClip>("timemasterShield.mp3").DontUnload();
            CustomMain.customAssets.trackerTrackCorpses = AssetBundleStream.LoadAsset<AudioClip>("trackerTrackCorpses.mp3").DontUnload();
            CustomMain.customAssets.trackerTrackPlayer = AssetBundleStream.LoadAsset<AudioClip>("trackerTrackPlayer.mp3").DontUnload();
            CustomMain.customAssets.trapperTrap = AssetBundleStream.LoadAsset<AudioClip>("trapperTrap.mp3").DontUnload();
            CustomMain.customAssets.tricksterPlaceBox = AssetBundleStream.LoadAsset<AudioClip>("tricksterPlaceBox.mp3").DontUnload();
            CustomMain.customAssets.tricksterUseBoxVent = AssetBundleStream.LoadAsset<AudioClip>("tricksterUseBoxVent.mp3").DontUnload();
            CustomMain.customAssets.vampireBite = AssetBundleStream.LoadAsset<AudioClip>("vampireBite.mp3").DontUnload();
            CustomMain.customAssets.vultureEat = AssetBundleStream.LoadAsset<AudioClip>("vultureEat.mp3").DontUnload();
            CustomMain.customAssets.warlockCurse = AssetBundleStream.LoadAsset<AudioClip>("warlockCurse.mp3").DontUnload();
            CustomMain.customAssets.witchSpell = AssetBundleStream.LoadAsset<AudioClip>("witchSpell.mp3").DontUnload();
            CustomMain.customAssets.disperserDisperse = AssetBundleStream.LoadAsset<AudioClip>("disperserDisperse.mp3").DontUnload();
        }
    }
}