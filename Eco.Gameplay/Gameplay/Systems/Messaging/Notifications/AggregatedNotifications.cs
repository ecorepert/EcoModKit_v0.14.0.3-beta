// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.AggregatedNotifications
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Notifications;

public class AggregatedNotifications
{
  public 
  #nullable disable
  IEnumerable<object> CurrentDatas(string key);

  /// <summary>Begin an aggregated message that appends the passed data to the list, updates the time of send, and assigns
  /// the instructions to how to build the final data.  The notification will be identified as a key of user+handle string.</summary>
  /// <param name="accumulateSeparateMessagesPerUser">If true, each user will have their own separate notification. Otherwise, users will be accumulated into a single notification.</param>
  /// <paran nane="showOneThenStartDelaying">If set, the first time an aggregated message is made it will </paran>
  /// 
  ///             TODO: When settlement set, only send to citizens of that.
  public void AddAggregatedMessage(
    User user,
    string handle,
    object data,
    double delay,
    bool showOneThenStartDelaying,
    Func<IEnumerable<User>, IEnumerable<object>, LocString> makeMsg,
    bool accumulateSeparateMessagesPerUser = true,
    Settlement settlement = null,
    NotificationCategory category = NotificationCategory.Notifications);

  /// <summary>Get any aggregated messages from the queue, and clear them from the list.</summary>
  public IEnumerable<(LocString Message, NotificationCategory Category)> GetAndClearReadyAggregatedMessages();

  /// <summary> Override all aggregated notification delay, used for testing. </summary>
  public static void SetDelayOverride(int? value);

  private class AggregatedNotification
  {
    public ConcurrentBag<object> AccumulatedData;
    public ThreadSafeList<User> AccumulatedUsers;
    public Func<IEnumerable<User>, IEnumerable<object>, LocString> MakeMsg;
    public double TimeToSend;
    public NotificationCategory Category;
  }
}
