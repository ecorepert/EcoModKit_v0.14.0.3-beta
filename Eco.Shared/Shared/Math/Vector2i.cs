// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Vector2i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math;

[TypeConverter(typeof (ValueTypeTypeConverter))]
[ForceAotHint]
[DebuggerDisplay("{x},{y}")]
public struct Vector2i : IEquatable<Vector2i>
{
  public int x;
  public int y;
  public static readonly Vector2i Zero;
  public static readonly Vector2i NegOne;
  public static readonly Vector2i One;
  public static readonly Vector2i Up;
  public static readonly Vector2i Down;
  public static readonly Vector2i Left;
  public static readonly Vector2i Right;
  public static readonly Vector2i MinVal;
  public static readonly 
  #nullable disable
  Vector2i[] Directions;

  [JsonIgnore]
  public int X { get; set; }

  [JsonIgnore]
  public int Y { get; set; }

  public float Length { get; }

  public float Magnitude { get; }

  public float MagnitudeSq { get; }

  public int Area { get; }

  public Vector2i(int x, int y);

  public Vector2i(int xy);

  public void Deconstruct(out int x, out int y);

  public override int GetHashCode();

  public override bool Equals(object other);

  public bool Equals(Vector2i other);

  public override string ToString();

  public static Vector2i Min(Vector2i a, Vector2i b);

  public static Vector2i Max(Vector2i a, Vector2i b);

  public static bool operator <(Vector2i a, Vector2i b);

  public static bool operator >(Vector2i a, Vector2i b);

  public static bool operator ==(Vector2i a, Vector2i b);

  public static bool operator !=(Vector2i a, Vector2i b);

  public static Vector2i operator -(Vector2i a, Vector2i b);

  public static Vector2i operator -(Vector2i a);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i operator /(Vector2i a, Vector2i b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i operator +(Vector2i a, Vector2i b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i operator *(Vector2i v1, Vector2i v2);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i operator %(Vector2i v1, Vector2i v2);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i operator *(Vector2i v, int t);

  public static Vector2i operator *(Vector2i v, float val);

  public static Vector2i operator -(Vector2i v, int t);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i operator +(Vector2i v, int t);

  public static implicit operator Vector2(Vector2i v);

  public static Vector2i operator /(Vector2i v, int val);

  public Vector3i X_Z(int newy = 0);

  public Vector3i XY_(int newz = 0);

  public Vector2i Wrap(Vector2i wrapSize);

  public Vector2i Wrap(int wrapSize);

  public static float WrappedDistance(Vector2i a, Vector2i b);

  public float WrappedDistance(Vector2i pos);

  public float Distance(Vector2i pos);

  public static int DistanceSq(Vector2i a, Vector2i b);

  /// <summary>Iterates all X,Z pairs from 0,0 to size,size (exclusive).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IEnumerable<Vector2i> XYIter(int size);

  /// <summary> Emits all integer two-component vectors with offset in range from 0 to size for each component and with the specified <paramref name="origin" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IEnumerable<Vector2i> XYIter(Vector2i origin, int size);

  /// <summary> Emits all integer two-component vectors from min (inclusive) to max (exclusive). </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IEnumerable<Vector2i> XYIterMinMax(Vector2i min, Vector2i max);

  /// <summary> Emits all integer two-component vectors from min (inclusive) to max (exclusive). </summary>
  public static IEnumerable<Vector2i> XYIterMinMax(int minX, int minY, int maxX, int maxY);

  public IEnumerable<Vector2i> XYIter();

  public IEnumerable<Vector2i> YXIter();

  /// Iterate over a range (inclusive)
  public static IEnumerable<Vector2i> XYIterInclusive(int min, int max);

  public IEnumerable<Vector2i> NeighborsAdjacent { get; }

  public IEnumerable<Vector2i> NeighborsDiagonal { get; }

  public IEnumerable<Vector2i> NeighborsDiagonalAndSelf { get; }
}
