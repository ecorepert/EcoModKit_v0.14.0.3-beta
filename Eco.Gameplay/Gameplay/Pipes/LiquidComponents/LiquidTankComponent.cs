// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.LiquidComponents.LiquidTankComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Wires;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Pipes.LiquidComponents;

/// <summary>A fluid storage tank on the pipe network: stores whatever fluid is pushed into its input (up to <see cref="P:Eco.Gameplay.Pipes.LiquidComponents.LiquidTankComponent.TankSize" />) and drains it back out
/// of its output at a capped rate. Filling and draining run the same tick, so it can take in at one rate while pushing out at another. The first fluid stored
/// locks the tank to that type until it is fully drained out. Stored fluid is never deleted — it only leaves by physically draining out the output (into pipes,
/// or spilled onto the ground via an open end, which may pollute), gated by the <see cref="P:Eco.Gameplay.Pipes.LiquidComponents.LiquidTankComponent.AllowOutput" /> valve.</summary>
[Serialized]
[CreateComponentTabLoc("Pipes", true)]
[LocDisplayName("Pipes")]
[NoIcon]
[Ecopedia(null, "Pipe Component", false, true, null)]
[RequireComponent(typeof (StatusComponent), null)]
[MustBeGridAligned]
public class LiquidTankComponent : 
  WorldObjectComponent,
  IController,
  IViewController,
  IHasUniversalID,
  IWireContainer,
  IPickupConfirmationComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override 
  #nullable disable
  string IconName { get; }

  [Serialized]
  [SyncToView(null, true)]
  public ItemStack Contents { get; }

  [SyncToView(null, true)]
  public int TankSize { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("PipeInput")]
  public WireInput InputPipe { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public LocString StoredDisplay { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("PipeOutput")]
  public WireOutput OutputPipe { get; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [UITypeName("Boolean")]
  [LocDescription("Allow stored fluid to drain out the output. Off (default): the tank holds everything. On: it drains at the full rate — out the connected pipe, or spilled onto the ground (which may pollute) if the output isn't piped to anything.")]
  public bool AllowOutput { get; set; }

  public override bool Enabled { get; }

  public IEnumerable<WireConnection> Wires { get; }

  /// <summary>Configures the tank. Must be called from the owning WorldObject's PostInitialize (before component Initialize). Stores config only; the pipes
  /// are created in <see cref="M:Eco.Gameplay.Pipes.LiquidComponents.LiquidTankComponent.Initialize" /> where the occupancy port footprint is guaranteed registered.</summary>
  public void Configure(
    int tankSize,
    float inputRatePerSecond,
    float outputRatePerSecond,
    BlockOccupancyType inputBlockType,
    BlockOccupancyType outputBlockType);

  public override void Initialize();

  public override void OnAfterObjectMoved();

  public override void Destroy();

  LocString IPickupConfirmationComponent.GetComponentPickupConfirmation();

  public override void OnPickup(Player player);

  public override void Tick();

  public override void LateTick();
}
