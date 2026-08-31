// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CrushedCoalItem
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
[LocDisplayName("Crushed Coal")]
[LocDescription("Coal that have been crushed into a usable size.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(22000)]
[Eco.Gameplay.Items.Fuel(80000f)]
[Tag("Fuel")]
[StartsDiscovered]
[Ecopedia("Blocks", "Processed Rock", true, true, null)]
[Tag("Coal")]
[Tag("Burnable Fuel")]
[Tag("Excavatable")]
[RequiresTool(typeof (ShovelItem))]
public class CrushedCoalItem : BlockItem<CrushedCoalBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }
}
