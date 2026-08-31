// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeActions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Utils;

public static class ThreadSafeActions
{
  /// <summary>
  /// Updates <see cref="T:Eco.Core.Utils.ThreadSafeActionBase`1" /> subject (action emitter). It is thread-safe and ensures old subscription removed from <paramref name="subject" /> even in concurrent environment.
  /// It possible though that both <paramref name="newSubject" /> and <paramref name="subject" /> subscribed. it is very rare case, but you should aware of it.
  /// It happens if action removed from old subject, but subject changed in another thread after this, before new subject assigned (it will be removed anyway because of interlocked change, but it may exists for short period of time).
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UpdateSubject<T, TAction>(
    ref T subject,
    T newSubject,
    Func<T, ThreadSafeActionBase<TAction>> actionAccessor,
    TAction action)
    where T : class
    where TAction : Delegate;

  /// <summary>
  /// Updates subject (action emitter). It uses addAction and removeAction operations for adding action to new subject and removing from the old.
  /// It is thread-safe and ensures old subscription removed from <paramref name="subject" /> even in concurrent environment.
  /// It possible though that both <paramref name="newSubject" /> and <paramref name="subject" /> subscribed for short period of time. It is very rare case, but you should aware of it.
  /// It happens if action removed from old subject, but subject changed in another thread after this, before new subject assigned (it will be removed anyway because of interlocked change, but it may exists for short period of time).
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UpdateSubject<T, TAction>(
    ref T subject,
    T newSubject,
    Action<T, TAction> addAction,
    Action<T, TAction> removeAction,
    TAction action)
    where T : class
    where TAction : Delegate;
}
