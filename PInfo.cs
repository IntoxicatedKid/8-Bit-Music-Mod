using HarmonyLib;

namespace _8BitMusicMod
{
    public static class PInfo
    {
        // each loaded plugin needs to have a unique GUID. usually author+generalCategory+Name is good enough
        public const string GUID = "intoxicatedkid.8bitmusicmod";
        public const string Name = "8 Bit Music Mod";
        public const string version = "1.0.0";
        public static readonly Harmony harmony = new Harmony(GUID);

    }
}
