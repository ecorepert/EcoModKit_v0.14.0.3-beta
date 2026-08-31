// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.SubscribableEvent`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Typed <see cref="T:Eco.Shared.View.ISubscribableEvent" />. Not thread-safe. Simple wrapper around <typeparamref name="T" /> delegate. Can be used with <see cref="T:Eco.Shared.View.EventSubscription" />.</summary>
public sealed class SubscribableEvent<T> : ISubscribableEvent where T : Delegate
{
  public T? Event;

  /// <summary>Adds new handler for <see cref="F:Eco.Shared.View.SubscribableEvent`1.Event" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Add(T handler);

  /// <summary>Removes previously added handler from <see cref="F:Eco.Shared.View.SubscribableEvent`1.Event" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Remove(T handler);

  void ISubscribableEvent.Add(Delegate action);

  void ISubscribableEvent.Remove(Delegate action);
}
