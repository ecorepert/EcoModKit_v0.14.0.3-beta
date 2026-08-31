// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.AnimalLayer
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation.Agents;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

[Serialized]
public sealed class AnimalLayer : SpeciesLayer
{
  /// <summary>Event triggered when animal layer population changes after a tick. Arguments: (layerName, populationBefore, populationAfter)</summary>
  public static ThreadSafeAction<string, float, float> PopulationTickChangedEvent;
  public static bool StopSpawn;

  public override Type SettingsType { get; }

  public override int TotalEntityCount { get; }

  /// <summary> Callback to be invoked once when server started while <see cref="M:Eco.Simulation.WorldLayers.Layers.AnimalLayer.InitSelf" /> only called once when <see cref="T:Eco.Simulation.WorldLayers.Layers.AnimalLayer" /> created. </summary>
  public void OnServerStart();

  public override bool MigrateVersion();

  protected override void PostLoadSelf();

  protected override void TickSelf();

  public override void TickFinished();

  /// <summary> Set initial layer values. </summary>
  protected override void InitSelf();

  /// <summary> Maximal population supported at the given cell, wrapped, for external checks like restocking. </summary>
  public float MaxPopAt(Vector2i layerPos);

  /// <summary> Checks if layer dimensions was changed and re-generated layer in this case. </summary>
  public override void BackwardsCompatibilityCheck();

  public override string ToString(Vector2i layerPos);

  public List<Animal> SafePopMapEntry(Vector2i v);
}
