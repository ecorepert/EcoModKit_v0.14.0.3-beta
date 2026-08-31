// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CrabPotItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Crab Pot")]
[LocDescription("A contraption to catch unsuspecting crabs in search of prey.")]
[IconGroup("World Object Minimap")]
[Ecopedia("Crafted Objects", "Specialty", true, true, null)]
[Eco.Gameplay.Items.Weight(500)]
[SalvageCost(new object[] {typeof (WoodScrap), 5f, typeof (BioResidue), 1f})]
public class CrabPotItem : WorldObjectItem<CrabPotObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }

  public override Type[] Blockers { get; }
}
