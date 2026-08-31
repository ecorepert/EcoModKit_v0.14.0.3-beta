// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.DirectionExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math;

public static class DirectionExtensions
{
  /// <summary> Returns player facing directions area (player's left, facing and right sides) </summary>
  public static 
  #nullable disable
  IEnumerable<DirectionAxisHorizontal> DirectionsArea(this DirectionAxisHorizontal dir);

  /// <summary> Returns player Direction Axis Horizontal in the clockwise rotation </summary>
  public static DirectionAxisHorizontal Rotate90(this DirectionAxisHorizontal dir);

  /// <summary> Returns the horizontal player direction axis counterclockwise rotation </summary>
  public static DirectionAxisHorizontal RotateNeg90(this DirectionAxisHorizontal dir);

  public static Eco.Shared.Math.Axis Axis(this DirectionAxis dir);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool HasDirectionAxis(this DirectionAxisFlags axes, DirectionAxis axis);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static DirectionAxisFlags ToDirectionAxises(this DirectionAxis axis);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i Delta(this DirectionAxis dir);

  public static Vector3i Delta(this DirectionAxisFlags dir);

  public static Vector3i Delta(this DirectionAxisHorizontal dir);

  public static Vector3i Delta(this HorzDir dir);

  public static Vector3i Delta(this HorzDirNone dir);

  public static Vector3i[] Get4Edges(this DirectionAxis dir);

  public static Vector3i[] Get8Edges(this DirectionAxis dir);

  public static Vector3i[] Get8Edges(this Eco.Shared.Math.Axis axis);

  public static Quaternion ToQuat(this Direction dir);

  public static Quaternion ToQuat(this Direction2D dir);

  public static Direction ToDir(this Vector3i vec);

  public static Vector3 ToVecXY(this Direction2D dir);

  /// <summary>Converts the direction into a Vector2i</summary>
  public static Vector2i ToVec2i(this Direction2D dir);

  public static float ToAngle(this Direction2D dir);

  public static float ToAngle(this HorzDir dir);

  public static Vector3i ToVec(this Direction dir);

  public static Vector3i ToVec(this DirectionAxis dir);

  public static Vector3i ToVec(this DirectionExtensions.CubeNeighbor neighbor);

  public static DirectionExtensions.CubeNeighbor Flip(this DirectionExtensions.CubeNeighbor neighbor);

  public static Direction FacingDir(Vector3 forward);

  public static LocString Localized(this HorzDir dir);

  public static HorzDir CardinalDirTo(this Vector2 src, Vector2 target);

  public static HorzDir CardinalDir(this Vector3 vec);

  public static HorzDir CardinalDir(this Vector2 vec);

  public static HorzDir CardinalDir(float angle);

  public static Direction AngleToDir(float angle);

  public static DirectionAxisHorizontal HorizontalDir(this Vector3 vec);

  public static DirectionAxisHorizontal HorizontalDir(this Vector2 vec);

  public static DirectionAxisHorizontal HorizontalDir(float angle);

  public static Direction Rotate90Right(this Direction dir);

  public static Direction Rotate180(this Direction dir);

  public static Direction2D Flip(this Direction2D dir);

  public static HorzDir Flip(this HorzDir dir);

  public static DirectionAxis Flip(this DirectionAxis dir);

  /// <summary>Get an approximate direction access this vector points in</summary>
  public static Direction ClosestDirectionAxis(Vector3 dir);

  public enum CubeNeighbor
  {
    Up,
    Down,
    Left,
    Right,
    Forward,
    Backward,
    UpRight,
    UpLeft,
    UpForward,
    UpBack,
    DownRight,
    DownLeft,
    DownForward,
    DownBack,
    ForwardRight,
    ForwardLeft,
    BackRight,
    BackLeft,
    UpRightForward,
    UpRightBack,
    UpLeftForward,
    UpLeftBack,
    DownRightForward,
    DownRightBack,
    DownLeftForward,
    DownLeftBack,
    Count,
  }
}
