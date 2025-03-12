using BepInEx;
using HarmonyLib;
using YNGGANEVISION.Patches;

namespace YNGGANEVISION
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class YngGameVision: BaseUnityPlugin
    {
        public const string pluginGuid = "yngprodaction.repo.vision";
        public const string pluginName = "YNGGAMEVISION";
        public const string pluginVersion = "1.1.0";

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

            Logger.LogInfo($"{pluginName} was initialized!");
        }
    }
}
