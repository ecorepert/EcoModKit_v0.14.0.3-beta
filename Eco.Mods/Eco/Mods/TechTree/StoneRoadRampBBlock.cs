// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.StoneRoadRampBBlock
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using Eco.World.Blocks.Features;
using Eco.World.Color;
using Eco.World.Water;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[RotatedVariants(new Type[] {typeof (StoneRoadRampBBlock), typeof (StoneRoadRampB90Block), typeof (StoneRoadRampB180Block), typeof (StoneRoadRampB270Block)})]
[Serialized]
[MakesRoads]
[Road(1.1f, null)]
[Wall]
[Constructed]
[Solid]
[IsForm(typeof (RampBFormType), typeof (StoneRoadItem))]
[Tag("Constructable")]
public class StoneRoadRampBBlock : 
  Block,
  IWaterLoggedBlock,
  IExtraBlockData,
  IColoredBlock,
  IColorBlockData
{
}
