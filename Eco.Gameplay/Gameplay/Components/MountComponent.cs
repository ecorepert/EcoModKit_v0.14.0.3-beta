// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.MountComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using PropertyChanged;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[NoIcon]
public sealed class MountComponent : WorldObjectComponent, IHasEnvVars
{
  /// <summary>global mount event with user and seat</summary>
  public static 
  #nullable disable
  ThreadSafeAction<User, int, MountComponent> MountEvent;
  /// <summary>global dismount event with user and seat</summary>
  public static ThreadSafeAction<User, int, MountComponent> DismountEvent;

  /// <summary>Called when a player mounts (any of the seats)</summary>
  public event Action PlayerMountedEvent;

  /// <summary>Called when a player dismounts (any of the seats)</summary>
  public event Action PlayerDismountedEvent;

  public override WorldObjectComponentClientAvailability Availability { get; }

  public 
  #nullable enable
  Player? Driver { get; set; }

  public List<Func<int, Player, Result>> MountValidation { get; }

  /// <summary>Return true if any player is mounted. </summary>
  public bool IsMounted { get; }

  /// <summary>Check for null values in occupants array. Returns true if found any. </summary>
  [EnvVar]
  [DependsOn("OccupantIDs")]
  public bool HasFreeSeat { get; }

  /// <summary>Looking for null value in occupants array. Returns index of array if found, -1 if not. </summary>
  public int FirstFreeSeatIndex { get; }

  /// <summary>Count all seats Mount has. </summary>
  public int Seats { get; }

  /// <summary>Returns non-null collection with players that currently mounted. </summary>
  public IEnumerable<Player> MountedPlayers { get; }

  /// <summary>Returns the name of all the mounted player. Returns an empty string if there are not occupants. </summary>
  public string MountedPlayersNames { get; }

  [SyncToView(null, true)]
  public int[] OccupantIDs { get; }

  public bool PauseExhaustion { get; }

  public void Initialize(int seats = 1, bool pauseExhaustion = true);

  /// <summary>True while any module-contributed seat is occupied. Module seats are the trailing <see cref="F:Eco.Gameplay.Components.MountComponent.extraSeats" /> entries of the occupant list.</summary>
  public bool ExtraSeatsOccupied { get; }

  /// <summary>Sets the seats a slotted vehicle module contributes on top of the base count, resizing the occupant list. Riders on removed seats are dismounted (removal is normally blocked upstream while they're occupied).</summary>
  public void SetExtraSeats(int extra);

  public void Dismount(int playerID);

  public void DismountAll();

  public void DismountAllWithAction(Action<Player> action);

  /// <summary> Dismounts specific <paramref name="player" /> from all occupied seats. </summary>
  [RPC(AccessType.None)]
  public void Dismount(Player? player);

  [Interaction(InteractionTrigger.InteractKey, "Sit", InteractionModifier.None, new string[] {"sit"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, AuthRequired = AccessType.ConsumerAccess)]
  public void MountInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  /// <summary>Clears seats whose occupant's client evidently no longer considers itself mounted (its avatar walked away). Heals ghost mounts from
  /// lost dismount requests, which otherwise pin driver bound state (like the vehicle's map icon) to the departed player until they log out.</summary>
  public override void Tick();

  public void MountSeat(int seatIndex, Player player);

  /// <summary>Mount player on first free seat through <see cref="M:Eco.Gameplay.Components.MountComponent.MountSeat(System.Int32,Eco.Gameplay.Players.Player)" /> </summary>
  public int MountSeatOnFree(Player player);

  /// <summary> Try to mount at specified seat index. If not valid -&gt; tries to mount first free spot </summary>
  public void TryMountTargetSeat(Player player, int seat);

  public void TryDismountPlayer(Player player);

  /// <summary>dismount all in current mount on pickup. </summary>
  public override void OnPickup(Player player);

  /// <summary> Useful when object is destroyed with players inside </summary>
  public override void Destroy();
}
