// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.LayerPosition
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

/// <summary> Struct which holds both <see cref="F:Eco.Simulation.WorldLayers.Layers.LayerPosition.Position" /> and <see cref="F:Eco.Simulation.WorldLayers.Layers.LayerPosition.VoxelsPerEntry" /> so may be used with any layer which will translate own value to requested layer position granularity. </summary>
public struct LayerPosition
{
  public Vector2i Position;
  public int VoxelsPerEntry;

  public LayerPosition(int x, int y, int voxelsPerEntry);

  public LayerPosition(Vector2i position, int voxelsPerEntry);

  /// <summary> Creates <see cref="T:Eco.Simulation.WorldLayers.Layers.LayerPosition" /> from <paramref name="worldPosition" /> with specified <paramref name="voxelsPerEntry" /> granularity. </summary>
  public static LayerPosition FromWorldPosition(Vector2i worldPosition, int voxelsPerEntry);
}
