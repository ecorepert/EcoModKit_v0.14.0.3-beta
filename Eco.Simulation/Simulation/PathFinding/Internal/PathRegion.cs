// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PathRegion
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Pathfinding.Internal;

/// <summary>Defines a region, which is a connected set of positions which can all be reached from each other.</summary>
public class PathRegion
{
  public ThreadSafeList<WorldPosition3i> PosList;
  public static readonly bool[][] CanTraverseByRegionType;

  public int Id { get; }

  public PathRegionType PathRegionType { get; }

  public int Size { get; }

  public ThreadSafeHashSet<WorldPosition3i> PosSet { get; }

  public void Initialize(
    WorldPosition3i pos,
    PathRegionType type,
    IReadOnlyDictionary<WorldPosition3i, PackedPathNode> graph,
    IReadOnlyDictionary<WorldPosition3i, PathRegion> posToRegion);

  public bool CanTraverse(PackedPathNode.PathBlockType blockType);

  /// <summary>For debugging, can get all the valid neighbors from a given node and pos.</summary>
  public int FillNeighbors(
    PackedPathNode node,
    WorldPosition3i centerPos,
    Span<WorldPosition3i> values);

  public int FillNeighbors(
    PackedPathNode node,
    WorldPosition3i centerPos,
    Span<(WorldPosition3i Pos, PackedPathNode.Movability Mov, HorzDir Dir)> values);

  /// <summary>Finds a random position, checking up to <see cref="F:Eco.Simulation.Pathfinding.Internal.PathRegion.MaxRandomPositionSamples" /> points (or 1% of the region, whichever is smaller), that is in the given direction within 90 degrees, and is the given distance. If dir is zero, ignore. Filterfunc can block points from being considered.</summary>
  public WorldPosition3i GetRandomPosition(
    WorldPosition3i startRaw,
    Vector3 dir,
    float min,
    float max,
    PathfindFlags flags,
    Func<WorldPosition3i, bool> filterFunc = null,
    float tramplePref = 0.3f);

  public bool UpdateNodeConnectivity(
    WorldPosition3i oldPos,
    WorldPosition3i newPos,
    PackedPathNode newNode,
    Span<WorldPosition3i> neighbors);

  public void Merge(PathRegion other);

  public bool CalcValid();

  public static bool[] GetAcceptableTransitions(PathRegionType type);
}
