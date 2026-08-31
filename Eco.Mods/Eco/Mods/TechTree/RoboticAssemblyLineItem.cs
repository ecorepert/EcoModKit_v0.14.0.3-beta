// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.RoboticAssemblyLineItem
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
[LocDisplayName("Robotic Assembly Line")]
[LocDescription("A complex set of machinery for creating equally complex things.")]
[IconGroup("World Object Minimap")]
[Ecopedia("Work Stations", "Craft Tables", true, true, null)]
[Eco.Gameplay.Items.Weight(10000)]
[SalvageCost(new object[] {typeof (CeramicScrap), 3f, typeof (CopperScrap), 4f, typeof (ElectronicScrap), 3f, typeof (GlassScrap), 0.8f, typeof (IronScrap), 8f, typeof (PlasticScrap), 4f, typeof (StoneRubble), 1.5f})]
[IgnorePowerModules]
[AllowPluginModules(ItemTypes = new Type[] {typeof (IndustryUpgradeItem), typeof (ElectronicsUpgradeItem), typeof (BasicUpgradeItem), typeof (AdvancedUpgradeItem), typeof (ModernUpgradeItem)})]
public class RoboticAssemblyLineItem : WorldObjectItem<RoboticAssemblyLineObject>, IPersistentData
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 7, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerConsumptionTooltip();

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
