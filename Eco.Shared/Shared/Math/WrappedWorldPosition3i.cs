// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WrappedWorldPosition3i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math.Geometry;
using Eco.Shared.Math.Wrapping;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math;

/// <summary>
/// Represents wrapped world position which doesn't require any further conversions. It prevents multiple checks everywhere for position to be actually wrapped or multiple conversions for same data.
/// Comparing to <see cref="T:Eco.Shared.Math.WorldPosition3i" /> it isn't packed, so doesn't require extra packing/unpacking operations and also readonly what allows to apply some optimizations and makes it thread-safe.
/// This is limited in Y along with XZ wrapping, if you are looking for Position without y limitation use <see cref="T:Eco.Shared.Math.WrappedPosition3i" />
/// </summary>
public readonly struct WrappedWorldPosition3i : IWrappedPosition3<int>, IPosition3<int>
{
  public readonly ref readonly WrappedSpace Space { get; }

  public bool HasBoundedY { get; }

  public int X { get; }

  public int Y { get; }

  public int Z { get; }

  /// <summary> Returns all orthogonal neighbors by X, Y, Z axes. It won't return Y axis neighbors if they out of bounds (bellow zero or above MaxY) and wrap X, Z neighbors (if they crossing zero coordinate). </summary>
  public 
  #nullable disable
  IEnumerable<WrappedWorldPosition3i> XYZNeighbors();

  /// <summary> Returns all orthogonal and diagonal neighbors by X, Y, Z axes. It won't return Y axis neighbors if they out of bounds (bellow zero or above MaxY) and wrap X, Z neighbors (if they crossing zero coordinate). </summary>
  public IEnumerable<WrappedWorldPosition3i> Full26Neighbors(bool includeSelf = true);

  /// <summary> Returns all orthogonal neighbors by X, Y, Z axes. It won't return Y axis neighbors if they out of bounds (bellow zero or above MaxY) and wrap X, Z neighbors (if they crossing zero coordinate). </summary>
  public IEnumerable<(WrappedWorldPosition3i Position, Direction Direction)> XYZNeighborsWithDirection();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryAdd(Vector3i delta, out WrappedWorldPosition3i result);

  /// <summary>Adds <paramref name="x" /> to <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.X" /> component and returns new value. The value should be not less than -<see cref="P:Eco.Shared.Voxel.World.WrappedVoxelSize" />.X.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WrappedWorldPosition3i AddX(int x);

  /// <summary>Adds <paramref name="z" /> to <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.Z" /> component and returns new value. The value should be not less than -<see cref="P:Eco.Shared.Voxel.World.WrappedVoxelSize" />.Z.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WrappedWorldPosition3i AddZ(int z);

  /// <summary>Tries to increase <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.Y" /> component where <paramref name="increment" /> should be positive value. If succeed (not out of world bounds) then returns <c>true</c> and increased value in <paramref name="increasedPos" />. For decreasing <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.Y" /> use <see cref="M:Eco.Shared.Math.WrappedWorldPosition3i.TryDecreaseY(System.Int32,Eco.Shared.Math.WrappedWorldPosition3i@)" />.</summary>
  public bool TryIncreaseY(int increment, out WrappedWorldPosition3i increasedPos);

  /// <summary>Tries to decrease <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.Y" /> component where <paramref name="decrement" /> should be positive value. If succeed (not out of world bounds) then returns <c>true</c> and decreased value in <paramref name="decreasedPos" />. For increasing <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.Y" /> use <see cref="M:Eco.Shared.Math.WrappedWorldPosition3i.TryIncreaseY(System.Int32,Eco.Shared.Math.WrappedWorldPosition3i@)" />.</summary>
  public bool TryDecreaseY(int decrement, out WrappedWorldPosition3i decreasedPos);

  /// <summary>Returns neighbor world position for <paramref name="dir" /> if possible. It may return <c>false</c> for invalid <paramref name="dir" /> value or if Y will go out of world bounds.</summary>
  public bool TryGetNeighbor(Direction dir, out WrappedWorldPosition3i neighborPos);

  /// <summary> If possible, returns two positions using passed axis. It may be impossible if it will be outside of world by Y coor. </summary>
  public bool TryGetSides(
    Axis axis,
    out WrappedWorldPosition3i side1,
    out WrappedWorldPosition3i side2);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(Vector3 worldPos, out WrappedWorldPosition3i wrappedWorldPos);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(Vector3i worldPos, out WrappedWorldPosition3i wrappedWorldPos);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(
    WrappedPosition3i worldPos,
    out WrappedWorldPosition3i wrappedWorldPos);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(int x, int y, int z, out WrappedWorldPosition3i wrappedWorldPos);

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> from unwrapped <paramref name="x" />, <paramref name="y" /> and <paramref name="z" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedWorldPosition3i Create(int x, int y, int z);

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> from unwrapped <paramref name="x" />, <paramref name="y" /> and <paramref name="z" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedWorldPosition3i Create(float x, float y, float z);

  /// <summary>Clumps <paramref name="wrapped" /> position in Y space. If Y less 0 then it will be 0, if Y greater or equal to World Space Y then it will be World Space Y - 1.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedWorldPosition3i Clamp(WrappedPosition3i wrapped);

  /// <summary>
  /// Adds <paramref name="y" /> to <paramref name="wrapped" /> and returns value. In result of that operation it may produce invalid <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> with <see cref="P:Eco.Shared.Math.WrappedWorldPosition3i.Y" /> out of world grid bounds.
  /// Only use it if you sure result of that operation won't overflow Y bounds if you want to skip checks for optimization purposes!
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedWorldPosition3i AddYUnchecked(WrappedWorldPosition3i wrapped, int y);

  public static implicit operator WrappedWorldPosition3i(Vector3i pos);

  public static explicit operator WrappedWorldPosition3i(WrappedPosition3i pos);

  public static explicit operator Vector3i(WrappedWorldPosition3i pos);

  public static explicit operator WorldPosition3i(WrappedWorldPosition3i pos);

  public static explicit operator WrappedWorldPosition3i(WorldPosition3i pos);

  public static explicit operator WrappedWorldPosition3i(Vector3 pos);

  public static explicit operator Vector3(WrappedWorldPosition3i pos);

  public bool Equals(WrappedWorldPosition3i other);

  public override bool Equals(object obj);

  public static bool operator ==(WrappedWorldPosition3i left, WrappedWorldPosition3i right);

  public static bool operator !=(WrappedWorldPosition3i left, WrappedWorldPosition3i right);

  public override int GetHashCode();

  public override string ToString();
}
