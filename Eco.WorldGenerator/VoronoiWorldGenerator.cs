// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.VoronoiWorldGenerator
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Utils;
using System.Drawing;

#nullable enable
namespace Eco.WorldGenerator;

public class VoronoiWorldGenerator
{
  public int WorldSize { get; }

  public 
  #nullable disable
  Bitmap TerrainMap { get; }

  public Bitmap HeightMap { get; }

  public Bitmap WaterLevelMap { get; }

  public Array2D<float> HeightData { get; }

  public Array2D<float> WaterData { get; }

  public Array2D<float> RainfallData { get; }

  public Array2D<float> TemperatureData { get; }

  public VoronoiWorldGenerator(bool previewOnly, bool skipSetSpawnLocation);

  public void InitializeConfig(VoronoiWorldGeneratorConfig config);

  public void Generate(VoronoiWorldGeneratorConfig config);

  public void RenderMaps(VoronoiWorldGeneratorConfig config);

  public static PointF ClosestWrappedLocation(PointF viewPosition, PointF position, int worldSize = 500);
}
