// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.SVector3
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

[TypeConverter(typeof (ValueTypeTypeConverter))]
[DebuggerDisplay("{x},{y},{z}")]
public struct SVector3 : IEquatable<SVector3>, IFormattable
{
  public static SVector3 Zero;
  public static SVector3 One;
  public static SVector3 Up;
  public static SVector3 Down;
  public static SVector3 Forward;
  public static SVector3 Back;
  public static SVector3 Right;
  public static SVector3 Left;
  public static SVector3 MinValue;
  public float x;
  public float y;
  public float z;

  [JsonIgnore]
  public float X { get; set; }

  [JsonIgnore]
  public float Y { get; set; }

  [JsonIgnore]
  public float Z { get; set; }

  public float Magnitude { get; }

  public float MagnitudeSq { get; }

  public Vector3i XYZi { get; }

  public WorldPosition3i WorldPosition3i { get; }

  public Vector2i XZi { get; }

  public Vector2 XZ { get; }

  public Vector2 XY { get; }

  public Vector2 YZ { get; }

  public SVector3 Normalized { get; }

  /// <summary> Returns normalized version of vector (by dividing each component on vector length), but returns <paramref name="defaultValue" /> in case if length is zero to avoid producing NaN vector. </summary>
  public SVector3 NormalizeSafe(SVector3 defaultValue = default (SVector3));

  public SVector3(float x, float y, float z);

  public SVector3(float v);

  public SVector3 ZeroY();

  public static bool operator ==(SVector3 a, SVector3 b);

  public static bool operator !=(SVector3 a, SVector3 b);

  public static SVector3 operator +(SVector3 v1, SVector3 v2);

  public static SVector3 operator +(SVector3 v1, float f);

  public static SVector3 operator -(SVector3 v1, SVector3 v2);

  public static SVector3 operator *(SVector3 v, float f);

  public static SVector3 operator *(SVector3 v, int f);

  public static SVector3 operator *(SVector3 v1, SVector3 v2);

  public static SVector3 operator /(SVector3 v, float f);

  public static SVector3 operator /(SVector3 v, int f);

  public static float Dot(SVector3 v1, SVector3 v2);

  public static SVector3 Cross(SVector3 lhs, SVector3 rhs);

  public static float Angle(SVector3 lhs, SVector3 rhs);

  public static bool IsNAN(SVector3 v);

  public static bool IsInfinity(SVector3 v);

  public static bool IsValid(SVector3 v);

  public static SVector3 Min(SVector3 min, SVector3 othermin);

  public static SVector3 Max(SVector3 max, SVector3 othermax);

  public override int GetHashCode();

  public override bool Equals(object other);

  public override string ToString();

  public string ToString(string formatString, IFormatProvider formatProvider = null);

  public string ToStringLabelled(string text);

  public SVector3 Cross(SVector3 rhs);

  /// <summary> Returns angle between two in degs.</summary>
  public float AngleRad(SVector3 to);

  public float AngleDeg(SVector3 to);

  /// <summary>
  /// Uses default rounding rules (bank rounding, or round to closest even in case of tie).
  /// I.e. 0.5 -&gt; 0, but 1.5 -&gt; 2.
  /// </summary>
  public Vector3i Round { get; }

  /// <summary>
  /// Always rounds to closes greater number. Preferred way of rounding for coordinates, because voxel coordinates always shifted down.
  /// I.e. 0.5 -&gt; 1, 1.5 -&gt; 2 and -1.5 -&gt; -1.
  /// </summary>
  public Vector3i RoundPositively { get; }

  public Vector3i Floor { get; }

  public Vector3i Ceiling { get; }

  public SVector3 RotateByXAxis(float radians);

  public SVector3 RotateByYAxis(float radians);

  public SVector3 RotateByZAxis(float radians);

  public void Clamp(SVector3 min, SVector3 max);

  public bool Equals(SVector3 other);

  public static float Distance(SVector3 a, SVector3 b);

  public static float DistanceSq(SVector3 a, SVector3 b);

  public float WrappedDistance(SVector3 other);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float WrappedDistance(SVector3 a, SVector3 b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float WrappedDistanceSq(SVector3 a, SVector3 b);

  /// <summary>Returns directional difference vector wrapped in <paramref name="size" /> (i.e. WrappedVoxelSize, WrappedChunkSize or WrappedPlotSize).</summary>
  public static SVector3 XZWrappedDirectionalVector(
    in SVector3 from,
    in SVector3 to,
    in SVector3 size);

  public static SVector3 Lerp(SVector3 a, SVector3 b, float t);

  public SVector3 Abs();

  public bool CloseTo(SVector3 other, SVector3 maxDistance);

  public SVector3 UnwrapRelative(SVector3 other);

  public static implicit operator Vector3(SVector3 value);

  public static implicit operator SVector3(Vector3 value);
}
