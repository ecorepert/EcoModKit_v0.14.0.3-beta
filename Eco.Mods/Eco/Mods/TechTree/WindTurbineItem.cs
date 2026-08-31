// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WindTurbineItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Wind Turbine")]
[LocDescription("Uses wind to produce electrical power. Requires clear space for 10 blocks in front of the blades for full power generation. Gains a small output boost when placed at higher elevations.")]
[IconGroup("World Object Minimap")]
[Ecopedia("Crafted Objects", "Power Generation", true, true, null)]
[Eco.Gameplay.Items.Weight(10000)]
[SalvageCost(new object[] {typeof (ChemicalWaste), 0.4f, typeof (CopperScrap), 3.2f, typeof (ElectronicScrap), 8f, typeof (GlassScrap), 1.6f, typeof (GoldScrap), 2f, typeof (IronScrap), 28f, typeof (PlasticScrap), 16.8f})]
public class WindTurbineItem : WorldObjectItem<WindTurbineObject>, IPersistentData
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 8, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerProductionTooltip();

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
