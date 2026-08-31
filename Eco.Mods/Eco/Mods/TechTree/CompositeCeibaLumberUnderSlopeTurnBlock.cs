// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CompositeCeibaLumberUnderSlopeTurnBlock
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Blocks;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using Eco.World.Blocks.Features;
using Eco.World.Color;
using Eco.World.Water;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[RotatedVariants(new Type[] {typeof (CompositeCeibaLumberUnderSlopeTurnBlock), typeof (CompositeCeibaLumberUnderSlopeTurn90Block), typeof (CompositeCeibaLumberUnderSlopeTurn180Block), typeof (CompositeCeibaLumberUnderSlopeTurn270Block)})]
[Serialized]
[Wall]
[Constructed]
[Solid]
[BuildRoomMaterialOption]
[BlockTier(5)]
[IsForm(typeof (UnderSlopeTurnFormType), typeof (CompositeCeibaLumberItem))]
[Tag("Constructable")]
public class CompositeCeibaLumberUnderSlopeTurnBlock : 
  Block,
  IWaterLoggedBlock,
  IExtraBlockData,
  IColoredBlock,
  IColorBlockData
{
}
