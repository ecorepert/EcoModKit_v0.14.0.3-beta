// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WasteFilterItem
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
[LocDisplayName("Waste Filter")]
[LocDescription("Treats raw sewage.")]
[IconGroup("World Object Minimap")]
[Ecopedia("Waste Management", "Treatment", true, true, null)]
[Eco.Gameplay.Items.Weight(5000)]
[SalvageCost(new object[] {typeof (BioResidue), 0.4f, typeof (CeramicScrap), 0.8f, typeof (CopperScrap), 0.8f, typeof (GoldScrap), 0.8f, typeof (IronScrap), 18.4f, typeof (StoneRubble), 0.4f})]
public class WasteFilterItem : WorldObjectItem<WasteFilterObject>, IPersistentData
{
  protected override OccupancyContext GetOccupancyContext { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 7, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PowerConsumptionTooltip();

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
