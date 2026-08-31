// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.HeatedDisplayCabinetItem
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
[LocDisplayName("Heated Display Cabinet")]
[LocDescription("A temperature regulated display storage.")]
[Ecopedia("Crafted Objects", "Stores", true, true, null)]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (BioResidue), 2f})]
public class HeatedDisplayCabinetItem : WorldObjectItem<HeatedDisplayCabinetObject>
{
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 50, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString UpdateTooltip();

  protected override OccupancyContext GetOccupancyContext { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 7, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerConsumptionTooltip();
}
