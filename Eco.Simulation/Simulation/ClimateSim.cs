// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.ClimateSim
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using Eco.Simulation.WorldLayers;
using Eco.Simulation.WorldLayers.Layers;
using System;

#nullable disable
namespace Eco.Simulation;

[LocDisplayName("ClimateSim")]
public class ClimateSim
{
  public double TimeSpentTicking;

  public WorldLayer Temperature { get; }

  /// <summary> Accumulates air pollution in tons. </summary>
  public AccumulatingPuller AirPollution { get; }

  public WorldLayer GroundPollution { get; }

  public WorldLayer SoilPollution { get; }

  public WorldLayer HeavyMineralPollution { get; }

  public WorldLayer ChemicalPollution { get; }

  public WorldLayer AcidRainPollution { get; }

  /// <summary> Can subscribe to this event for climate state updates. </summary>
  public event Action ClimateStateChanged;

  public ClimateState State { get; set; }

  public override string ToString();

  public void Initialize(ClimateState state);

  public static ClimateState LoadState();

  /// <summary> Pulls data at beginning of tick for more precise results. </summary>
  public void Pull();

  public void Tick();

  public void SetSeaLevel(float newLevel);

  /// <summary>Flood-fills the columns connected to the ocean through water at or below <paramref name="seaLevel" />. Source of truth for which water counts as sea: inland water that isn't connected never does.</summary>
  public static Array2D<bool> OceanConnectedColumns(float seaLevel, Func<Vector2i, bool> isOcean);

  public void ApplySettings(ClimateState settings);

  /// <summary> Adds <paramref name="tons" /> of air pollution at <paramref name="pos" />. </summary>
  public void AddAirPollutionTons(WrappedPosition3i pos, float tons);
}
