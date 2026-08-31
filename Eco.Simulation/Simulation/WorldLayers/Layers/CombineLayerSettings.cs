// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.CombineLayerSettings
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
public class CombineLayerSettings : WorldLayerSettings
{
  [LocCategory("Combine")]
  [LocDescription("How the two layers are combined.")]
  [LocDisplayName("Operator")]
  public WorldLayerOp Op { get; set; }

  [LocCategory("Combine")]
  [LocDescription("The layers involved in the combination.")]
  [LocDisplayName("Layer1Name")]
  public string Layer1Name { get; set; }

  [LocCategory("Combine")]
  [LocDescription("The layers involved in the combination.")]
  [LocDisplayName("Layer2Name")]
  public string Layer2Name { get; set; }

  [LocCategory("Combine")]
  [LocDescription("The weights of the layers in the final product/sum.")]
  [LocDisplayName("Weight1")]
  public float Weight1 { get; set; }

  [LocCategory("Combine")]
  [LocDescription("The weights of the layers in the final product/sum.")]
  [LocDisplayName("Weight2")]
  public float Weight2 { get; set; }

  [LocCategory("Combine")]
  [LocDescription("New values are throttled to change by this percentage per tick at max.")]
  [LocDisplayName("Change Rate")]
  public float ChangeRate { get; set; }

  public override Type LayerType { get; }

  public override string ToString();
}
