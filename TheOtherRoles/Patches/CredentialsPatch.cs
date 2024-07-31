using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TheOtherRoles;
using TheOtherRoles.CustomGameModes;
using TheOtherRoles.Players;
using TheOtherRoles.Utilities;
using TMPro;
using TownOfRoles.Patches;
using UnityEngine;

namespace TheOtherRoles.Patches {
    [HarmonyPatch]
    public static class CredentialsPatch {
        public static string fullCredentialsVersion =
$@"<size=130%><color=#ff351f>TheOtherRolesCE</color></size> v{TheOtherRolesPlugin.Version.ToString() + (TheOtherRolesPlugin.betaDays > 0 ? "-BETA" : "")}";

        public static string fullCredentials =
$@"<size=130%><color=#ff351f>TheOtherRoles Community Edition</color></size> v{TheOtherRolesPlugin.Version.ToString()}
<size=60%>
Modded by <color=#FCCE03FF>JustASysAdmin</color> & <color=#00FFFF>FangKuai</color>, based on TheOtherRoles by <color=#FCCE03FF>Eisbison</color>.<br>Additional artwork by <color=#FCCE03FF>SvettyScribbles</color>, <color=#FCCE03FF>JustASysAdmin</color> , <color=#00FFFF>FangKuai</color> & <color=#9932CC>乱码</color>.</size>";

        public static string mainMenuCredentials =
    $@"Modded by <color=#FCCE03FF>JustASysAdmin</color> & <color=#00FFFF>FangKuai</color>.<br>Additional artwork by <color=#FCCE03FF>SvettyScribbles</color>, <color=#FCCE03FF>JustASysAdmin</color>, <color=#00FFFF>FangKuai</color> & <color=#9932CC>乱码</color>.</size>";

//        public static string contributorsCredentials =
//$@"<size=60%> <color=#FCCE03FF>Special thanks to <color=#00FFFF>FangKuai<color=#FCCE03FF> & Smeggy</color></size>";

        [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
        internal static class PingTrackerPatch
        {
            static void Postfix(PingTracker __instance) {
                __instance.text.alignment = TextAlignmentOptions.TopRight;
                var position = __instance.GetComponent<AspectPosition>();
                if (AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started) {
                    string gameModeText = $"";
                    if (HideNSeek.isHideNSeekGM) gameModeText = $"Hide 'N Seek";
                    else if (HandleGuesser.isGuesserGm) gameModeText = $"Guesser";
                    else if (PropHunt.isPropHuntGM) gameModeText = "Prop Hunt";
                    if (gameModeText != "") gameModeText = Helpers.cs(Color.yellow, gameModeText) + "\n";
                    __instance.text.text = $"<size=130%><color=#ff351f>TheOtherRolesCE</color></size> v{TheOtherRolesPlugin.Version.ToString() + (TheOtherRolesPlugin.betaDays > 0 ? "-BETA" : "")}\n{gameModeText}" + __instance.text.text;
                    position.DistanceFromEdge = new Vector3(2.25f, 0.11f, 0);
                } else {
                    string gameModeText = $"";
                    if (MapOptionsTor.gameMode == CustomGamemodes.HideNSeek) gameModeText = $"Hide 'N Seek";
                    else if (MapOptionsTor.gameMode == CustomGamemodes.Guesser) gameModeText = $"Guesser";
                    else if (MapOptionsTor.gameMode == CustomGamemodes.PropHunt) gameModeText = $"Prop Hunt";
                    if (gameModeText != "") gameModeText = Helpers.cs(Color.yellow, gameModeText) + "\n";

                    var host = $"Host: {GameData.Instance?.GetHost()?.PlayerName}";
                    __instance.text.text = $"{fullCredentialsVersion}\n  {gameModeText + fullCredentials}\n {host}\n {__instance.text.text}";
                    position.DistanceFromEdge = new Vector3(3.5f, 0.1f, 0);
                }
                position.AdjustPosition();
            }
        }

        [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
        internal class VersionShowerStartPatch
        {
            private static GameObject VersionShower1;
            public static GameObject OVersionShower;
            private static TextMeshPro VisitText;
            private static void Postfix(VersionShower __instance)
            {
                var friendCode = GameObject.Find("FriendCode");
                if (friendCode != null && VersionShower1 == null)
                {
                    VersionShower1 = UnityEngine.Object.Instantiate(friendCode, friendCode.transform.parent);
                    VersionShower1.transform.localPosition = friendCode.transform.localPosition + new Vector3(3.2f, 0f, 0f);
                    VersionShower1.transform.localScale *= 1.7f;
                    var TMP = VersionShower1.GetComponent<TextMeshPro>();
                    TMP.alignment = TextAlignmentOptions.Right;
                    TMP.SetText(mainMenuCredentials);
                }
                if ((OVersionShower = GameObject.Find("VersionShower")) != null && VisitText == null)
                {
                    VisitText = UnityEngine.Object.Instantiate(__instance.text);
                    VisitText.name = "TOR User Counter";
                    VisitText.alignment = TextAlignmentOptions.Left;
                    VisitText.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                    VisitText.transform.localPosition = new Vector3(-3.92f, -2.9f, 0f);
                    VisitText.enabled = GameObject.Find("TOR Background") != null;

                    __instance.text.text = $"<color=#ff351f>TheOtherRoles Community Edition</color> v{TheOtherRolesPlugin.Version.ToString() + (TheOtherRolesPlugin.betaDays > 0 ? "-BETA" : "")}";
                    __instance.text.alignment = TextAlignmentOptions.Left;
                    OVersionShower.transform.localPosition = new Vector3(-4.92f, -3.3f, 0f);

                    var ap1 = OVersionShower.GetComponent<AspectPosition>();
                    if (ap1 != null) UnityEngine.Object.Destroy(ap1);
                    var ap2 = VisitText.GetComponent<AspectPosition>();
                    if (ap2 != null) UnityEngine.Object.Destroy(ap2);
                };
            }
        }

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start)), HarmonyPriority(Priority.First)]
        internal class TitleLogoPatch
        {
            public static GameObject TOR_Background;
            public static GameObject Ambience;
            public static GameObject Starfield;
            public static GameObject LeftPanel;
            public static GameObject RightPanel;
            public static GameObject CloseRightButton;
            public static GameObject Tint;
            public static GameObject Sizer;
            public static GameObject AULogo;
            public static GameObject BottomButtonBounds;

