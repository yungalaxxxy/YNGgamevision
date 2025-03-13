using HarmonyLib;
using Photon.Pun;


namespace YNGGAMEVISION.Patches;

public static class UpgradePatch
{
    [HarmonyPatch(typeof(ItemUpgradePlayerEnergy), nameof(ItemUpgradePlayerEnergy.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerEnergyPatch()
    {
        var players = SemiFunc.PlayerGetAll();
        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerEnergy(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }

    [HarmonyPatch(typeof(ItemUpgradePlayerHealth), nameof(ItemUpgradePlayerHealth.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerHealthPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerHealth(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }

    [HarmonyPatch(typeof(ItemUpgradePlayerExtraJump), nameof(ItemUpgradePlayerExtraJump.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerExtraJumpPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerExtraJump(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }


    [HarmonyPatch(typeof(ItemUpgradeMapPlayerCount), nameof(ItemUpgradeMapPlayerCount.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradeMapPlayerCountPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradeMapPlayerCount(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }



    [HarmonyPatch(typeof(ItemUpgradePlayerTumbleLaunch), nameof(ItemUpgradePlayerTumbleLaunch.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerTumbleLaunchPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerTumbleLaunch(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }


    [HarmonyPatch(typeof(ItemUpgradePlayerSprintSpeed), nameof(ItemUpgradePlayerSprintSpeed.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerSprintSpeedPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerSprintSpeed(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }


    [HarmonyPatch(typeof(ItemUpgradePlayerGrabStrength), nameof(ItemUpgradePlayerGrabStrength.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerGrabStrengthPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerGrabStrength(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }


    [HarmonyPatch(typeof(ItemUpgradePlayerGrabThrow), nameof(ItemUpgradePlayerGrabThrow.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerThrowStrengthPatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerThrowStrength(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }


    [HarmonyPatch(typeof(ItemUpgradePlayerGrabRange), nameof(ItemUpgradePlayerGrabRange.Upgrade))]
    [HarmonyPrefix]
    public static bool UpgradePlayerGrabRangePatch()
    {
        var players = SemiFunc.PlayerGetAll();

        foreach (var player in players)
        {
            PunManager.instance.UpgradePlayerGrabRange(SemiFunc.PlayerGetSteamID(player));
        }

        return false;
    }
}
