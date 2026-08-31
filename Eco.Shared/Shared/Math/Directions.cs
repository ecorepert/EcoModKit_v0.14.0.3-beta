// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Directions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Math;

public static class Directions
{
  public static readonly 
  #nullable disable
  Vector3i[] DirectionAxisDeltas;
  public static readonly Vector3i[] DirectionAxisHorizontalDeltas;
  public static readonly Vector3i[] CardinalDirectionDeltas;
  public static readonly Vector3i[] CardinalDirectionNoneDeltas;
  public static readonly Vector3i[] CubeCornerDeltas;
  public static readonly HorzDirNone[][] DiagonalComponents;
  public static readonly Diagonals[][] AdjacentCorners;
  public static readonly Direction[] Landscape;
  public static readonly Direction[] All;
  public static Matrix2x2i[] FacingRotations;

  public static Direction Inverse(this Direction direction);

  /// <summary> Returns list of facing rotations from player facing area (player's left, facing and right sides) </summary>
  public static IEnumerable<Matrix2x2i> FacingRotationsArea(this DirectionAxisHorizontal dir);
}
