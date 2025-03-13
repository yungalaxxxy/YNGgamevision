using BepInEx;
using HarmonyLib;
using YNGGAMEVISION.Patches;

namespace YNGGAMEVISION
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class YngGameVision: BaseUnityPlugin
    {
        public const string pluginGuid = "yngprodaction.repo.vision";
        public const string pluginName = "YNGGAMEVISION";
        public const string pluginVersion = "1.2.0";

        public void Awake()
        {
            Logger.LogInfo($"Mod {pluginName} was launched");
            Harmony harmony = new Harmony(pluginGuid);
            ConfigManager.Initialize(Config);

            if (ConfigManager.useUpgradePatch.Value)
            {
                harmony.PatchAll(typeof(TextChatPatch));
                Logger.LogInfo("TextChat patch applied");
            }
            if (ConfigManager.useTextPatch.Value)
            {
                harmony.PatchAll(typeof(UpgradePatch));
                Logger.LogInfo("Upgrade patch applied");
            }
            if (ConfigManager.useHealthPatch.Value)
            {
                harmony.PatchAll(typeof(HealthPatch));
                Logger.LogInfo("Health patch applied");
            }
            if (ConfigManager.useSprintPatch.Value)
            {
                harmony.PatchAll(typeof(SprintPatch));
                Logger.LogInfo($"Sprint patch applied!");
            }

            Logger.LogInfo($"{pluginName}:{pluginVersion} was initialized!");
        }
    }
}
