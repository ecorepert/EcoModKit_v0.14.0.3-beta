// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.GroundPollutionPotentialLayerSettings
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
public class GroundPollutionPotentialLayerSettings : WorldLayerSettings
{
  [LocCategory("Spread")]
  public float SpreadScale { get; set; }

  [LocCategory("Spread")]
  public float MinSpreadValue { get; set; }

  [LocCategory("Spread")]
  public int MaxSpreadRadius { get; set; }

  [LocCategory("Spread")]
  public float WaterSpreadMultiplier { get; set; }

  [LocCategory("Spread")]
  public int MaxWaterSpreadRadius { get; set; }

  public override Type LayerType { get; }

  public override string ToString();
}
