// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.ChangeWatcher
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable enable
namespace Eco.Core.Properties;

/// <summary>The one and only service that should be used for the server to monitor updates of properties.</summary>
public static class ChangeWatcher
{
  public static ISubscription? WatchPropAndCall(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged watch,
    [ControllerPropertyName(null)] string memberName,
    Action onChanged);

  public static ISubscription WatchAllPropsAndCall(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged watch,
    Action onChanged);

  public static ISubscription WatchEventAndCall(
    this ISubscriptions<ThreadSafeSubscriptions> ss,
    ThreadSafeAction eventAction,
    Action onChanged);

  public static ISubscription WatchEventAndCall<T>(
    this ISubscriptions<ThreadSafeSubscriptions> ss,
    ThreadSafeAction<T> eventAction,
    Action<T> onChanged,
    T callparam);

  public static ISubscription WatchEventAndCall<T1, T2>(
    this ISubscriptions<ThreadSafeSubscriptions> ss,
    ThreadSafeAction<T1, T2> eventAction,
    Action<T1, T2> onChanged,
    T1 callparam1,
    T2 callparam2);

  public static ISubscription WatchEventAndCall<T1, T2, T3>(
    this ISubscriptions<ThreadSafeSubscriptions> ss,
    ThreadSafeAction<T1, T2, T3> eventAction,
    Action<T1, T2, T3> onChanged,
    T1 callparam1,
    T2 callparam2,
    T3 callparam3);

  public static ISubscription WatchEventAndCall<T1, T2, T3, T4>(
    this ISubscriptions<ThreadSafeSubscriptions> ss,
    ThreadSafeAction<T1, T2, T3, T4> eventAction,
    Action<T1, T2, T3, T4> onChanged,
    T1 callparam1,
    T2 callparam2,
    T3 callparam3,
    T4 callparam4);

  public static ISubscription WatchEventAndCall<T1, T2, T3, T4, T5>(
    this ISubscriptions<ThreadSafeSubscriptions> ss,
    ThreadSafeAction<T1, T2, T3, T4, T5> eventAction,
    Action<T1, T2, T3, T4, T5> onChanged,
    T1 callparam1,
    T2 callparam2,
    T3 callparam3,
    T4 callparam4,
    T5 callparam5);

  public static ISubscription? WatchPropOnAllInstancesAndCall(
    this ISubscriptions<ThreadSafeSubscriptions>? subs,
    Type type,
    [ControllerPropertyName(null)] string memberName,
    Action onChanged);

  public static ISubscription? WatchAllPropsOnAllInstancesAndCall(
    this ISubscriptions<ThreadSafeSubscriptions>? subs,
    Type type,
    Action onChanged);

  public static void WatchPropOnPropAndCall(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged watch,
    string memberName,
    string memberOfMemberName,
    Action onChanged);

  /// <summary>Watches a member called 'memberName' on object 'watch'. This member must be a property, and fody property notification is used to notify changes.
  /// Maintains subscription on 'subs' (though null can be passed in which case the subscription isnt tracked).</summary>
  public static ISubscription? WatchProp(
    this ISubscriptions<ThreadSafeSubscriptions>? subs,
    INotifyPropertyChanged watch,
    [ControllerPropertyName(null)] string memberName,
    PropertyChangedBeforeAfterEventHandler onChanged);

  /// <summary>Finds the subscriptions using the given callback and removes it for the given watch</summary>
  public static void Unwatch(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged watch);

  /// <summary>Watches for any property change on a given object.</summary>
  public static ISubscription WatchAllProps(
    this ISubscriptions<ThreadSafeSubscriptions>? subs,
    INotifyPropertyChanged watch,
    PropertyChangedBeforeAfterEventHandler onChanged);

  /// <summary>Watch a given property on ALL instances of a given type.</summary>
  public static ISubscription? WatchPropOnAllInstances(
    this ISubscriptions<ThreadSafeSubscriptions>? subs,
    Type type,
    string memberName,
    PropertyChangedBeforeAfterEventHandler onChanged);

  /// <summary>Watch ALL properties on ALL instances of a given type.</summary>
  public static ISubscription? WatchAllPropsOnAllInstances(
    this ISubscriptions<ThreadSafeSubscriptions>? subs,
    Type type,
    PropertyChangedBeforeAfterEventHandler onChanged);

  /// <summary>Go through the subscriptions and remove any that watch the given subject.</summary>
  public static void UnwatchSubject(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged subject);

  /// THREADSAFEACTION subscriptions.
  ///             Pack of ThreadSafeAction watch/unwatch (rolled out so we can use mulitple params)
  ///             <summary>Subscribe to a regular PropertyChangedBeforeAfterEventHandler and track it.</summary>
  public static ISubscription WatchEvent(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction eventAction,
    Action callback);

