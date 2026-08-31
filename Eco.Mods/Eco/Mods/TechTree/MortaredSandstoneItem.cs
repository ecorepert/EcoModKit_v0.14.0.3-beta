// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MortaredSandstoneItem
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
[LocDisplayName("Mortared Sandstone")]
[LocDescription("Used to create tough but rudimentary buildings.")]
[Eco.Gameplay.Items.MaxStackSize(15)]
[Eco.Gameplay.Items.Weight(10000)]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (StoneRubble), 0.25f})]
[Tag("MortaredStone")]
[Tag("Constructable")]
[Eco.Gameplay.Items.Tier(2f, true)]
public class MortaredSandstoneItem : BlockItem<MortaredSandstoneBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
