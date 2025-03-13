using HarmonyLib;

namespace YNGGAMEVISION.Patches;

[HarmonyPatch(typeof(PlayerController))]
public static class SprintPatch
{
    [HarmonyPatch("Start")]
    [HarmonyPrefix]
    public static void StartPatch(ref float ___EnergySprintDrain, ref float ___sprintRechargeTime, ref float ___sprintRechargeAmount)
    {
        ___EnergySprintDrain = ConfigManager.SprintDrain.Value;
        ___sprintRechargeTime = ConfigManager.SprintRechargeTime.Value;
        ___sprintRechargeAmount = ConfigManager.SprintRechargeAmount.Value;
    }
}
