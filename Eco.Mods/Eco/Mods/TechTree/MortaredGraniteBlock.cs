// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MortaredGraniteBlock
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Blocks;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[Solid]
[Wall]
[Constructed]
[BuildRoomMaterialOption]
[BlockTier(2)]
[RequiresSkill(typeof (MasonrySkill), 2)]
public class MortaredGraniteBlock : Block, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }
}
