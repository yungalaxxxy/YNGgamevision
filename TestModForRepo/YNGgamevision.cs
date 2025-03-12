using BepInEx;
using HarmonyLib;
using TestModForRepo.Patches;

namespace TestModForRepo
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class YngGameVision: BaseUnityPlugin
    {
        public const string pluginGuid = "yngprodaction.repo.vision";
        public const string pluginName = "YNGGAMEVISION";
        public const string pluginVersion = "1.0.1";

        public void Awake()
        {
            Logger.LogInfo($"Mod {pluginName} was launched");
            Harmony harmony = new Harmony(pluginGuid);
            harmony.PatchAll(typeof(TextChatPatch));
            harmony.PatchAll(typeof(UpgradePatch));
            Logger.LogInfo($"Method ChatMessageSend was altered");
        }
    }
}
