// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.ClimateState
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Stats;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Simulation;

[Serialized]
[Localized(true, false, "", false)]
[HasStatProps]
public sealed class ClimateState : 
  IStorage,
  ISerializable,
  IController,
  IViewController,
  IHasUniversalID
{
  public IPersistent StorageHandle { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float TotalCO2 { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float LifetimeCO2FromPollution { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float LifetimeCO2FromAnimals { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float LifetimeCO2FromPlants { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float TotalGroundPollution { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float TotalSoilPollution { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float TotalHeavyMineralPollution { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float TotalChemicalPollution { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.PPM, StatType.ContinuousValue)]
  public float TotalAcidRainPollution { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [Tag("Climate")]
  [StatProp("Environment", Unit.Meters, StatType.ContinuousValue)]
  public float SeaLevel { get; set; }

  [Serialized]
  [Tag("Climate")]
  [StatProp("Environment", Unit.Celsius, StatType.ContinuousValue)]
  public float AverageGlobalTemperature { get; set; }

  [Serialized]
  [Category("Climate")]
  [LocDisplayName("CO2 From Citizen Activity ppm")]
  [Score(-1f)]
  public float CO2FromCitizenActivityPpm { get; set; }

  [Serialized]
  [Category("Climate")]
  [LocDisplayName("CO2 From Animals ppm")]
  public float CO2FromAnimalsPpm { get; set; }

  [Serialized]
  [Category("Climate")]
  [LocDisplayName("CO2 From Plants ppm")]
  public float CO2FromPlantsPpm { get; set; }

  [SyncToView(null, true)]
  [Category("Climate")]
  [LocDisplayName("Past 24 Hours CO2 ppm Delta")]
  public float CO2DayDelta { get; set; }

  [Serialized]
  [Category("Climate")]
  [Score(-1f)]
  public float CO2TotalDelta { get; set; }

  [Serialized]
  [Category("Climate")]
  [LocDisplayName("Temperature change degrees")]
  public float TemperatureDayDelta { get; set; }

  [Serialized]
  [Category("Climate")]
  [Score(-1f)]
  public float TemperatureTotalDelta { get; set; }

  [Serialized]
  [Category("Climate")]
  public float InitialSeaLevel { get; set; }

  [Serialized]
  [Category("Climate")]
  [LocDisplayName("Sea level change meters")]
  public float SeaLevelDayDelta { get; set; }

  [Serialized]
  [Category("Climate")]
  [Score(-1f)]
  public float SeaLevelTotalDelta { get; set; }

  [Serialized]
  [Category("Climate")]
  public bool SeaLevelApplied { get; set; }

  [Serialized]
  public double PastPeriod { get; set; }

  ref int IHasUniversalID.ControllerID { get; }

  public ClimateState Clone();

  public override string ToString();

  /// <summary> Calculates per day PPM for <paramref name="lastTickValue" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float PerDay(float lastTickValue);

  /// <summary> Calculates per hour PPM for <paramref name="lastTickValue" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float PerHour(float lastTickValue);

  /// <summary> Appends state to <see cref="T:Eco.Shared.Localization.LocStringBuilder" />. </summary>
  public void AppendTo(LocStringBuilder sb);

  /// <summary> Returns <see cref="T:Eco.Shared.Localization.LocString" /> representation of Climate State. </summary>
  public LocString ToLocString();
}
