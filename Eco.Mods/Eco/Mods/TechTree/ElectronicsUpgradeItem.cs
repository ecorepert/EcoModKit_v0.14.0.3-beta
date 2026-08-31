// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ElectronicsUpgradeItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Electronics Upgrade")]
[LocDescription("Modern Upgrade that greatly increases efficiency when crafting Electronics recipes.")]
[Eco.Gameplay.Items.Weight(1)]
[SalvageCost(new object[] {typeof (Trash), 1f})]
[Ecopedia("Upgrade Modules", "Specialty Upgrades", true, true, null)]
[Tag("Upgrade")]
[Tag("SpecialtyModule")]
public class ElectronicsUpgradeItem : EfficiencyModule
{
  public override float MaterialTierBump { get; }

  public override IEnumerable<Bonus> Bonuses { get; }
}
