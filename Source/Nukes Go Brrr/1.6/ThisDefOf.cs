using Rimatomics;
using RimWorld;

namespace NukesGoBrrr;

[DefOf]
public static class ThisDefOf
{
    public static ResearchStepDef RimatomicsNukesGoBrrr_SPM3;

    static ThisDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThisDefOf));
    }
}