  /// <summary>Subscribe to a regular PropertyChangedBeforeAfterEventHandler and track it.</summary>
  public static ISubscription WatchEvent<T>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T> eventAction,
    Action<T> callback);

  /// <summary>Subscribe to a regular PropertyChangedBeforeAfterEventHandler and track it.</summary>
  public static ISubscription WatchEvent<T1, T2>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2> eventAction,
    Action<T1, T2> callback);

  /// <summary>Subscribe to a regular PropertyChangedBeforeAfterEventHandler and track it.</summary>
  public static ISubscription WatchEvent<T1, T2, T3>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2, T3> eventAction,
    Action<T1, T2, T3> callback);

  /// <summary>Subscribe to a regular PropertyChangedBeforeAfterEventHandler and track it.</summary>
  public static ISubscription WatchEvent<T1, T2, T3, T4>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2, T3, T4> eventAction,
    Action<T1, T2, T3, T4> callback);

  /// <summary>Subscribe to a regular PropertyChangedBeforeAfterEventHandler and track it.</summary>
  public static ISubscription WatchEvent<T1, T2, T3, T4, T5>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2, T3, T4, T5> eventAction,
    Action<T1, T2, T3, T4, T5> callback);

  /// <summary>Make a subscription to track an enumerable that implements the <see cref="T:Eco.Core.Utils.ITrackedEnumerable" /> interface and call the callback whenever its entries get changed.</summary>
  /// <param name="ss">The object that we want to add the subscription to.</param>
  /// <param name="enumerable">The enumerable that we want to watch.</param>
  /// <param name="callback">The action that will be called whenever the property that we're watching get changed.</param>
  public static ISubscription WatchEnumerable(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ITrackedEnumerable enumerable,
    Action callback);

  /// <summary>Make a subscription to track a specified property for all the entries that are inside the specified enumerable (the enumerable must implement the <see cref="T:Eco.Core.Utils.ITrackedEnumerable" /> interface).</summary>
  /// <param name="ss">The object that we want to add the subscription to.</param>
  /// <param name="enumerable">The enumerable that we want to watch its entries properties.</param>
  /// <param name="propertyName">The name of the property that we want to track for all the entries.</param>
  /// <param name="callback">The action that will be called whenever the property that we're watching get changed.</param>
  public static ISubscription WatchPropInsideEnumerable(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ITrackedEnumerable enumerable,
    string propertyName,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Make a subscription to track all properties for all entries that are inside the specified enumerable (the enumerable must implement the <see cref="T:Eco.Core.Utils.ITrackedEnumerable" /> interface).</summary>
  /// <param name="ss">The object that we want to add the subscription to.</param>
  /// <param name="enumerable">The enumerable that we want to watch its entries properties.</param>
  /// <param name="callback">The action that will be called whenever the property that we're watching get changed.</param>
  public static ISubscription WatchAllPropInsideEnumerable(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ITrackedEnumerable enumerable,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Unsubscribe, using the target and callback as handles.</summary>
  public static void Unwatch(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction eventAction,
    Action callback);

  /// <summary>Unsubscribe, using the target and callback as handles.</summary>
  public static void Unwatch<T>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T> eventAction,
    Action<T> callback);

  /// <summary>Unsubscribe, using the target and callback as handles.</summary>
  public static void Unwatch<T1, T2>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2> eventAction,
    Action<T1, T2> callback);

  /// <summary>Unsubscribe, using the target and callback as handles.</summary>
  public static void Unwatch<T1, T2, T3>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2, T3> eventAction,
    Action<T1, T2, T3> callback);

  /// <summary>Unsubscribe, using the target and callback as handles.</summary>
  public static void Unwatch<T1, T2, T3, T4>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2, T3, T4> eventAction,
    Action<T1, T2, T3, T4> callback);

  /// <summary>Unsubscribe, using the target and callback as handles.</summary>
  public static void Unwatch<T1, T2, T3, T4, T5>(
    this ISubscriptions<ThreadSafeSubscriptions>? ss,
    ThreadSafeAction<T1, T2, T3, T4, T5> eventAction,
    Action<T1, T2, T3, T4, T5> callback);

  /// <summary>Here we do a nested watch: we watch for a given property *on* an instance specified by another property.
  /// For example, settlement may want to watch when Settlement.Leader.MarkedupName changes.  This requires a nested watch,
  /// as it must trigger both
  ///   1) when Leader changes or
  ///   2) when Leader.MarkedupName changes.
  /// It also handles the weak-reference subscription and unsubscrition of all parts involved.
  /// Note: unlike WatchMember, 'subs' must be non-null, because tracking member-of-member subscriptions is always necessary</summary>
  public static void WatchPropOnProp(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged watch,
    string memberName,
    string? memberOfMemberName,
    PropertyChangedBeforeAfterEventHandler callback);

  /// <summary>Watches for when a given member changes, and maintains a subscription to *every* property on that instance, removing old subscriptions.</summary>
  public static void WatchAllPropsOnProp(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    INotifyPropertyChanged watch,
    string memberName,
    PropertyChangedBeforeAfterEventHandler callback);
}
