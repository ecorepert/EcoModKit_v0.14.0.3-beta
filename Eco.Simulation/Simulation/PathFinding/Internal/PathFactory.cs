// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PathFactory
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Pathfinding.Internal;

public static class PathFactory
{
  /// <summary>Builds the nodes and regions.</summary>
  public static void Initialize(
    Dictionary<WorldPosition3i, PackedPathNode> nodes,
    PathRegionSet[] regionSets);

  public static void DetectAndSetBigJumps(
    Dictionary<WorldPosition3i, PackedPathNode> nodes,
    WorldPosition3i pos,
    PackedPathNode packed);

  public static bool UpdateChangedNode(
    Dictionary<WorldPosition3i, PackedPathNode> nodes,
    ref WorldPosition3i originalPos,
    out WorldPosition3i newPos,
    out PackedPathNode newNode);
}
