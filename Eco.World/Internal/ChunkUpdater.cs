// Decompiled with JetBrains decompiler
// Type: Eco.World.Internal.ChunkUpdater
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Collections;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.World.Internal;

/// <summary>
/// <see cref="T:Eco.World.Internal.ChunkUpdater" /> is central place for all chunk synchronization logic.
/// It manages clients subscribe/unsubscribe chunks logic and then ensures clients receives subscribed chunks and all updates for subscribed chunks.
/// Updates grouped by clients and will broadcast if possible.
/// It uses two main collection for chunk updates processing:
/// - <see cref="F:Eco.World.Internal.ChunkUpdater.chunkQueues" /> contains per-client
/// </summary>
internal class ChunkUpdater
{
  public ChunkUpdater(WorldChunkGrid chunkGrid);

  /// <summary>Subscribe client for <paramref name="chunkColumns" />.</summary>
  public void SubscribeChunkColumns(INetClient client, List<Vector2i> chunkColumns);

  /// <summary>Unsubscribe client from <paramref name="chunkColumns" />.</summary>
  public void UnsubscribeChunkColumns(INetClient client, HashSet<Vector2i> chunkColumns);

  /// <summary>Approximate number of chunk column deliveries still queued for <paramref name="client" />, as published by the last <see cref="M:Eco.World.Internal.ChunkUpdater.Service" /> pass. Safe to poll from any thread.</summary>
  public int GetPendingColumnCount(INetClient client);

  /// <summary>Main loop method which should be called regular to deliver chunk changes and subscribed/unsubscribed chunks.</summary>
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Service();

  /// <summary>Notify chunk changed for updates scheduling.</summary>
  public void NotifyChunkChanged(WorldChunk chunk);

  /// <summary>Notify client disconnected for cleanup.</summary>
  public void NotifyClientDisconnected(INetClient client);

  /// <summary><see cref="T:Eco.World.Internal.ChunkUpdater.IDelivery" /> is a common interface for modified chunk and subscribed chunk column to be processed in generic way.</summary>
  private interface IDelivery
  {
    Vector2i ChunkColumn { get; }

    /// <summary>Send delivery using <paramref name="chunkUpdater" /> to <paramref name="clients" />.</summary>
    void Send(ChunkUpdater chunkUpdater, UnscopedEnumerable<INetClient> clients);

    /// <summary>Get deliveries capacity for <paramref name="observer" />.</summary>
    static abstract int GetCapacity(IWorldObserver observer);

    /// <summary>Sets deliveries capacity for <paramref name="observer" />.</summary>
    static abstract void SetCapacity(IWorldObserver observer, int capacity);
  }

  /// <summary><see cref="T:Eco.World.Internal.ChunkUpdater.ChunkColumnSynchronizationInfo" /> contains per-chunk column info for chunk updates tracking.</summary>
  private sealed class ChunkColumnSynchronizationInfo : HashSet<INetClient>
  {
    public double SyncTime;
  }

  /// <summary>Represents asynchronously added command which then should be executed with <see cref="M:Eco.World.Internal.ChunkUpdater.ExecutePendingCommands" />. We don't apply it immediately to avoid concurrency.</summary>
  private readonly struct Command : IEquatable<ChunkUpdater.Command>
  {
    /// <summary>Represents asynchronously added command which then should be executed with <see cref="M:Eco.World.Internal.ChunkUpdater.ExecutePendingCommands" />. We don't apply it immediately to avoid concurrency.</summary>
    public Command(IReadOnlyCollection<Vector2i> ChunkColumns, INetClient Client, bool Subscribed);

    public IReadOnlyCollection<Vector2i> ChunkColumns { get; init; }

    public INetClient Client { get; init; }

    public bool Subscribed { get; init; }

    [CompilerGenerated]
    public override 
    #nullable disable
    string ToString();

    [CompilerGenerated]
    public static bool operator !=(ChunkUpdater.Command left, ChunkUpdater.Command right);

    [CompilerGenerated]
    public static bool operator ==(ChunkUpdater.Command left, ChunkUpdater.Command right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(ChunkUpdater.Command other);

    [CompilerGenerated]
    public void Deconstruct(
      out 
      #nullable enable
      IReadOnlyCollection<Vector2i> ChunkColumns,
      out INetClient Client,
      out bool Subscribed);
  }

  /// <summary>Delivery for chunk column. Uses for newly subscribed chunk columns.</summary>
  private struct ChunkColumnDelivery : 
    IEquatable<ChunkUpdater.ChunkColumnDelivery>,
    IComparable<ChunkUpdater.ChunkColumnDelivery>,
    ChunkUpdater.IDelivery
  {
    private Vector2 chunkCenter;
    private float sortKey;

    public Vector2i ChunkColumn { get; }

    public ChunkColumnDelivery(Vector2i column);

    public void Send(ChunkUpdater chunkUpdater, UnscopedEnumerable<INetClient> clients);

    /// <summary>Update sort key for prioritized chunks delivery based on distance to player.</summary>
    public void UpdateSortKey(Vector2 chunkOrigin);

    public static int GetCapacity(IWorldObserver observer);

    public static void SetCapacity(IWorldObserver observer, int capacity);

    public bool Equals(ChunkUpdater.ChunkColumnDelivery other);

    public override bool Equals(object? obj);

    public override int GetHashCode();

    public int CompareTo(ChunkUpdater.ChunkColumnDelivery other);
  }

  /// <summary>Single chunk delivery for already delivered chunk change.</summary>
  private readonly struct ChunkDelivery : 
    ChunkUpdater.IDelivery,
    IEquatable<ChunkUpdater.ChunkDelivery>
  {
    /// <summary>Single chunk delivery for already delivered chunk change.</summary>
    public ChunkDelivery(WorldChunk Chunk);

    public WorldChunk Chunk { get; init; }

    public Vector2i ChunkColumn { get; }

    public void Send(ChunkUpdater chunkUpdater, UnscopedEnumerable<INetClient> clients);

    public static int GetCapacity(IWorldObserver observer);

    public static void SetCapacity(IWorldObserver observer, int capacity);

    [CompilerGenerated]
    public override 
    #nullable disable
    string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      ChunkUpdater.ChunkDelivery left,
      ChunkUpdater.ChunkDelivery right);

    [CompilerGenerated]
    public static bool operator ==(
      ChunkUpdater.ChunkDelivery left,
      ChunkUpdater.ChunkDelivery right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(ChunkUpdater.ChunkDelivery other);

    [CompilerGenerated]
    public void Deconstruct(out 
    #nullable enable
    WorldChunk Chunk);
  }
}
