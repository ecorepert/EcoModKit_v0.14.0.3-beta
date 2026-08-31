// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.FilterComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Garbage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Pipes.LiquidComponents;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>Generic liquid-driven filter. Converts an input liquid to an output liquid and emits configurable fractional-block outputs
/// when their per-output thresholds are reached. Configured through <see cref="M:Eco.Gameplay.Components.FilterComponent.Configure(System.Collections.Generic.IReadOnlyDictionary{System.Type,System.Type},System.Single,System.Single,Eco.Gameplay.Components.FilterOutputDef[],System.Nullable{Eco.Gameplay.Garbage.CatalystSpec})" /> at the owning WorldObject's PostInitialize.</summary>
[Serialized]
[RequireComponent(typeof (LiquidConverterComponent), null)]
[RequireComponent(typeof (SharedLinkComponent), null)]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (MustBeOwnedComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[Eco.Core.Utils.Priority(1)]
[Ecopedia(null, "Pipe Component", false, true, null)]
[NoIcon]
public class FilterComponent : WorldObjectComponent, IOperatingWorldObjectComponent, IPersistentData
{
  public const int Priority = 1;

  public 
  #nullable disable
  object PersistentData { get; set; }

  [SyncToView(null, true)]
  public int InputLiquidTypeID { get; }

  [SyncToView(null, true)]
  public int OutputLiquidTypeID { get; }

  [SyncToView(null, true)]
  public float LiquidRatePerSecond { get; }

  [SyncToView(null, true)]
  public float LiquidYield { get; }

  [SyncToView(null, true)]
  public int[] OutputItemTypeIDs { get; }

  [SyncToView(null, true)]
  public float[] OutputUnitsPerEmission { get; }

  [SyncToView(null, true)]
  public float[] OutputProgress { get; }

  [SyncToView(null, true)]
  public int ConfiguredCatalystTypeID { get; }

  public bool HasProcessingGate { get; }

  public bool HasSolidOutputs { get; }

  public bool RelayWhenOutOfCatalyst { get; set; }

  public bool Operating { get; }

  public override bool Enabled { get; }

  /// <summary>Configures the filter. Must be called from the owning WorldObject's PostInitialize. <paramref name="conversions" /> lists every
  /// (input fluid → output fluid) this filter performs, all treated as peers: whichever fluid actually arrives is processed (a pipe network carries a
  /// single fluid, so no manual selection is needed). <paramref name="liquidYield" /> is the fraction of the processed volume that leaves as output fluid
  /// (1 = lossless, 0.5 = two liters in per liter out); the rest is lost. The shared <paramref name="outputs" /> solid byproducts advance from the processed
  /// input volume, and the shared <paramref name="catalyst" />, when set, is consumed from linked inputs (falling back to pass-through when none remain).</summary>
  public void Configure(
    IReadOnlyDictionary<Type, Type> conversions,
    float liquidRate,
    float liquidYield,
    FilterOutputDef[] outputs = null,
    CatalystSpec? catalyst = null);

  /// <summary>Configures the filter to auto-detect any of <paramref name="profiles" />' input fluids and apply that profile's byproducts + catalyst,
  /// all producing <paramref name="outputLiquidType" />. Whichever fluid actually arrives is processed — a pipe network carries a single fluid, so no
  /// manual selection is needed (e.g. waste filter: sewage / industrial sewage / chemical waste).</summary>
  public void ConfigureMultiInput(
    Type outputLiquidType,
    float liquidRate,
    float liquidYield,
    FilterInputProfile[] profiles);

  public override void Initialize();

  public override void Destroy();
}
