// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.WorldLayerPuller`1
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
/// Modifies a world layer based on the state of the world and events since the last tick, e.g. adjusts animal population based on player hunting activity.
/// </summary>
public abstract class WorldLayerPuller<TIntermediateDescription> : 
  IWorldLayerPuller,
  IWorldLayerRelationship
{
  public abstract string OutputLayerName { get; }

  public WorldLayer OutputLayer { get; }

  public abstract float Apply(WorldArea area);

  public abstract float ApplyDestructive(WorldArea area);

  public abstract string DescribeGeneral { get; }

  public string DescribeParameterized(WorldArea area);

  protected abstract TIntermediateDescription DescribeSpecific(WorldArea area);

  protected abstract string DescribeAggregated(
    IEnumerable<TIntermediateDescription> intermediateDescriptions);
}
