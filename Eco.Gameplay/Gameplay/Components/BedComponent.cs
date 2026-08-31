// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.BedComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>Handles sleep for player through bed objects with <see cref="P:Eco.Gameplay.Components.BedComponent.MountComponent" /> and <see cref="T:Eco.Gameplay.Systems.SleepManager" />
/// and has a button to open the sleep manager.</summary>
[Serialized]
[LocDisplayName("Bed")]
[LocDescription("Sleep in the bed to advance time.")]
[ChatCommandHandler]
[Ecopedia(null, "Bed Component", false, true, null)]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
[RequireComponent(typeof (MountComponent), null)]
[Tag("Bed")]
public class BedComponent : WorldObjectComponent, IPickupConfirmationComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  /// <summary>Stores users as value and seat number that is occupied by user as key. </summary>
  [SyncToView(null, true)]
  [Serialized]
  public 
  #nullable disable
  ControllerDictionary<int, User> SleepingUsers { get; }

  /// <summary>Returns <see cref="P:Eco.Gameplay.Components.BedComponent.MountComponent" />. Cannot return null, because it's required. </summary>
  public MountComponent MountComponent { get; }

  /// <summary>Make check for free space by checking <see cref="P:Eco.Gameplay.Components.BedComponent.SleepingUsers" /> with seats count in <see cref="P:Eco.Gameplay.Components.BedComponent.MountComponent" /> due to beds
  /// depend on <see cref="P:Eco.Gameplay.Components.BedComponent.MountComponent" /> and have no own max seats count. </summary>
  public bool HasFreeSpace { get; }

  public override void Initialize();

  [Interaction(InteractionTrigger.InteractKey, "Sleep", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, InteractionFlags.BlocksOtherInteraction, null, true, new string[] {}, RequiredEnvVars = new string[] {"sleep"}, AuthRequired = AccessType.ConsumerAccess)]
  public void SleepInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  /// <summary> Use this for player to sleep in bed only. Uses <see cref="P:Eco.Gameplay.Components.BedComponent.MountComponent" />. </summary>
  [RPC]
  public bool Sleep(Player player);

  /// <summary>Dismounts user from bed, removes from list of "sleepers", removes OnEnterWorld sub. Wakes user in <see cref="T:Eco.Gameplay.Systems.SleepManager" /> </summary>
  [RPC(AccessType.None)]
  public void Wake(User user);

  /// <summary>Moves the player to safe ground above the bed. Called by the client when waking with no clear exit so an enclosed bed (e.g. the starting tent) can never trap the player.</summary>
  [RPC(AccessType.None)]
  public void Unstuck(Player player);

  /// <summary>To avoid awkward behaviour wakes all users in current bed on pickup. </summary>
  /// <param name="player"></param>
  public override void OnPickup(Player player);

  /// <summary>Returns confirmation popup text for player that want to pickup bed with sleeping players. </summary>
  public LocString GetComponentPickupConfirmation();

  [ChatSubCommand("Test", "Spawn a bed and sleep in it.", ChatAuthorizationLevel.DevTier)]
  public static Task Bed(User user);

  /// <summary>To avoid awkward behaviour wakes all players on current bed on destroy. </summary>
  public override void Destroy();
}
