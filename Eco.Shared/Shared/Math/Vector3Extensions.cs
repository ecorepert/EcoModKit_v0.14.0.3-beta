// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Vector3Extensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary>Extension methods for <see cref="T:System.Numerics.Vector3" />.</summary>
public static class Vector3Extensions
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsFinite(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i FloorToInt(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i CeilingToInt(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool CloseTo(this Vector3 one, Vector3 other, Vector3 maxDistance);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 WithY(this Vector3 v, float y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2 XZ(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i XYZi(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i XZi(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Eco.Shared.Math.WorldPosition3i WorldPosition3i(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Eco.Shared.Math.WorldPosition3i WorldPosition3iOrInvalid(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Eco.Shared.Math.WorldPosition3i WorldPosition3iOrInvalid(this Vector3i v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i Round(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 ZeroY(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 Cross(this Vector3 lhs, Vector3 rhs);

  public static string ToStringLabelled(this Vector3 v, string text);

  public static Vector3 ToVector3(this string value);

  public static float XZDistance(in Vector3 from, in Vector3 to);

  /// <summary>Returns directional difference vector wrapped in <paramref name="size" /> (i.e. WrappedVoxelSize, WrappedChunkSize or WrappedPlotSize).</summary>
  public static Vector3 XZWrappedDirectionalVector(in Vector3 from, in Vector3 to, in Vector3 size);

  /// <summary>Wraps a true 'vector' (which is now meaningless so we need a long name, points in the shortest direction after accounting for world wrapping).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 XZWrappedDirectionalVector(in this Vector3 from, in Vector3 to);

  /// <summary>
  /// Always rounds to closes greater number. Preferred way of rounding for coordinates, because voxel coordinates always shifted down.
  /// I.e. 0.5 -&gt; 1, 1.5 -&gt; 2 and -1.5 -&gt; -1.
  /// </summary>
  public static Vector3i RoundPositively(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float DistanceSqr(Vector3 a, Vector3 b);

  public static Vector3 Abs(this Vector3 v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 Floor(this Vector3 v);

  /// <summary> Returns angle between two in degs.</summary>
  public static float AngleRad(this Vector3 from, Vector3 to);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 NormalizeToLength(this Vector3 vector, float len);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 Normalize(this Vector3 vector);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Magnitude(this Vector3 vector);
}
