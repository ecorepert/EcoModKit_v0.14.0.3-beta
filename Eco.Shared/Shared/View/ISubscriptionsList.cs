// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ISubscriptionsList
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Base interface for subscriptions lists (may be thread-safe or thread-unsafe list implementation). It also may support pooling.</summary>
public interface ISubscriptionsList : IEnumerable<ISubscription>, IEnumerable
{
  /// <summary>Unsubscribe all subscriptions matching predicate.</summary>
  void UnsubscribeAll<TPredicate>(TPredicate predicate) where TPredicate : IPredicate<ISubscription>;

  /// <summary>Unsubscribes fist subscription matching <paramref name="predicate" />.</summary>
  /// <returns><c>true</c> if a match was found and unsubscribed.</returns>
  bool UnsubscribeFirst<TPredicate>(TPredicate predicate) where TPredicate : IPredicate<ISubscription>;

  /// <summary>Unsubscribes specific <paramref name="subscription" />.</summary>
  bool RemoveSubscription(ISubscription subscription);

  /// <summary>Adds new <paramref name="subscription" /> to <see cref="T:Eco.Shared.View.ISubscriptionsList" />.</summary>
  void AddSubscription(ISubscription subscription);

  /// <summary>Unsubscribes all previously added subscriptions and cleans subscription collection.</summary>
  void UnsubscribeAll();

  /// <summary>Releases unsubscribed <paramref name="subscription" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected static void ReleaseSubscription(ISubscription subscription);
}
