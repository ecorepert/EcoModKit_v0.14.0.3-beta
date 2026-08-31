// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.WorldSettings
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Core.Plugins;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Settings;
using SharpNoise.Modules;
using System.ComponentModel;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>
/// The world settings used to generate the world.
/// <para>Config file can be found at Config/WorldGenerator.eco</para>
/// <para>Also see <see cref="P:Eco.WorldGenerator.WorldSettings.VoronoiWorldGeneratorConfig" /> for the rest of the world settings.</para>
/// </summary>
[Localized(true, false, "", false)]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class WorldSettings : IVersionedConfig, IValidatableConfig
{
  public static readonly WorldDimensions.WorldDimensionsPreset DefaultPreset;

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int LastConfigVersion { get; }

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int ConfigVersion { get; set; }

  [JsonIgnore]
  [LocDescription("World generation seed.")]
  public int Seed { get; set; }

  [LocDescription("Presets of settings suitable for worlds of various sizes. Changes dimensions and various advanced configurations")]
  public WorldDimensions.WorldDimensionsPreset MapSizePreset { get; set; }

  [LocDescription("Chunk dimensions of the world along X-Z. Both dimensions must have the same value and be divisible by 4. World size has limits but they usually apply when world size bigger than 250x250. If you want size bigger -> then MaxBuildHeight must be less than 320. Example: Size 300 has 238 max height, 400 has 134, etc.")]
  public WorldDimensions Dimensions { get; set; }

  [LocDescription("Sea level height.")]
  public int WaterLevel { get; set; }

  [LocDescription("Maximum height of the world when generating terrain.")]
  public int MaxGenerationHeight { get; set; }

  [LocDescription("Maximum height of the world citizens may build to. Can't be lowered after world creation. Note that values bigger than 160 will heavily increase CPU and RAM resources needed for world. Has hard limit for 320. Should not be lower than MaxGenerationHeight. World dimensions product ((Length * 10) * MaxBuildHeight * (Width * 10)) must be less than max value if INT, so values can be clamped to lower on server start.")]
  public int MaxBuildHeight { get; set; }

  /// <summary>
  /// Validates provided value as requested max build height
  /// Checks that world x * y * z is less than max value if integer and returns max possible height rounded to nearest chunk size
  /// Also notifies in console if it was clamped
  /// This doesn't change world size, only clamps itself, and this validation is still needed as height can be set independently
  /// </summary>
  public int ValidateMaxBuildHeight(int value = -1);

  [LocDescription("Advanced configurations")]
  [DisplayName("Advanced Config")]
  public VoronoiWorldGeneratorConfig VoronoiWorldGeneratorConfig { get; }

  [Browsable(false)]
  public Module HeightmapModule { get; set; }

  [Browsable(false)]
  public Module WaterModule { get; set; }

  [Browsable(false)]
  public Module RainfallModule { get; set; }

  [Browsable(false)]
  public Module TemperatureModule { get; set; }

  public WorldSettings.CraterSettings Crater { get; set; }

  [LocDescription("Defines the world module for world generation.")]
  public ITerrainModule TerrainModule { get; set; }

  [Browsable(false)]
  public Vector2i ChunkDimensions { get; }

  [Browsable(false)]
  public Vector2i VoxelSize { get; }

  [Browsable(false)]
  public float FrequencyScale { get; }

  [Browsable(false)]
  public string SizeDescription { get; }

  public void OnParamChanged(string param);

  [Localized(true, false, "", false)]
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class CraterSettings
  {
    [LocDescription("Frequency of craters (should be very low)")]
    public float Frequency { get; set; }

    [LocDescription("Radius range")]
    public Range RadiusRange { get; set; }

    [LocDescription("Depth range (percent of radius)")]
    public Range DepthRange { get; set; }
  }
}
