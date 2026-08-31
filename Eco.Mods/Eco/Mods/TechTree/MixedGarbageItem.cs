// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MixedGarbageItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Garbage;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Mixed Garbage")]
[LocDescription("A pile of mixed garbage that needs to be sorted. Could pollute depending on what is inside it.")]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.MaxStackSize(20)]
[RequiresTool(typeof (ShovelItem))]
[Tag("Diggable")]
[Tag("Excavatable")]
[Tag("Garbage")]
[Ecopedia("Blocks", "Byproducts", true, true, null)]
public class MixedGarbageItem : WasteBlockItem<MixedGarbageBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
