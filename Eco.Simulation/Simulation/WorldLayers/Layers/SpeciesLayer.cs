// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.SpeciesLayer
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Simulation.Types;
using System;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

[Serialized]
public abstract class SpeciesLayer : WorldLayer, ISpeciesLayer
{
  public int AddedOrganismsToWorld;
  public int RemovedFromWorld;
  public int NoRoomForPlants;
  public int HarvestedByPlayers;
  public int InvasiveSpeciesKilled;

  public abstract int TotalEntityCount { get; }

  public Species Species { get; }

  public SpeciesLayerSettings SpeciesSettings { get; }

  public override Type SettingsType { get; }

  protected override void PostLoadSelf();

  public LocString GetSpeciesName();
}
