// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.FractionalBlockItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Blocks;

/// <summary>Inventory item carrying a fractional composition in <see cref="P:Eco.Gameplay.Blocks.FractionalBlockItem.InternalRepartition" />: a mix of materials rather than a single one.
/// Stackable: when stacks are split or merged the repartition is redistributed so that total absolute quantities are conserved.
/// On placement, the repartition is transferred to the corresponding <see cref="T:Eco.Gameplay.Blocks.FractionalBlock" /> in the world.
/// This is the composition mechanism only — what the materials <em>are</em> (and what they do once in the world) is up to whoever fills it in.</summary>
[Serialized]
public abstract class FractionalBlockItem : BlockItem
{
  /// <summary>Per-unit composition of this item. Each key identifies a material, its value is that material's per-unit quantity.
  /// When a stack of N items exists, the total absolute quantity of material M is <c>InternalRepartition[M] * N</c>.
  /// [ThreadSafe]: mutated only under inventory lock (merge/split) or on fresh instances; reads during tooltip display are on a stable snapshot.
  /// NOT [SyncToView] — the material types are not registered as ViewClassInfo, so BSON would serialize the Type keys as null (causing
  /// ArgumentNullException on the client at Dictionary.Add). Tooltips render the breakdown server-side and push it to the client as a formatted LocString.</summary>
  [Serialized]
  [Notify]
  [ThreadSafe]
  public Dictionary<Type, float> InternalRepartition { get; set; }

  public override bool IsStackable { get; }

  /// <summary>Deep-clones the item, producing an independent copy with its own repartition dictionary.</summary>
  public override Item Clone();

  /// <summary>Splits per-unit repartition when a stack is divided into two halves. Mils allocation is delegated to
  /// <see cref="M:Eco.Gameplay.Blocks.MilsMath.AllocateForStackSplit(System.Collections.Generic.IReadOnlyDictionary{System.Type,System.Single},System.Int32,System.Int32)" /> (rare-materials-leave-first bias); this method only handles the
  /// per-unit conversion and applies the result to the cloned items.</summary>
  public override (Item Moved, Item Remaining) SplitItem(int movedCount, int remainingCount);

  /// <summary>Returns how many units the given stacked block type represents, based on its index in the item's BlockTypes array.
  /// For non-stacked items (single BlockType in array), returns 1 when matching. Returns 0 if the type isn't in this item's stack.</summary>
  public int GetBlockUnitCount(Type blockType);

  /// <summary>Absorbs an existing <see cref="T:Eco.Gameplay.Blocks.FractionalBlock" />'s per-unit repartition into this item (which represents 1 unit).
  /// Produces a merged per-unit repartition for the resulting stack of <paramref name="existingUnits" /> + 1 units, conserving
  /// absolute material quantities. Called during stacking placement so the existing block's contents aren't overwritten.</summary>
  public void MergeFromExistingBlock(IReadOnlyDictionary<Type, float> existing, int existingUnits);

  /// <summary>Merges two fractional items by summing their absolute quantities (perUnit * stackSize) across all sub-materials,
  /// then redistributing per-unit over the combined stack size. Writes the result into <paramref name="mergingInto" />.</summary>
  public override Item Merge(Item mergingInto, int thisCount, int otherCount);
}
