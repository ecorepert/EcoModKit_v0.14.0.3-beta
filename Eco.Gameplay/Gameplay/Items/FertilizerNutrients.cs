// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.FertilizerNutrients
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Holds information about the nutrient levels in a fertilizer item (each item has different values).</summary>
public struct FertilizerNutrients
{
  public FertilizerNutrients();

  public FertilizerNutrients(float nitrogen, float phosphorus, float potassium);

  public LocString Description();

  /// <summary>Applies nutrients directly to the world layers and triggers sync to clients via Modify().
  /// Bypasses the AccumulatingPuller for immediate feedback — safe because game actions and layer ticks run on the same thread sequentially.</summary>
  public void ApplyNutrientsDirect(Vector2i worldPos, float multiplier = 1f);

  /// <summary>Reads the current value of a nutrient layer at a position (0-1 density).</summary>
  public static float ReadLayerValue(string layerName, Vector2i worldPos);
}
