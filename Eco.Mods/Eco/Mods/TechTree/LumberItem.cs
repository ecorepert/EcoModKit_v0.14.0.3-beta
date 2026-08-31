// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LumberItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Lumber")]
[LocDescription("Can be fashioned into various usable equipment.")]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.Fuel(4000f)]
[Tag("Fuel")]
[Eco.Gameplay.Items.ResourcePile]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (WoodScrap), 0.15f, typeof (BioResidue), 0.05f, typeof (IronScrap), 0.05f})]
[Tag("Lumber")]
[Tag("Burnable Fuel")]
[Tag("Constructable")]
[Eco.Gameplay.Items.Tier(3f, true)]
public class LumberItem : BlockItem<LumberBlock>
{
  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
