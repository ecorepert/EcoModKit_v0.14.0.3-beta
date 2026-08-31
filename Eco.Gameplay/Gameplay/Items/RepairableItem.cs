// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.RepairableItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Represents an Item that can be repaired and is affected on usage, See DurabilityItems.md </summary>
[Serialized]
public abstract class RepairableItem : DurabilityItem
{
  public override float DurabilityPercent { get; }

  [SyncToView(null, true)]
  public override bool CanBeUsedInCraftWithoutFullDurability { get; }

  /// <summary> Durability for <see cref="T:Eco.Gameplay.Items.RepairableItem" /> uses a value from 0 to <see cref="P:Eco.Gameplay.Items.DurabilityItem.OriginalMaxDurability" /> and is based on <see cref="F:Eco.Gameplay.Items.RepairableItem.durability" /> </summary>
  [Serialized]
  [Notify]
  public float Durability { get; set; }

  public virtual float DefaultMinRequiredIntegrityInTradeOffers { get; }

  /// <summary>The current max durability, which may have been reduced from previous repairs.</summary>
  [Serialized]
  [Notify]
  public float IntegrityAmount { get; set; }

  /// <summary>Determines how much the max durability has been reduced, due to past repairs.</summary>
  [DependsOnMember("IntegrityAmount")]
  [SyncToView(null, true)]
  public float IntegrityPercent { get; }

  /// <summary>When an item is repaired, its max durability is reduced by this many percentage points (the reduction is prorated based on how much repair was applied,
  /// so you dont need to wait till its almost broken to apply). This will be summed with the repair penalty of the repairing item as well (so either can be negative to give a reduction).</summary>
  public virtual float RepairPenaltyToDurability { get; }

  /// <summary> The amount needed for to fully repair a broken item.</summary>
  public abstract IDynamicValue SkilledRepairCost { get; }

  /// <summary> Template for the repaired item needed, cost is calculated based on missing durability. </summary>
  public virtual Item RepairItem { get; }

  /// <summary>For objects that can have multiple items repair them, return them all here.</summary>
  public virtual IEnumerable<RepairingItem> RepairItems { get; }

  public override int RepresentativeHash();

  public bool MaterialRepairsItem(Type itemType);

  public override bool CanStack(Item other);

  /// <summary>Merging two near-broken parts (see CanStack) breaks the stack fully; any other combination averages durability and integrity,
  /// weighted by count. Callers should still gate on CanStack — averaging is the safe fallback for paths that merge by type.</summary>
  public override Item Merge(Item mergingInto, int thisCount, int otherCount);

  /// <summary> The repair tag needed, used if <see cref="P:Eco.Gameplay.Items.RepairableItem.RepairItem" /> is null, this is for cases where multiple items can repair this item. </summary>
  public virtual Tag RepairTag { get; }

  /// <summary> Show Proper UI Link for the cost needed to repair this item. </summary>
  public string DescribeRepairCost(User user, bool shortText);

  [SyncToView(null, true)]
  public bool CanBeRepaired { get; }

  public virtual int FullRepairAmount { get; }

  /// <summary> The Skills required to repair this item. </summary>
  public RepairRequiresSkillAttribute[] SkillReqs { get; }

  /// <summary> Calculates the repair cost for the item based on DurabilityPercent&gt; </summary>
  public int RepairCost(User user, float materialMult = 1f);

  /// <summary> Applies durability changes when the item is used. </summary>
  public virtual void UseDurability(float amountToConsume, Player player, bool notify = true);

  public override int GetQualityGroup();

  public override Item Clone();

  /// <summary> Get the current durability of the item. </summary>
  public override float GetDurability();

  public override void SetDurability(float d);

  public override float PercentBrokenFromOriginal { get; }
}
