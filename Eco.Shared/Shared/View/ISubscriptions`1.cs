// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ISubscriptions`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>
/// This is a replacement for IAnonymousSubscriber.
/// This simplifies Subscription management, because you can use it with extension methods for easy subscription management.
/// </summary>
public interface ISubscriptions<out TSubscriptionsList> : ISubscriptions where TSubscriptionsList : ISubscriptionsList
{
  TSubscriptionsList? Subscriptions { get; }

  /// <summary>Gets existing or creates new <see cref="P:Eco.Shared.View.ISubscriptions`1.Subscriptions" /> list.</summary>
  TSubscriptionsList GetOrCreateSubscriptionsList();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  void ISubscriptions.UnsubscribeAll();
}
