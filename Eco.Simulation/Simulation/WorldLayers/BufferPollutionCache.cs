// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.BufferPollutionCache
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;
using System.Collections.Concurrent;
using System.Threading;

#nullable disable
namespace Eco.Simulation.WorldLayers;

[Serialized]
public class BufferPollutionCache : IStorage, ISerializable
{
  public static Func<Vector3i, (GroundPollutionType Type, float Amount)[]> FractionalPollutionResolver;

  public IPersistent StorageHandle { get; set; }

  [Serialized]
  public ThreadSafeDictionary<Vector2i, BufferCellSums> CellSums { get; }

  [Serialized]
  public ThreadSafeDictionary<Vector3i, BufferCellSums> BlockReverse { get; }

  public ConcurrentDictionary<Vector2i, ConcurrentDictionary<int, GroundPolluterContainer>> ContainerBuckets { get; }

  public BufferPollutionCache(IPersistent storageHandle);

  public void Initialize();

  public void DoCacheUpdate(CancellationToken token);

  public float GetBlockSum(Vector2i xz, GroundPollutionType type);

  public void SetContainer(int parentId, Vector2i cell, float soil, float heavy, float chem);

  public void RemoveContainer(int parentId, Vector2i cell);

  public float GetContainerSum(Vector2i xz, GroundPollutionType type);
}
