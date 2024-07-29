using HarmonyLib;
using System;
using TMPro;
using UnityEngine;
using static TheOtherRoles.Patches.CredentialsPatch;
using Object = UnityEngine.Object;

namespace TownOfRoles.Patches;

[HarmonyPatch]
public class MainMenuManagerPatch
{
    public static MainMenuManager Instance { get; private set; }

    public static GameObject InviteButton;
    public static GameObject WebsiteButton;
    public static GameObject UpdateButton;
    public static GameObject PlayButton;

    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.OpenGameModeMenu))]
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.OpenAccountMenu))]
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.OpenCredits))]
    [HarmonyPrefix, HarmonyPriority(Priority.Last)]
    public static void ShowRightPanel() => ShowingPanel = true;

    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    [HarmonyPatch(typeof(OptionsMenuBehaviour), nameof(OptionsMenuBehaviour.Open))]
    [HarmonyPatch(typeof(AnnouncementPopUp), nameof(AnnouncementPopUp.Show))]
    [HarmonyPrefix, HarmonyPriority(Priority.Last)]
    public static void HideRightPanel()
    {
        ShowingPanel = false;
        AccountManager.Instance?.transform?.FindChild("AccountTab/AccountWindow")?.gameObject?.SetActive(false);
    }

    public static void ShowRightPanelImmediately()
    {
        ShowingPanel = true;
        TitleLogoPatch.RightPanel.transform.localPosition = TitleLogoPatch.RightPanelOp;
        Instance.OpenGameModeMenu();
    }

    public static bool ShowedBak = true;
    private static bool ShowingPanel = true;
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.LateUpdate)), HarmonyPostfix]
    public static void MainMenuManager_LateUpdate()
    {
        if (GameObject.Find("MainUI") == null) ShowingPanel = false;

        if (TitleLogoPatch.RightPanel != null)
        {
            var pos1 = TitleLogoPatch.RightPanel.transform.localPosition;
            Vector3 lerp1 = Vector3.Lerp(pos1, TitleLogoPatch.RightPanelOp + new Vector3((ShowingPanel ? 0f : 10f), 0f, 0f), Time.deltaTime * (ShowingPanel ? 3f : 2f));
            if (ShowingPanel
                ? TitleLogoPatch.RightPanel.transform.localPosition.x > TitleLogoPatch.RightPanelOp.x + 0.03f
                : TitleLogoPatch.RightPanel.transform.localPosition.x < TitleLogoPatch.RightPanelOp.x + 9f
                ) TitleLogoPatch.RightPanel.transform.localPosition = lerp1;
        }
    }
}