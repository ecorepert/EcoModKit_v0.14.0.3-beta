// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.Subscriptions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>
/// Simple subscriptions collection which may be used for holding subset of subscriptions for class.
/// It also may be used as ISubscription to keep sub-collection of subscriptions and unsubscribed together with main collection.
/// </summary>
public sealed class Subscriptions : 
  List<ISubscription>,
  ISubscriptionsList,
  IEnumerable<ISubscription>,
  IEnumerable,
  ISupportNestedSubscriptions<Subscriptions>,
  ISubscription,
  ISubscriptions<Subscriptions>,
  ISubscriptions
{
  Subscriptions ISubscriptions<Subscriptions>.Subscriptions { get; }

  public Subscriptions GetOrCreateSubscriptionsList();

  public void ReleaseSubscriptionsList();

  bool ISubscriptionsList.RemoveSubscription(ISubscription subscription);

  void ISubscriptionsList.AddSubscription(ISubscription subscription);

  public void UnsubscribeAll();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  bool ISubscriptionsList.UnsubscribeFirst<TPredicate>(TPredicate predicate);

  void ISubscriptionsList.UnsubscribeAll<TPredicate>(TPredicate predicate);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Unsubscribe();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  void ISubscription.ReturnToPool();

  public Subscriptions AddNestedSubscriptions();

  ~Subscriptions();
}
