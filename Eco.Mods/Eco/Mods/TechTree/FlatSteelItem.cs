// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.FlatSteelItem
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
[LocDisplayName("Flat Steel")]
[LocDescription("Coated with a layer of epoxy, this steel refuses to rust.")]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Eco.Gameplay.Items.Weight(10000)]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (IronScrap), 0.2f, typeof (ChemicalWaste), 0.05f})]
[Tag("Constructable")]
[Eco.Gameplay.Items.Tier(5f, true)]
public class FlatSteelItem : BlockItem<FlatSteelBlock>
{
  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
