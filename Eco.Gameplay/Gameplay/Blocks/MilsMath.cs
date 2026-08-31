// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.MilsMath
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Blocks;

/// <summary>Fixed-point integer arithmetic for the compositions carried by a <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" />, and for the machines that consume and
/// produce them. All quantities are in <em>mils</em> (1000 mils = 1 unit) so material conservation is exact — floats would drift.</summary>
public static class MilsMath
{
  public const int UnitMils = 1000;

  /// <summary>Slices exactly one whole unit out of <paramref name="materials" />, or the full <paramref name="totalMils" /> if smaller.</summary>
  public static Dictionary<Type, int> SliceOneUnit(
    IReadOnlyDictionary<Type, int> materials,
    int totalMils);

  /// <summary>Allocates per-material mils for a stack-split. Returns each material's <c>(TotalMils, MovedMils)</c>; RemainMils = TotalMils − MovedMils.
  /// Biases small materials to leave the stack: rounding ceiling lands on the moved side, and the global excess trim is taken from
  /// the largest moved contributors (opposite of <see cref="M:Eco.Gameplay.Blocks.MilsMath.DistributeByLargestRemainder(System.Collections.Generic.IReadOnlyDictionary{System.Type,System.Int32},System.Int32)" />'s bias).</summary>
  public static Dictionary<Type, (int TotalMils, int MovedMils)> AllocateForStackSplit(
    IReadOnlyDictionary<Type, float> perUnitRepartition,
    int movedCount,
    int totalCount);

  /// <summary>Hamilton's method on integer weights: distributes <paramref name="target" /> across the keys of <paramref name="weights" />
  /// so shares sum to exactly <paramref name="target" />. Leftover from floors goes to the largest fractional remainders; ties broken by key Name.</summary>
  public static Dictionary<Type, int> DistributeByLargestRemainder(
    IReadOnlyDictionary<Type, int> weights,
    int target);

  /// <summary>Hamilton's method on float weights. Weights are normalised by their sum, so the shares always add up to exactly
  /// <paramref name="target" /> — a composition that doesn't quite sum to 1 (float drift) still yields a whole unit rather than losing the difference.</summary>
  public static Dictionary<Type, int> DistributeByLargestRemainder(
    IReadOnlyDictionary<Type, float> weights,
    int target);
}
