// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.FarEastLumberRoofPeakCornerBlock
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
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[RotatedVariants(new Type[] {typeof (FarEastLumberRoofPeakCornerBlock), typeof (FarEastLumberRoofPeakCorner90Block), typeof (FarEastLumberRoofPeakCorner180Block), typeof (FarEastLumberRoofPeakCorner270Block)})]
[Serialized]
[Wall]
[Constructed]
[Solid]
[BuildRoomMaterialOption]
[BlockTier(3)]
[IsForm(typeof (RoofPeakCornerFormType), typeof (FarEastLumberItem))]
[Tag("Constructable")]
public class FarEastLumberRoofPeakCornerBlock : Block, IColoredBlock, IColorBlockData
{
}
