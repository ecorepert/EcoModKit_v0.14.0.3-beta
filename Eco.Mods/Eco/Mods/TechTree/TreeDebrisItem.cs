// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TreeDebrisItem
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
[LocDisplayName("Tree Debris")]
[LocDescription("Clear cut debris that needs to be broken down to be more usable.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[System.ComponentModel.Category("Hidden")]
[StartsDiscovered]
[Ecopedia("Blocks", "Byproducts", true, true, null)]
public class TreeDebrisItem : BlockItem<TreeDebrisBlock>
{
}
