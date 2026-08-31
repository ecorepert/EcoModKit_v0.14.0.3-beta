// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.HeavyMineralPollutantItem
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
[LocDisplayName("Heavy Mineral Pollutant")]
[LocDescription("A concentrated source of pollutants from heavy industry ? leached metals and degraded tailings. Severely contaminates the ground; isolate or bury it far from inhabited areas.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(15000)]
[Ecopedia("Blocks", "Byproducts", true, true, null)]
[Tag("Excavatable")]
[Tag("Garbage")]
[RequiresTool(typeof (ShovelItem))]
public class HeavyMineralPollutantItem : BlockItem<HeavyMineralPollutantBlock>
{
  public override bool CanStickToWalls { get; }
}
