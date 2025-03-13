using System;
using BepInEx.Logging;
using HarmonyLib;

namespace YNGGAMEVISION.Patches;

[HarmonyPatch(typeof(ItemHealthPack))]
public static class HealthPatch
{
    [HarmonyPatch(nameof(ItemHealthPack.OnDestroy))]
    [HarmonyPostfix]
    public static void OnDestroyPatch(ItemHealthPack __instance)
    {
        var players = SemiFunc.PlayerGetAll();
        foreach(var player in players)
        {
            player.playerHealth.Heal(__instance.healAmount);
        }
    }
}
