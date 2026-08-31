// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GardenGravelItem
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
[LocDisplayName("Garden Gravel")]
[LocDescription("An unexpected surprise of peace and quiet in the rush for survival..")]
[Eco.Gameplay.Items.MaxStackSize(15)]
[Eco.Gameplay.Items.Weight(26000)]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (StoneRubble), 1f})]
[Tag("Constructable")]
public class GardenGravelItem : BlockItem<GardenGravelBlock>
{
  public override Type[] BlockTypes { get; }
}
