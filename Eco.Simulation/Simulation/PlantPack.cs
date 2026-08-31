// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.PlantPack
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation.Agents;

#nullable disable
namespace Eco.Simulation;

[Serialized]
public class PlantPack : IStorage, ISerializable
{
  public IPersistent StorageHandle { get; set; }

  [Serialized]
  public Vector2i Key { get; set; }

  [Serialized]
  public ThreadSafeList<Plant> Plants { get; }

  public PlantPack(Vector2i key, IPersistent storageHandle);

  public void Add(Plant plant);

  public void Remove(Plant plant);

  public void MarkDirty();

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();
}
