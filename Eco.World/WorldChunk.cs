// Decompiled with JetBrains decompiler
// Type: Eco.World.WorldChunk
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Voxel;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.World;

[Serialized]
public class WorldChunk : IChunk
{
  public static readonly ThreadSafeAction<Vector3i, Vector3i, Block, Block> ChunkAndBlockChangedEvent;
  public static readonly ThreadSafeAction<WorldChunk> ChunkChangedEvent;
  [Serialized]
  protected Block?[] blocks;

  [Serialized]
  public Vector3i Position { get; set; }

  [Serialized]
  public int Encasement { get; }

  [Serialized]
  public double LastUpdated { get; }

  public IEnumerable<Block?> Blocks { get; }

  public virtual void OnChanged();

  /// <summary> Gets "Block" from local chunk pos coords. Has internal check for negative height. Chunks starts from y = 0. If lower -&gt; returns empty block </summary>
  public virtual Block GetBlock(Vector3i localPosition);

  protected virtual void SetBlockInternal(Block? block, Vector3i localPosition);

  public void SetBlockUnsafe(Block? block, Vector3i localPos);

  public Block SetBlock(Type blockType, Vector3i localPosition, params object[] args);

  public Block SetBlock<T>(Vector3i localPosition, params object[] args) where T : Block;

  public void DeleteBlock(Vector3i localPosition);

  protected void ConvertBlocks();

  public virtual BSONObject PackIntoBson();

  public bool[] EncasesNeighbors();

  public bool[] EncasesWaterNeighbors();

  public override string ToString();
}
