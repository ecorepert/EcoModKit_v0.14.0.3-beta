// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.HewnLogItem
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
[LocDisplayName("Hewn Log")]
[LocDescription("A log hewn and shaped to be a building material. Hewing logs at a workbench will grant no experience.")]
[Eco.Gameplay.Items.MaxStackSize(15)]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.Fuel(4000f)]
[Tag("Fuel")]
[Eco.Gameplay.Items.ResourcePile]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (WoodScrap), 0.25f})]
[Tag("HewnLog")]
[Tag("Burnable Fuel")]
[Tag("Constructable")]
[Eco.Gameplay.Items.Tier(2f, true)]
public class HewnLogItem : BlockItem<HewnLogBlock>
{
  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
