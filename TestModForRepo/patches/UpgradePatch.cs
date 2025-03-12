using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx.Logging;
using HarmonyLib;
using Photon.Pun;
using Steamworks;

namespace TestModForRepo.Patches;

[HarmonyPatch(typeof(PunManager))]
public static class UpgradePatch
{
    [HarmonyPatch("UpgradePlayerEnergy")]
    [HarmonyPrefix]
    public static bool UpgradePlayerEnergyPatch(PunManager __instance, StatsManager ___statsManager, PhotonView ___photonView)
    {
        var logger = Logger.CreateLogSource("[UpdatePlayerEnergy]");
        logger.LogInfo($"Energy buff for all!");
        Dictionary<string, int> playerUpgradeStamina = ___statsManager.playerUpgradeStamina;
        var players = SemiFunc.PlayerGetAll();
        if (SemiFunc.IsMasterClientOrSingleplayer())
        {

            MethodInfo methodInfo = __instance.GetType().GetMethod("UpdateEnergyRightAway", BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var player in players)
            {
                string playerSteamId = SemiFunc.PlayerGetSteamID(player);
                methodInfo.Invoke(__instance, new object[] { playerSteamId });
            }
        }
        if (SemiFunc.IsMasterClient())
        {   
            foreach (var player in players)
            {
                string playerSteamId = SemiFunc.PlayerGetSteamID(player);
                playerUpgradeStamina[playerSteamId]++;
                ___photonView.RPC("UpgradePlayerEnergyRPC", RpcTarget.Others, new object[]
                {
                    playerSteamId,
                ___statsManager.playerUpgradeStamina[playerSteamId]
                });         
            };
        }
        return false;
    }
}
