// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.BaseUserIDList`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Localization;
using StrangeCloud.Service.Client.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Players;

[TypeConverter(typeof (ExpandableObjectConverter))]
public abstract class BaseUserIDList<T>
{
  public ThreadSafeAction<string?> UserIDAddedEvent;
  public ThreadSafeAction<string?> UserIDRemovedEvent;

  public SerializedSynchronizedCollection<T> Collection { get; set; }

  /// <summary>Add user to the collection and notify result or describe result</summary>
  /// <param name="invoker"></param>
  /// <param name="targetIdOrName"></param>
  /// <param name="time">For how long user should stay in the list. If empty : time is five years. Format: 1m, 1h, 1d, 1w</param>
  /// <param name="listDisplayName"></param>
  /// <param name="reason"></param>
  public User? AddAndNotifyOrDescribe(
    IChatClient? invoker,
    string targetIdOrName,
    string time = "",
    LocString? listDisplayName = null,
    string reason = "");

  public void RemoveAndNotify(
    IChatClient? invoker,
    string targetIdOrName,
    LocString? listDisplayName = null,
    string reason = "");

  public void DescribeCollection(IChatClient invoker);

  public bool Contains(User user);

  public bool Contains(StrangeUser strangeUser);

  protected abstract void UpdateStoredUsers();

  protected abstract bool TryAddUser(
    string targetIdOrName,
    (bool Result, DateTime Date) countedTime);

  protected abstract bool TryRemoveUser(string targetIdOrName);

  protected virtual List<string> CachedDescribeEntries { get; set; }

  protected abstract bool ContainsByParams(params string?[] ids);

  /// <summary> Helper that shows elements of the collection or tries to add or remove provided string element (updates config if something was changed). </summary>
  protected User? FindAndAddOrRemoveToList(
    IChatClient? invoker,
    string targetIdOrName,
    string? time,
    bool add = true,
    LocString? listDisplayName = null,
    string reason = "");
}
