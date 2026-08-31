// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TinyStockpileItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Tiny Stockpile")]
[LocDescription("Designates a 2x3x2 area as storage for large items.")]
[Ecopedia("Crafted Objects", "Storage", true, true, null)]
[Eco.Gameplay.Items.Weight(500)]
[SalvageCost(new object[] {typeof (WoodScrap), 0.1f})]
public class TinyStockpileItem : WorldObjectItem<TinyStockpileObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }
}
