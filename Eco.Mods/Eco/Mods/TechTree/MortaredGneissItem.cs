// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MortaredGneissItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Mortared Gneiss")]
[LocDescription("Used to create tough but rudimentary buildings.")]
[Eco.Gameplay.Items.MaxStackSize(15)]
[Eco.Gameplay.Items.Weight(10000)]
[System.ComponentModel.Category("Hidden")]
[NoIcon]
[SalvageCost(new object[] {typeof (StoneRubble), 0.25f})]
public class MortaredGneissItem : BlockItem<MortaredGneissBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
