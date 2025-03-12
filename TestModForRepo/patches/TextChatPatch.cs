using System;
using HarmonyLib;

namespace YNGGANEVISION.Patches;

[HarmonyPatch(typeof(PlayerAvatar))]
public static class TextChatPatch
{
    [HarmonyPatch("ChatMessageSend")]
    [HarmonyPrefix]
    public static void ChatMessageSendPatch(PlayerAvatar __instance,ref string _message, ref bool _debugMessage)
    {
        _message = "ya loh bez voicechata";
    }
}
