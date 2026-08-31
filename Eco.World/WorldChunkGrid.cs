// Decompiled with JetBrains decompiler
// Type: Eco.World.WorldChunkGrid
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.Voxel;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.World;

public abstract class WorldChunkGrid : ChunkGrid<
#nullable disable
PersistentChunk>, INetObject, INetObjectPriority
{
  public float Priority { get; }

  /// <summary>Registers a preload anchor for <paramref name="client" />: chunk columns around <paramref name="pos" /> stream in addition to the observer's own view range.</summary>
  public void SetPreloadAnchor(INetClient client, Vector3 pos, float radius);

  /// <summary>Clears the preload anchor; its columns unsubscribe on the next update unless the observer's own range now covers them.</summary>
  public void ClearPreloadAnchor(INetClient client);

  /// <summary>Drops all anchor state for a disconnected client (its subscriptions die with the connection).</summary>
  public void RemovePreloadAnchor(INetClient client);

  public NetObject NetObj { get; }

  public int ID { get; }

  public bool Active { get; set; }

  public double NetObjectCreationRealtime { get; set; }

  public NetworkChannel UpdateChannel { get; }

  public NetworkChannel InitialStateChannel { get; }

  public Vector3i ChunkSize { get; }

  public Vector3i VoxelSize { get; }

  public WorldChunkGrid();

  public WorldChunkGrid(IChunkContainer<PersistentChunk> container, bool threadSafe);

  public WorldChunkGrid(
    NetObject owner,
    IChunkContainer<PersistentChunk> container,
    bool threadSafe);

  /// <summary> Completes arrays of top block position and top solid block type into arrays. It's faster than go column by column since it re-uses same chunk for all positions (and chunk look up is slow) </summary>
  public void FillCache(
    Vector2i chunkPos2D,
    Array2D<int> topBlockHeight,
    Array2D<Block> topSolidBlock);

  public int GetMaxY(Vector2i worldPos);

  public int GetTopBlockHeight(Vector2i worldPos);

  public Block GetTopSolidBlock(Vector2i worldPos);

  public void SetBlocks(IEnumerable<BlockChange> blocks);

  public Block SetBlock(Type blockType, WrappedWorldPosition3i worldPos, params object[] args);

  /// <summary> If you know the chunk you can pass it to avoid lookup for better performance </summary>
  public Block SetBlock(
    Type blockType,
    WrappedWorldPosition3i worldPos,
    PersistentChunk chunk = null,
    params object[] args);

  public Block SetBlock<T>(WrappedWorldPosition3i worldPos, params object[] args) where T : Block;

  /// <summary> If you know the chunk you can pass it to avoid lookup for better performance </summary>
  public Block SetBlock<T>(
    WrappedWorldPosition3i worldPos,
    PersistentChunk chunk = null,
    params object[] args)
    where T : Block;

  /// <summary>See <see cref="M:Eco.World.World.DeleteBlock(Eco.Shared.Math.WrappedWorldPosition3i,System.Boolean)" /></summary>
  public virtual void DeleteBlock(WrappedWorldPosition3i worldPos, bool checkForWaterFlow = true);

  public Block GetBlock(WrappedWorldPosition3i worldPos);

  public void CalculateChunkEncasement(Action<float> updateAction);

  public virtual void ReceiveInitialState(BSONObject bsonObj);

  public virtual void ReceiveUpdate(BSONObject bsonObj);

  public virtual void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual bool IsRelevant(INetObjectViewer viewer);

  public virtual bool IsNotRelevant(INetObjectViewer viewer);

  public virtual bool IsUpdated(INetObjectViewer viewer);

  public virtual void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  /// <summary>Extra subscription anchor streaming chunks around a position the observer is not at yet (teleport preload). Applied* tracks what the last subscription diff used.</summary>
  private sealed class PreloadAnchor : IEquatable<WorldChunkGrid.PreloadAnchor>
  {
    /// <summary>Extra subscription anchor streaming chunks around a position the observer is not at yet (teleport preload). Applied* tracks what the last subscription diff used.</summary>
    public PreloadAnchor(
      Vector3 Pos,
      float Radius,
      bool Cleared = false,
      Vector3? AppliedPos = null,
      float AppliedRadius = 0.0f);

    public Vector3 Pos { get; init; }

    public float Radius { get; init; }

    public bool Cleared { get; init; }

    public Vector3? AppliedPos { get; init; }

    public float AppliedRadius { get; init; }

    [CompilerGenerated]
    public override 
    #nullable enable
    string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      WorldChunkGrid.PreloadAnchor? left,
      WorldChunkGrid.PreloadAnchor? right);

    [CompilerGenerated]
    public static bool operator ==(
      WorldChunkGrid.PreloadAnchor? left,
      WorldChunkGrid.PreloadAnchor? right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object? obj);

    [CompilerGenerated]
    public bool Equals(WorldChunkGrid.PreloadAnchor? other);

    [CompilerGenerated]
    public WorldChunkGrid.PreloadAnchor \u003CClone\u003E\u0024();

    [CompilerGenerated]
    public void Deconstruct(
      out Vector3 Pos,
      out float Radius,
      out bool Cleared,
      out Vector3? AppliedPos,
      out float AppliedRadius);
  }
}
