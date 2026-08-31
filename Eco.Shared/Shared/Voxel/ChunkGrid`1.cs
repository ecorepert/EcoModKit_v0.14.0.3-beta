// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.ChunkGrid`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Voxel;

public abstract class ChunkGrid<TChunk> : IChunkGrid where TChunk : class, IChunk
{
  public event Action<Vector3i> SizeChangedEvent;

  public abstract TChunk CreateChunk(Vector3i chunkPos);

  public Guid Guid { get; protected set; }

  public IEnumerable<TChunk> Chunks { get; }

  public int ChunksCount { get; }

  public Vector3i MinChunkPos { get; }

  public Vector3i MaxChunkPos { get; }

  public Vector3i WrappedChunkSize { get; }

  public Vector3i WrappedVoxelSize { get; }

  public ChunkGrid();

  public ChunkGrid(IChunkContainer<TChunk> container, bool threadSafe);

  public void SetVoxelSize(Vector3i size);

  protected Vector3i GetWrappedChunkPosition(Vector3i chunkPos);

  protected Vector3i GetWrappedChunkPositionInternal(Vector3i chunkPos);

  public TChunk GetChunk(Vector3i chunkPos);

  /// <summary>Returns all non-empty chunks in chunk <paramref name="column" />.</summary>
  public IEnumerable<TChunk> GetChunkColumn(Vector2i column);

  public IEnumerable<IChunk> GetChunks(WorldRange range);

  /// <summary>Gets all chunks in <paramref name="ranges" /> (unwrapped).</summary>
  public IEnumerable<IChunk> GetChunks(IEnumerable<WorldRange> ranges);

  public IEnumerable<IChunk> GetVisibleChunks(Vector3 observerPosition, float viewDistance);

  public TChunk GetOrAddChunk(Vector3i chunkPos);

  public void AddChunk(TChunk chunk);

  public virtual void RemoveChunk(TChunk chunk);

  public virtual void Clear(Guid newGuid);

  public Vector3 ClosestWrappedLocation(Vector3 viewPosition, Vector3 position);
}
