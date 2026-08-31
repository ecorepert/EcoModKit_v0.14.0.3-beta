// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Settings.ClimateSettings
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Simulation.Settings;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
public class ClimateSettings
{
  public const float ParticlesPerTon = 1000000f;

  [LocDescription("Makeup of the atmosphere in percentages.")]
  public float InitialOxygenPercent { get; set; }

  [LocDescription("Makeup of the atmosphere in percentages.")]
  public float InitialNitrogenPercent { get; set; }

  [LocDescription("Makeup of the atmosphere in percentages.")]
  [LocDisplayName("Initial CO2 Percent")]
  public float InitialCO2Percent { get; set; }

  [LocDescription("Initial air pressure.")]
  public float AirPressure { get; set; }

  [LocDescription("Atmosphere volume in cubic meters.")]
  public double AtmosphereVolume { get; set; }

  [LocDescription("Show atmosphere data in status panel.")]
  public bool AtmosphereDisplayEnabled { get; set; }

  [LocDescription("Air pollution output is divided by this to determine PPM. It depends on AtmospherePressureKgPerM2 and the world area. For 1km2 and pressure 1kg/m2, 1 ton = 1PPM (part per million), which is the unit that determines climate change effects.")]
  [LocDisplayName("Atmosphere Size (tons)")]
  public float AtmosphereSizeInTons { get; }

  [LocDisplayName("PPM per ton")]
  [LocDescription("How much PPM (particles per million) will be added to/removed from atmosphere per one tone of matter (i.e. CO2).")]
  public float PPMPerTon { get; set; }

  [LocDescription("Atmosphere pressure used in the atmosphere size formula. Trees absorb and pollution from tables produced in tons and converted to PPM by dividing on total atmosphere size. AtmosphereSizeInTons = WorldAreaInM2 * AtmospherePressureKgPerM2 where WorldAreaInM2 = (Dimensions.x * 10) * (Dimensions.y * 10). In example for 1km\u00B2 (1000000m\u00B2) world with atmosphere pressure 1 kg/m\u00B2 it will be 1000000 tons, resulting in 1 PPM per 1 ton of pollution or absorb (1 PPM =  1000000 * tons / AtmosphereSizeInTons), increasing pressure to 2 will result in 0.5 PPM per ton.")]
  [LocDisplayName("Atmosphere Pressure (kg/m\u00B2)")]
  public float AtmospherePressureKgPerM2 { get; set; }

  public float PpmToTons(float ppm);

  public float TonsToPpm(float tons);

  [LocCategory("Atmosphere")]
  [LocDescription("Multiplier for pollution. Requires server restart when changed.")]
  public float PollutionMultiplier { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("The starting level of CO2 in the atmosphere, and the min value we clamp to.")]
  [LocDisplayName("Min CO2 ppm")]
  public float MinCO2ppm { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("Whether sea level changes should be simulated.")]
  public bool SeaLevelSimEnabled { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("Whether temperature changes should be simulated.")]
  public bool TemperatureSimEnabled { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("Sea levels start rising when CO2 is above this value")]
  [LocDisplayName("Sea Levels' Rise At CO2 ppm")]
  public float SeaLevelsRiseAtCO2ppm { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("For every X ppm over the base 'SeaLevelsRiseAtCO2ppm' value, the sea level will rise 1 meter.")]
  [LocDisplayName("CO2 ppm Per Sea Level Meter Rise")]
  public float CO2ppmPerSeaLevelMeterRise { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("No matter how bad it gets, it will never get worse than this.")]
  public float MaxSeaLevelRise { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("No matter how bad it gets, it will never get worse than this.")]
  public float MaxTemperatureRise { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("Sea levels can not rise more than this many units per day.")]
  public float MaxSeaLevelRiseRatePerDay { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("Temperature can not rise more than this many units per day.")]
  public float MaxTemperatureChangePerDay { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("At this level of CO2, global temperatures start to rise.")]
  [LocDisplayName("Temperatures Rise At CO2 ppm")]
  public float TemperaturesRiseAtCO2ppm { get; set; }

  [LocCategory("Atmosphere")]
  [LocDescription("For every X ppm over the base 'SeaLevelsRiseAtCO2ppm' value, the global temperature level will rise 1 degree.")]
  [LocDisplayName("CO2 ppm Per Degree Temperature Rise")]
  public float CO2ppmPerDegreeTemperatureRise { get; set; }

  [LocDescription("Max CO2 amount from all animals, per day, in PPM")]
  [LocDisplayName("Max CO2 Per Day From Animals")]
  public float MaxCO2PerDayFromAnimals { get; set; }

  [LocDescription("Min CO2 amount (typically negative) from all plants, per day, in PPM")]
  [LocDisplayName("Min CO2 Per Day From Plants")]
  public float MinCO2PerDayFromPlants { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Number of in-game days the buffer pollution layers take to converge toward their target value (and to decay back down).")]
  public float BufferPollutionConvergenceDays { get; set; }

  [LocCategory("Ground")]
  [LocDescription("In-game days that freshly produced waste is held pollution-free before it starts polluting the ground once stored. Waste that wasn't produced (dumped blocks, etc.) pollutes immediately.")]
  public float GroundPollutionGraceDays { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Heavy mineral pollution stops decaying naturally once a claim's value rises above this. Only active decontamination can bring it back down past this point.")]
  public float HeavyMineralNaturalDecayCeiling { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Chemical pollution stops decaying naturally once a claim's value rises above this. Only active decontamination can bring it back down past this point.")]
  public float ChemicalNaturalDecayCeiling { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Contribution of the Soil Pollution buffer to ground pollution (ground = sum of each buffer × its ratio).")]
  public float GroundPollutionSoilRatio { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Contribution of the Heavy Mineral Pollution buffer to ground pollution (ground = sum of each buffer × its ratio).")]
  public float GroundPollutionHeavyMineralRatio { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Contribution of the Chemical Pollution buffer to ground pollution (ground = sum of each buffer × its ratio).")]
  public float GroundPollutionChemicalRatio { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Contribution of the Acid Rain Pollution buffer to ground pollution (ground = sum of each buffer × its ratio).")]
  public float GroundPollutionAcidRainRatio { get; set; }

  [LocCategory("Ground")]
  [LocDescription("Debris max value is attained when this many blocks are placed.")]
  public float MaxDebrisBlocks { get; set; }
}
