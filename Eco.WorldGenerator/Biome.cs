// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.Biome
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Utils;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.WorldGenerator;

public abstract class Biome
{
  public string Name;
  public System.Drawing.Color Color;
  public static Ocean Ocean;
  public static DeepOcean DeepOcean;
  public static Grassland Grassland;
  public static Coast Coast;
  public static ColdCoast ColdCoast;
  public static WarmCoast WarmCoast;
  public static WarmForest WarmForest;
  public static ColdForest ColdForest;
  public static RainForest RainForest;
  public static Desert Desert;
  public static Tundra Tundra;
  public static Taiga Taiga;
  public static Ice Ice;
  public static Wetland Wetland;
  public static Steppe Steppe;
  public static HighDesert HighDesert;
  public static Dictionary<int, Biome> BiomeLookupFromColor;
  public static Array2D<Biome> BiomeData;

  public int BadNeighborsRange { get; }

  public Biome[] BadNeighbors { get; }

  public Eco.Shared.Math.Range ElevationRange { get; }

  public Eco.Shared.Math.Range TemperatureRange { get; }

  public Eco.Shared.Math.Range MoistureRange { get; }

  public Type PrevailingRockType { get; }

  public float UpperHeight { get; }

  public HashSet<BiomePolygon> GetValidPositions(BiomePolygon[] polygons);

  public Biome(
    string name,
    Eco.Shared.Math.Range elevationRange,
    Eco.Shared.Math.Range temperatureRange,
    Eco.Shared.Math.Range moistureRange,
    System.Drawing.Color color,
    Type geology,
    int badNeighborsRange = 0,
    Biome[] badNeighbors = null);
}
