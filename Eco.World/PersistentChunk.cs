// Decompiled with JetBrains decompiler
// Type: Eco.World.PersistentChunk
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using ConcurrentCollections;
using Eco.Core.Serialization.Migrations;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.World;

[Serialized]
[SerializesType(typeof (Block[]))]
public class PersistentChunk : WorldChunk
{
  public const int NumIdleTicksBeforeFreezing = 15;

  public PersistentChunkPack Container { get; }

  public static ConcurrentHashSet<PersistentChunk> ActiveChunks { get; }

  public bool Active { get; }

  [Serialized]
  public bool HasTransientBlocks { get; }

  public bool Frozen { get; }

  public PersistentChunk();

  public PersistentChunk(PersistentChunkPack container);

  public override BSONObject PackIntoBson();

  public void RemoveTransientBlocks();

  public void TryFreeze();

  public void Freeze();

  /// <summary>
  /// Converts chunk from old format to new chunk format using <paramref name="migrationManager" />.
  /// It is required, because for optimization purposes chunk contains serialized blocks data, but when
  /// schema changes block ids may be changed as well.
  /// </summary>
  /// <param name="migrationManager">Migration manager containing information about old and new schemas.</param>
  /// <param name="legacy">this flag used only for backward compatibility with 8.3, may be removed in 10.0.</param>
  public void Convert(MigrationManager migrationManager, bool legacy);

  /// <summary> It may not invalidate cache in case if it was thawed just for readonly access. Readonly access means that it have to make again array of blocks, but it doesnt changed anything, so cached bson bytes are still valid for sending to clients.  </summary>
  public void Thaw(bool invalidateCache = true);

  public void OnNeighborEdgeChanged(Type blockType);

  public override void OnChanged();

  public void WakeUp(Vector3i localPosition);

  public void WakeUpFromNeighbour(Vector3i localPosition);

  public void SetContainer(PersistentChunkPack container);

  [Eco.Shared.Serialization.OnDeserialized]
  protected void OnDeserialized();

  public void TryTick();

  public override Block GetBlock(Vector3i localPosition);

  protected override void SetBlockInternal(Block block, Vector3i localPosition);

  /// <summary>Recalculates if chunk has <see cref="T:Eco.World.Blocks.Transient" /> blocks, updates <see cref="P:Eco.World.PersistentChunk.HasTransientBlocks" /> property and returns new value. If the chunk is frozen then just returns current value or <c>false</c> if undefined.</summary>
  public bool UpdateHasTransientBlocks();
}
