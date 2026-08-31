// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.SubscriptionExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

public static class SubscriptionExtensions
{
  public static void UnsubscribeAll(this IList<IEventSubscription> subs);

  public static void UnsubscribeAll(this ConcurrentQueue<IEventSubscription> subs);

  public static IEventSubscription SubscribeUnique(
    this ThreadSafeAction eventAction,
    Action handlerAction);

  public static IEventSubscription SubscribeUnique<T>(
    this ThreadSafeAction<T> eventAction,
    Action<T> handlerAction);

  public static IEventSubscription SubscribeUnique<T1, T2>(
    this ThreadSafeAction<T1, T2> eventAction,
    Action<T1, T2> handlerAction);

  public static IEventSubscription SubscribeUnique<T1, T2, T3>(
    this ThreadSafeAction<T1, T2, T3> eventAction,
    Action<T1, T2, T3> handlerAction);

  public static IEventSubscription SubscribeUnique<T1, T2, T3, T4>(
    this ThreadSafeAction<T1, T2, T3, T4> eventAction,
    Action<T1, T2, T3, T4> handlerAction);

  public static IEventSubscription SubscribeUnique<T1, T2, T3, T4, T5>(
    this ThreadSafeAction<T1, T2, T3, T4, T5> eventAction,
    Action<T1, T2, T3, T4, T5> handlerAction);

  public static void SubscribeUniqueAndTrack(
    this ThreadSafeList<IEventSubscription> tutorialSubscriptions,
    ThreadSafeAction eventAction,
    Func<bool> func);

  public static void SubscribeUniqueAndTrack<T>(
    this ThreadSafeList<IEventSubscription> tutorialSubscriptions,
    ThreadSafeAction<T> eventAction,
    Func<T, bool> func);

  public static void SubscribeUniqueAndTrack<T1, T2>(
    this ThreadSafeList<IEventSubscription> tutorialSubscriptions,
    ThreadSafeAction<T1, T2> eventAction,
    Func<T1, T2, bool> func);
}
