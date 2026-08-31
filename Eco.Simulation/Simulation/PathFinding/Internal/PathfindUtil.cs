// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.Internal.PathfindUtil
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Pathfinding.Internal;

/// <summary>Utility methods for pathfinding operations.</summary>
public static class PathfindUtil
{
  /// <summary>
  /// Efficiently selects a position from candidates by finding the top 3 scoring candidates
  /// and randomly picking from them. This provides good direction bias while maintaining
  /// some randomness for natural movement.
  /// </summary>
  /// <param name="candidates">List of candidates with their scores</param>
  /// <returns>The selected position</returns>
  public static WorldPosition3i SelectFromTopCandidates(
    List<(WorldPosition3i Pos, float Score)> candidates);
}
