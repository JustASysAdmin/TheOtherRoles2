using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TheOtherRoles;
using TheOtherRoles.CustomGameModes;
using TheOtherRoles.Modules;
using TheOtherRoles.Players;
using TheOtherRoles.Utilities;
using TMPro;
using UnityEngine;

namespace TheOtherRoles.Patches 
{
    [HarmonyPatch]
    public static class CredentialsPatch 
    {
        public static string producer = "<color=#FCCE03FF>JustASysAdmin</color>";
        public static string artworker = "<color=#FCCE03FF>SvettyScribbles</color>, <color=#FCCE03FF>JustASysAdmin</color> and <color=#00ffff>fangkuai</color>";
        public static string specialthanks = "<color=#00FFFF>fangkuai, <color=#FCCE03FF>Smeggy and Imp11</color>";
        public static string pingtextcolor = "";
        public static string fullCredentialsVersion = 
        $@"<size=130%><color=#ff351f>TheOtherRoles Community Edition</color></size> v{TheOtherRolesPlugin.Version.ToString() + (TheOtherRolesPlugin.betaDays>0 ? "-BETA": "")}";

        [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
        internal static class PingTrackerPatch
        {
            static void Postfix(PingTracker __instance){
                //Ping text color
                var ping = AmongUsClient.Instance.Ping;
                if (ping < 50) pingtextcolor = "<color=#00ffff>";
                else if (ping < 100) pingtextcolor = "<color=#00ec00>";
                else if (ping < 200) pingtextcolor = "<color=#ff44ff>";
                else if (ping < 300) pingtextcolor = "<color=#8600ff>";
                else if (ping < 400) pingtextcolor = "<color=#ff0000>";
                else if (ping > 700) pingtextcolor = ("<color=#ff0000>" + Helpers.transl("pingveryhigh"));

                __instance.text.alignment = TextAlignmentOptions.TopRight;
                var position = __instance.GetComponent<AspectPosition>();
                if (AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started) {
                    string gameModeText = $"";
                    if (HideNSeek.isHideNSeekGM) gameModeText = $"Hide 'N Seek";
                    else if (HandleGuesser.isGuesserGm) gameModeText = $"Guesser";
                    else if (PropHunt.isPropHuntGM) gameModeText = $"Prop Hunt";
                    if (gameModeText != "") gameModeText = Helpers.cs(Color.yellow, gameModeText) + "\n";
                    __instance.text.text = $"<size=130%><color=#ff351f>TheOtherRoles Community Edition</color></size> v{TheOtherRolesPlugin.Version.ToString() + (TheOtherRolesPlugin.betaDays > 0 ? "-BETA" : "")}\n{gameModeText}" + pingtextcolor + string.Format(Helpers.transl("pingtextchange"), AmongUsClient.Instance.Ping);
                    if (CachedPlayer.LocalPlayer.PlayerControl.isLover())
                    {
                        __instance.gameObject.GetComponent<AspectPosition>().DistanceFromEdge = new Vector3(1.2f, 0.8f, 0f);
                    }
                    else if (PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.Data.IsDead)
                    {
                        __instance.gameObject.GetComponent<AspectPosition>().DistanceFromEdge = new Vector3(2.0f, 0.1f, 0f);
                    }
                    else
                    {
                        __instance.gameObject.GetComponent<AspectPosition>().DistanceFromEdge = new Vector3(1.2f, 0.1f, 0f);
                    }
                    __instance.gameObject.GetComponent<AspectPosition>().AdjustPosition();
                    position.DistanceFromEdge = new Vector3(2.25f, 0.11f, 0);
                } else {
                    string gameModeText = $"";
                    if (MapOptionsTor.gameMode == CustomGamemodes.HideNSeek) gameModeText = $"Hide 'N Seek";
                    else if (MapOptionsTor.gameMode == CustomGamemodes.Guesser) gameModeText = $"Guesser";
                    else if (MapOptionsTor.gameMode == CustomGamemodes.PropHunt) gameModeText = $"Prop Hunt";
                    if (gameModeText != "") gameModeText = Helpers.cs(Color.yellow, gameModeText) + "\n";

                    var host = $"Host: {GameData.Instance?.GetHost()?.PlayerName}";
                    __instance.text.text = $"{fullCredentialsVersion}\n{host}\n  {gameModeText}" + "<size=60%>" + Helpers.transl("Moddedby") + producer + $"\n{Helpers.transl("artwork")+ artworker + "\n" + Helpers.transl("basedtor")}" + $"</size>\n{pingtextcolor}" + string.Format(Helpers.transl("pingtextchange"),AmongUsClient.Instance.Ping);
                    if (AmongUsClient.Instance.GameState != InnerNet.InnerNetClient.GameStates.Started)
                    {
                        __instance.gameObject.GetComponent<AspectPosition>().DistanceFromEdge = new Vector3(0.5f, 0.8f, 0f);
                    }
                    else if (PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.Data.IsDead)
                    {
                        __instance.gameObject.GetComponent<AspectPosition>().DistanceFromEdge = new Vector3(2.0f, 0.1f, 0f);
                    }
                    else
                    {
                        __instance.gameObject.GetComponent<AspectPosition>().DistanceFromEdge = new Vector3(1.2f, 0.1f, 0f);
                    }
                    __instance.gameObject.GetComponent<AspectPosition>().AdjustPosition();
                }
                position.AdjustPosition();
            }
        }

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
        public static class LogoPatch
        {
            public static SpriteRenderer renderer;
            public static Sprite bannerSprite;
            public static Sprite horseBannerSprite;
            public static Sprite banner2Sprite;
            private static PingTracker instance;

            public static GameObject motdObject;
            public static TextMeshPro motdText;

            static void Postfix(PingTracker __instance) {
                var torLogo = new GameObject("bannerLogo_TOR");
                torLogo.transform.SetParent(GameObject.Find("RightPanel").transform, false);
                torLogo.transform.position = new Vector3(2.095f, 0.658f, 520f);
                renderer = torLogo.AddComponent<SpriteRenderer>();
                loadSprites();
                renderer.sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Banner.png", 300f);

                instance = __instance;
                loadSprites();
                // renderer.sprite = MapOptionsTor.enableHorseMode ? horseBannerSprite : bannerSprite;
                renderer.sprite = EventUtility.isEnabled ? banner2Sprite : bannerSprite;
                var credentialObject = new GameObject("credentialsTOR");
                var credentials = credentialObject.AddComponent<TextMeshPro>();
                credentials.SetText($"v{TheOtherRolesPlugin.Version.ToString() + (TheOtherRolesPlugin.betaDays > 0 ? "-BETA" : "")}\n<size=85%>{Helpers.transl("Moddedby") + producer + " "+ Helpers.transl("artwork") + artworker + "\n" + Helpers.transl("basedtor")}\n<size=60%>\n{Helpers.transl("specialthanks") + specialthanks }</size>");
                credentials.alignment = TMPro.TextAlignmentOptions.Center;
                credentials.fontSize *= 0.05f;

                credentials.transform.SetParent(torLogo.transform);
                credentials.transform.localPosition = Vector3.down * 1.25f;
                motdObject = new GameObject("torMOTD");
                motdText = motdObject.AddComponent<TextMeshPro>();
                motdText.alignment = TMPro.TextAlignmentOptions.Center;
                motdText.fontSize *= 0.04f;

                motdText.transform.SetParent(torLogo.transform);
                motdText.enableWordWrapping = true;
                var rect = motdText.gameObject.GetComponent<RectTransform>();
                rect.sizeDelta = new Vector2(5.2f, 0.25f);

                motdText.transform.localPosition = Vector3.down * 2.25f;
                motdText.color = new Color(1, 53f / 255, 31f / 255);
                Material mat = motdText.fontSharedMaterial;
                mat.shaderKeywords = new string[] { "OUTLINE_ON" };
                motdText.SetOutlineColor(Color.white);
                motdText.SetOutlineThickness(0.025f);
            }

            public static void loadSprites() {
                if (bannerSprite == null) bannerSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Banner.png", 300f);
                if (banner2Sprite == null) banner2Sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.Banner2.png", 300f);
                if (horseBannerSprite == null) horseBannerSprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.bannerTheHorseRoles.png", 300f);
            }

            public static void updateSprite() {
                loadSprites();
                if (renderer != null) {
                    float fadeDuration = 1f;
                    instance.StartCoroutine(Effects.Lerp(fadeDuration, new Action<float>((p) => {
                        renderer.color = new Color(1, 1, 1, 1 - p);
                        if (p == 1) {
                            renderer.sprite = MapOptionsTor.enableHorseMode ? horseBannerSprite : bannerSprite;
                            instance.StartCoroutine(Effects.Lerp(fadeDuration, new Action<float>((p) => {
                                renderer.color = new Color(1, 1, 1, p);
                            })));
                        }
                    })));
                }
            }
        }

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.LateUpdate))]
        public static class MOTD {
            public static List<string> motds = new List<string>();
            private static float timer = 0f;
            private static float maxTimer = 5f;
            private static int currentIndex = 0;

            public static void Postfix() {
                if (motds.Count == 0) {
                    timer = maxTimer;
                    return;
                }
                if (motds.Count > currentIndex && LogoPatch.motdText != null)
                    LogoPatch.motdText.SetText(motds[currentIndex]);
                else return;

                // fade in and out:
                float alpha = Mathf.Clamp01(Mathf.Min(new float[] { timer, maxTimer - timer }));
                if (motds.Count == 1) alpha = 1;
                LogoPatch.motdText.color = LogoPatch.motdText.color.SetAlpha(alpha);
                timer -= Time.deltaTime;
                if (timer <= 0) {
                    timer = maxTimer;
                    currentIndex = (currentIndex + 1) % motds.Count;
                }
            }

            public static async Task loadMOTDs() {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/TheOtherRolesAU/MOTD/main/motd.txt");
                response.EnsureSuccessStatusCode();
                string motds = await response.Content.ReadAsStringAsync();
                foreach(string line in motds.Split("\n", StringSplitOptions.RemoveEmptyEntries)) {
                        MOTD.motds.Add(line);
                }
            }
        }        
    }
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start)), HarmonyPriority(Priority.First)]
    internal class TitleLogoPatch
    {
        public static GameObject ModStamp;
        private static void Postfix(MainMenuManager __instance)
        {
            if (!(ModStamp = GameObject.Find("ModStamp"))) return;
            var ModStampRenderer = ModStamp.GetComponent<SpriteRenderer>();
            ModStampRenderer.sprite = Helpers.loadSpriteFromResources("TheOtherRoles.Resources.ModStamp.png", 150f);
        }
    }
}
