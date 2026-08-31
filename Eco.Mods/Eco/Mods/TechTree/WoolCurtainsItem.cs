// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WoolCurtainsItem
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
[LocDisplayName("Wool Curtains")]
[LocDescription("Curtains woven using the finest wool. \n\n (Only cosmetic does not impact room value.)")]
[Eco.Gameplay.Items.MaxStackSize(20)]
[Eco.Gameplay.Items.Weight(5000)]
[Ecopedia("Blocks", "Building Materials", true, true, null)]
[SalvageCost(new object[] {typeof (Textiles), 0})]
[Tag("Constructable")]
public class WoolCurtainsItem : BlockItem<WoolCurtainsBlock>
{
  public override LocString DisplayNamePlural { get; }

  public override bool IgnoreRooms { get; }

  public override Type[] BlockTypes { get; }
}
