// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.WorldLayerPusher`1
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers;

/// <summary>
/// Modifies the world to reflect the state of the world layer simulation, e.g. spawns and kills animals to make the population match.
/// </summary>
public abstract class WorldLayerPusher<TIntermediateDescription> : 
  IWorldLayerPusher,
  IWorldLayerRelationship
{
  /// <summary>Layer names which should be used to populate layerValues for <see cref="M:Eco.Simulation.WorldLayers.WorldLayerPusher`1.Apply(Eco.Shared.Math.WorldArea,System.Single[],Eco.Simulation.WorldLayers.WorldLayerNeighborInfo[],System.Int32)" />.</summary>
  public abstract string[] DependencyLayerNames { get; }

  public WorldLayer[] Dependencies { get; }

  public abstract void Apply(
    WorldArea area,
    float[] layerValues,
    WorldLayerNeighborInfo[] neighborValues,
    int length);

  public abstract string DescribeGeneral { get; }

  public string DescribeParameterized(WorldArea area);

  protected abstract TIntermediateDescription DescribeSpecific(
    WorldArea area,
    float[] layerValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected abstract string DescribeAggregated(
    IEnumerable<TIntermediateDescription> intermediateDescriptions);
}
