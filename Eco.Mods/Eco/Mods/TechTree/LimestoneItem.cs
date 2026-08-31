// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LimestoneItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Limestone")]
[LocDescription("A hard rock useful for construction and industrial processes. Limestone is sedimentary, forming mostly from the fallen compacted remains of marine organisms.")]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Eco.Gameplay.Items.Weight(6500)]
[Eco.Gameplay.Items.ResourcePile]
[Ecopedia("Natural Resources", "Stone", true, true, null)]
[Currency(10000)]
[Tag("Currency")]
[SalvageCost(new object[] {typeof (StoneRubble), 0.25f})]
[Tag("Rock")]
[Tag("Excavatable")]
public class LimestoneItem : BlockItem<LimestoneBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
