// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SaguaroRibItem
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
[LocDisplayName("Saguaro Rib")]
[LocDescription("Saguaro rib is a basic, lightweight wood harvested from the saguaro cactus.")]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.Fuel(4000f)]
[Tag("Fuel")]
[Ecopedia("Natural Resources", "Logs", true, true, null)]
[SalvageCost(new object[] {typeof (BioResidue), 0.25f})]
[Tag("Wood")]
[Tag("Burnable Fuel")]
public class SaguaroRibItem : BlockItem<SaguaroRibBlock>
{
  public override bool CanStickToWalls { get; }

  public override Type[] BlockTypes { get; }
}
