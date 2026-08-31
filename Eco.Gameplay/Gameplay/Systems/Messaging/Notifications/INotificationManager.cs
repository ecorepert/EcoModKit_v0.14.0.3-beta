// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.INotificationManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Notifications;

public interface INotificationManager
{
  /// <summary>
  /// Sends <see cref="T:Eco.Gameplay.Systems.Messaging.Notifications.Notification" /> to users from <paramref name="to" /> enumerable. If <paramref name="to" /> is <c>null</c> then sends to all users, but if <paramref name="to" /> is empty then doesn't send notification to any user.
  /// This way you may distinguish between empty user set (i.e. from Demographic) and broadcast message.
  /// </summary>
  Result Send(
    IEnumerable<User>? to,
    NotificationCategory category,
    LocString message,
    NotificationStyle style,
    IEnumerable<User>? except = null,
    bool forceTemporary = false);
}
