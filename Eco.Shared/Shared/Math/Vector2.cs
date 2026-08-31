// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Vector2
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
[DebuggerDisplay("{x},{y}")]
public struct Vector2 : IFormattable, IEquatable<Vector2>
{
  public float x;
  public float y;
  public static Vector2 zero;
  public static Vector2 one;
  public static Vector2 up;
  public static Vector2 down;
  public static Vector2 left;
  public static Vector2 right;

  [JsonIgnore]
  public float X { get; set; }

  [JsonIgnore]
  public float Y { get; set; }

  public Vector2(float x, float y);

  public override string ToString();

  public string ToString(string formatString, IFormatProvider formatProvider = null);

  public Vector3 X_Z(float y = 0.0f);

  public static Vector2 operator +(Vector2 v1, Vector2 v2);

  public static Vector2 operator +(Vector2 v1, float f);

  public static Vector2 operator -(Vector2 v1, Vector2 v2);

  public static Vector2 operator -(Vector2 v1, float f);

  public static Vector2 operator *(Vector2 v, float f);

  public static Vector2 operator /(Vector2 v1, Vector2 v2);

  public static Vector2 operator /(Vector2 v1, float f);

  public static float Dot(Vector2 v1, Vector2 v2);

  public static float Distance(Vector2 target, Vector2 currentPos);

  public static float DistanceSq(Vector2 target, Vector2 currentPos);

  public Vector2 Wrap(Vector2 wrapSize);

  public float WrappedDistance(Vector2 other);

  public static float WrappedDistance(Vector2 a, Vector2 b);

  /// <summary>Calculates squared distance for wrapped axes distances for voxel world size.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float WrappedDistanceSq(in Vector2 a, in Vector2 b);

  /// <summary>Calculates distance for wrapped axes distances for <paramref name="size" /> (i.e. size may be voxel size, chunk size or plot size).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float WrappedDistance(Vector2 a, Vector2 b, in Vector2 size);

  /// <summary>Calculates squared distance for wrapped axes distances for <paramref name="size" /> (i.e. size may be voxel size, chunk size or plot size).</summary>
  public static float WrappedDistanceSq(in Vector2 a, in Vector2 b, in Vector2 size);

  /// <summary>Returns directional difference vector wrapped in size (i.e. WrappedVoxelSize, WrappedChunkSize or WrappedPlotSize).</summary>
  public static Vector2 WrappedDirectionalVector(in Vector2 from, in Vector2 to);

  public static Vector2 WrappedDirectionalVector(in Vector2 from, in Vector2 to, in Vector2 size);

  public float Length { get; }

  public float LengthSq { get; }

  public float Magnitude { get; }

  public float MagnitudeSq { get; }

  public Vector2 Normalized { get; }

  /// <summary>
  /// Same as <see cref="P:Eco.Shared.Math.Vector2.Normalized" />, but for zero-length vector it returns <paramref name="defaultValue" /> instead.
  /// <see cref="P:Eco.Shared.Math.Vector2.Normalized" /> will return <see cref="F:System.Single.NaN" /> vector in this case.
  /// </summary>
  public Vector2 NormalizeSafe(Vector2 defaultValue = default (Vector2));

  /// <summary>
  /// Uses default rounding rules (bank rounding, or round to closest even in case of tie).
  /// I.e. 0.5 -&gt; 0, but 1.5 -&gt; 2.
  /// </summary>
  public Vector2i Round { get; }

  /// <summary>
  /// Always rounds to closes greater number. Preferred way of rounding for coordinates, because voxel coordinates always shifted down.
  /// I.e. 0.5 -&gt; 1, 1.5 -&gt; 2 and -1.5 -&gt; -1.
  /// </summary>
  public Vector2i RoundPositively { get; }

  public Vector2i Floor { get; }

  public Vector2i Ceiling { get; }

  public static Vector2 Lerp(Vector2 a, Vector2 b, float t);

  public Vector2 Rotate(float angleDeg);

  public static float AngleBetweenRad(Vector2 a, Vector2 b);

  /// <summary> Returns angle between two in degs.</summary>
  public float AngleRad(Vector2 to);

  public float AngleDeg(Vector2 to);

  public float Angle { get; }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static explicit operator Vector2i(Vector2 value);

  public static bool operator ==(Vector2 a, Vector2 b);

  public static bool operator !=(Vector2 a, Vector2 b);

  public override int GetHashCode();

  public override bool Equals(object other);

  public bool Equals(Vector2 other);
}
