// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SmallHangingAshlarGneissSignItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
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
[LocDisplayName("Small Hanging Ashlar Gneiss Sign")]
[LocDescription("A small sign for all of your smaller text needs!")]
[Ecopedia("Crafted Objects", "Signs", true, true, null)]
[Eco.Gameplay.Items.Weight(1000)]
[SalvageCost(new object[] {typeof (IronScrap), 0.4f, typeof (StoneRubble), 3.2f})]
public class SmallHangingAshlarGneissSignItem : 
  WorldObjectItem<SmallHangingAshlarGneissSignObject>,
  IPersistentData
{
  protected override OccupancyContext GetOccupancyContext { get; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
