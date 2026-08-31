// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ChemicalPollutantItem
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
[LocDisplayName("Chemical Pollutant")]
[LocDescription("A horrid heap of toxic, ultra-polluting chemical waste. Devastates the ground around it and seeps into nearby soil and water ? contain it, or keep it as far from anything living as possible.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(15000)]
[Ecopedia("Blocks", "Byproducts", true, true, null)]
[Tag("Garbage")]
public class ChemicalPollutantItem : BlockItem<ChemicalPollutantBlock>
{
  public override bool CanStickToWalls { get; }
}
