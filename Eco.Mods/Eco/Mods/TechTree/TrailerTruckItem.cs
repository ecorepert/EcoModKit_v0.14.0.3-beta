// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TrailerTruckItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Trailer Truck")]
[LocDescription("Modern truck for hauling sizable loads.")]
[IconGroup("World Object Minimap")]
[Eco.Gameplay.Items.Weight(25000)]
[SalvageCost(new object[] {typeof (IronScrap), 8f, typeof (Textiles), 1.2f, typeof (CopperScrap), 4f, typeof (ChemicalWaste), 2f})]
[System.ComponentModel.Category("Hidden")]
[AirPollution(0.5f)]
public class TrailerTruckItem : WorldObjectItem<TrailerTruckObject>, IPersistentData
{
  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
