// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.Notification
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Notifications;

/// <summary>Notification for use in server side and for storage. Client side uses manually created NotificationView representation</summary>
[Serialized]
public abstract class Notification : ISerializable, IBsonSerializable, IHasCreationTime
{
  [Serialized]
  public double TimeSeconds { get; set; }

  [Serialized]
  public NotificationCategory Category { get; set; }

  [Serialized]
  public string Text { get; set; }

  public LocString LocalizedText { get; set; }

  [Serialized]
  public NotificationStyle Style { get; set; }

  /// <summary>Returns all receivers as enumerable for the <see cref="T:Eco.Gameplay.Systems.Messaging.Notifications.Notification" />.</summary>
  public abstract IEnumerable<User> GetReceivers();

  /// <summary>Returns only online receivers as enumerable for the <see cref="T:Eco.Gameplay.Systems.Messaging.Notifications.Notification" />.</summary>
  public abstract IEnumerable<User> GetOnlineReceivers();

  /// <summary>Checks if the notification has <paramref name="receiver" />.</summary>
  public abstract bool HasReceiver(User receiver);

  protected Notification();

  protected Notification(
    NotificationCategory category,
    LocString localizedText,
    NotificationStyle style);

  public BSONArray ToBson();
}
