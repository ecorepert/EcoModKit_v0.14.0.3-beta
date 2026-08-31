// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.AshlarBasaltItem
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
[LocDisplayName("Ashlar Basalt")]
[LocDescription("Ashlar is finely cut stone made by an expert mason. Ashlar stone is an especially decorative building material that comes in a variety of styles based on the type of rock used.")]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Eco.Gameplay.Items.Weight(10000)]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (StoneRubble), 0.4f, typeof (IronScrap), 0.05f})]
[Tag("AshlarStone")]
[Tag("Constructable")]
[Eco.Gameplay.Items.Tier(5f, true)]
public class AshlarBasaltItem : BlockItem<AshlarBasaltBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
