// Decompiled with JetBrains decompiler
// Type: Eco.World.Pipes.PipePassThroughManager
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Serialization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.World.Pipes;

/// <summary>Remembers that a pipe runs through a wall voxel without replacing the wall, so the wall keeps sealing the room
/// while the fluid network and the client renderer treat the voxel as a pipe. Modeled on <see cref="T:Eco.World.Water.WaterManager" />.</summary>
[Serialized]
public class PipePassThroughManager : AutoSingleton<PipePassThroughManager>
{
  public void Initialize();

  public bool TryGet(Vector3i pos, out PassThroughEntry entry);

  public void Add(Vector3i pos, Type pipeBlockType, Direction orientation);

  public bool Remove(Vector3i pos, out PassThroughEntry entry);

  /// <summary>Packs this chunk's pass-throughs as ushort triples (localIndex, pipeBlockId, orientation) for client rendering, or null if none.</summary>
  public ushort[] PackForChunk(Vector3i chunkPos);

  [Serialized]
  public class PassThroughCacheData : IStorage, ISerializable
  {
    public IPersistent StorageHandle { get; set; }
  }
}
