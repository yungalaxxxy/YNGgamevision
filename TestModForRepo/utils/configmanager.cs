using BepInEx.Configuration;

namespace YNGGANEVISION
{
    public static class ConfigManager
    {
        public static ConfigEntry<bool> useTextPatch { get; private set; }
        public static ConfigEntry<bool> useUpgradePatch { get; private set; }

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
        }
    }
}