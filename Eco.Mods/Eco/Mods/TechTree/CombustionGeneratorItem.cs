// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CombustionGeneratorItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Pipes.Gases;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Combustion Generator")]
[LocDescription("Consumes most fuels to produce energy.")]
[IconGroup("World Object Minimap")]
[Ecopedia("Crafted Objects", "Power Generation", true, true, null)]
[LiquidProducer(typeof (SmogItem), 1.2f)]
[Eco.Gameplay.Items.Weight(5000)]
[SalvageCost(new object[] {typeof (ChemicalWaste), 1f, typeof (IronScrap), 6f})]
public class CombustionGeneratorItem : WorldObjectItem<CombustionGeneratorObject>, IPersistentData
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 7, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerConsumptionTooltip();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 8, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerProductionTooltip();

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
