// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PathRegionSet
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Math;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Pathfinding.Internal;

/// <summary>Defines a set of path regions of the same type.</summary>
public class PathRegionSet
{
  public ThreadSafeList<PathRegion> Regions;
  public Dictionary<WorldPosition3i, PathRegion> PosToRegion;
  public Dictionary<int, PathRegion> IdToRegion;

  public PathRegionType PathRegionType { get; }

  public void Initialize(
    PathRegionType type,
    IReadOnlyDictionary<WorldPosition3i, PackedPathNode> pathGraph);

  public bool CanTraverse(PackedPathNode.PathBlockType blockType);

  /// <summary>Get the region at the given position, +/- 1 Y</summary>
  public (PathRegion Region, WorldPosition3i Pos) GetRegionAt(
    Vector3 rawpos,
    bool allowOtherYValues,
    bool checkNeighbors);

  /// <summary>Dirty all regions that had this position.</summary>
  public void UpdateNodeConnectivity(
    WorldPosition3i oldPos,
    WorldPosition3i newPos,
    PackedPathNode newNode);

  public void UpdateDirtyRegions(
    IReadOnlyDictionary<WorldPosition3i, PackedPathNode> graph);
}
