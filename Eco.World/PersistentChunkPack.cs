// Decompiled with JetBrains decompiler
// Type: Eco.World.PersistentChunkPack
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.World;

[Serialized]
public class PersistentChunkPack : PersistentChunkObject
{
  [Serialized]
  public Vector3i Key { get; set; }

  public IStorageManager StorageManager { get; set; }

  public PersistentChunkPack();

  public PersistentChunkPack(Vector3i key, IPersistent storageHandle);

  public void AddChunk(PersistentChunk chunk);

  public void RemoveChunk(PersistentChunk chunk);

  public void ForEachChunk(Action<PersistentChunk> action);

  public void MarkDirty();

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();
}
