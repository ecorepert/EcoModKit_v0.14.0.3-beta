// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.LiquidComponents.LiquidConverterComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Pipes.LiquidComponents;

[Serialized]
[RequireComponent(typeof (LiquidConsumerComponent), "ConvertorIn")]
[RequireComponent(typeof (LiquidProducerComponent), "ConvertorOut")]
[Ecopedia(null, "Pipe Component", false, true, null)]
[NoIcon]
[MustBeGridAligned]
public sealed class LiquidConverterComponent : 
  WorldObjectComponent,
  IController,
  IViewController,
  IHasUniversalID,
  IDisposable
{
  public Func<Type, float, bool> CanFilter;
  public Func<bool> RelayWhenCantFilter;

  public event Action<Type, float> OnConvert;

  public override bool Enabled { get; }

  public event Func<bool> ShouldConvertLiquid;

  public LiquidConsumerComponent In { get; }

  public LiquidProducerComponent Out { get; }

  public IEnumerable<Type> AcceptedInputTypes { get; }

  public bool PassThroughUnknownTypes { get; set; }

  public float OutputYield { get; set; }

  public void Setup(
    Type inputType,
    Type outputsType,
    BlockOccupancyType inputBlockType,
    BlockOccupancyType outputBlockType,
    float consumptionRate = 1f,
    float requiredFlow = 0.9f);

  public void RegisterAdditionalConversion(Type inputType, Type outputType);

  internal float Convert(PipePayload input);

  /// <summary>Whether this converter processes <paramref name="itemType" /> through its buffered input: the primary type or a registered alternate.</summary>
  public bool AcceptsInput(Type itemType);

  /// <summary>Downstream room for the CONVERTED result of <paramref name="inputType" />, expressed in input-fluid liters (yield applied). Lets the input
  /// accept more than its buffer holds on an oversized tick (e.g. a time skip) and convert the overflow inline instead of capping the tick at buffer size.</summary>
  public float ConvertedCapacityInInputTerms(Type inputType);

  /// <summary>Downstream room for a foreign type relayed unchanged (pass-through is live and unbuffered). Downstream inputs answer from their local
  /// buffers, so this never recurses through the network — the re-entrancy guard only catches chained pass-through relays looping back into us.</summary>
  public float PassThroughCapacity(Type itemType);

  public override void LateTick();

  ref int IHasUniversalID.ControllerID { get; }

  public void Dispose();
}
