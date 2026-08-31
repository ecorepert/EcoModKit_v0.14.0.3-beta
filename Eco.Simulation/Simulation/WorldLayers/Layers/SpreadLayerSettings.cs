// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.SpreadLayerSettings
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
public class SpreadLayerSettings : WorldLayerSettings
{
  [LocCategory("Spread")]
  [LocDescription("A tile will approach this percentage value of its highest-value neighbor.")]
  public float SpreadRate { get; set; }

  [LocCategory("Spread")]
  [LocDescription("Spread-rate drops to zero as height difference approaches this value.")]
  public float ZeroAtHeightDiff { get; set; }

  [LocCategory("Spread")]
  [LocDescription("The value approaches the desire value at this rate.")]
  public float SourceInfluenceRate { get; set; }

  [LocCategory("Spread")]
  [LocDescription("Base layer which determines the min-value of a location.")]
  public string BaseLayerName { get; set; }

  public string HeightLayerName { get; set; }

  public override Type LayerType { get; }

  public override string ToString();
}
