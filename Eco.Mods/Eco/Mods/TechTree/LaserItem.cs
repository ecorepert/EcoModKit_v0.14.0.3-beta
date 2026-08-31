// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LaserItem
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
[LocDisplayName("Laser")]
[LocDescription("AVOID DIRECT EYE EXPOSURE")]
[IconGroup("World Object Minimap")]
[Ecopedia("Crafted Objects", "Specialty", true, true, null)]
[Eco.Gameplay.Items.Weight(10000)]
[SalvageCost(new object[] {typeof (ChemicalWaste), 4f, typeof (CopperScrap), 25f, typeof (ElectronicScrap), 2f, typeof (GlassScrap), 16f, typeof (GoldScrap), 30f, typeof (IronScrap), 30f, typeof (PlasticScrap), 4f})]
public class LaserItem : WorldObjectItem<LaserObject>
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 7, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerConsumptionTooltip();
}
