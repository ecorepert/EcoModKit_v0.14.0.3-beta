// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Vector3i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math;

[TypeConverter(typeof (ValueTypeTypeConverter))]
[DebuggerDisplay("{x},{y},{z}")]
public struct Vector3i : IEquatable<Vector3i>, IComparable<Vector3i>
{
  public int x;
  public int y;
  public int z;
  public static readonly Vector3i Zero;
  public static readonly Vector3i NegOne;
  public static readonly Vector3i One;
  public static readonly Vector3i Forward;
  public static readonly Vector3i Back;
  public static readonly Vector3i Up;
  public static readonly Vector3i Down;
  public static readonly Vector3i Left;
  public static readonly Vector3i Right;
  public static readonly Vector3i ForwardRight;
  public static readonly Vector3i MinValue;
  public static readonly Vector3i MaxValue;
  public static readonly 
  #nullable disable
  Vector3i[] Directions;
  public static readonly Vector3i[] DirectionsXZ;
  public static readonly Vector3i[] Full26NeighborOffsets;

  [JsonIgnore]
  public int X { get; set; }

  [JsonIgnore]
  public int Y { get; set; }

  [JsonIgnore]
  public int Z { get; set; }

  public float Magnitude { get; }

  public int SqrMagnitude { get; }

  public int MultTogether { get; }

  public Vector2i XZ { get; }

  public Vector3i(int x, int y, int z);

  public Vector3i(int x, int y);

  public Vector3i ZeroY();

  /// <summary>Returns new <see cref="T:Eco.Shared.Math.Vector3i" /> with <see cref="P:Eco.Shared.Math.Vector3i.Y" /> component with added <paramref name="deltaY" />. You can use negative <paramref name="deltaY" /> to subtract value.</summary>
  public Vector3i AddY(int deltaY);

  public static Vector3i RandomXZOrthoDirection();

  public static IEnumerable<Vector3i> XYZIter(int size);

  public IEnumerable<Vector3i> XYZIter();

  public IEnumerable<Vector3i> YXZIter();

  public IEnumerable<Vector3i> XYZIterInclusive();

  public static IEnumerable<Vector3i> XYZIterInclusive(int min, int max);

  public static IEnumerable<Vector3i> XYZIterInclusive(Vector3i min, Vector3i max);

  /// <summary>
  /// Returns List of positions in sphere based on center and radius.
  /// Gets cube with 2x radius as side + center point, and then filters by the squared distance from the center.
  /// Positions are proved to be not under the bedrock
  /// </summary>
  public static IEnumerable<Vector3i> XYZIterInSphere(Vector3i center, int radius);

  public IEnumerable<Vector3i> XZFullNeighborsAndSelf { get; }

  public IEnumerable<Vector3i> XZNeighborsAndSelf { get; }

  public IEnumerable<Ray> XZNeighborsAndDir { get; }

  public IEnumerable<Vector3i> XZNeighbors { get; }

  public IEnumerable<Vector3i> XZFullNeighbors { get; }

  public IEnumerable<Vector3i> XYZNeighborsAndSelf { get; }

  public IEnumerable<Vector3i> XYZNeighbors { get; }

  public IEnumerable<Vector3i> Full26Neighbors { get; }

  public static float Distance(Vector3i a, Vector3i b);

  public static int DistanceSq(Vector3i a, Vector3i b);

  /// <summary> Returns the scalar value for the given axis. </summary>
  public int GetAxis(Axis a);

  public Vector3i Abs();

  public float WrappedDistance(Vector3i pos);

  /// <summary>Wraps a true 'vector' (which is now meaningless so we need a long name, points in the shortest direction after accounting for world voxel wrapping).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i XZWrappedDirectionalVector(Vector3i from, Vector3i to);

  public Vector3i XZWrap(Vector3i wrapSize);

  public Vector3i UnwrapRelative(Vector3i other);

  public override int GetHashCode();

  public override bool Equals(object other);

  public string ToStringLabelled(string text);

  public override string ToString();

  public string ToStringBasic();

  public static Vector3i FromStringBasic(string s);

  public static Vector3i Mid(Vector3i a, Vector3i b);

  public static Vector3i Min(Vector3i a, Vector3i b);

  public static Vector3i Max(Vector3i a, Vector3i b);

  public static bool operator ==(Vector3i a, Vector3i b);

  public static bool operator !=(Vector3i a, Vector3i b);

  public bool InBounds(int max);

  public static Vector3i operator *(Vector3i v, int t);

  public static Vector3i operator *(Vector3i v1, Vector3i v2);

  public static Vector3 operator *(Vector3i v, float t);

  public static Vector3i operator -(Vector3i v, int t);

  public static Vector3i operator -(Vector3i v);

  public static Vector3i operator +(Vector3i v, int t);

  public static Vector3i operator /(Vector3i v, int t);

  public static bool operator >=(Vector3i v1, Vector3i v2);

  public static bool operator <=(Vector3i v1, Vector3i v2);

  public static bool operator >(Vector3i v1, Vector3i v2);

  public static bool operator <(Vector3i v1, Vector3i v2);

  public static Vector3i operator -(Vector3i a, Vector3i b);

  public static Vector3i operator +(Vector3i a, Vector3i b);

  public static implicit operator Vector3(Vector3i v);

  public static explicit operator Vector3i(Vector3 v);

  public bool Equals(Vector3i other);

  /// <summary> Return the smallest axis, breaking ties arbitrarily. </summary>
  public Axis MinAxis();

  /// <summary> Return the largest axis, breaking ties arbitrarily. </summary>
  public Axis MaxAxis();

  public Vector3 Normalized { get; }

  public Vector3 NormalizedOrZero { get; }

  public bool CloseTo(Vector3i other, Vector3i maxDistance);

  public int CompareTo(Vector3i other);

  public Vector3i X_Z(int newY = 0);

  public Vector3i XY_(int newZ = 0);
}
