// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.Voronoi
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>Description of Voronoi.</summary>
public class Voronoi
{
  public Voronoi(double minDistanceBetweenSites);

  /// @param xValuesIn Array of X values for each site.
  ///              @param yValuesIn Array of Y values for each site. Must be identical length to yValuesIn
  ///              @param minX The minimum X of the bounding box around the voronoi
  ///              @param maxX The maximum X of the bounding box around the voronoi
  ///              @param minY The minimum Y of the bounding box around the voronoi
  ///              @param maxY The maximum Y of the bounding box around the voronoi
  ///              @return
  public List<GraphEdge> GenerateVoronoi(
    double[] xValuesIn,
    double[] yValuesIn,
    double minX,
    double maxX,
    double minY,
    double maxY);
}
