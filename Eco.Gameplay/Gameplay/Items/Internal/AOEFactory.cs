// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Internal.AOEFactory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable enable
namespace Eco.Gameplay.Items.Internal;

public static class AOEFactory
{
  public static AreaOfEffectMode Make(
    string mode,
    bool requireCentralBlock,
    string areaBlocks,
    float initialConeRadius,
    float finalConeRadius,
    float coneLength);
}
