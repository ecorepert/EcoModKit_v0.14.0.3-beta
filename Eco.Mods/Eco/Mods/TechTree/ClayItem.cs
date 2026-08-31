// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ClayItem
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
[LocDisplayName("Clay")]
[LocDescription("A very fine grained deposit of weathered bits of rock. Plastic when wet and brittle when dry, clay is impermeable to many liquids and useful for many industrial and environmental purposes.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(22000)]
[Ecopedia("Natural Resources", "Blocks", true, true, null)]
[SalvageCost(new object[] {typeof (CeramicScrap), 1f})]
[Tag("Excavatable")]
[RequiresTool(typeof (ShovelItem))]
public class ClayItem : BlockItem<ClayBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }
}
