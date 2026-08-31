// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.WastePollutionAging
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Garbage;

public static class WastePollutionAging
{
  public static float AgeDays(double createdAtSeconds, double nowSeconds);

  public static bool IsPolluting(double createdAtSeconds, double nowSeconds, float graceDays);

  public static double BlendCreatedSeconds(
    double aSeconds,
    int aCount,
    double bSeconds,
    int bCount);

  public static double EffectiveForBlend(
    double createdAtSeconds,
    double nowSeconds,
    double graceSeconds);
}
