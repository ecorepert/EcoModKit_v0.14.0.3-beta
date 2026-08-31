// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.AnimalLayerSettings
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Simulation.WorldLayers.Layers;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
public class AnimalLayerSettings : SpeciesLayerSettings, IDependencyLayer
{
  public override 
  #nullable disable
  Type LayerType { get; }

  public override string Subcategory { get; set; }

  [LocCategory("Species")]
  [LocDescription("The name of the layer that defines habitability for this species.")]
  public string HabitabilityLayer { get; set; }

  public bool IsTerrestrial { get; set; }

  public override string ToString();

  public IEnumerable<WorldLayerSettings> Dependencies();
}
