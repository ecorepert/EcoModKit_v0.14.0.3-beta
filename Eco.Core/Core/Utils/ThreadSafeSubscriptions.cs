// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeSubscriptions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

#nullable enable
namespace Eco.Core.Utils;

/// <summary>Thread safe implementation of <see cref="T:Eco.Shared.View.ISubscriptionsList" /> for server-side code.</summary>
public class ThreadSafeSubscriptions : 
  ISubscriptionsList,
  IEnumerable<ISubscription>,
  IEnumerable,
  ISubscription,
  ISupportNestedSubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public void UnsubscribeAll<TPredicate>(TPredicate predicate) where TPredicate : IPredicate<ISubscription>;

  public bool UnsubscribeFirst<TPredicate>(TPredicate predicate) where TPredicate : IPredicate<ISubscription>;

  public bool RemoveSubscription(ISubscription subscription);

  public void AddSubscription(ISubscription subscription);

  public void UnsubscribeAll();

  public void Unsubscribe();

  public ThreadSafeSubscriptions AddNestedSubscriptions();

  public ThreadSafeSubscriptions Subscriptions { get; }

  public ThreadSafeSubscriptions GetOrCreateSubscriptionsList();

  public void ReleaseSubscriptionsList();

  public ImmutableList<ISubscription>.Enumerator GetEnumerator();

  IEnumerator<ISubscription> IEnumerable<ISubscription>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
