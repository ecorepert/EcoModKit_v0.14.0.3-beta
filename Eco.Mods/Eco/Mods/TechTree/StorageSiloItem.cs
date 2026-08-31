// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.StorageSiloItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
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
[LocDisplayName("Storage Silo")]
[LocDescription("A wooden silo capable of storing extra large stacks of crops, seeds, and fertilizer. Silos are not able to store other types of materials.")]
[Ecopedia("Crafted Objects", "Storage", true, true, null)]
[Eco.Gameplay.Items.Weight(5000)]
[SalvageCost(new object[] {typeof (IronScrap), 1.6f})]
public class StorageSiloItem : WorldObjectItem<StorageSiloObject>
{
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 50, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString UpdateTooltip();

  protected override OccupancyContext GetOccupancyContext { get; }
}
