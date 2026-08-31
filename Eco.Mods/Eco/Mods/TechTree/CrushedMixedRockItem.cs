// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CrushedMixedRockItem
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
[LocDisplayName("Crushed Mixed Rock")]
[LocDescription("A mixture of rocks that can be used in a variety of recipes or simply as landfill.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(26000)]
[Ecopedia("Blocks", "Processed Rock", true, true, null)]
[Tag("CrushedRock")]
[Tag("Excavatable")]
[RequiresTool(typeof (ShovelItem))]
public class CrushedMixedRockItem : BlockItem<CrushedMixedRockBlock>
{
  public override bool CanStickToWalls { get; }
}
