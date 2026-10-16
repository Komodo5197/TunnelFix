using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using System.Reflection;

[assembly: MelonInfo(typeof(TunnelFix.Core), "TunnelFix", "1.0.0", "Komodo5197", null)]
[assembly: MelonGame("Hadoque", "Ultros")]

namespace TunnelFix
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }

        public static RoomManager mapPrepArea;
    }

    [HarmonyPatch(typeof(RoomSaveManager), nameof(RoomSaveManager.LoadEggTunnels))]
    public static class Patch
    {
        private static bool Prefix()
        {
            if (Core.mapPrepArea!=null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    [HarmonyPatch(typeof(MapGUI), nameof(MapGUI.PrepWorldMap))]
    public static class Patch2
    {
        private static void Prefix(RoomManager r)
        {
            Core.mapPrepArea = r;
        }

        private static void Postfix()
        {
            Core.mapPrepArea = null;
        }
    }

   /* [HarmonyPatch(typeof(Il2CppBitwave_Scripts.AreaRoomManager), "get_ActiveAreaID")]
    public static class Patch3
    {
        private static bool Prefix(ref RoomManager.AreaName __result)
        {
            if (Core.mapPrepArea != null)
            {
                MelonLogger.Msg("overriding tunnel area id to "+Core.mapPrepArea.areaID);
                __result = Core.mapPrepArea.areaID;
                return false;
            }
            else
            {
                return true;
            }
        }
    }*/
}

