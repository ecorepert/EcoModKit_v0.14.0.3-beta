// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Controller;

public static class ControllerExtensions
{
  /// <summary>Watch for a property changing through the fody system.
  /// DEPRECATED. Use ChangeWatcher class.</summary>
  public static PropertyChangedEventHandler WatchPropDeprecated(
    this INotifyPropertyChanged watch,
    [ControllerPropertyName(null)] string name,
    Action<object> func);

  /// <summary>Watch for a property changing through the fody system, using a passed handler.
  /// DEPRECATED. Use ChangeWatcher class.</summary>
  public static void WatchPropDeprecated(
    this INotifyPropertyChanged watch,
    PropertyChangedEventHandler handler);

  public static void UnwatchProp(
    this INotifyPropertyChanged? watch,
    PropertyChangedEventHandler handler);

  /// <summary>Unsubsribe to all event handlers on the given property notifier.</summary>
  public static void UnwatchAll(
    this IEnumerable<PropertyChangedEventHandler> list,
    INotifyPropertyChanged? watch);

  /// <summary>Makes sure <paramref name="handler" /> is called whenever value of any property changes in any element of <paramref name="collection" /></summary>
  /// <param name="callbacks"><see cref="T:Eco.Core.Utils.TrackingCallbacks" /> for <paramref name="collection" /></param>
  public static void WatchPropertyOnAllEntries<T>(
    this IEnumerable<T> collection,
    TrackingCallbacks callbacks,
    PropertyChangedEventHandler handler)
    where T : INotifyPropertyChanged;

  /// <summary>Makes sure <paramref name="onChange" /> is called whenever value of property with name <paramref name="propertyName" /> changes in any element of <paramref name="collection" /></summary>
  /// <param name="callbacks"><see cref="T:Eco.Core.Utils.TrackingCallbacks" /> for <paramref name="collection" /></param>
  public static void WatchPropertyOnAllEntries<T>(
    this IEnumerable<T> collection,
    TrackingCallbacks callbacks,
    [ControllerPropertyName("T")] string propertyName,
    Action<object> onChange)
    where T : INotifyPropertyChanged;

  public static void CheckChangedEnumerables(
    IController controller,
    [ControllerPropertyName(null)] string propertyName,
    object before,
    object after);

  /// <summary>Alternative to <see cref="M:Eco.Core.Controller.ControllerExtensions.Changed(Eco.Core.Controller.IController,System.String)" /> with null check for property name. It should be removed when all places which may pass null as property name fixed,</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void ChangedSafe(this IController controller, [ControllerPropertyName(null)] string? name);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Changed(this IController controller, [ControllerPropertyName(null)] string name);

  public static void OnPropertyChanged(
    this IController controller,
    [ControllerPropertyName(null)] string name,
    ISaveablePlugin? savePlugin);

  public static void OnPropertyChanged<T>(object sender, PropertyChangedEventArgs args) where T : ISaveablePlugin;

  /// <summary> Set a property if it's changed and notify it's changed. No need to set name if used in a propery. </summary>
  public static void SetProperty<T>(
    this IController controller,
    ref T propertyStore,
    T value,
    [ControllerPropertyName(null), CallerMemberName] string? name = null);

  public static BSONValue Package(this IController controller, INetClient boundClient);

  /// <summary> Relay subscription calls to the controller object. </summary>
  /// <remarks> Subscriptions require the Controller object exists, so try to bind them here. </remarks>
  public static void Subscribe(
    this IController controller,
    [ControllerPropertyName(null)] string propname,
    Action changedCallback);

  /// <summary> Relay subscription calls to the controller object, then call the method. </summary>
  /// <remarks> Subscriptions require the Controller object exists, so try to bind them here. </remarks>
  public static void SubscribeAndCall(
    this IController controller,
    [ControllerPropertyName(null)] string propname,
    Action changedCallback);

  /// <summary> Relay subscription calls to the controller object, if a subscription with the same callback is not already bound. </summary>
  /// <remarks> Subscriptions require the Controller object exists, so try to bind them here. </remarks>
  public static void SubscribeUnique(
    this IController controller,
    [ControllerPropertyName(null)] string propname,
    Action changedCallback);

  /// <summary> Unsubscribe previously subscribed controller. Returns false if there wasn't such subscription. </summary>
  public static bool Unsubscribe(
    this IController controller,
    [ControllerPropertyName(null)] string propname,
    Action changedCallback);

  /// <inheritdoc cref="M:Eco.Core.Controller.ControllerManager.SubscribeController(Eco.Core.Controller.IController,Eco.Shared.View.ISubscriptions{Eco.Core.Utils.ThreadSafeSubscriptions},System.String,System.Action)" />
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Subscribe(
    this IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    [ControllerPropertyName("controller")] string propname,
    Action changedCallback);

  /// <inheritdoc cref="M:Eco.Core.Controller.ControllerManager.SubscribeControllerAndCall(Eco.Core.Controller.IController,Eco.Shared.View.ISubscriptions{Eco.Core.Utils.ThreadSafeSubscriptions},System.String,System.Action)" />
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SubscribeAndCall(
    this IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    [ControllerPropertyName("controller")] string propname,
    Action changedCallback);

  /// <inheritdoc cref="M:Eco.Core.Controller.ControllerManager.SubscribeControllerUnique(Eco.Core.Controller.IController,Eco.Shared.View.ISubscriptions{Eco.Core.Utils.ThreadSafeSubscriptions},System.String,System.Action)" />
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SubscribeUnique(
    this IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    [ControllerPropertyName("controller")] string propname,
    Action changedCallback);

  /// <inheritdoc cref="M:Eco.Core.Controller.ControllerManager.SubscribeControllerUniqueAndCall(Eco.Core.Controller.IController,Eco.Shared.View.ISubscriptions{Eco.Core.Utils.ThreadSafeSubscriptions},System.String,System.Action)" />
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void SubscribeUniqueAndCall(
    this IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    [ControllerPropertyName("controller")] string propname,
    Action changedCallback);

  /// <summary> Subscribe to ALL sync parameters, and ALL the children of those sync parameters that are also controllers. </summary>
  public static void SubscribeAllRecursive(
    this ISubscriptions<ThreadSafeSubscriptions> subs,
    IController? controller,
    Action<PropertyInfo, object> changedCallback,
    Func<PropertyInfo, bool>? filter = null,
    PropertyInfo? parentProp = null);

  /// <summary>Watch of changes of all properties marked with <see cref="T:Eco.Shared.Networking.ScanPropAttribute" /> in the collection recursively, which can be useful for updates in complex structures with nested objects, like Election. <b>NOTE: As it subscribes for everything it's very ineffective method. Avoid if possible.</b></summary>
  public static void SubscribeAllPropsRecursive(
    this IEnumerable<IController> collection,
    TrackingCallbacks callbacks,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    Action<PropertyInfo, object> onChange);

  public static bool CheckScanIntoPropAttr(PropertyInfo? parentProp, PropertyInfo prop);
}
