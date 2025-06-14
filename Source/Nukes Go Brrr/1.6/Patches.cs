using HarmonyLib;
using Rimatomics;
using Verse;

namespace NukesGoBrrr;

[StaticConstructorOnStartup]
public static class Patches
{
    static Patches()
    {
        Harmony harmony = new("NachoToast.RimatomicsNukesGoBrrr");

        harmony.Patch(
            original: AccessTools.PropertyGetter(
                type: typeof(WorldObject_Missile),
                name: "TraveledPctStepPerTick"),
            postfix: new HarmonyMethod(
                methodType: typeof(Patches),
                methodName: nameof(TraveledPctStepPerTick_Postfix)));
    }

    private static void TraveledPctStepPerTick_Postfix(WorldObject_Missile __instance, ref float __result)
    {
        if (__instance is not WorldObject_ICBMfission)
        {
            return;
        }

        if (ThisDefOf.RimatomicsNukesGoBrrr_SPM3.IsFinished)
        {
            __result *= 20f;
        }
    }
}
