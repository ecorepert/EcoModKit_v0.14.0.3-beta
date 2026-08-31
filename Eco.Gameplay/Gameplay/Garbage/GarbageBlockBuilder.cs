// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageBlockBuilder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Garbage;

/// <summary>Picks the single item that represents one whole unit of a garbage composition, choosing the most "sorted"
/// form the mix justifies. This is what drives the visible garbage-sorting progression the player works through:
///   • one material only               → that material's pure output (e.g. just iron → IronScrap), fully sorted.
///   • several materials, one category  → that family's MixedXxx item (e.g. all metals → MixedMetalScrap), the level-1 sorter result.
///   • only residuals                   → MixedResiduals, the same block a sorter's sink emits, for the Residuals Sorter to split.
///   • materials from many categories   → the generic MixedGarbage, raw unsorted waste.
/// Residuals (pollutants, compost, bio residue, trash — see <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.IsResidual" />) are terminal leftovers, not a
/// sortable input, so they ride along in the composition but get no say in the tier: a metal mix contaminated with some residual is
/// still MixedMetalScrap. Only when the mix is nothing *but* residuals do they decide, and a single one keeps its pure output.
/// As garbage is run through sorters its composition narrows (fewer materials, eventually a single category/material), so the
/// same builder naturally "upgrades" what it produces from generic → category → pure. The category and generic forms are
/// fractional blocks that remember their exact mix (so a downstream sorter can keep separating them); pure forms are plain
/// blocks — 100% one material, nothing left to track.</summary>
public static class GarbageBlockBuilder
{
  public static 
  #nullable disable
  Item ConferFreshness(Item item);

  /// <summary>The residuals sink always emits one MixedResiduals fractional block carrying the exact residual mix — even a
  /// single-material slice — so the sink's output is uniform (never a loose pure residual) and only the Residuals Sorter
  /// separates it back into pure residuals.</summary>
  public static Item CreateResidualsBlock(IReadOnlyDictionary<Type, int> mils);

  /// <inheritdoc cref="M:Eco.Gameplay.Garbage.GarbageBlockBuilder.CreateResidualsBlock(System.Collections.Generic.IReadOnlyDictionary{System.Type,System.Int32})" />
  public static Item CreateResidualsBlock(IReadOnlyDictionary<Type, float> perUnit);

  /// <summary>Mils-based entry point (composition stored as integer mils for exact conservation). Sum should be approximately
  /// <see cref="F:Eco.Gameplay.Blocks.MilsMath.UnitMils" /> (one whole unit). Converts to per-unit fractions and defers to the float overload.</summary>
  public static Item CreateBlockForComposition(IReadOnlyDictionary<Type, int> mils);

  /// <summary>Float entry point. Composition expressed as per-unit fractions (sum ≈ 1). Walks the sorting ladder
  /// most-refined-first: pure single material, then single-category mix, then the generic fallback.</summary>
  public static Item CreateBlockForComposition(IReadOnlyDictionary<Type, float> composition);
}
