// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.VectorPacker3Int
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary>Vector packing helper. Packs a 3 int vector into single int value.  Used for packing both
/// voxel positions and chunk positions.
/// It packs them by considering the max XYZ values, and then making each one a multiple for that.  So:
///  Y = val / (maxX * maxZ)
///  Z = (val % (maxX * maxZ)) / maxX
///  X = (val % maxX)
///  Tha max size it will need to pack is thus maxX * maxY * maxZ.
/// </summary>
public readonly struct VectorPacker3Int
{
  private readonly int oneZ;
  private readonly int oneY;
  private readonly int upperBound;
  public readonly int XSize;
  public readonly int ZSize;

  /// <summary>Max Y which may be packed.</summary>
  public int MaxY { get; }

  public VectorPacker3Int(int xSize, int zSize);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int Pack(Vector3i value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int Pack(int x, int y, int z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryPack(int x, int y, int z, out int packedYZX);

  /// <summary>Tries to pack values assuming they already wrapped, but Y may be out of bounds. Unlike <see cref="M:Eco.Shared.Math.VectorPacker3Int.TryPack(System.Int32,System.Int32,System.Int32,System.Int32@)" /> doesn't wrap X and Z to match their number space and so can exceed limits and corrupt packed value.</summary>
  /// <returns><c>false</c> if Y out of bounds.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryPackWrapped(int wrappedX, int y, int wrappedZ, out int packedYZX);

  /// <summary>Packs values assuming they already wrapped. Unlike <see cref="M:Eco.Shared.Math.VectorPacker3Int.Pack(System.Int32,System.Int32,System.Int32)" /> doesn't wrap X and Z to match their number space and so can exceed limits and corrupt packed value.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int PackWrapped(int wrappedX, int y, int wrappedZ);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int PackXZ(int x, int z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int PackY(int y);

  [SkipLocalsInit]
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Vector3i Unpack(int packedYZX);

  [SkipLocalsInit]
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Unpack(int packedYZX, out int x, out int y, out int z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int UnpackX(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int UnpackY(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int UnpackZ(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int ReplaceX(int packedYZX, int x);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int ReplaceY(int packedYZX, int y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int ReplaceZ(int packedYZX, int z);

  /// <summary>Removes Y and returns packed value as if it with Y == 0.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int RemoveY(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int IncrementX(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int DecrementX(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int IncrementY(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int DecrementY(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int IncrementZ(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int DecrementZ(int packedYZX);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int AddX(int packedYZX, int val);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int AddY(int packedYZX, int val);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int AddZ(int packedYZX, int val);

  public bool TryAddY(int packedYZX, int val, out int newPackedYZX);

  public bool TryIncrementY(int packedYZX, out int newPackedYZX);

  public bool TryDecrementY(int packedYZX, out int newPackedYZX);

  /// <summary>Returns range of packed values for specified <paramref name="y" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public IntRange XZRange(int y = 0);
}
