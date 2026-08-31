// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.SubscriptionsExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Extension methods for <see cref="T:Eco.Shared.View.ISubscriptions`1" />.</summary>
public static class SubscriptionsExtensions
{
  /// <summary>Function which creates IPropertySubscription, for server it will create ImmutablePropertySubscription instead of PropertySubscription, because it is thread-safe</summary>
  public static Func<IObservable, string, Action, IPropertySubscription> CreatePropertySubscription;

  /// <summary>Unsubscribe all subscriptions matching predicate.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UnsubscribeAll<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    Func<ISubscription, bool> predicate)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary>Unsubscribes fist subscription matching <paramref name="predicate" />.</summary>
  /// <returns><c>true</c> if a match was found and unsubscribed.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool UnsubscribeFirst<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    Func<ISubscription, bool> predicate)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary>Unsubscribe all subscriptions matching predicate.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UnsubscribeAll<TSubscriptionsList, TPredicate>(
    this ISubscriptions<TSubscriptionsList> ss,
    TPredicate predicate)
    where TSubscriptionsList : ISubscriptionsList
    where TPredicate : IPredicate<ISubscription>;

  /// <summary>Unsubscribes fist subscription matching <paramref name="predicate" />.</summary>
  /// <returns><c>true</c> if a match was found and unsubscribed.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool UnsubscribeFirst<TSubscriptionsList, TPredicate>(
    this ISubscriptions<TSubscriptionsList> ss,
    TPredicate predicate)
    where TSubscriptionsList : ISubscriptionsList
    where TPredicate : IPredicate<ISubscription>;

  /// <summary>Unsubscribes specific <paramref name="subscription" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool RemoveSubscription<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    ISubscription subscription)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary>Unsubscribes all previously added subscriptions and cleans subscription collection.</summary>
  /// <param name="release">by default Subscriptions list will be just cleared and then may be reused without recreation of list, but if Subscriptions won't be used anymore they may be released and returned to pool.</param>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UnsubscribeAll<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    bool release = false)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary>Unsubscribe all subscriptions for given subject.</summary>
  /// <param name="ss">this ref.</param>
  /// <param name="subject">subject to unsubscribe.</param>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UnsubscribeAllForSubject<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IObservable? subject)
    where TSubscriptionsList : ISubscriptionsList;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Unsubscribe<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IObservable? subject,
    string propertyName,
    Action changedCallback)
    where TSubscriptionsList : ISubscriptionsList;

  public static ISubscription? Subscribe<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IObservable s,
    string propertyName,
    Action changedCallback)
    where TSubscriptionsList : ISubscriptionsList;

  public static bool SubscribeUnique<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IObservable s,
    string propname,
    Action changedCallback)
    where TSubscriptionsList : ISubscriptionsList;

  public static void SubscribeAndCall<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IObservable s,
    string propname,
    Action changedCallback)
    where TSubscriptionsList : ISubscriptionsList;

  public static bool SubscribeUniqueAndCall<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IObservable s,
    string propname,
    Action changedCallback)
    where TSubscriptionsList : ISubscriptionsList;

  public static void Subscribe<TSubscriptionsList, T>(
    this ISubscriptions<TSubscriptionsList> ss,
    SubscribableEvent<T> eventAction,
    T callback)
    where TSubscriptionsList : ISubscriptionsList
    where T : Delegate;

  public static void SubscribeAndCall<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    SubscribableEvent<Action> eventAction,
    Action callback)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary>Makes nested subscriptions collection working as subset of <paramref name="ss" />. It will be unsubscribed when <see cref="M:Eco.Shared.View.SubscriptionsExtensions.UnsubscribeAll``1(Eco.Shared.View.ISubscriptions{``0},System.Func{Eco.Shared.View.ISubscription,System.Boolean})" /> called on <paramref name="ss" />, but may when <see cref="M:Eco.Shared.View.SubscriptionsExtensions.UnsubscribeAll``1(Eco.Shared.View.ISubscriptions{``0},System.Func{Eco.Shared.View.ISubscription,System.Boolean})" /> called on this it will only clear nested subscriptions.</summary>
  public static TSubscriptionsList MakeNestedSubscriptions<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss)
    where TSubscriptionsList : ISubscriptionsList, ISupportNestedSubscriptions<TSubscriptionsList>;

  /// <summary>
  /// Destroys nested subscriptions previously created with <see cref="M:Eco.Shared.View.SubscriptionsExtensions.MakeNestedSubscriptions``1(Eco.Shared.View.ISubscriptions{``0})" />.
  /// It will unsubscribe all subscriptions in <paramref name="nested" /> and remove from <paramref name="subs" />.
  /// Destroyed nested subscriptions can't be used, because they will be recycled and continue using it will lead to unpredictable behavior.
  /// </summary>
  public static void DestroyNestedSubscriptions<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> subs,
    TSubscriptionsList nested)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary> Tries to add <paramref name="subscription" /> to <paramref name="ss" />. Internally it subscribes on <see cref="P:Eco.Shared.View.IPropertySubscription.Subject" />. If subscription already was added to same property with same callback then it will return <c>false</c> and won't add subscription. </summary>
  public static bool TrySubscribe<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    IPropertySubscription subscription)
    where TSubscriptionsList : ISubscriptionsList;

  /// <summary>Creates a subscription but doesnt track it within a Subscriptions object. Should only be used when something is subscribing to its own properties,
  /// meaning both 'watched' and 'watcher' are a single object and die at the same time.</summary>
  public static ISubscription SubscribeWithoutTracking(
    IObservable observable,
    string propname,
    Action callback);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void AddSubscription<TSubscriptionsList>(
    this ISubscriptions<TSubscriptionsList> ss,
    ISubscription subscription)
    where TSubscriptionsList : ISubscriptionsList;
}
