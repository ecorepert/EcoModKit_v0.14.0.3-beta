// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.HardwoodLumberHallwayTableItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Hardwood Lumber Hallway Table")]
[LocDescription("A smaller table for displaying different items.")]
[Ecopedia("Housing Objects", "Seating", true, true, null)]
[Tag("Housing")]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (WoodScrap), 5f, typeof (IronScrap), 0.2f})]
public class HardwoodLumberHallwayTableItem : WorldObjectItem<HardwoodLumberHallwayTableObject>
{
  public static readonly HomeFurnishingValue homeValue;

  protected override OccupancyContext GetOccupancyContext { get; }

  public override HomeFurnishingValue HomeValue { get; }
}
