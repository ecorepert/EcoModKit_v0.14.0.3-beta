// Decompiled with JetBrains decompiler
// Type: Eco.World.World
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.World;

public abstract class World : Eco.Shared.Voxel.World
{
  public static 
  #nullable disable
  Array2D<int> MaxYCache { get; set; }

  public static Array2D<int> MaxWaterHeight { get; set; }

  public static Array2D<Block> TopBlockCache { get; set; }

  public static IEnumerable<PersistentChunk> Chunks { get; }

  public static int ChunksCount { get; }

  public static ThreadSafeAction<Vector2i, int> OnTopBlockChanged { get; }

  public static ThreadSafeAction<WrappedWorldPosition3i> OnBlockChanged { get; }

  public static ThreadSafeAction<Vector2i> OnTopOrWaterBlockCacheChanged { get; }

  public static IEnumerable<PersistentChunk> XZChunks(Vector2i columnPos);

  public static bool Locked { get; }

  public static void Lock();

  public static void Unlock();

  public static void Initialize(WorldChunkGrid chunkGrid);

  public static void Initialize(Vector3i chunkSize);

  public static void UpdateMaxHeight(int maxHeight);

  public static void CalculateChunkEncasement(Action<float> updateAction);

  /// <summary>Streams chunk columns around <paramref name="pos" /> to <paramref name="client" /> in addition to its own view range (teleport preload).</summary>
  public static void SetChunkPreloadAnchor(INetClient client, Vector3 pos, float radius);

  /// <summary>Clears the preload anchor set by <see cref="M:Eco.World.World.SetChunkPreloadAnchor(Eco.Shared.Networking.INetClient,System.Numerics.Vector3,System.Single)" />.</summary>
  public static void ClearChunkPreloadAnchor(INetClient client);

  /// <summary>Approximate number of chunk column deliveries still queued for <paramref name="client" />. Safe to poll from any thread.</summary>
  public static int PendingChunkColumns(INetClient client);

  public static PersistentChunk GetChunk(Vector3i chunkPos);

  /// <summary>Returns the block at the location or Block.Empty. Returns <see cref="P:Eco.World.Blocks.Block.Empty" /> for invalid <paramref name="worldPos" /> (i.e. Y negative or Z above top block).</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Block GetBlock(Vector3i worldPos);

  /// <summary>Returns the block at the location or Block.Empty.</summary>
  public static Block GetBlock(WrappedPosition3i worldPos);

  /// <summary>Returns the block at the location or Block.Empty.</summary>
  public static Block GetBlock(WrappedWorldPosition3i worldPos);

  /// <summary>Returns type of the block located at given position.</summary>
  public static Type GetBlockType(Vector3i worldPos);

  /// <summary>Returns type of the block located at given position.</summary>
  public static Type GetBlockType(WrappedPosition3i worldPos);

  /// <summary>Returns type of the block located at given position.</summary>
  public static Type GetBlockType(WrappedWorldPosition3i worldPos);

  public static Block GetBlockFromChunkIfPossible(Vector3i pos, PersistentChunk chunk);

  public static Vector3i GetTopGroundPos(Vector2i worldPos);

  public static Vector3i GetTopGroundPos(Vector3i worldPos);

  /// <summary>Returns the position of the topmost solid, non-constructed block in a world column.</summary>
  public static (Vector3i Position, Block Block, bool IsUnderConstructed) GetTopSolidNonConstructedPos(
    Vector2i worldColumn);

  public static Vector3i GetTopPathPos(Vector2i worldPos);

  /// <summary> Clamps Y coordinate of <paramref name="pos" /> to water height </summary>
  public static Vector3i ClampToWaterHeight(Vector3i pos);

  public static Block GetBlockProbablyTop(WrappedWorldPosition3i worldPos);

  public static T SetBlock<T>(WrappedWorldPosition3i worldPos, params object[] args) where T : Block;

  /// <summary> If you know the chunk you can pass it to avoid lookup for better performance </summary>
  public static T SetBlock<T>(
    WrappedWorldPosition3i worldPos,
    PersistentChunk chunk = null,
    params object[] args)
    where T : Block;

  public static Block SetBlock(
    Type blockType,
    WrappedWorldPosition3i worldPos,
    params object[] args);

  /// <summary> If you know the chunk you can pass it to avoid lookup for better performance </summary>
  public static Block SetBlock(
    Type blockType,
    WrappedWorldPosition3i worldPos,
    PersistentChunk chunk = null,
    params object[] args);

  public static void BatchApply(IEnumerable<BlockChange> changes);

  /// <summary>Deletes the block at from the world at worldPos.</summary>
  /// <param name="worldPos">The world position of the block to be deleted.</param>
  /// <param name="checkForWaterFlow">Set to true to replace the block with Block.Empty. Ie. Crater should force delete the terrain. Handles removing blocks underwater.</param>
  public static void DeleteBlock(WrappedWorldPosition3i worldPos, bool checkForWaterFlow = true);

  /// <summary> Forces chunk dirty at specified block pos </summary>
  public static void ForceUpdate(WrappedWorldPosition3i worldPos);

  /// <summary> Forces chunk dirty at specified block positions, updates once per chunk. Useful for lots of positions in same chunk </summary>
  public static void ForceUpdateBatch(IEnumerable<WrappedWorldPosition3i> worldPositions);

  /// <summary> Ensures the given ChunkPos is world-wrapped. </summary>
  public static Vector3i WorldWrapChunkPos(Vector3i chunkPos);

