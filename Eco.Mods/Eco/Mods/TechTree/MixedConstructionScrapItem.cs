// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MixedConstructionScrapItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Garbage;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Mixed Construction Scrap")]
[LocDescription("Sorted construction scrap from a garbage sorting process. Contains building materials that need further processing.")]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Tag("Garbage")]
[Ecopedia("Blocks", "Byproducts", true, true, null)]
public class MixedConstructionScrapItem : WasteBlockItem<MixedConstructionScrapBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }
}
