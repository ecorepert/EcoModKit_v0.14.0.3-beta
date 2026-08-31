// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.AI.GridUtils
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Agents.AI;

public class GridUtils
{
  /// <summary> Fast Voxel Traversal Algorithm (Based on Bresenham's line algorithm). Uses trigonometry in comparing to grid traversal algorithm. http://www.cse.yorku.ca/~amana/research/grid.pdf </summary>
  public static IEnumerable<Vector3i> DrawLine(Vector3 start, Vector3 end);

  /// <summary> Grid traversal algorithm based on bresenham's algorithm. Iterates through all 2d cells along a line. Returns
  /// true if all visits return true.</summary>
  public static bool GridTraverse(Eco.Shared.Math.Vector2 start, Eco.Shared.Math.Vector2 end, Func<Vector2i, bool> visit);

  /// <summary>&gt;Return all voxels that are visited by a ray going from <param name="start" /> to <param name="end" /> by J. Amanatides, A. Woo. A Fast Voxel Traversal Algorithm for Ray Tracing. Eurographics '87.  http://www.cse.yorku.ca/~amana/research/grid.pdf
  /// We are following the equation {u} +t{v} (it represents a ray).
  /// General idea:
  /// 1: initialize phase begins with identifying the voxel where the ray begins, find if our ray (by each axis) is incremented or decremented (step sign).
  /// Then we define t value - where the ray crosses the first voxel boundary (in each axis diraction).
  /// And compute delta for each axis direction - how far in units of t we should follow along the ray to make this distance be equal to width of a voxel (1 in our case).</summary>
  /// 
  ///             2: incremental phase: minimum of t in each direction will define in which direction we can go one step more and still be inside a voxel. Then move (by incrementing deltas) and repeat.
  public static IEnumerable<Vector3i> FastVoxelTraversal(
    Vector3 start,
    Vector3 end,
    Func<Vector3i, bool> visit);

  /// <summary> Slow grid-traverse algorithm for finding path from start to end point </summary>
  public List<Vector2i> BruteForceLine(Eco.Shared.Math.Vector2 start, Eco.Shared.Math.Vector2 end, float delta);
}
