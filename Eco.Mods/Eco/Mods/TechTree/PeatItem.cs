// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PeatItem
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
[LocDisplayName("Peat")]
[LocDescription("A combustible organic material which can be used as fuel.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(4000)]
[Eco.Gameplay.Items.Fuel(80000f)]
[Tag("Fuel")]
[Ecopedia("Natural Resources", "Blocks", true, true, null)]
[Tag("Excavatable")]
[Tag("Burnable Fuel")]
[RequiresTool(typeof (ShovelItem))]
public class PeatItem : BlockItem<PeatBlock>
{
  public override LocString DisplayNamePlural { get; }
}
