// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PetroleumItem
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
[LocDisplayName("Petroleum")]
[LocDescription("A fossil fuel essential for manufacturing gasoline, plastics, and asphalt. Its extraction, transport, and burning all have environmental impacts.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(10000)]
[Ecopedia("Blocks", "Liquids", true, true, null)]
[SalvageCost(new object[] {typeof (IronScrap), 0.3f, typeof (ChemicalPollutant), 0.1f})]
public class PetroleumItem : BlockItem<PetroleumBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }
}
