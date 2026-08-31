// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.NotificationManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Notifications;

/// <summary>
/// NotificationManager is the central hub for dispatching notifications of all sorts to the players.
/// This class exposes static API for easier usage, but internally uses ServiceHolder instance which is needed for tests with DummyNotificationManager.
/// </summary>
public class NotificationManager : 
  Singleton<NotificationManager>,
  INetObjectPriority,
  INetObject,
  INotificationManager
{
  public AggregatedNotifications AggregatedNotifications;

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public void ReceiveInitialState(BSONObject bsonObj);

  public void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveUpdate(BSONObject bsonObj);

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public float Priority { get; }

  public int TotalMessages { get; }

  public void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void ServerMessageToPlayerLoc(
    FormattableString text,
    User to,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void ServerMessageToPlayerLocStr(
    string text,
    User to,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat);

  /// <summary> Send chat message to player, it's temporary won't be stored on server storage </summary>
  public static void TemporaryServerMessageToPlayer(
    LocString text,
    User? to,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat);

  /// <summary> Send chat message to player </summary>
  public static void ServerMessageToPlayer(
    LocString text,
    User? to,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat,
    bool forceTemporary = false);

  public static void ServerMessageToAlias(
    LocString text,
    IAlias to,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat,
    bool forceTemporary = true);

  public static void ServerMessageToAlias(
    LocString text,
    IAlias to,
    Func<User, bool> predicate,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat,
    bool forceTemporary = true);

  public static void Msg(
    LocString text,
    IEnumerable<User> to,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Chat,
    bool forceTemporary = false);

  public static void GlobalNotification(Result result);

  public static void GlobalNotificationLoc(
    FormattableString s,
    NotificationCategory category = NotificationCategory.Notifications,
    bool isImportant = false);

  public static void GlobalNotification(
    LocString s,
    NotificationCategory category = NotificationCategory.Notifications,
    bool isImportant = false);

  public static void ServerMessageToAllLoc(
    FormattableString s,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Info,
    IEnumerable<User>? except = null);

  public static void ServerMessageToAll(
    LocString text,
    NotificationCategory category = NotificationCategory.Notifications,
    NotificationStyle style = NotificationStyle.Info,
    IEnumerable<User>? except = null,
    bool forceTemporary = true);

  public Result Send(
    IEnumerable<User>? to,
    NotificationCategory category,
    LocString message,
    NotificationStyle style = NotificationStyle.Info,
    IEnumerable<User>? except = null,
    bool forceTemporary = false);

  /// <summary>Send RPC with <param name="notificationMessage"></param> notification message and <param name="position"></param> position to <param name="user"></param>user</summary>
  public void SendInstantNotification(
    User user,
    LocString notificationMessage,
    InstantNotificationPosition position);

  internal void AddToNotificationLog(Notification message);

  public static IEnumerable<Notification> GetNotificationsVisibleTo(
    User user,
    int max,
    double timeSentBefore = 1.7976931348623157E+308);

  public void Tick();
}
