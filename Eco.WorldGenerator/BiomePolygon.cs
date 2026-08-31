// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.BiomePolygon
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System.Drawing;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>Represents <see cref="P:Eco.WorldGenerator.BiomePolygon.Biome" /> polygon with associated temperature, moisture and elevation. One biome may have multiple polygons with slightly different characteristics.</summary>
public class BiomePolygon
{
  public PointF[] Points;
  public PointF Site;
  public PointF Center;
  public int[] Adjacent;
  public float MaxElevation;
  public float Elevation;
  public float Temperature;
  public float Moisture;
  public bool HasRiver;
  public bool HasLake;
  public int Index;

  public Biome Biome { get; set; }

  public Biome PreviousBiome { get; }

  public Color HeightmapColor { get; }

  public Color Color { get; }

  public Brush Brush { get; }
}
