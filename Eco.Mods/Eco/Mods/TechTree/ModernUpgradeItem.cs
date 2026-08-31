// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ModernUpgradeItem
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
[LocDisplayName("Modern Upgrade")]
[LocDescription("Modern Upgrade with great efficiency increase.")]
[Eco.Gameplay.Items.Weight(1000)]
[SalvageCost(new object[] {typeof (Trash), 1f})]
[Ecopedia("Upgrade Modules", "Modern Upgrades", true, true, null)]
[Tag("Upgrade")]
[Tag("ModernModule")]
public class ModernUpgradeItem : EfficiencyModule
{
  public override LocString DisplayNamePlural { get; }

  public override float PowerConsumption { get; }

  public override ModulePowerType PowerType { get; }

  public override IEnumerable<Bonus> Bonuses { get; }
}
