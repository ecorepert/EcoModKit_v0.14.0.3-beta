// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.AnimalSim
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.Agents;
using Eco.Simulation.Tracking;
using Eco.Simulation.Types;
using System;
using System.Numerics;

#nullable enable
namespace Eco.Simulation;

public class AnimalSim : Eco.Simulation.Simulation
{
  public AnimalPerfStats AnimalPerfStats;

  public ObserverManager ObserverManager { get; }

  /// <summary>
  /// Spawn alive animal from <paramref name="species" /> at <paramref name="pos" />.
  /// Optionally <paramref name="onCreate" /> action may be provided which will be called **before** animal registered as tickable.
  /// It ensures animal fully initialized before first tick.
  /// </summary>
  public Animal SpawnAnimal(
    AnimalSpecies species,
    Vector3 pos,
    int herdID,
    Action<Animal>? onCreate = null);

  /// <summary> Spawn animal's corpse from <paramref name="species" /> at <paramref name="pos" />. </summary>
  public Animal SpawnCorpse(AnimalSpecies species, Vector3 pos, int herdID);
}
