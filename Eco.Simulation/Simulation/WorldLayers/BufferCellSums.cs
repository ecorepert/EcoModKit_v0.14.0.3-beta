// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.BufferCellSums
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Simulation.WorldLayers;

[Serialized]
public class BufferCellSums
{
  [Serialized]
  public float Soil { get; set; }

  [Serialized]
  public float HeavyMineral { get; set; }

  [Serialized]
  public float Chemical { get; set; }

  public float Get(GroundPollutionType type);

  public void Add(GroundPollutionType type, float delta);

  public bool IsEmpty { get; }
}