            public static Vector3 RightPanelOp;

            private static void Postfix(MainMenuManager __instance)
            {
                GameObject.Find("BackgroundTexture")?.SetActive(false);

                TOR_Background = new GameObject("TOR Background");
                TOR_Background.transform.position = new Vector3(0, 0, 520f);
                var bgRenderer = TOR_Background.AddComponent<SpriteRenderer>();
                bgRenderer.sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.MainMenu.TOR_BG.jpg", 179f);

                if (!(Ambience = GameObject.Find("Ambience"))) return;
                if (!(Starfield = Ambience.transform.FindChild("starfield").gameObject)) return;
                StarGen starGen = Starfield.GetComponent<StarGen>();
                starGen.SetDirection(new Vector2(0, -2));
                Starfield.transform.SetParent(TOR_Background.transform);
                UnityEngine.Object.Destroy(Ambience);

                if (!(LeftPanel = GameObject.Find("LeftPanel"))) return;
                LeftPanel.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                static void ResetParent(GameObject obj) => obj.transform.SetParent(LeftPanel.transform.parent);
                LeftPanel.ForEachChild((Il2CppSystem.Action<GameObject>)ResetParent);
                LeftPanel.SetActive(false);

                Color shade = new(0f, 0f, 0f, 0f);
                var standardActiveSprite = __instance.newsButton.activeSprites.GetComponent<SpriteRenderer>().sprite;
                var minorActiveSprite = __instance.quitButton.activeSprites.GetComponent<SpriteRenderer>().sprite;

                Dictionary<List<PassiveButton>, (Sprite, Color, Color, Color, Color)> mainButtons = new()
        {
            {new List<PassiveButton>() {__instance.playButton, __instance.inventoryButton, __instance.shopButton},
                (standardActiveSprite, new(1f, 0.524f, 0.549f, 0.8f), shade, Color.white, Color.white) },
            {new List<PassiveButton>() {__instance.newsButton, __instance.myAccountButton, __instance.settingsButton},
                (minorActiveSprite, new(1f, 0.825f, 0.686f, 0.8f), shade, Color.white, Color.white) },
            {new List<PassiveButton>() {__instance.creditsButton, __instance.quitButton},
                (minorActiveSprite, new(0.526f, 1f, 0.792f, 0.8f), shade, Color.white, Color.white) },
        };

                void FormatButtonColor(PassiveButton button, Sprite borderType, Color inActiveColor, Color activeColor, Color inActiveTextColor, Color activeTextColor)
                {
                    button.activeSprites.transform.FindChild("Shine")?.gameObject?.SetActive(false);
                    button.inactiveSprites.transform.FindChild("Shine")?.gameObject?.SetActive(false);
                    var activeRenderer = button.activeSprites.GetComponent<SpriteRenderer>();
                    var inActiveRenderer = button.inactiveSprites.GetComponent<SpriteRenderer>();
                    activeRenderer.sprite = minorActiveSprite;
                    inActiveRenderer.sprite = minorActiveSprite;
                    activeRenderer.color = activeColor.a == 0f ? new Color(inActiveColor.r, inActiveColor.g, inActiveColor.b, 1f) : activeColor;
                    inActiveRenderer.color = inActiveColor;
                    button.activeTextColor = activeTextColor;
                    button.inactiveTextColor = inActiveTextColor;
                }

                foreach (var kvp in mainButtons)
                    kvp.Key.Do(button => FormatButtonColor(button, kvp.Value.Item1, kvp.Value.Item2, kvp.Value.Item3, kvp.Value.Item4, kvp.Value.Item5));

                GameObject.Find("Divider")?.SetActive(false);

                if (!(RightPanel = GameObject.Find("RightPanel"))) return;
                var rpap = RightPanel.GetComponent<AspectPosition>();
                if (rpap) UnityEngine.Object.Destroy(rpap);
                RightPanelOp = RightPanel.transform.localPosition;
                RightPanel.transform.localPosition = RightPanelOp + new Vector3(10f, 0f, 0f);
                RightPanel.GetComponent<SpriteRenderer>().color = new(1f, 0.78f, 0.9f, 1f);

                CloseRightButton = new GameObject("CloseRightPanelButton");
                CloseRightButton.transform.SetParent(RightPanel.transform);
                CloseRightButton.transform.localPosition = new Vector3(-4.78f, 1.3f, 1f);
                CloseRightButton.transform.localScale = new(1f, 1f, 1f);
                CloseRightButton.AddComponent<BoxCollider2D>().size = new(0.6f, 1.5f);
                var closeRightSpriteRenderer = CloseRightButton.AddComponent<SpriteRenderer>();
                closeRightSpriteRenderer.sprite = CustomMain.customAssets.RightPanelCloseButton;
                closeRightSpriteRenderer.color = new(1f, 0.78f, 0.9f, 1f);
                var closeRightPassiveButton = CloseRightButton.AddComponent<PassiveButton>();
                closeRightPassiveButton.OnClick = new();
                closeRightPassiveButton.OnClick.AddListener((System.Action)MainMenuManagerPatch.HideRightPanel);
                closeRightPassiveButton.OnMouseOut = new();
                closeRightPassiveButton.OnMouseOut.AddListener((System.Action)(() => closeRightSpriteRenderer.color = new(1f, 0.78f, 0.9f, 1f)));
                closeRightPassiveButton.OnMouseOver = new();
                closeRightPassiveButton.OnMouseOver.AddListener((System.Action)(() => closeRightSpriteRenderer.color = new(1f, 0.68f, 0.99f, 1f)));

                Tint = __instance.screenTint.gameObject;
                var ttap = Tint.GetComponent<AspectPosition>();
                if (ttap) UnityEngine.Object.Destroy(ttap);
                Tint.transform.SetParent(RightPanel.transform);
                Tint.transform.localPosition = new Vector3(-0.0824f, 0.0513f, Tint.transform.localPosition.z);
                Tint.transform.localScale = new Vector3(1f, 1f, 1f);
                __instance.howToPlayButton.gameObject.SetActive(true);
                __instance.howToPlayButton.transform.parent.Find("FreePlayButton").gameObject.SetActive(true);

                var creditsScreen = __instance.creditsScreen;
                if (creditsScreen)
                {
                    var csto = creditsScreen.GetComponent<TransitionOpen>();
                    if (csto) UnityEngine.Object.Destroy(csto);
                    var closeButton = creditsScreen.transform.FindChild("CloseButton");
                    closeButton?.gameObject.SetActive(false);
                }

                if (!(Sizer = GameObject.Find("Sizer"))) return;
                if (!(AULogo = GameObject.Find("LOGO-AU"))) return;
                Sizer.transform.localPosition += new Vector3(0f, 0.12f, 0f);
                AULogo.transform.localScale = new Vector3(0.66f, 0.67f, 1f);
                AULogo.transform.position += new Vector3(0f, 0.1f, 0f);
                var logoRenderer = AULogo.GetComponent<SpriteRenderer>();
                logoRenderer.sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.MainMenu.TOR-Logo.png", 100f);

                if (!(BottomButtonBounds = GameObject.Find("BottomButtonBounds"))) return;
                BottomButtonBounds.transform.localPosition -= new Vector3(0f, 0.1f, 0f);
            }
        }
        [HarmonyPatch(typeof(CreditsScreenPopUp))]
        internal class CreditsScreenPopUpPatch
        {
            [HarmonyPatch(nameof(CreditsScreenPopUp.OnEnable))]
            public static void Postfix(CreditsScreenPopUp __instance)
            {
                __instance.BackButton.transform.parent.FindChild("Background").gameObject.SetActive(false);
            }
        }
    }
}
