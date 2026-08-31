// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.LiquidComponents.LiquidConsumerComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Wires;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Pipes.LiquidComponents;

[Serialized]
[CreateComponentTabLoc("Pipes", true)]
[LocDisplayName("Pipes")]
[NoIcon]
[Ecopedia(null, "Pipe Component", false, true, null)]
[MustBeGridAligned]
public class LiquidConsumerComponent : 
  WorldObjectComponent,
  IController,
  IViewController,
  IHasUniversalID,
  IWireContainer,
  IOperatingWorldObjectComponent,
  IOperatingEfficiencyComponent,
  IPickupConfirmationComponent
{
  public 
  #nullable disable
  ThreadSafeAction<Type, float> OnConsumed;
  public Func<bool> ShouldConsumeLiquid;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  [SyncToView(null, true)]
  public bool HasProcessingBypass { get; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [UITypeName("Boolean")]
  [VisibilityParam("HasProcessingBypass")]
  [LocDisplayName("Pass fluid through when out of catalyst")]
  [LocDescription("What to do when this filter runs out of catalyst. ON: let the incoming fluid pass straight through unfiltered (keeps the line flowing, but it isn't cleaned). OFF: stop and hold the fluid back until catalyst is restocked.")]
  public bool RelayWhenOutOfCatalyst { get; set; }

  [Serialized]
  public Ray InputPosDir { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("PipeInput")]
  public WireInput InputPipe { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public LocString BufferDisplay { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("CatalystDisplay")]
  [VisibilityParam("HasActiveCatalyst")]
  [LocDisplayName("Catalyst")]
  [LocDescription("The catalyst this filter consumes: how many are stocked in the linked inventories, and the charge left on the loaded one.")]
  public int CatalystTypeID { get; }

  [SyncToView(null, true)]
  public bool HasActiveCatalyst { get; }

  [SyncToView(null, true)]
  public int CatalystAvailableCount { get; }

  [SyncToView(null, true)]
  public float CatalystProgress { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("FilterOutputsDisplay")]
  [VisibilityParam("HasOutputAccumulator")]
  [LocDisplayName("Byproducts")]
  [LocDescription("Solid byproducts captured by this filter: each fills up as fluid is processed and is emitted as a block when full.")]
  public bool HasOutputAccumulator { get; }

  public override bool Enabled { get; }

  public bool Operating { get; }

  public float OperatingEfficiency { get; }

  public LocString SupplyShortfallReport { get; }

  public Type AcceptedType { get; }

  public event Action<Type> OnUpstreamFluidTypeChanged;

  public bool AcceptAnyType { get; set; }

  public IEnumerable<WireConnection> Wires { get; }

  /// <summary>The buffered volume awaiting consumption, in liters (surfaced for pickup handling and tests).</summary>
  public float BufferedAmount { get; }

  /// <summary>The buffered fluid type, or null while empty.</summary>
  public Type BufferedType { get; }

  /// <summary>Deletes the buffered fluid (input-side contents are discarded on pickup, after their spill effects were applied).</summary>
  public void ClearBuffer();

  LocString IPickupConfirmationComponent.GetComponentPickupConfirmation();

  public override void OnPickup(Player player);

  public override void Destroy();

  public void Setup(
    Type acceptedType,
    float consumptionRate,
    BlockOccupancyType blockOccupancyType,
    float percentRequiredFlow,
    LiquidConverterComponent converter = null);

  public override void OnAfterObjectMoved();

  public void SetAcceptedInputLabel(IEnumerable<Type> acceptedTypes);

  public void QueueConsume(float amount);

  /// <summary>Feeds the catalyst readout (slot icon, linked-inventory stock, remaining-charge fraction). Pass typeID -1 to clear it (catalyst-less setup).</summary>
  public void SetCatalystDisplay(
    int typeID,
    int availableCount,
    float remainingUnits,
    float peakUnits);

  public override void Tick();

  public LocString LiquidName { get; }

  public override void LateTick();

  ref int IHasUniversalID.ControllerID { get; }
}
