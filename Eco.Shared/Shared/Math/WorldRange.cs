// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WorldRange
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable enable
namespace Eco.Shared.Math;

[Serialized]
[TypeConverter(typeof (ValueTypeTypeConverter))]
public struct WorldRange
{
  [Serialized]
  public Vector3i min;
  [Serialized]
  public Vector3i max;
  private static WorldRange invalid;
  private static WorldRange zero;

  /// <summary> The length not including the maximum position. </summary>
  public int Length { get; }

  /// <summary> The width not including the maximum position. </summary>
  public int Width { get; }

  /// <summary> The height not including the maximum position. </summary>
  public int Height { get; }

  /// <summary> The volume not including the maximum position. </summary>
  public int Volume { get; }

  /// <summary> The size not including the maximum position. </summary>
  public Vector3i Size { get; }

  /// <summary> The length including the maximum position. </summary>
  public int LengthInc { get; }

  /// <summary> The width including the maximum position. </summary>
  public int WidthInc { get; }

  /// <summary> The height including the maximum position. </summary>
  public int HeightInc { get; }

  /// <summary> The volume including the maximum position. </summary>
  public int VolumeInc { get; }

  /// <summary> The size including the maximum position. </summary>
  public Vector3i SizeInc { get; }

  public WorldRange(int cubedims);

  public WorldRange(Vector3i min, Vector3i max);

  public WorldRange(Vector2i min, Vector2i max);

  /// <summary>Creates a World Range that contains a list of Vector3i</summary>
  public WorldRange(
  #nullable disable
  IEnumerable<Vector3i> enumeration);

  public WorldRange Pan(Vector3i pan);

  public override string ToString();

  /// <summary> A range where IsValid() will return false. </summary>
  public static WorldRange Invalid { get; }

  /// <summary> A range around 0,0,0 with 0 dimentions. </summary>
  public static WorldRange Empty { get; }

  public override bool Equals(object other);

  public bool Equals(WorldRange otherRange);

  public override int GetHashCode();

  public static bool operator ==(WorldRange left, WorldRange right);

  public static bool operator !=(WorldRange left, WorldRange right);

  /// <summary>Checks if the range contains X,Z <paramref name="pos" />.</summary>
  public bool ContainsXZ(Vector2i pos);

  public bool Contains(Vector3 pos);

  public bool Contains(Vector3i pos);

  public bool Contains(WorldRange other);

  public bool Intersects(WorldRange other);

  public WorldRange Intersect(WorldRange other);

  public WorldRange[] XZWrap(WorldRange wrappingRange);

  /// <summary>Shift world range by the given delta.</summary>
  public WorldRange Translate(Vector3i delta);

  public WorldRange TranslateXZ(Vector2i delta);

  /// <summary>Expands the maximum value by <paramref name="delta" />. Useful for converting from an inclusive world range to an exclusive one.</summary>
  public WorldRange ExpandMax(Vector3i delta);

  public int XZWrap(WorldRange wrappingRange, WorldRange[] buffer);

  /// <summary> Collapses a square range into a line. </summary>
  public void CollapseAlongAxis(Axis a, bool collapseTowardsMin);

  /// <summary> Swaps any values where the min of the axis is larger than the max of the axis. </summary>
  public void Fix(Vector3i worldSize = default (Vector3i));

  public WorldRange TranslatedBy(Vector3i translation);

  /// <summary>Rotates <see cref="T:Eco.Shared.Math.WorldRange" /> around (0, 0, 0) (works only with exclusive range). I.e. (-2,-2)-(4,4) rotated by 180 degree will be (-3,-3)-(3,3). When used as exclusive range will include point which was rotated from (-2,-2) to (2,2).</summary>
  public WorldRange RotatedByExc(Quaternion rotation);

  /// <summary>Rotates <see cref="T:Eco.Shared.Math.WorldRange" /> around (0, 0, 0) (works only with inclusive range). I.e. (-2,-2)-(4,4) rotated by 180 degree will be (-4,-4)-(2,2).</summary>
  public WorldRange RotatedByInc(Quaternion rotation);

