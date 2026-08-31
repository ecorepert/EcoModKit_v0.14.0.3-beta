// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Pushers.PlantSpawner
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.Types;
using Eco.Simulation.WorldLayers.Layers;
using System.Collections.Generic;

#nullable enable
namespace Eco.Simulation.WorldLayers.Pushers;

public sealed class PlantSpawner : 
  WorldLayerPusher<float>,
  IWorldLayerPusher,
  IWorldLayerRelationship,
  IPostWorldGenWorldLayerPusher
{
  public override 
  #nullable disable
  string[] DependencyLayerNames { get; }

  int IWorldLayerPusher.VoxelsPerEntry { get; }

  /// <inheritdoc cref="M:Eco.Simulation.WorldLayers.IWorldLayerPusher.Apply(Eco.Shared.Math.WorldArea,System.Single[],Eco.Simulation.WorldLayers.WorldLayerNeighborInfo[],System.Int32)" />
  public override void Apply(
    WorldArea area,
    float[] unused,
    WorldLayerNeighborInfo[] neighborValues,
    int length);

  public override string DescribeGeneral { get; }

  protected override float DescribeSpecific(
    WorldArea area,
    float[] layerValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override string DescribeAggregated(IEnumerable<float> intermediateDescriptions);

  /// <inheritdoc cref="M:Eco.Simulation.WorldLayers.IPostWorldGenWorldLayerPusher.PostWorldGenPush(Eco.Shared.Math.WorldArea,System.Single[],Eco.Simulation.WorldLayers.WorldLayerNeighborInfo[],System.Int32)" />
  public void PostWorldGenPush(
    WorldArea area,
    float[] unused,
    WorldLayerNeighborInfo[] neighborValues,
    int length);

  /// <summary> Layers layout info for <see cref="T:Eco.Simulation.WorldLayers.Pushers.PlantSpawner" /> dependencies. </summary>
  private sealed class LayersInfo
  {
    public int MaxVoxelsPerEntry;
    public int MinVoxelsPerEntry;
    public WorldLayer TrampledLayer;
    public (int VoxelsPerEntry, PlantLayer[] Layers)[] PlantLayerGroups;
    public WorldLayer[] CapacityLayers;
    public string[] CapacityLayerNames;
  }

  /// <summary>
  /// <see cref="T:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity" /> class holds information about available capacity for <see cref="F:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.LayerNames" /> with <see cref="F:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.VoxelsPerEntry" /> granularity.
  /// <see cref="F:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.AvailableCapacities" /> has flatten 2D array structure of [[availableCapacitiesPerLayerForCell1], [availableCapacitiesPerLayerForCell2], .., [availableCapacitiesPerLayerForCellN]].
  /// Each such cell is for <see cref="F:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.VoxelsPerEntry" /> dimension. In each cell it has LayerNames.Count entries one value per capacity layer with same index as in LayerNames.
  /// We need to have multiple cells in available capacities because of some plants like trees may use multiple capacity cells and should consume capacity from all of them evenly if possible.
  /// Small plants usually consume capacity only from one capacity cell.
  /// It is up to constructor calling code how to order cells, but usually it has Y groups of X size and offset of each cell may be calculated as (Y * xSize + X) * LayerNames.Count.
  /// Capacity may be consumed in two ways:
  /// <p>- Consume as much as possible with <see cref="M:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.Consume(Eco.Simulation.Types.PlantSpecies,System.Int32,System.Int32)" />, it will ignore unconsumed capacity;</p>
  /// <p>- Either fully consume all requested capacities or not consume at all with <see cref="M:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.TryConsume(Eco.Simulation.Types.PlantSpecies,System.Int32,System.Int32)" /></p>
  /// </summary>
  private class Capacity
  {
    public readonly float[] AvailableCapacities;
    public readonly string[] LayerNames;
    public readonly int VoxelsPerEntry;

    public Capacity(string[] layerNames, float[] availableCapacities, int voxelsPerEntry);

    /// <summary>Returns size of capacities slice for <paramref name="voxelsPerEntry" /> resolution. Calculated as <c>(voxelsPerEntry * voxelsPerEntry / cellArea) * LayerNames.Length</c>.</summary>
    public int GetSliceSize(int voxelsPerEntry);

    /// <summary>Tries to consume (reduce) available capacity for <paramref name="count" /> of plant <paramref name="species" />. Returns <c>true</c> if succeed. If failed then no modification to capacity happens.</summary>
    public bool TryConsume(PlantSpecies species, int count, int offset);

    /// <summary>Consumes as much as possible from <see cref="F:Eco.Simulation.WorldLayers.Pushers.PlantSpawner.Capacity.AvailableCapacities" /> for <paramref name="count" /> of plant <paramref name="species" />. Consuming means that available capacity reduced by consumed capacity amount.</summary>
    public void Consume(PlantSpecies species, int count, int offset);
  }
}
