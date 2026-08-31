// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.SubscriptionUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Utils;
using Eco.Shared.View;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Controller;

public static class SubscriptionUtils
{
  public static void SubscribeToListPropertyAndCall(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    IController parent,
    string listProperty,
    string entryProperty,
    Action onChanged);

  /// <summary>
  /// Updates subscription subject (action emitter). It is thread-safe and ensures old subscription removed from <paramref name="subject" /> even in concurrent environment.
  /// It possible though that both <paramref name="newSubject" /> and <paramref name="subject" /> subscribed. it is very rare case, but you should aware of it.
  /// It happens if action removed from old subject, but subject changed in another thread after this, before new subject assigned (it will be removed anyway because of interlocked change, but it may exists for short period of time).
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void UpdateSubject<T>(
    ref T subject,
    T newSubject,
    string propertyName,
    Action action)
    where T : class, IController;
}
