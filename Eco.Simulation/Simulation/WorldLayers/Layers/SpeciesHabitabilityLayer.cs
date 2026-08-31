// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.SpeciesHabitabilityLayer
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

[Serialized]
public class SpeciesHabitabilityLayer : WorldLayer, ISpeciesLayer
{
  public SpeciesHabitabilityLayerSettings HabitabilitySettings { get; }

  public override Type SettingsType { get; }

  public SpeciesLayer SpeciesLayer { get; }

  protected override void InitSelf();

  protected override void PostLoadSelf();

  public string DescribeInfluences(Vector2i worldPos, Vector2i layerPos);

  protected override void TickSelf();

  protected float GetHabitability(Vector2i pos);

  public LocString GetSpeciesName();
}
