// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.IndustrialElevatorItem
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
[LocDisplayName("Industrial Elevator")]
[LocDescription("An industrial elevator for transporting extra large loads vertically. It requires a 6x10 vertical shaft to function.")]
[IconGroup("World Object Minimap")]
[Eco.Gameplay.Items.Weight(25000)]
[SalvageCost(new object[] {typeof (IronScrap), 8f, typeof (CopperScrap), 4f, typeof (ChemicalWaste), 0.5f})]
[Ecopedia("Crafted Objects", "Specialty", true, true, null)]
public class IndustrialElevatorItem : WorldObjectItem<IndustrialElevatorObject>, IPersistentData
{
  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }

  protected override OccupancyContext GetOccupancyContext { get; }
}
