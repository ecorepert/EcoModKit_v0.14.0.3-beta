// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WorldPosition3i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math;

[TypeConverter(typeof (ValueTypeTypeConverter))]
public struct WorldPosition3i : IComparable, IComparable<int>, IEquatable<WorldPosition3i>
{
  private static VectorPacker3Int packer;
  private static int halfXSize;
  private static int halfZSize;
  private int packedYZX;
  public const int MaxSupportedWorldHeight = 320;
  public const int MaxWorldHeightInChunkPosition = 32 /*0x20*/;
  public static int MaxWorldHeightForCurrentWorldSize;
  public static readonly WorldPosition3i Invalid;

  public static int MaxChunkY { get; }

  public int X { get; set; }

  public int Y { get; set; }

  public int Z { get; set; }

  public bool IsValid { get; }

  public static void Initialize(Vector3i worldSize);

  /// <summary> Initialize world height. Server does this from configs, and client reuses same method when receiving chunk data from server </summary>
  public static void InitWithHeight(int sizeY);

  public WorldPosition3i(int x, int y, int z);

  public WorldPosition3i(int x, int z);

  public WorldPosition3i(Vector3i vec);

  public static explicit operator int(WorldPosition3i vec);

  public static explicit operator WorldPosition3i(int i);

  public static explicit operator Vector3i(WorldPosition3i w);

  public static explicit operator Vector3(WorldPosition3i w);

  public static explicit operator Vector2i(WorldPosition3i w);

  public static explicit operator Vector2(WorldPosition3i w);

  public static explicit operator WorldPosition3i(Vector3i w);

  public static WorldPosition3i ClampAndCast(Vector3i pos);

  public Vector2i XZ { get; }

  public int A2DIndex { get; }

  /// <summary>Creates <see cref="T:Eco.Shared.Math.WorldPosition3i" /> from pre-wrapped position. Be careful when use this method, if used with unwrapped value may return wrong position.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WorldPosition3i FromWrapped(int x, int y, int z);

  /// <summary>Creates <see cref="T:Eco.Shared.Math.WorldPosition3i" /> from pre-wrapped position. Be careful when use this method, if used with unwrapped value may return wrong position.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WorldPosition3i FromWrapped(Vector3i wrapped);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition3i AddX(int val);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition3i AddZ(int val);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition3i Add(Vector2i dir);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition3i Add(int x, int z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryAddY(int val, out WorldPosition3i newPos);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition3i X_Z();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition3i X_Z(int y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(Vector3 pos, out WorldPosition3i worldPosition);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(Vector3i pos, out WorldPosition3i worldPosition);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreate(int x, int y, int z, out WorldPosition3i worldPosition);

  /// <summary>Tries to create <see cref="T:Eco.Shared.Math.WorldPosition3i" /> from pre-wrapped position, but with potentially out-of-world-grid-bounds Y. When used with unwrapped X and Z will result in invalid position.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreateWrapped(Vector3i wrapped, out WorldPosition3i worldPosition);

  /// <summary>Tries to create <see cref="T:Eco.Shared.Math.WorldPosition3i" /> from pre-wrapped position, but with potentially out-of-world-grid-bounds Y. When used with unwrapped X and Z will result in invalid position.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreateWrapped(
    int wrappedX,
    int y,
    int wrappedZ,
    out WorldPosition3i worldPosition);

  public static float Distance(WorldPosition3i a, WorldPosition3i b);

  public static int DistanceSq(WorldPosition3i a, WorldPosition3i b);

  public 
  #nullable disable
  WorldPosition3i[] XZNeighbors();

  /// <summary>Jump is only allowed in 4 directions from one 3x3 block to another. This returns all four neighbors to jump</summary>
  public void XZJumpNeighbors(
    out WorldPosition3i n,
    out WorldPosition3i e,
    out WorldPosition3i s,
    out WorldPosition3i w);

  /// <summary>Get all neighbors available for pathfinding</summary>
  public void XZFullNeighbors(
    out WorldPosition3i n,
    out WorldPosition3i ne,
    out WorldPosition3i e,
    out WorldPosition3i se,
    out WorldPosition3i s,
    out WorldPosition3i sw,
    out WorldPosition3i w,
    out WorldPosition3i nw);

  public IEnumerable<WorldPosition3i> NeighborsXZ();

  public static IEnumerable<WorldPosition3i> WorldXZIter(int y = 0);

  public IEnumerable<WorldPosition3i> SpiralOutXZIter(int size);

  public override int GetHashCode();

  public override string ToString();

  public static bool operator ==(WorldPosition3i a, WorldPosition3i b);

  public static bool operator !=(WorldPosition3i a, WorldPosition3i b);

  public static Vector3i GetDelta(WorldPosition3i to, WorldPosition3i from);

  public int CompareTo(object value);

  public int CompareTo(int value);

  public override bool Equals(object other);

  public bool Equals(WorldPosition3i other);
}
