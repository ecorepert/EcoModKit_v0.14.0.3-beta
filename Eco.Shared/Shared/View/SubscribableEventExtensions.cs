// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.SubscribableEventExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.View;

/// <summary>"Syntax sugar" for <see cref="T:Eco.Shared.View.SubscribableEvent`1" />.</summary>
public static class SubscribableEventExtensions
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Invoke(this SubscribableEvent<Action> subscribableEvent);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Invoke<T>(
    this SubscribableEvent<Action<T>> subscribableEvent,
    T arg);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Invoke<T1, T2>(
    this SubscribableEvent<Action<T1, T2>> subscribableEvent,
    T1 arg1,
    T2 arg2);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Invoke<T1, T2, T3>(
    this SubscribableEvent<Action<T1, T2, T3>> subscribableEvent,
    T1 arg1,
    T2 arg2,
    T3 arg3);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Invoke<T1, T2, T3, T4>(
    this SubscribableEvent<Action<T1, T2, T3, T4>> subscribableEvent,
    T1 arg1,
    T2 arg2,
    T3 arg3,
    T4 arg4);
}
