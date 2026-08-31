// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.TrackedCollectionExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Core.Utils;

public static class TrackedCollectionExtensions
{
  /// <summary> Use watcher in order to have easy way to unsubscribe by Unwatch in object. </summary>
  public static void OnCurrentAndFutureEntries<T>(
    this ITrackedEnumerable list,
    Action<INetObject, T> func,
    ISubscriptions<ThreadSafeSubscriptions> watcher,
    Action<INetObject, T> funcUndo = null);

  /// <summary>We notify the parent of this controller list and the list itself that it was changed (somethings were adedd/removed).</summary>
  public static void NotifyChanged(this ITrackedControllerEnumerable list);

  /// <summary>We apply the specified changes and then notify.</summary>
  public static void ApplyChange(this ITrackedControllerEnumerable list, Action change);

  /// <summary>We apply the specified changes and return what's needed and then notify.</summary>
  public static T ApplyChange<T>(this ITrackedControllerEnumerable list, Func<T> change);

  /// <summary>We try to apply the changes and if we were succesful we notify. We return whether we were able to apply the changes or not.</summary>
  public static bool ApplyChangeConditional(
    this ITrackedControllerEnumerable list,
    Func<bool> change);
}
