// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LaboratoryItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Laboratory")]
[LocDescription("For more advanced research and manufacturing. Science rules!")]
[IconGroup("World Object Minimap")]
[Ecopedia("Work Stations", "Researching", true, true, null)]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (BioResidue), 2f, typeof (IronScrap), 4f})]
[AllowPluginModules(ItemTypes = new Type[] {typeof (CuttingEdgeCookingUpgradeItem), typeof (BasicUpgradeItem), typeof (AdvancedUpgradeItem), typeof (ModernUpgradeItem)})]
public class LaboratoryItem : WorldObjectItem<LaboratoryObject>, IPersistentData
{
  protected override OccupancyContext GetOccupancyContext { get; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
