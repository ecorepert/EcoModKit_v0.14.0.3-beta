// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PathFinder
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Pathing;
using Eco.Simulation.Types;
using Priority_Queue;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Pathfinding.Internal;

public static class PathFinder
{
  public static Path FindPath(
    Vector3 startraw,
    Vector3 endraw,
    PathRegionType regionType,
    PathfindFlags flags,
    bool allowDifferentYOnStart = false,
    bool allowDifferentYOnEnd = true);

  public static Path FindPathInDirection(
    Vector3 startraw,
    Vector3 dir,
    float minDistance,
    float maxDistance,
    PathRegionType regionType,
    PathfindFlags flags,
    AnimalSpecies species);

  private class Node : FastPriorityQueueNode
  {
    public WorldPosition3i Pos;
    public PathFinder.Node CameFrom;
    public float CostSoFar;
    public int Depth;

    public Node(WorldPosition3i pos, PathFinder.Node cameFrom, float costSoFar, int depth);
  }
}