  public static IEnumerable<PersistentChunk> ChunksInRange(WorldRange range);

  /// <summary> Returns all the current chunks at the given XZ chunkPos coordinate organized from lowest to highest. </summary>
  public static IEnumerable<PersistentChunk> GetChunkColumn(Vector2i pos);

  /// <summary> Returns all the current chunks starting (inclusively) at the given chunkPos coordinate extending to the top of the column in ascending order. </summary>
  public static IEnumerable<PersistentChunk> GetChunkColumnAscendingFrom(Vector3i pos);

  /// <summary> Returns all the current chunks at the given XZ chunkPos coordinate organized from highest to lowest. </summary>
  public static IEnumerable<PersistentChunk> GetChunkColumnFromTop(Vector2i pos);

  /// <summary> Pass chunk of world pos so it dont have to go to chunk table which is slow </summary>
  public static void AwakeNear(WrappedWorldPosition3i worldPos, PersistentChunk chunkAtPosition);

  public static void AwakeNearDiagonals(WrappedWorldPosition3i worldPos);

  public static PersistentChunk GetChunkWorld(Vector3i worldPos);

  public static void InitCachedData(Vector2i size);

  /// <summary> Invalidates top block and underwater block caches for every X,Z in the world. It will only trigger cache update events if <paramref name="notify" /> set to <c>true</c>. </summary>
  public static void ReCacheAllData(bool notify = true);

  public static void ResetCache();

  /// <summary>Invalidates all block caches for requested set of chunk column positions (as 2D chunk positions).</summary>
  public static void ReCacheColumns(
    IEnumerable<Vector2i> chunkPosXZ,
    int columnsCount,
    bool notify = true);

  public static Block GetTopBlock(Vector2i worldPos);

  /// <summary>The y position above the top solid block</summary>
  public static int GetTopEmptyBlock(Vector2i worldPos);

  public static Vector3i GetTopEmptyPos(Vector2i worldPos);

  public static WorldPosition3i GetTopEmptyPos(WorldPosition2i worldPos);

  /// <summary>The position either one block over the top ground, or the position of the top water spot (not one above the water, exact height)</summary>
  public static Vector3i GetTopEmptyPosOrWaterBlock(Vector2i worldPos);

  public static bool TopIsWater(Vector2i pos);

  public static WorldPosition3i GetTopPathPos(WorldPosition2i worldPos);

  /// <summary>The y position of the top solid block</summary>
  public static int GetTopSolidBlockY(Vector2i worldPos);

  /// <summary>Faster than GetTopBlockY but don't performs wrapping </summary>
  public static int GetTopSolidBlockYRaw(Vector2i worldPos);

  /// <summary>Faster than GetTopBlockY but don't performs wrapping </summary>
  public static int GetTopSolidBlockYRaw(int x, int y);

  /// <summary>Check the cached water and block heights to see if this position is water at the top block.</summary>
  public static bool WaterAtTop(Vector2i pos);

  /// <summary>Y position of the top solid block underwater.</summary>
  public static int GetTopSolidBlockUnderwater(Vector2i waterPos, int maxDeep = 5);

  /// <summary>Return the highest position occupied by a block (land or water) at the position that is passed in the parameter.</summary>
  /// <param name="pos">Position to check. Doesn't have to be wrapped.</param>
  /// <returns>Unwrapped position, unless passed argument was already wrapped.</returns>
  public static Vector3i GetTopBlockPos(Vector2i pos);

  /// <summary>Return the highest Y position occupied by a block (land or water) at the position that is passed in the parameter.</summary>
  /// <param name="pos">Position to check. Doesn't have to be wrapped.</param>
  public static int GetTopBlockY(Vector2i pos);

  public static Block NextBlockUp(Vector3i pos);

  public static int GetWaterHeight(Vector2i worldPos);

  public static void Clear();

  public static bool IsUnderwater(Vector2i blockPos);

  public static bool IsUnderwater(WorldPosition3i blockPos);

  public static bool IsUnderwater(WrappedWorldPosition3i blockPos);

  public static bool IsUnderwater(WrappedPosition3i blockPos);

  public static bool IsConstructed(Vector2i blockPos);

  public static bool IsSolidOrOccupied(WrappedWorldPosition3i blockPos);

  public static Vector3i MaxYPos(Vector2i pos);

  public static WorldPosition3i MaxYPos(WorldPosition3i pos);

  public static WorldPosition3i MaxWaterPos(WorldPosition3i pos);

  public static Vector3i RandomMapPos();

  public static Vector3i RandomMapPos(Random randomizer);

  public static WorldPosition3i GetRandomLandPos();

  public static WorldPosition3i GetRandomLandPos(Random randomizer);

  public static Vector3i BlockAtOrBelow(Vector3i pos);

  public static Vector3i GetRandomLandPosNear(Vector3i nearPos, float radius = 10f);

  public static bool AllNeighborsMatchOrHigher(Vector3i pos);

  public static Vector3i GetEmptyPilePosition(Vector2i xzPos);

  public static Vector3i FindPyramidPos(Vector3i start);

  public static int GetDeepestNeighbor(Vector3i pos, out Vector3i outvec);

  public static int GetDepth(Vector3i pos);

  public static bool IsPathPos(WrappedPosition3i pos);

  public static bool IsTopGround(WrappedPosition3i pos);

  /// <summary> Checks if position is inside vertical world bounds </summary>
  public static bool IsLegalVerticalPosition(Vector3 pos);
}
