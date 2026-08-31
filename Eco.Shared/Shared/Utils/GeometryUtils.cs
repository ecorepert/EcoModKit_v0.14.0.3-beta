// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.GeometryUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;
using System.Numerics;

#nullable enable
namespace Eco.Shared.Utils;

public static class GeometryUtils
{
  public static bool IsPointInsideQuadrilateral(
    Eco.Shared.Math.Vector2 point,
    Eco.Shared.Math.Vector2 vertexA,
    Eco.Shared.Math.Vector2 vertexB,
    Eco.Shared.Math.Vector2 vertexC,
    Eco.Shared.Math.Vector2 vertexD);

  public static bool IsPointInsideTriangle(
    Eco.Shared.Math.Vector2 point,
    Eco.Shared.Math.Vector2 vertexA,
    Eco.Shared.Math.Vector2 vertexB,
    Eco.Shared.Math.Vector2 vertexC);

  /// <summary>
  /// Return every block which is inside a 2D cone area, considering that the cone starts at "originBlock" and has a direction "forwardDirection".
  /// This function was created to have a way to check which blocks the player is looking at up to a maximum distance, using a cone to check for the blocks.
  /// </summary>
  /// <remarks>The Y axis of the direction is ignored, so it doesn't matter if the player is looking up or down.</remarks>
  /// <param name="initialRadius">The initial radius of the cone check (i.e. from the "originBlock" position).</param>
  /// <param name="finalRadius">The final radius of the cone check. Should be bigger than "initialRadius".</param>
  /// <param name="length">Length of the cone check.</param>
  public static 
  #nullable disable
  IEnumerable<Vector3i> GetBlocksInConeCheck2D(
    Vector3i originBlock,
    Vector3 forwardDirection,
    float initialRadius,
    float finalRadius,
    float length);

  /// <summary>
  /// Get the circle with given radius which is perpendicular to targetDir and touches the targetPos.
  /// There could be two such circles, return the closer one.
  /// </summary>
  public static Vector3 GetCirclePoint(
    Vector3 curPos,
    Vector3 targetPos,
    Vector3 targetDir,
    float radius);

  /// <summary>
  /// Given a circle with radius and center.
  /// Calculate 2 tangents to this circle from curPos.
  /// Return tangent which have same chirality as targetDir vector (cw or ccw).
  /// </summary>
  public static Vector3 GetTangentPoint(
    Vector3 curPos,
    Vector3 targetPos,
    Vector3 targetDir,
    Vector3 circleCenter,
    float radius);
}
