// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SandItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Sand")]
[LocDescription("High quality sand is a sought after resource used for making glass and concrete. Though desert sand is abundant, it is not suitable for these materials.")]
[Eco.Gameplay.Items.Weight(20000)]
[Eco.Gameplay.Items.MaxStackSize(10)]
[RequiresTool(typeof (ShovelItem))]
[StartsDiscovered]
[Tag("Diggable")]
[Tag("Excavatable")]
[Ecopedia("Natural Resources", "Blocks", true, true, null)]
public class SandItem : BlockItem<SandBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }
}
