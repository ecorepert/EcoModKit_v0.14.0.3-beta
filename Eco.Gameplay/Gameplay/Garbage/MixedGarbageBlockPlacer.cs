// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.MixedGarbageBlockPlacer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Blocks;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Garbage;

/// <summary>Places <see cref="T:Eco.Gameplay.Garbage.MixedGarbageBlock" /> stacks in the world from a SalvageCost-derived composition.
/// Pipeline: AccumulateBudgetFromItem/FromLiveObject feed a shared mils pool; FlushBudget pads with Trash, derives a
/// per-unit repartition, and distributes units across candidate cells via PlaceOrMerge.</summary>
public static class MixedGarbageBlockPlacer
{
  public static readonly int MaxStackedUnits;
  public static readonly int TargetUnitsPerCell;
  public static readonly int BagCapacityMils;

  /// <summary>Returns the MixedGarbageStacked{N}Block type for N ∈ [1, MaxStackedUnits], clamped.</summary>
  public static 
  #nullable disable
  Type GetStackedType(int units);

  /// <summary>Returns the unit count carried by a MixedGarbageStacked{N}Block type. 0 if the type isn't a stacked garbage block.</summary>
  public static int GetUnits(Type blockType);

  /// <summary>Raw SalvageCost mils carried by a single unit of <paramref name="itemType" /> (no efficiency, no padding). Used by the
  /// garbage-bag capacity cap. Returns 0 if the item has no <see cref="T:Eco.Gameplay.Items.SalvageCostAttribute" />.</summary>
  public static int RawDecayMilsPerUnit(Type itemType);

  /// <summary>Applies <paramref name="efficiency" /> to <paramref name="itemType" />'s <see cref="T:Eco.Gameplay.Items.SalvageCostAttribute" /> (recovered fraction stays under
  /// the original material, lost fraction goes to <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.DegradedForm" /> / Trash) and accumulates the mils into <paramref name="budget" />
  /// without padding. Returns true iff the item had a usable SalvageCost.</summary>
  public static bool AccumulateBudgetFromItem(
    Type itemType,
    float efficiency,
    int sourceUnits,
    Dictionary<Type, int> budget);

  /// <summary>Accumulates a stored <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" /> stack into <paramref name="budget" />, preserving its per-unit composition
  /// scaled by <paramref name="quantity" /> (no efficiency loss — the material is already in its final, mixed form).</summary>
  public static void AccumulateBudgetFromFractional(
    FractionalBlockItem fractional,
    int quantity,
    Dictionary<Type, int> budget);

  /// <summary>Accumulates the SalvageCost of a live WorldObject into <paramref name="budget" />: its shell (<c>CreatingItem</c>) plus every stack
  /// held by its <see cref="T:Eco.Gameplay.Objects.IInventoryWorldObjectComponent" />s. Returns true iff at least one source contributed.</summary>
  public static bool AccumulateBudgetFromLiveObject(
    WorldObject obj,
    float efficiency,
    Dictionary<Type, int> budget);

  /// <summary>Pads <paramref name="mils" /> in place with Trash to the next whole-unit multiple of <see cref="F:Eco.Gameplay.Blocks.MilsMath.UnitMils" /> and returns
  /// the padded total. Mutates <paramref name="mils" /> by design.</summary>
  public static (int TotalMils, int TotalUnits) PadToWholeUnits(Dictionary<Type, int> mils);

  /// <summary>Converts an absolute-mils composition into a per-unit repartition (each value / <paramref name="totalMils" />, summing to ≈ 1).</summary>
  public static Dictionary<Type, float> ToPerUnitRepartition(
    IReadOnlyDictionary<Type, int> mils,
    int totalMils);

  /// <summary>Pads the <paramref name="budget" />, derives a shared per-unit repartition, and distributes the units across
  /// <paramref name="candidatePositions" /> round-robin (lowest-Y first, cap <see cref="F:Eco.Gameplay.Garbage.MixedGarbageBlockPlacer.MaxStackedUnits" /> per cell). Returns the positions written.
  /// <paramref name="budget" /> is not mutated.</summary>
  public static IReadOnlyList<Vector3i> FlushBudget(
    IReadOnlyDictionary<Type, int> budget,
    IEnumerable<Vector3i> candidatePositions);

  /// <summary>Enumerates placement candidates around <paramref name="origin" />, height-preferred: the central column straight up first
  /// (natural pile extension), then the rest of the sphere ordered by descending Y with Manhattan XZ distance as the tie-breaker.
  /// Callers filter by emptiness and stop once enough cells are gathered. Shared by the explosion budget flush and the decaying-bag finalization.</summary>
  public static IEnumerable<Vector3i> EnumOverflowPositions(Vector3i origin, int maxRadius);

  /// <summary>Drops <paramref name="units" /> units of MixedGarbage at <paramref name="pos" />. If pos already contains a MixedGarbageBlock,
  /// merges as much as fits (weighted per-unit repartition) and climbs the leftover overflow to the cell above — existing garbage is never
  /// overwritten. A non-garbage block at pos is overwritten (caller's responsibility — callers pass air / fresh-garbage cells).</summary>
  public static void PlaceOrMerge(
    Vector3i pos,
    IReadOnlyDictionary<Type, float> perUnit,
    int units);

  /// <summary>Post-gravity settle + merge pass. For each garbage position, scans down through air until the first non-air cell: if it's a
  /// MixedGarbage that fits, merges into it; otherwise settles just above. Iterates until stable so blocks left floating by a merge fall too.
  /// Membership is tracked in a HashSet with deferred add/remove so a pass over hundreds of cells stays O(n log n), not O(n²).</summary>
  public static void MergeColumnsBottomUp(IEnumerable<Vector3i> garbagePositions);
}
