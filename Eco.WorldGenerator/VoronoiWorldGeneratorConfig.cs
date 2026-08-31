// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.VoronoiWorldGeneratorConfig
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Settings;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>
/// The world settings used in the heightmap module in the WorldGenerator.eco config.
/// <para>Also see <see cref="T:Eco.WorldGenerator.UI.TerrainEditorPanel" /></para>
/// </summary>
[Localized(true, false, "", false)]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class VoronoiWorldGeneratorConfig
{
  [LocDescription("World generation seed. 0 means 'assign random seed at generation time'")]
  public int Seed { get; set; }

  [LocDescription("Radius of initial seed points. Influences cell size.")]
  public float PointRadius { get; set; }

  [LocDescription("Percentage of the world to create as land. Rest will be ocean.")]
  public Eco.Shared.Math.Range LandPercentRange { get; set; }

  [JsonIgnore]
  public float LandPercent { get; }

  [LocDescription("Number of cells to place as coastline.")]
  public int CoastlineSize { get; set; }

  [LocDescription("Number of cells to place as shallow ocean near the coast.")]
  public int ShallowOceanSize { get; set; }

  [LocDescription("Weight of land to spawn for the desert biome.")]
  public float DesertWeight { get; set; }

  [LocDescription("Weight of land to spawn for the warm forest biome.")]
  public float WarmForestWeight { get; set; }

  [LocDescription("Weight of land to spawn for the cold forest biome.")]
  public float CoolForestWeight { get; set; }

  [LocDescription("Weight of land to spawn for the taiga biome.")]
  public float TaigaWeight { get; set; }

  [LocDescription("Weight of land to spawn for the tundra biome.")]
  public float TundraWeight { get; set; }

  [LocDescription("Weight of land to spawn for the ice biome.")]
  public float IceWeight { get; set; }

  [LocDescription("Weight of land to spawn for the rainforest biome.")]
  public float RainforestWeight { get; set; }

  [LocDescription("Weight of land to spawn for the wetland biome.")]
  public float WetlandWeight { get; set; }

  [LocDescription("Weight of land to spawn for the steppe biome.")]
  public float SteppeWeight { get; set; }

  [LocDescription("Weight of land to spawn for the high desert biome.")]
  public float HighDesertWeight { get; set; }

  [WorldPresetsRange(new float[] {1f, 3f, 2f, 4f, 3f, 4f})]
  [LocDescription("Number of continents to spawn.")]
  public Eco.Shared.Math.Range NumContinentsRange { get; set; }

  [LocDescription("Range that continents avoid other land masses.")]
  public Eco.Shared.Math.Range ContinentAvoidRange { get; set; }

  [JsonIgnore]
  public int NumContinents { get; }

  [WorldPresetsRange(new float[] {1f, 3f, 2f, 4f, 3f, 4f})]
  [LocDescription("Min number of smaller islands to spawn.")]
  public Eco.Shared.Math.Range NumSmallIslandsRange { get; set; }

  [LocDescription("Range that islands avoid other land masses.")]
  public Eco.Shared.Math.Range IslandAvoidRange { get; set; }

  [JsonIgnore]
  public int NumSmallIslands { get; }

  [WorldPresetsValue(new object[] {0.05f, 0.04f, 0.03f})]
  [LocDescription("Weight of land to spawn as smaller islands.")]
  public float IslandWeight { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of rainforest biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumRainforests { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of warm forest biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumWarmForests { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of cool forest biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumCoolForests { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of taiga biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumTaigas { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of tundra biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumTundras { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of ice biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumIces { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of desert biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumDeserts { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of wetland biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumWetlands { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of high desert biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumHighDeserts { get; set; }

  [WorldPresetsValue(new object[] {1, 2, 2})]
  [LocDescription("Minimum number of steppe biomes to spawn. Multiple biomes can merge into one larger biome.")]
  public int NumSteppes { get; set; }

  [WorldPresetsRange(new float[] {0.0018f, 0.003f, 0.0025f, 0.0035f, 0.003f, 0.004f})]
  [LocDescription("Size range to spawn lakes.")]
  public Eco.Shared.Math.Range LakeSizeRange { get; set; }

  [WorldPresetsRange(new float[] {2f, 4f, 3f, 5f, 4f, 5f})]
  [LocDescription("Number lakes to spawn.")]
  public Eco.Shared.Math.Range NumLakesRange { get; set; }

  [JsonIgnore]
  public int NumLakes { get; }

  [WorldPresetsRange(new float[] {1f, 3f, 2f, 4f, 3f, 4f})]
  [LocDescription("Number of rivers to spawn.")]
  public Eco.Shared.Math.Range NumRiversRange { get; set; }

  [LocDescription("Distance in meters that rivers avoid themselves or other rivers.")]
  public int RiverCellAvoidance { get; set; }

  [LocDescription("Approximate width of rivers.")]
  public float RiverCellWidth { get; set; }

  [JsonIgnore]
  public int NumRivers { get; }

  [LocDescription("The distance in meters from the ocean where the maximum world elevation is allowed. (x in the elevation equation [(d*x)^y])")]
  public float MaxElevationOceanDistance { get; set; }

  [LocDescription("The power or rate of change in elevation from the ocean. (y in the elevation equation [(d*x)^y])")]
  public float ElevationPower { get; set; }

  [LocDescription("Autoscales features based on world size compared to default (720). Internally affects the number of biomes and continent size. For finer control of larger worlds, disable this feature.")]
  public bool AutoScale { get; set; }

  [LocDescription("Power used in the autoscale function (worldSize / defaultWorldSize) ^ exponent")]
  public float AutoScaleExponent { get; set; }

  [Browsable(false)]
  public float ScaleModifier { get; }

  [Browsable(false)]
  public float InverseScaleModifier { get; }

  [Browsable(false)]
  public float LinearScaleModifier { get; }

  [Browsable(false)]
  public float InverseLinearScaleModifier { get; }

  [Browsable(false)]
  [LocDescription("Whether or not to save an image of the terrain after generation.")]
  public bool SaveTerrainImage { get; }

  public void Initialize(Random random);

  public void Reset();

  /// <summary>Main method to generate a world based on the current configuration settings. Thread safe.</summary>
  public VoronoiWorldGenerator GenerateWorld(bool previewOnly = false, bool skipSetSpawnLocation = false);

  /// <summary> Update properties with <see cref="T:Eco.WorldGenerator.WorldPresetsValue" /> attribute based on corresponding <paramref name="preset" /> value </summary>
  public void SetPreset(WorldDimensions.WorldDimensionsPreset preset);
}
