// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.VectorUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Numerics;

#nullable enable
namespace Eco.Shared.Math;

public static class VectorUtils
{
  public static Vector3 NormalizedNoY(this Vector3 vec);

  public static Vector3 RandomNormalXZ();

  public static (Vector3i AdjacentNeighbor, Vector3i DiagonalNeighbor) GetNearestXZNeighbors(
    this Vector3 pos);

  /// <summary> Get the nearest XZ-adjacent grid cell to pos that satisfies isValid. </summary>
  public static bool TryGetNearestAdjacent(
    this Vector3 pos,
    out Vector3i nearest,
    #nullable disable
    Func<Vector3i, bool> isValid);

  public static Vector3 AngleToDirDeg(float angleDeg);

  /// <summary> Returns distinct collection of vectors form the area that were shifted and rotated according to provided params. </summary>
  public static IEnumerable<Vector3i> MoveAndRotate(
    this IEnumerable<Vector3i> area,
    Vector3i position,
    Quaternion rotation);

  /// <summary> Average position, or zero's if none in list. </summary>
  public static Vector2 Average(this IEnumerable<Vector2> posList);

  /// <summary> Average position, or zero's if none in list. </summary>
  public static Vector3 Average(this IEnumerable<Vector3> posList);

  /// <summary> Average position, or zero's if none in list. </summary>
  public static Vector2i Average(this IEnumerable<Vector2i> posList);

  public static Vector2i Wrap(this Vector2i vec);

  /// <summary> Average position, or zero's if none in list. </summary>
  public static IEnumerable<Vector2i> WrapAll(this IEnumerable<Vector2i> posList, Vector2i wrapSize);

  /// <summary> Average position, or zero's if none in list. </summary>
  public static Vector3i Average(this IEnumerable<Vector3i> posList);

  /// <summary> Parses Vector2 string representation to <see cref="T:Eco.Shared.Math.Vector2" /> value. </summary>
  public static Vector2 ParseVector2(string str);

  /// <summary> Parses Vector3 string representation to <see cref="T:System.Numerics.Vector3" /> value. </summary>
  public static Vector3 ParseVector3(string str);

  /// <summary>Analogue of Unity Vector3.Project</summary>
  public static Vector3 Project(this Vector3 vector, Vector3 onNormal);

  public static Vector3 CapToLength(this Vector3 vector, float maxLength);

  public static Vector2 CapToLength(this Vector2 vector, float maxLength);

  /// <summary>Slerp variation</summary>
  public static Vector3 Slerp(this Vector3 start, Vector3 end, float percent);

  /// <summary>Rotate vector clockwise around +Y axis</summary>
  public static Vector3 RotatedAroundY(this Vector3 vector, float angle);

  public static Vector3 UnwrapRelative(this Vector3 v, Vector3 other);

  public static Vector3 AvgWrappedPos(this IEnumerable<Vector3> list);

  /// <summary>Find the nearest block to this one in horizontal, vertical, or diagonal position away.</summary>
  public static IEnumerable<Vector3i> ClosestGridPositions(Vector3 position);

  public static float DistanceTo(this Vector3 vector, Vector3 other);
}
