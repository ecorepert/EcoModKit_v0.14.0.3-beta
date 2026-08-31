// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.DebrisCache
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Simulation.WorldLayers;

/// <summary> Caches information about tree debris presence in the world. Used in plant and trampling simulation. </summary>
[Serialized]
public class DebrisCache : IStorage, ISerializable
{
  public IPersistent StorageHandle { get; set; }

  /// <summary> Cache contains mapping between X,Z and Y of tree debris. It only supports one tree debris in a column which should be fine in 99.999% cases and we don't need 100% precision here. </summary>
  [Serialized]
  public ThreadSafeDictionary<Vector2i, int> Cache { get; }

  public DebrisCache(IPersistent storageHandle);

  public void Initialize(Vector3i worldVoxelSize);

  /// <summary> Flushes queued block changes and actualizes cache state. </summary>
  public void Flush();
}
