using System;
using BepInEx.Configuration;

namespace YNGGAMEVISION
{
    public static class ConfigManager
    {
        public static ConfigEntry<bool> useTextPatch { get; private set; }
        public static ConfigEntry<bool> useUpgradePatch { get; private set; }
        public static ConfigEntry<bool> useHealthPatch { get; private set; }
        public static ConfigEntry<bool> useSprintPatch { get; private set; } 
        public static ConfigEntry<float> SprintDrain { get; private set; }
        public static ConfigEntry<float> SprintRechargeTime { get; private set; }
        public static ConfigEntry<float> SprintRechargeAmount { get; private set; }


        public static void Initialize(ConfigFile config)
        {
            useTextPatch = config.Bind("Flags settings", "useTextPatch", true,
                new ConfigDescription(
                    "Flag for TextChat patch.",
                    new AcceptableValueList<bool>(false,true)
                ));

            useUpgradePatch = config.Bind("Flags settings", "useUpgradePatch", true,
                new ConfigDescription(
                    "Flag for Uprages patch.",
                    new AcceptableValueList<bool>(false, true)
                ));
            useHealthPatch = config.Bind("Flags settings", "useHealthPatch", true,
                new ConfigDescription(
                    "Flag for Health patch.",
                    new AcceptableValueList<bool>(false, true)
                ));

            useSprintPatch = config.Bind("Flags settings", "useSprintPatch", true,
                new ConfigDescription(
                    "Flag for Sprint patch.",
                    new AcceptableValueList<bool>(false, true)
                ));
            SprintDrain = config.Bind("Sprint Settings", "SprintDrain", 5f,
                new ConfigDescription(
                    "How fast ur stamina draining while sprint. In-game default value is 1f.",
                    new AcceptableValueRange<float>(0f, 20f)
                ));
            SprintRechargeTime = config.Bind("Sprint Settings", "SprintRechargeTime", 0.5f,
                new ConfigDescription(
                    "How fast ur stamina stars recharging. In-game default value is 1f.",
                    new AcceptableValueRange<float>(0f, 5f)
                ));
            SprintRechargeAmount = config.Bind("Sprint Settings", "SprintRechargeAmount", 3f,
                new ConfigDescription(
                    "Changes recharge amount per second. In-game default value is 2f.",
                    new AcceptableValueRange<float>(0f, 20f)
                ));
        }
    }
}