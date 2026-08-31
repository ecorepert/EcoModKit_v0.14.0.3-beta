// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WashingMachineItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

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
[LocDisplayName("Washing Machine")]
[LocDescription("Why hand scrub your clothes on a washboard when you could throw them into this magical cleaning machine?")]
[Ecopedia("Housing Objects", "Bathroom", true, true, null)]
[Tag("Housing")]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (CopperScrap), 1.8f, typeof (GlassScrap), 0.4f, typeof (GoldScrap), 1.2f, typeof (IronScrap), 2.4f})]
public class WashingMachineItem : WorldObjectItem<WashingMachineObject>
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 7, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerConsumptionTooltip();
}
