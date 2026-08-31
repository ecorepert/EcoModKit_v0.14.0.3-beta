// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.WasteBlockItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Blocks;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>A <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" /> whose composition is made of <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" />s — the mixed garbage, family and residual blocks
/// the recycling chain passes around. On top of the composition it carries the pollution grace clock: a fractional block only knows what it is made of,
/// it is this layer that knows the mix is <em>waste</em> and that waste eventually pollutes the ground.</summary>
[Serialized]
public abstract class WasteBlockItem : FractionalBlockItem, IAgingWaste
{
  [Serialized]
  public double CreatedAtSeconds { get; set; }

  public virtual float PollutionGraceDays { get; }

  public float AgeDays { get; }

  public bool IsPolluting { get; }

  /// <summary>Split halves keep the parent's age; a genuine merge re-blends it in <see cref="M:Eco.Gameplay.Garbage.WasteBlockItem.Merge(Eco.Gameplay.Items.Item,System.Int32,System.Int32)" />.</summary>
  public override Item Clone();

  /// <summary>Merges the compositions as usual, then blends the two stacks' pollution clocks by count so the merged stack ages as the mean of its parts.</summary>
  public override Item Merge(Item mergingInto, int thisCount, int otherCount);
}
