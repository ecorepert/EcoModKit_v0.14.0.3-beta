// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.SecondOrderReaction
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

/// <summary>
/// Simulates a differential equation of the form dz/dt = c * x * y.
/// This is the same math as is used to describe a second-order chemical reaction, so I've elected to adopt that terminology.
/// It should be an apt analogy for every use of this interaction - acid rain happens when air pollution meets rain; predation happens when predator meets prey; etc.
/// 
/// N.B. this class, like all WorldLayerInteractions, does not modify the input layers.
/// In chemical terms, the inputs are both catalysts by default - they are not affected by the reaction.
/// If you wish an input to be affected, create another instance of SecondOrderReaction that has that input as its product.
/// </summary>
[Localized(true, false, "", false)]
public class SecondOrderReaction : WorldLayerInteraction<float>
{
  [LocCategory("Reaction")]
  [LocDescription("The name of the layer that contains the concentration of the first input.")]
  public string ReactantOneLayerName { get; set; }

  [LocCategory("Reaction")]
  [LocDescription("The name of the layer that contains the concentration of the second input.")]
  public string ReactantTwoLayerName { get; set; }

  [LocCategory("Reaction")]
  [LocDescription("The name of the layer that contains the concentration of the product.")]
  public string ProductLayerName { get; set; }

  [LocCategory("Reaction")]
  [LocDescription("The amount of product to create (or, if negative, to remove) when the product of the input concentrations is 1.")]
  public float ReactionRate { get; set; }

  [LocDescription("Whether the interaction should operate on the special first initialization tick after worldgen (when dependency cycles are not allowed).")]
  public bool ActivePostWorldgen { get; set; }

  public override string[] DependencyLayerNames { get; }

  public override string[] WorldInitDependencyLayerNames { get; }

  public override string OutputLayerName { get; }

  public override float Apply(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override float PostWorldgen(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override string DescribeGeneral { get; }

  protected override float DescribeSpecific(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override string DescribeAggregated(IEnumerable<float> intermediateDescriptions);
}
