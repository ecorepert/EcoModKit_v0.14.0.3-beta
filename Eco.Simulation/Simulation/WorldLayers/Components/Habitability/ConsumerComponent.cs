// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Components.Habitability.ConsumerComponent
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Simulation.WorldLayers.Components.Habitability;

[Localized(true, false, "", false)]
public class ConsumerComponent : HabitabilityComponent
{
  [LocCategory("Animal")]
  [LocDescription("A list of food sources which this animal relies on.")]
  public 
  #nullable disable
  List<Type> Prey;

  [LocCategory("Animal")]
  [LocDescription("Available calories of food sources in the area to support one animal fully.")]
  public float CalorieConsumption { get; set; }

  public override IEnumerable<WorldLayerSettings> Dependencies();

  public override void PostLoad();

  public override float GetHabitability(SpeciesHabitabilityLayer layer, Vector2i layerPos);

  public override LocString Describe(
    SpeciesHabitabilityLayer layer,
    Vector2i worldPos,
    Vector2i layerPos);
}
