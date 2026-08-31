// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PoweredCartItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Powered Cart")]
[LocDescription("Large cart for hauling sizable loads.")]
[IconGroup("World Object Minimap")]
[Eco.Gameplay.Items.Weight(15000)]
[SalvageCost(new object[] {typeof (WoodScrap), 5f, typeof (IronScrap), 3f, typeof (Textiles), 2f, typeof (BioResidue), 0.4f})]
[AirPollution(0.1f)]
[Ecopedia("Crafted Objects", "Vehicles", true, true, null)]
public class PoweredCartItem : WorldObjectItem<PoweredCartObject>, IPersistentData
{
  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
