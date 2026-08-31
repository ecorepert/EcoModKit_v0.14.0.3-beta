// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.IWorldLayerPusher
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public interface IWorldLayerPusher : IWorldLayerRelationship
{
  int VoxelsPerEntry { get; }

  string[] DependencyLayerNames { get; }

  WorldLayer[] Dependencies { get; }

  void Apply(
    WorldArea area,
    float[] layerValues,
    WorldLayerNeighborInfo[] neighborValues,
    int length);
}