  /// <summary>Returns new <see cref="T:Eco.Shared.Math.WorldRange" /> extended in each direction by <paramref name="extent" />.</summary>
  /// <example><code>
  /// new WorldRange(new(0, 0, 0), new(1, 1, 1)).ExtendedBy(new(1, 0, 2)); // WorldRange((-1, 0, -2), (2, 1, 3))
  /// </code></example>
  public WorldRange ExtendedBy(Vector3i extent);

  public Vector3 CenterExc { get; }

  public Vector3 CenterInc { get; }

  public Vector3 BottomCenter { get; }

  public bool IsValid { get; }

  public bool IsEmpty { get; }

  public BSONObject ToBson();

  public void FromBson(BSONObject bson);

  public static WorldRange FromExtents(Vector3i min, Vector3i max);

  public void ForEach(Action<Vector3i> a);

  public IEnumerable<Vector3i> XYZIter();

  public IEnumerable<Vector3i> XYZIterInc();

  /// <summary>Iterates all X,Z positions in the range.</summary>
  public IEnumerable<Vector2i> XZIter();

  /// <summary>Iterates all X,Z positions in the range.</summary>
  public IEnumerable<PlotPos> PlotPosIter();

  /// <summary>Iterates all X,Z positions in the range in wrapped space.</summary>
  public IEnumerable<Vector2i> WrappedXZIter(Vector3i wrappedSize);

  public IEnumerable<Vector2i> XZIterInc();

  public IEnumerable<Vector3i> EdgesInc();

  public IEnumerable<Vector3i> InteriorsInc();

  /// <summary>
  /// Returns enumerable with all corners of this <see cref="T:Eco.Shared.Math.WorldRange" />
  /// </summary>
  public IEnumerable<Vector3i> Corners();

  /// <summary>Result will be in [inclusive;exclusive) format</summary>
  public void ExtendToInclude(Vector3i testPos);

  /// <summary>Extends current range to fully include <paramref name="range" />.</summary>
  public void ExtendToInclude(WorldRange range);

  public void ForEachInc(Action<Vector3i> a);

  public int EdgeCount(Vector3i windowPos);

  public static WorldRange SurroundingSpace(Vector3 pos, int dim);

  /// <summary>
  /// Checks if current current range intersects with another range in a wrapped space. Based loosely on the implementation of <see cref="M:Eco.Shared.Math.WorldRange.Intersects(Eco.Shared.Math.WorldRange)" />
  /// It makes sure to convert the ranges to a wrapped world space.
  /// </summary>
  public bool IntersectsWrapped(WorldRange other, Vector3i wrappedSize);

  /// <summary>
  /// Returns the wrapped version of the current range, making sure that the min point is in wrapped space while the end point may get out of wrapped size boundaries
  /// Since manually wrapping each component may result in an invalid range, we make sure to find an appropiate max position so that the range is always valid.
  /// [Any valid range] -&gt; [Wrapped min range)]
  /// </summary>
  public WorldRange GetWorldRangeWithWrappedMin(Vector3i wrappedSize);

  /// <summary>
  /// Returns sub-range(s) for current range which doesn't overlap <paramref name="range" />. Useful for range difference calculation.
  /// Possible outcomes:
  /// - min1.x,min1.z,max1.x,min2.z (when part of the range is before other range min z and overlaps)
  /// - min1.x,max2.z,max1.x,max1.z (when part of the range is after other range max Z and overlaps)
  /// - min1.x,min{1,2}.z,min2.x,max{1,2}.z (when part of the range is at left, Z depends on previous parts slices)
  /// - max2.x,min{1,2}.z,max1.x,max{1,2}.z (when part of the range is at right, Z depends on previous parts slices)
  /// </summary>
  public IEnumerable<WorldRange> GetNonOverlappingXZRanges(WorldRange range);

  public Vector3i ClosestPointTo(Vector3i pos);

  public void Deconstruct(out Vector3i min, out Vector3i max);

  /// <summary>Return a rect that represents the xz footprint of this world range.</summary>
  public Rect ToXZRect();
}
