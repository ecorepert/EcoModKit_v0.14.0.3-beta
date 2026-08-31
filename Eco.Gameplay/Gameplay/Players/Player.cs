// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Player
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Agents;
using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Minimap;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using Eco.Shared.Voxel;
using Eco.Simulation.Agents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Players;

[AutogenClass]
public sealed class Player : WorldObserver, ICanTakeDamage, IDisposable, INotificationReceiver
{
  public 
  #nullable disable
  ThreadSafeAction<PlotPos> OnChangedPlotPosition;
  internal readonly MovementHackDetector MovementHackDetector;
  /// <summary>Handles all player vehicle mounting and dismounting logic.</summary>
  public readonly MountManager MountManager;

  public ThreadSafeAction<Eco.Gameplay.UI.WorldMarker.WorldMarker> OnMarkerAdd { get; }

  public override string Name { get; }

  public override void InfoBox(string msg);

  public MinimapObject MinimapObject { get; }

  public int TargetId { get; }

  public Vector3i TargetPos { get; }

  /// <summary>Sets the new MaxAllowedVelocity value. Can be null.</summary>
  internal void SetMaxAllowedVelocity(float? value);

  public Vector3 BaseVelocity { get; }

  public float DesiredSpeed { get; }

  public override Vector3 FacingDir { get; }

  public override INetClient Client { get; }

  public bool Flying { get; }

  public override bool IsAdmin();

  /// <summary>
  /// Flag determining if the player currently has the Twitch integration enabled.
  /// </summary>
  public bool TwitchEnabled { get; }

  /// <summary>
  /// Called when the client changes the value of <see cref="P:Eco.Gameplay.Players.Player.TwitchEnabled" />.
  /// </summary>
  public static ThreadSafeAction<User, bool> OnTwitchEnableStateChange { get; }

  [NewTooltipChildren(CacheAs.Instance)]
  public User User { get; }

