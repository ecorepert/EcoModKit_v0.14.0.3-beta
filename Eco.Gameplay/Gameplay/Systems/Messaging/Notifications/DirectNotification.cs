// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.DirectNotification
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Notifications;

/// <summary>Direct notification to one or more users.</summary>
[Serialized]
public class DirectNotification : Notification
{
  [Serialized]
  public ThreadSafeHashSet<User> Receivers { get; set; }

  public override IEnumerable<User> GetReceivers();

  public override IEnumerable<User> GetOnlineReceivers();

  public override bool HasReceiver(User receiver);

  public DirectNotification(
    NotificationCategory category,
    LocString localizedText,
    NotificationStyle style,
    IEnumerable<User> receivers);
}
