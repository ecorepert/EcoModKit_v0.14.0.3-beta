// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.DecayingLayerSettings
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
public class DecayingLayerSettings : WorldLayerSettings
{
  [LocCategory("Decaying")]
  [LocDescription("The rate of decay by flat value per tick. Applied before percent decay.")]
  public float DecayRateFlat { get; set; }

  [LocCategory("Decaying")]
  [LocDescription("The rate of decay by percent per tick. Applied after flat decay.")]
  public float DecayRatePercent { get; set; }

  public override Type LayerType { get; }

  public override string ToString();
}
