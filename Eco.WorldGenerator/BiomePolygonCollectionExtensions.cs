// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.BiomePolygonCollectionExtensions
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Utils;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.WorldGenerator;

/// <summary>Extension methods for array of <see cref="T:Eco.WorldGenerator.BiomePolygon" /> objets.</summary>
public static class BiomePolygonCollectionExtensions
{
  /// <summary>Returns set of connected land polygons.</summary>
  public static 
  #nullable disable
  IReadOnlyCollection<BiomePolygon> LandFloodFill(
    this BiomePolygon[] polygons,
    BiomePolygon startPoly);

  /// <summary>
  /// Collects indices of all adjacent polygons for startPoly.
  /// <paramref name="range" /> defines max rank of neighborhood. For range = 1 it will return only direct adjacent, for range = 2 it will also return adjacent of adjacent etc.
  /// </summary>
  public static IEnumerable<int> AdjacentPolygons(
    this BiomePolygon[] polygons,
    int startPoly,
    int range);

  /// <summary>Calculates minimal distance to closest non-land biome.</summary>
  public static int DistanceToOcean(this BiomePolygon[] polygons, int startPoly);

  /// <summary>Calculates distance from <paramref name="startPoly" /> to first polygon not matching <paramref name="predicate" />.</summary>
  /// 
  ///             todo: this methods looks confusing, it probably should be named differently or calculate distance to first polygon MATCHING predicate
  public static int DistanceTo(
    this BiomePolygon[] polygons,
    int startPoly,
    Func<BiomePolygon, bool> predicate);

  /// <summary>Generates layer data from <paramref name="polygons" /> using <paramref name="valueGetter" /> to obtain polygon value. The value should be within range 0-1. Produced value error less than 1e-7.</summary>
  public static Array2D<float> GenerateDataByPolygons(
    this BiomePolygon[] polygons,
    int worldSize,
    Func<BiomePolygon, float> valueGetter);
}
