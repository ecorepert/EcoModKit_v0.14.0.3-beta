// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.World
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Voxel;

/// <summary>
/// Wrapper class around the static voxel grid that represents the world.
/// Essentially this class exists so its easier to do WorldCache.SomeMethod() instead of WorldCache.Obj.SomeMethod().
/// Gets ChunkViews from the ChunkGrid.
/// Gets Blocks from Chunks from the ChunkGrid.
/// </summary>
public abstract class World
{
  public static float WorldSizeMultiplier;

  protected static 
  #nullable disable
  IChunkGrid ChunkGrid { get; }

  public static Vector3i MinChunkPos { get; }

  public static Vector3i MaxChunkPos { get; }

  public static Vector3i VoxelSize { get; }

  public static Vector3i ChunkSize { get; }

  public static float Area { get; }

  public static Vector3 Center { get; }

  public static Vector3i WrappedChunkSize { get; }

  public static Vector3i WrappedVoxelSize { get; }

  public static bool Exists { get; }

  public static void Initialize(IChunkGrid chunkGrid);

  public static void Destroy();

  public static IEnumerable<IChunk> GetVisibleChunks(Vector3 observerPosition, float viewDistance);

  public static IEnumerable<IChunk> GetChunks(WorldRange range);

  public static WorldRange GetWorldRangeFromPositionAndDistance(
    Vector3 observerPosition,
    float viewDistance);

  /// <summary> Converts <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> to chunk position. </summary>
  public static Vector3i ToChunkPosition(WrappedPosition3i worldPos);

  /// <summary> Converts <paramref name="worldRange" /> to chunk range. Works with negative min/max positions. </summary>
  public static WorldRange ToChunkRange(WorldRange worldRange);

  public static IEnumerable<Vector3i> ChunkAndNeighbors(WrappedWorldPosition3i worldPos);

  public static IEnumerable<Vector3i> GetNeighborChunks(Vector3i chunkPos, Vector3i localPos);

  /// <summary>Converts <paramref name="value" /> to chunk space. It divides value by chunk size and floors result (i.e. -1 will be -1 in chunk space, but 1 will be 0).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int ToChunkSpace(float value);

  /// <summary>Converts <paramref name="value" /> to chunk space. It divides value by chunk size and floors result (i.e. -1 will be -1 in chunk space, but 1 will be 0).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int ToChunkSpace(int value);

  /// <summary>Converts world space position to chunk space. Unlike <see cref="M:Eco.Shared.Voxel.World.ToChunkPosition(Eco.Shared.Math.WrappedPosition3i)" /> works with unwrapped positions and returns unwrapped chunk position.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i ToChunkSpace(Vector3 worldPosition);

  /// <summary>Converts world space position to chunk space. Unlike <see cref="M:Eco.Shared.Voxel.World.ToChunkPosition(Eco.Shared.Math.WrappedPosition3i)" /> works with unwrapped positions and returns unwrapped chunk position.</summary>
  public static Vector3i ToChunkSpace(Vector3i worldPosition);

  public static Vector3 WrappedLerp(Vector3 start, Vector3 end, float percent);

  /// Warning: The coordinates are modulus/wrapping based on the chunk size, not relative to the chunk origin
  public static Vector3i ToLocalPosition(Vector3i point);

  /// Warning: The coordinates are modulus/wrapping based on the chunk size, not relative to the chunk origin
  public static Vector3i ToLocalPosition(int pointX, int pointY, int pointZ);

  /// <summary> Returns local block position within chunk space. All chunks should be aligned to <see cref="F:Eco.Shared.Voxel.Chunk.Size" />. Using <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> let us skip some check and use most optimized algorithm. </summary>
  public static Vector3i ToLocalPosition(WrappedWorldPosition3i worldPos);

  public static Vector3i ToMapPosition(Vector3i chunkPosition, Vector3i localPosition);

  public static Vector2i ToMapPosition(Vector2i chunkPosition, Vector2i localPosition);

  public static Eco.Shared.Math.Vector2 GetWrappedWorldPosition(Eco.Shared.Math.Vector2 worldPos);

  public static Vector2i GetWrappedWorldPosition(Vector2i worldPos);

  public static Vector3i GetWrappedWorldPosition(Vector3i worldPos);

  public static Vector3 GetWrappedWorldPosition(Vector3 worldPos);

  public static float WrappedDistance(WrappedPosition3 viewPosition, WrappedPosition3 position);

  public static float WrappedDistance(Eco.Shared.Math.Vector2 viewPosition, Eco.Shared.Math.Vector2 position);

  public static float WrappedDistance(Vector3 viewPosition, Vector3 position);

  public static float WrappedDistanceSq(WrappedPosition3 viewPosition, WrappedPosition3 position);

  public static float WrappedDistanceSq(Vector3 viewPosition, Vector3 position);

  public static float WrappedDistanceSq(Eco.Shared.Math.Vector2 viewPosition, Eco.Shared.Math.Vector2 position);

  public static Eco.Shared.Math.Vector2 ClosestWrappedLocation(
    Eco.Shared.Math.Vector2 viewPosition,
    Eco.Shared.Math.Vector2 position);

  public static Vector3 ClosestWrappedLocation(Vector3 viewPosition, Vector3 position);

  public static Vector3 ClosestWrappedLocationSafe(Vector3 viewPosition, Vector3 position);

  public static string SizeDescription { get; }
}
