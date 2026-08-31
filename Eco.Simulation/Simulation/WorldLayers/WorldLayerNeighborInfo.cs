// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.WorldLayerNeighborInfo
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Simulation.WorldLayers;

/// <summary>
/// This struct provides on demand values for all neighbor cells around the <see cref="F:Eco.Simulation.WorldLayers.WorldLayerNeighborInfo.cell" /> (3x3 matrix with the cell in the center).
/// It may be used by interactions which requires neighbors info (i.e. for values spreading).
/// </summary>
public struct WorldLayerNeighborInfo
{
  private readonly bool poolArray;
  private readonly WorldArea cell;
  private readonly IWorldLayerView layer;
  private float[] pooledArray;
  private volatile float[] neighborhood;

  /// <summary> Use <paramref name="poolArray" /> only in case if you are going to Dispose this object after using </summary>
  public WorldLayerNeighborInfo(WorldArea cell, IWorldLayerView layer, bool poolArray = false);

  public WorldLayerNeighborInfo(float[] data);

  /// <summary> The values of the corresponding layer in the 8 adjacent layer cells (plus this center one).
  /// Arranged geometrically from least to most x and y, e.g. Neighborhood[0, 2] is the adjacent cell with a smaller x and a larger y coordinate.
  /// </summary>
  public float[] Neighborhood { get; }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int PosToArrIndex(int x, int y);

  public void Dispose();
}
