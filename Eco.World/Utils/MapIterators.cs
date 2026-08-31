// Decompiled with JetBrains decompiler
// Type: Eco.World.Utils.MapIterators
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.World.Utils;

public class MapIterators
{
  public static 
  #nullable disable
  IEnumerable<Vector3i> ChunkColumnVoxels(Vector2i col);

  public static IEnumerable<Vector3i> Voxels(WorldRange range);

  public static IEnumerable<Vector3i> VoxelColumn(Vector2i pos);

  public static IEnumerable<Vector2i> Surface();

  public static IEnumerable<Vector3i> LandSurfacesInColumn(int cx, int cz, bool mustBeEmptyAbove = true);

  public static Vector3i[][] BorderingNeighborBlocks { get; }

  public static Vector3i[] VecRange(Eco.Shared.Math.Range xRange, Eco.Shared.Math.Range yRange, Eco.Shared.Math.Range zRange);

  public static WorldArea GetVoxelRangeFromChunkCol(Vector2i chunkcol);

  public static IEnumerable<Tuple<Block, Vector3i>> Neighbors(Vector3i pos);

  public static IEnumerable<Tuple<Block, Vector3i>> NeighborsHorizontal(Vector3i pos);

  public static IEnumerable<Tuple<Block, Vector3i>> Neighbors(Vector3i pos, Type enumType);
}
