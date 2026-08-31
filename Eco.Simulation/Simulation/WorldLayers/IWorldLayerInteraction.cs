// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.IWorldLayerInteraction
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Simulation.WorldLayers.Layers;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public interface IWorldLayerInteraction : IWorldLayerRelationship
{
  WorldLayer[] Dependencies { get; }

  string[] DependencyLayerNames { get; }

  WorldLayer[] PostWorldgenDependencies { get; }

  string[] WorldInitDependencyLayerNames { get; }

  WorldLayer OutputLayer { get; }

  string OutputLayerName { get; }

  float Apply(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  float PostWorldgen(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  bool Verify(List<LocString> errors);

  bool RequiresNeighborhood { get; }
}
