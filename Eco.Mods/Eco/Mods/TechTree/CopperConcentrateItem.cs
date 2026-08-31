// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CopperConcentrateItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Copper Concentrate")]
[LocDescription("Copper ore that has been concentrated to remove impurities. Ore concentrate is used by smiths to smelt metal bars.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(20000)]
[Ecopedia("Blocks", "Processed Rock", true, true, null)]
[SalvageCost(new object[] {typeof (StoneRubble), 3f})]
[Tag("ConcentratedOre")]
[Tag("Excavatable")]
[RequiresTool(typeof (ShovelItem))]
public class CopperConcentrateItem : BlockItem<CopperConcentrateBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }
}
