﻿using BepInEx;
using HarmonyLib;
using TestModForRepo.Patches;

namespace TestModForRepo
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class TestMod: BaseUnityPlugin
    {
        public const string pluginGuid = "yngprodaction.repo.vision";
        public const string pluginName = "R.E.P.O. testing";
        public const string pluginVersion = "0.5.0";

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