  public override bool IsInitialized { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public Player(User user, float viewDistance, INetClient client);

  public override void Destroy();

  public void DestroyPlayer();

  [RPC(AccessType.Admin)]
  public void SetFlying(bool set);

  /// <summary> Open info panel </summary>
  /// <param name="title"></param>
  /// <param name="text"></param>
  /// <param name="category"> The category, based on which will be remembered preferred positions and size. </param>
  public void OpenInfoPanel(string title, string text, string category);

  /// <summary> Opens the Objectives UI on the client. </summary>
  [RPC]
  public void OpenObjectives();

  /// <summary>True once the client's avatar spawned and started sending observer updates: the signal that bulk data (deferred view syncs) may flow without delaying the join handshake.</summary>
  public bool ClientReadyForBulkData { get; }

  public override void ReceiveUpdate(BSONObject bsonObj);

  public void SetInitialMinimapObjectPos();

  public override bool IsUpdated(INetObjectViewer viewer);

  public override void SendInitialState(BSONObject obj, INetObjectViewer viewer);

  public override void Error(LocString message);

  public void ErrorLocStr(string message);

  public void ErrorLoc(FormattableString message);

  public void InfoBox(LocString message);

  public void InfoBoxLocStr(string message);

  public void InfoBoxLoc(FormattableString message);

  public void InfoBoxExtraLoc(FormattableString message, string extra);

  public void Msg(LocString message, NotificationStyle style = NotificationStyle.Chat);

  public void MsgLoc(FormattableString message, NotificationStyle style = NotificationStyle.Chat);

  public void MsgLocStr(string message, NotificationStyle style = NotificationStyle.Chat);

  public Result OkBox(LocString message, bool succeeded);

  public void OkBox(LocString message);

  public void OkBoxLoc(FormattableString message);

  public void OkBoxLocStr(string message);

  public void OkBoxExtraLoc(FormattableString message, string extra);

  public Result OkBoxLoc(FormattableString message, bool succeeded);

  public Task<bool> OkBoxAwaitable(LocString message);

  public Task<bool> OkBoxAwaitableLoc(FormattableString message);

  public Task<bool> ConfirmBoxLoc(FormattableString message);

  public Task<bool> ConfirmBox(LocString message);

  /// <summary>Opens a large popup dialog box with the supplied text and header.</summary>
  /// <param name="header">Header of the new popup dialog.</param>
  /// <param name="message">The text to display to the user in the popup dialog.</param>
  /// <param name="button">Text to display on the button. Defaults to "Ok".</param>
  public Task<bool> LargeInfoBox(LocString header, LocString message, LocString? button = null);

  /// <summary>Opens a large resizable popup dialog box with the supplied text, header and two buttons.  Seconds button will be 'copy'</summary>
  /// <param name="header">Header of the new popup dialog.</param>
  /// <param name="message">Text to display to the user in the popup dialog.</param>
  /// <param name="buttonOne">Text to display on the first button ('Ok' by default).</param>
  /// <param name="buttonTwo">Text to display on the second button ('Copy' by default).</param>
  public Task<bool> LargeInfoBoxWithTwoButtons(
    LocString header,
    LocString message,
    LocString? buttonOne = null,
    LocString? buttonTwo = null);

  /// <summary>Opens a large resizable popup dialog box with the supplied text, header and two buttons.</summary>
  /// <param name="header">Header of the new popup dialog.</param>
  /// <param name="message">Text to display to the user in the popup dialog.</param>
  /// <param name="buttonOne">Text to display on the first button ('Ok' by default).</param>
  /// <param name="buttonTwo">Text to display on the second button ('Copy' by default).</param>
  public Task<bool> LargeInfoBoxConfirm(
    LocString header,
    LocString message,
    LocString? buttonOne = null,
    LocString? buttonTwo = null);

  /// <summary>Presents a text input dialog to the user to send a text back to the server or hit cancel.</summary>
  /// <param name="message">Message to show to the user about the text they are entering</param>
  /// <param name="defaultText">Default text to place into the input field</param>
  /// <returns>Text entered by the user if they hit confirm. Otherwise returns the value of <see cref="F:System.String.Empty" /></returns>
  public Task<string> InputString(LocString message, LocString? defaultText = null);

  /// <summary>Presents a password input dialog to the user to send a text back to the server or hit cancel.</summary>
  /// <inheritdoc cref="M:Eco.Gameplay.Players.Player.InputString(Eco.Shared.Localization.LocString,System.Nullable{Eco.Shared.Localization.LocString})" />
  public Task<string> InputPasswordString(LocString message, LocString? defaultText = null);

  /// <summary>Presents a large text input dialog to the user to send a text back to the server or hit cancel.</summary>
  /// <inheritdoc cref="M:Eco.Gameplay.Players.Player.InputString(Eco.Shared.Localization.LocString,System.Nullable{Eco.Shared.Localization.LocString})" />
  /// <param name="maxLength">Sets the max number of characters that the user can enter into the text field.</param>
  public Task<string> InputLargeString(LocString message, LocString? defaultText = null, int maxLength = 400);

  /// <summary>Sets the client's current Twitch enabled status state.</summary>
  /// <param name="state">State that the client is currently in.</param>
  public void SetTwitchEnabledOnServer(bool state);

  public override void SendUpdate(BSONObject obj, INetObjectViewer viewer);

  public override string ToString();

  /// <summary> Delegates damage to <see cref="P:Eco.Gameplay.Players.Player.User" />. </summary>
  [RPC]
  public bool TryDamage(int source, float damage, DamageSourceType sourceType);

  [RPC]
  public bool TryDamage(INetObject source, float damage, DamageSourceType sourceType);

  public string DisplayName { get; }

  [RPC]
  public void ShowLocation(PointOfInterest pointOfInterest);

  [RPC]
  public void ShowLocationPos(Vector3i position);

  /// <summary>Sets the player's twitch enabled state</summary>
  /// <param name="state">Client's new Twitch integration enabled state</param>
  [RPC]
  public void SetTwitchEnabled(bool state);

  public void SetPosition(Vector3 position);

  /// <summary>Teleports like <see cref="M:Eco.Gameplay.Players.Player.SetPosition(System.Numerics.Vector3)" /> but first streams the destination chunks to the client so the player doesn't arrive into un-meshed void.
  /// Dedicated flow for preloaded teleport commands — regular teleports stay instant.</summary>
  public Task PreloadedTeleportAsync(Vector3 position);

  public void SetRelativePosAndRot(int targetID, Vector3 position, Vector3 direction);

  public void SetPositionAndRotation(Vector3 position, Eco.Shared.Math.Quaternion rotation);

  [RPC]
  public void DropExactWaypoint(Vector3i pos, string data);

  [RPC]
  public void DropWaypoint(Vector2i pos);

  [RPC]
  public void DeleteAllWaypoints();

  [RPC]
  public void MinimapOpened();

  [RPC]
  public void NotifyMinimapIsOpenInWindowOrFullscreenMode();

  [RPC]
  public void MinimapSelectLayer();

  [RPC]
  public void HandleLinkClicked(
    string linkId,
    bool cntrPressed,
    bool shiftPressed,
    TooltipOrigin origin);

  [RPC]
  public void HandleButtonLinkClicked(string linkId, string rpcMethodName, BSONObject args);

  [RPC]
  public void HandleViewLinkClicked(
    IController obj,
    bool cntrPressed,
    bool shiftPressed,
    TooltipOrigin origin);

  [RPC]
  public Item GetItemForType(string typeName);

  [RPC]
  public string GetItemUILinkForType(string typeName);

  [RPC]
  public void GiveReputationTo(User user, int targetID, float value, string review);

  [RPC]
  public void GiveReputationTo(
    User user,
    int targetID,
    float value,
    string review,
    Vector3i actionLocation);

  [RPC]
  public void OpenRepDialog(int targetID);

  public void TrySetEmote(string emoteID);

  public void StopEmotes();

  /// <summary>
  /// This function is called by the client when the player is in 'shadow placement' mode.
  /// It checks if a placement position is valid or not, by receiving the position and rotation of the object to be placed from the player.
  /// Returns true if the placement is valid, false otherwise. Also returns the blocks that are blocking the object placement position, if any.
  /// </summary>
  [RPC]
  public (bool IsValid, List<Vector3i> UnavailablePositions) IsValidPlacement(
    Vector3i position,
    Eco.Shared.Math.Quaternion rotation);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SpawnBlockEffect(Vector3i blockPosition, System.Type blockType, BlockEffect effect);

  public void SpawnBlockEffect(
    Vector3i blockPosition,
    System.Type blockType,
    BlockEffect effect,
    BlockEffectParameters parameters);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void SpawnBlockEffect(
    WrappedWorldPosition3i blockPosition,
    System.Type blockType,
    BlockEffect effect,
    BlockEffectParameters parameters);

  public override object ConvertToType(System.Type type);

  public void Dispose();

  public override void SimulationInteract(
    INetObject interactor,
    WorldObserver.SimulationInteractType interactionType);

  public ref int ControllerID { get; }
}
