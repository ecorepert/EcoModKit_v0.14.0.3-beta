// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.PropertyChanges
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary>
/// <see cref="T:Eco.Core.PropertyHandling.PropertyChanges" /> is a class for managing property subscriptions both global and per instance.
/// <c>Global(Un)Subscribe</c> methods may be used for global subscriptions (for all-instances)
/// and <see cref="M:Eco.Core.PropertyHandling.PropertyChanges.FirePropertyChanged(Eco.Core.PropertyHandling.INotifyPropertyChangedInvoker,System.String,System.Object,System.Object)" /> should be used to fire both per-instance and global PropertyChanged events.
/// Usually used in conjunction with Fody <c>PropertyChangedNotificationInterceptor.Intercept</c> which may be implemented as:
/// <code>
/// public static class PropertyChangedNotificationInterceptor2
/// {
///     public static void Intercept(INotifyPropertyChangedInvoker invoker, string propertyName, object? before, object? after) =&gt; PropertyChanges.FirePropertyChanged(invoker, propertyName, before, after);
/// }
/// </code>
/// Read more about property changes in README.md.
/// </summary>
public static class PropertyChanges
{
  /// <summary>Fires both per-instance (using InvokePropertyChanged) and global property change events. If <paramref name="before" /> and <paramref name="after" /> both <c>null</c> it assumes that no before/after values available.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void FirePropertyChanged(
    this INotifyPropertyChangedInvoker invoker,
    string propertyName,
    object? before,
    object? after);

  /// <summary>Fires both per-instance (using InvokePropertyChanged) and global property change events.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void FirePropertyChanged(
    this INotifyPropertyChangedInvoker invoker,
    MemberChangedBeforeAfterEventArgs args);

  /// <summary>If <paramref name="source" /> is <see cref="T:Eco.Core.PropertyHandling.INotifyPropertyChangedInvoker" /> then invokes InvokePropertyChanged which fires per-instance property changes. Anyway fires global property change events.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void FirePropertyChanged(this object source, string propertyName);

  /// <summary>If <paramref name="source" /> is <see cref="T:Eco.Core.PropertyHandling.INotifyPropertyChangedInvoker" /> then invokes InvokePropertyChanged which fires per-instance property changes. Anyway fires global property change events.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void FirePropertyChanged(
    this object source,
    string propertyName,
    object? before,
    object? after);

  /// <summary>If <paramref name="source" /> is <see cref="T:Eco.Core.PropertyHandling.INotifyPropertyChangedInvoker" /> then invokes InvokePropertyChanged which fires per-instance property changes. Anyway fires global property change events.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void FirePropertyChanged(this object source, MemberChangedBeforeAfterEventArgs args);

  /// <summary>Subscribes for <paramref name="propertyName" /> changes on all instances of <paramref name="type" />.</summary>
  public static void GlobalSubscribe(
    Type type,
    string propertyName,
    PropertyChangedBeforeAfterEventHandler action);

  /// <summary>Unsubscribes from <paramref name="propertyName" /> changes on all instances of <paramref name="type" />.</summary>
  public static void GlobalUnsubscribe(
    Type type,
    string propertyName,
    PropertyChangedBeforeAfterEventHandler action);

  /// <summary>Subscribes for all notified properties changes on all instances of <paramref name="type" />.</summary>
  public static void GlobalSubscribe(Type type, PropertyChangedBeforeAfterEventHandler action);

  /// <summary>Unsubscribes from all notified properties changes on all instances of <paramref name="type" />.</summary>
  public static void GlobalUnsubscribe(Type type, PropertyChangedBeforeAfterEventHandler action);

  /// <summary>Return true if the property has an attribute that will make it notify through fody.</summary>
  public static bool IsNotifyingProperty(this PropertyInfo prop);
}
