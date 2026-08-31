// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MachinistTableItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Machinist Table")]
[LocDescription("A fancy tool bench that creates equally fancy toys.")]
[IconGroup("World Object Minimap")]
[Ecopedia("Work Stations", "Craft Tables", true, true, null)]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (IronScrap), 2.4f, typeof (WoodScrap), 1f})]
[AllowPluginModules(ItemTypes = new Type[] {typeof (MechanicsAdvancedUpgradeItem), typeof (MiningAdvancedUpgradeItem), typeof (BasicUpgradeItem), typeof (AdvancedUpgradeItem), typeof (ModernUpgradeItem)})]
public class MachinistTableItem : ModuleItem<MachinistTableObject>, IPersistentData
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
