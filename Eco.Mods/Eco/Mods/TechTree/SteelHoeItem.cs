// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SteelHoeItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Steel Hoe")]
[LocDescription("A steel hoe with improved range to help tilling larger areas.")]
[Eco.Gameplay.Items.Tier(3f, true)]
[RepairRequiresSkill(typeof (BlacksmithSkill), 0)]
[Eco.Gameplay.Items.Weight(1000)]
[SalvageCost(new object[] {typeof (WoodScrap), 0.8f, typeof (IronScrap), 6f, typeof (BioResidue), 1f, typeof (Textiles), 0.2f})]
[System.ComponentModel.Category("Tool")]
[Tag("Tool")]
[Ecopedia("Items", "Tools", true, true, null)]
public class SteelHoeItem : HoeItem, IAoeToolItem
{
  public 
  #nullable disable
  AreaOfEffectMode AreaOfEffectMode { get; }

  public override IDynamicValue CaloriesBurn { get; }

  public override IDynamicValue Damage { get; }

  public override Type ExperienceSkill { get; }

  public override IDynamicValue ExperienceRate { get; }

  public override IDynamicValue Tier { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public override float OriginalMaxDurability { get; }

  public override int FullRepairAmount { get; }

  public override IEnumerable<RepairingItem> RepairItems { get; }
}
