using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using Object = UnityEngine.Object;
using TheOtherRoles.Patches;
using UnityEngine.SceneManagement;
using AmongUs.Data;
using TMPro;
using Assets.InnerNet;

namespace TheOtherRoles.Modules {
    
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public class MainMenuPatch {
        private static bool horseButtonState = MapOptionsTor.enableHorseMode;
        //private static Sprite horseModeOffSprite = null;
        //private static Sprite horseModeOnSprite = null;
        private static AnnouncementPopUp popUp;

        private static void Prefix(MainMenuManager __instance) {
            var template = GameObject.Find("ExitGameButton");
            var template2 = GameObject.Find("CreditsButton");
            if (template == null || template2 == null) return;

            var buttonDiscord = UnityEngine.Object.Instantiate(template, null);
            GameObject.Destroy(buttonDiscord.GetComponent<AspectPosition>());
            buttonDiscord.transform.localPosition = new(-0.459f, -1.87f, 0);

            var textDiscord = buttonDiscord.GetComponentInChildren<TextMeshPro>();
            textDiscord.transform.localPosition = new(0, 0.035f, -2);
            textDiscord.alignment = TextAlignmentOptions.Right;
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) =>
            {
                if (textDiscord != null)
                    textDiscord.SetText("Discord");
            })));

            PassiveButton passiveButtonDiscord = buttonDiscord.GetComponent<PassiveButton>();
            SpriteRenderer buttonSpriteDiscord = buttonDiscord.transform.FindChild("Inactive").GetComponent<SpriteRenderer>();

            passiveButtonDiscord.OnClick = new Button.ButtonClickedEvent();
            passiveButtonDiscord.OnClick.AddListener((System.Action)(() => Application.OpenURL("https://discord.gg/77RkMJHWsM")));

            Color discordColor = new Color32(88, 101, 242, byte.MaxValue);
            buttonSpriteDiscord.color = textDiscord.color = discordColor;
            passiveButtonDiscord.OnMouseOut.AddListener((System.Action)delegate
            {
                buttonSpriteDiscord.color = textDiscord.color = discordColor;
            });

            // TOR credits button
            var buttoncredits = GameObject.Instantiate(template, null);
            Object.Destroy(buttoncredits.GetComponent<AspectPosition>());
            buttoncredits.transform.localPosition = new(-0.459f, -1.48f, 0);

            var textcredits = buttoncredits.GetComponentInChildren<TextMeshPro>();
            textcredits.transform.localPosition = new(0, 0.035f, -2);
            textcredits.alignment = TextAlignmentOptions.Right;
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) =>
            {
                textcredits.SetText("TOR Credits");
            })));

            PassiveButton passiveButtoncredits = buttoncredits.GetComponent<PassiveButton>();
            SpriteRenderer buttonSpritecredits = buttoncredits.transform.FindChild("Inactive").GetComponent<SpriteRenderer>();

            passiveButtoncredits.OnClick = new Button.ButtonClickedEvent();
            Color creditsColor = new Color32(0, 245, 255, byte.MaxValue);
            buttonSpritecredits.color = textcredits.color = creditsColor;
            passiveButtoncredits.OnMouseOut.AddListener((System.Action)delegate
            {
                buttonSpritecredits.color = textcredits.color = creditsColor;
            });
            passiveButtoncredits.OnClick.AddListener((System.Action)delegate
            {
                // do stuff
                if (popUp != null) Object.Destroy(popUp);
                var popUpTemplate = Object.FindObjectOfType<AnnouncementPopUp>(true);
                popUp = Object.Instantiate(popUpTemplate);

                popUp.gameObject.SetActive(true);
                string creditsString = @$"<align=""center"">Github Contributors:
Alex2911    amsyarasyiq    MaximeGillot
Psynomit    probablyadnf    JustASysAdmin

[https://discord.gg/77RkMJHWsM]Discord[] Moderators:
Streamblox    Draco Cordraconis
Thanks to all our discord helpers!

Adapted by <b>FangKuai</b>

Thanks to miniduikboot & GD for hosting modded servers

";
                creditsString += $@"<size=60%> Other Credits & Resources:
OxygenFilter - For the versions v2.3.0 to v2.6.1, we were using the OxygenFilter for automatic deobfuscation
Reactor - The framework used for all versions before v2.0.0, and again since 4.2.0
BepInEx - Used to hook game functions
Essentials - Custom game options by DorCoMaNdO:
Before v1.6: We used the default Essentials release
v1.6-v1.8: We slightly changed the default Essentials.
v2.0.0 and later: As we were not using Reactor anymore, we are using our own implementation, inspired by the one from DorCoMaNdO
Jackal and Sidekick - Original idea for the Jackal and Sidekick came from Dhalucard
Among-Us-Love-Couple-Mod - Idea for the Lovers modifier comes from Woodi-dev
Jester - Idea for the Jester role came from Maartii
ExtraRolesAmongUs - Idea for the Engineer and Medic role came from NotHunter101. Also some code snippets from their implementation were used.
Among-Us-Sheriff-Mod - Idea for the Sheriff role came from Woodi-dev
TooManyRolesMods - Idea for the Detective and Time Master roles comes from Hardel-DW. Also some code snippets from their implementation were used.
TownOfUs - Idea for the Swapper, Shifter, Arsonist and a similar Mayor role came from Slushiegoose
Ottomated - Idea for the Morphling, Snitch and Camouflager role came from Ottomated
Crowded-Mod - Our implementation for 10+ player lobbies was inspired by the one from the Crowded Mod Team
Goose-Goose-Duck - Idea for the Vulture role came from Slushiegoose
ugackMiner53 - Idea and core code for the Prop Hunt game mode
TheEpicRoles - Idea for the first kill shield (partly) and the tabbed option menu (fully + some code), by LaicosVK DasMonschta Nova</size>";
                creditsString += "</align>";
                Assets.InnerNet.Announcement creditsAnnouncement = new()
                {
                    Id = "torCredits",
                    Language = 0,
                    Number = 500,
                    Title = "Credits and Contributors",
                    ShortTitle = "TOR CE Credits",
                    SubTitle = "",
                    PinState = false,
                    Date = "06.22.2024",
                    Text = creditsString,
                };
                __instance.StartCoroutine(Effects.Lerp(0.1f, new Action<float>((p) =>
                {
                    if (p == 1)
                    {
                        var backup = DataManager.Player.Announcements.allAnnouncements;
                        DataManager.Player.Announcements.allAnnouncements = new();
                        popUp.Init(false);
                        DataManager.Player.Announcements.SetAnnouncements(new Announcement[] { creditsAnnouncement });
                        popUp.CreateAnnouncementList();
                        popUp.UpdateAnnouncementText(creditsAnnouncement.Number);
                        popUp.visibleAnnouncements._items[0].PassiveButton.OnClick.RemoveAllListeners();
                        DataManager.Player.Announcements.allAnnouncements = backup;
                    }
                })));
            });
        }

        public static void addSceneChangeCallbacks() {
            SceneManager.add_sceneLoaded((Action<Scene, LoadSceneMode>)((scene, _) => {
                if (!scene.name.Equals("MatchMaking", StringComparison.Ordinal)) return;
                MapOptionsTor.gameMode = CustomGamemodes.Classic;
                // Add buttons For Guesser Mode, Hide N Seek in this scene.
                // find "HostLocalGameButton"
                var template = GameObject.FindObjectOfType<HostLocalGameButton>();
                var gameButton = template.transform.FindChild("CreateGameButton");
                var gameButtonPassiveButton = gameButton.GetComponentInChildren<PassiveButton>();

                var guesserButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                guesserButton.transform.localPosition += new Vector3(0f, -0.5f);
                var guesserButtonText = guesserButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var guesserButtonPassiveButton = guesserButton.GetComponentInChildren<PassiveButton>();
                
                guesserButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                guesserButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    MapOptionsTor.gameMode = CustomGamemodes.Guesser;
                    template.OnClick();
                }));

                var HideNSeekButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                HideNSeekButton.transform.localPosition += new Vector3(1.7f, -0.5f);
                var HideNSeekButtonText = HideNSeekButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var HideNSeekButtonPassiveButton = HideNSeekButton.GetComponentInChildren<PassiveButton>();
                
                HideNSeekButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                HideNSeekButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    MapOptionsTor.gameMode = CustomGamemodes.HideNSeek;
                    template.OnClick();
                }));
                var PropHuntButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                PropHuntButton.transform.localPosition += new Vector3(3.4f, -0.5f);
                var PropHuntButtonText = PropHuntButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var PropHuntButtonPassiveButton = PropHuntButton.GetComponentInChildren<PassiveButton>();
                PropHuntButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                PropHuntButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    MapOptionsTor.gameMode = CustomGamemodes.PropHunt;
                    template.OnClick();
                }));
                template.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                    guesserButtonText.SetText("TOR Guesser");
                    HideNSeekButtonText.SetText("TOR Hide N Seek");
                    PropHuntButtonText.SetText("TOR Prop Hunt");
                })));
            }));
        }
    }
}
