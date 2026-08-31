// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageTooltipUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Garbage;

/// <summary>Shared formatting for mixed-garbage compositions (material type -&gt; mils). Used by any component that holds
/// accumulating garbage and wants to show its current contents in a hover tooltip (recycler output, sorters, ...).</summary>
public static class GarbageTooltipUtils
{
  /// <summary>Per-material breakdown of a composition: a fixed-width percentage column then the material, so rows stay aligned
  /// regardless of digit count. Returns "Empty" when nothing is held.</summary>
  public static LocString FormatComposition(
  #nullable disable
  IReadOnlyDictionary<Type, int> mils);

  /// <summary>A garbage amount expressed in blocks (1 = one full MixedGarbageBlock): a percentage while under one block, a block count at or above it,
  /// so a big craft reads as "2.5 blocks" instead of "250%". Mirrors what the crafting UI shows on a garbage output slot.</summary>
  public static LocString BlockAmount(float blocks);

  /// <summary>Bare block amount for aligned quantity columns: a percentage under one block ("40%"), a block count at or above it ("x4", "x2.5").</summary>
  public static string CompactBlockAmount(float blocks);

  /// <summary>A hoverable icon+name link for a garbage material (its sorted output item when known, else the raw material name).</summary>
  public static LocString MaterialLabel(Type materialType);

  /// <summary>Icon for a garbage material: its sorted output item's icon when known, else the generic garbage icon. The material classes themselves have no sprites.</summary>
  public static string MaterialIconName(Type materialType);

  /// <summary>Display name for a garbage material: its sorted output item's name when known, else the raw class name.</summary>
  public static LocString MaterialDisplayName(Type materialType);

  /// <summary>Every material a fractional block of <paramref name="itemType" /> can hold, for the item template (an instance shows its real composition instead).
  /// A family block (e.g. MixedMetalScrap) lists that family's materials; the generic mixed garbage owns no family, so it lists them all. Sortable families also
  /// carry residuals as contamination, which is called out rather than listed material by material.</summary>
  public static LocString PossibleContents(Type itemType);
}
