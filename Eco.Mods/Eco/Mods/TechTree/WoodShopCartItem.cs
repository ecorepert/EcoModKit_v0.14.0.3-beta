// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WoodShopCartItem
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
[LocDisplayName("Wood Shop Cart")]
[LocDescription("A store in a wooden cart, very useful when your customers are far away.")]
[IconGroup("World Object Minimap")]
[Eco.Gameplay.Items.Weight(10000)]
[SalvageCost(new object[] {typeof (WoodScrap), 4f, typeof (Textiles), 1f})]
[Ecopedia("Crafted Objects", "Vehicles", true, true, null)]
public class WoodShopCartItem : WorldObjectItem<WoodShopCartObject>, IPersistentData
{
  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object PersistentData { get; set; }
}
