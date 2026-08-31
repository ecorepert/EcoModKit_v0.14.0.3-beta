// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Pullers.PlantPopulationPuller
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using Eco.Simulation.WorldLayers.Layers;
using NetFabric.Hyperlinq;

#nullable enable
namespace Eco.Simulation.WorldLayers.Pullers;

/// <summary> Special kind of IStartupWorldLayerPuller which tracks added/removed plants between ticks and apply changes when tick happens. It also sync layer with actual plants count on startup. </summary>
public class PlantPopulationPuller : 
  IStartupWorldLayerPuller,
  IWorldLayerPuller,
  IWorldLayerRelationship
{
  public PlantPopulationPuller(WorldLayer outputLayer, PlantSpecies species);

  public string DescribeGeneral { get; }

  public string DescribeParameterized(WorldArea area);

  public string OutputLayerName { get; }

  public WorldLayer OutputLayer { get; }

  /// <summary> Returns population delta for current added/remove plants snapshot. It will be negative value if removed plants more than added and positive otherwise. </summary>
  public int PopulationDelta(WorldArea area);

  public float Apply(WorldArea area);

  public float ApplyDestructive(WorldArea area);

  /// <summary> On startup ensures world plants count and layer plants count synced. </summary>
  public float GetStartupValue(Vector2i layerPos, WorldArea area);

  public void AddPlant(Plant plant);

  public void RemovePlant(Plant plant);

  /// <summary>Function which checks if plant belongs to a specific area. Uses with NetFabric.Hyperlinq for zero-allocation filters.</summary>
  private readonly struct PlantInAreaFilter : IFunction<Plant, bool>
  {
    private readonly WorldArea area;

    public PlantInAreaFilter(WorldArea area);

    public bool Invoke(Plant plant);
  }
}
