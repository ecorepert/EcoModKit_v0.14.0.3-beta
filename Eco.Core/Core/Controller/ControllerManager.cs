// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Pools.Collections;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Manages all controllers on server-side. Controllers are server objects which has view on the client. See ContorllerPacking.md for details. </summary>
/// <remarks>For debugging purposes you may run build with /p:DefineConstants=LOG_VIEW_SYSTEM or you can enable it in .csproj file. In this mode it will produce ViewData-{date}.txt file with sorted view data in stable order.</remarks>
[LocDisplayName("ControllerManager")]
public sealed class ControllerManager : 
  Singleton<ControllerManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IInitializablePlugin,
  IDisposable
{
  public static Func<Type, LocString>? TypeToMarkedUpName;
  public static Func<Type, IEnumerable<string>>? TypeToTags;
  internal static readonly ConditionalWeakTable<IController, ControllerSubscriptions> Subscriptions;
  internal static ConcurrentDictionary<int, ControllerInstanceInfo> Controllers;
  internal readonly ConcurrentDictionary<(Type ControllerType, string MemberName), (string MemberName, bool IndividualSyncing)[]> SyncedPropertiesCache;
  public ConcurrentDictionary<string, int> ViewNameToID;
  public ConcurrentDictionary<string, IControllerMarshaler> ViewNameToMarshaler;
  public ViewTypeData ViewTypeData;
  public static ThreadSafeAction<IMvcNetClient> ClientGotLotsPendingViews;
  public static ThreadSafeAction<IController, string, IMvcNetClient?> ControllerPropertyNotification;

  public static BSONValue ViewData { get; }

  public static bool ControllerIsRegisteredOrSubscribed(IController controller);

  public IEnumerable<IControllerMarshaler> Marshalers { get; }

  public IEnumerable<Type> MarshalersControllerTypes { get; }

  /// <summary> Find basest types which implements both IPropertyChanged and INotifyPropertyChanged </summary>
  public IEnumerable<Type> MarshalersBasestTypes { get; }

  public SyncFlags GetPropertySyncFlags(Type controllerType, string propertyName);

  public bool TryGetViewClassInfo(Type type, [NotNullWhen(true)] out ViewClassInfo? viewClassInfo);

  public ViewClassInfo? GetViewClassInfo(Type type);

  public ViewClassInfo? GetViewClassInfo(int id);

  public ViewClassInfo? GetViewClassInfo(string viewTypeName);

  internal bool TryGetBoundedControllerIDAndMarshaller(
    IController? controller,
    out int controllerID,
    [MaybeNullWhen(false)] out IControllerMarshaler controllerMarshaler);

  public static bool UnsubscribeController(
    IController controller,
    string propname,
    Action changedCallback);

  /// <summary>Creates a subscription but doesnt track it within a Subscriptions object. Should only be used when something is subscribing to its own properties,
  /// meaning both 'watched' and 'watcher' are a single object and die at the same time.</summary>
  public static ISubscription? SubscribeWithoutTracking(
    IController controller,
    string propname,
    Action callback);

  /// <summary>Subscribes to controller and registers subscription in <paramref name="subscriptions" />.</summary>
  public static void SubscribeController(
    IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    string propName,
    Action changedCallback);

  /// <summary>Subscribes to controller, registers subscription in <paramref name="subscriptions" /> and calls <paramref name="changedCallback" />.</summary>
  public static void SubscribeControllerAndCall(
    IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    string propName,
    Action changedCallback);

  /// <summary>Subscribes to controller (unique) and registers subscription in <paramref name="subscriptions" />.</summary>
  public static void SubscribeControllerUnique(
    IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    string propName,
    Action changedCallback);

  /// <summary>Subscribes to controller, registers subscription in <paramref name="subscriptions" /> and calls <paramref name="changedCallback" />.</summary>
  public static void SubscribeControllerUniqueAndCall(
    IController controller,
    ISubscriptions<ThreadSafeSubscriptions> subscriptions,
    string propName,
    Action changedCallback);

  /// <summary> Used when needed to notify property to specific client. I.e. when he requested property with attribute MustRequest. </summary>
  public static void NotifyPropertyForClient(
    IController controller,
    string propertyName,
    IMvcNetClient client);

  /// <summary>Subscribe on property <paramref name="propName" /> changes for the <paramref name="controller" />.</summary>
  public static void SubscribeController(
    IController controller,
    string propName,
    Action changedCallback,
    bool unique = false);

  public static IController? GetController(int id);

  public static object? HandleViewRPC(
    INetClient client,
    IController controller,
    string methodIdOrName,
    BSONObject bson);

  public static object? HandleViewRPC(
    INetClient client,
    int universalID,
    string methodIdOrName,
    BSONObject bson);

  public static void HandleReleaseViews(INetClient client, ReadOnlySpan<int> controllerIds);

  public static void HandleBoundView(INetClient client, int controllerId);

  public void Run();

  public TimeSpan DoWork();

  /// <summary>Package all changes into bson. It generates BSON-&gt;Clients since same BSON can be notifies to multiply clients.</summary>
  public void PackageChanges(
    IController controller,
    string propertyName,
    PoolableListWrapper<ClientNotification> notifications,
    IMvcNetClient[]? clients = null);

  /// <summary>Removes and returns per-player synced members that were skipped for <paramref name="client" /> while it had no observer.
  /// Their views are already marked synced, so the caller must re-send them (per client) once the observer is assigned.</summary>
  public static IReadOnlyCollection<(IController Controller, string Member)> DrainDeferredObserverMembers(
    IMvcNetClient client);

  public Task ShutdownAsync();

  internal static BSONValue ToBson(object obj, in BsonSerializationContext context);

  /// <summary> You can use it when you don't carry about recollection of related views </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  [return: NotNullIfNotNull("controller")]
  public static BSONValue? PackageController(
    IController? controller,
    INetClient? boundClient,
    PackageFlags flags = PackageFlags.None);

  public static BSONValue? PackageBigController(
    IController obj,
    INetClient client,
    PackageFlags flags = PackageFlags.None);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  [return: NotNullIfNotNull("controller")]
  public static BSONValue? PackageController(
    IController? controller,
    in BsonSerializationContext context,
    PackageFlags flags = PackageFlags.None);

  public string? GetStatus();

  public void Initialize(TimedTask timer);

  public static object? FromBson(BSONObject bson);

  /// <summary> Returns controller type id (<see cref="F:Eco.Shared.View.ViewClassInfo.TypeID" />) for <paramref name="type" />. </summary>
  public static int GetControllerTypeId(Type? type);

  /// <summary>Checks if corresponding View type exists for the controller.</summary>
  /// <remarks>Generic types can't have views themselves, so in their case this method checks if generic type definition has a view.</remarks>
  public static bool HasViewType(Type? type);

  public static Type? GetControllerType(Type? type);

  /// <summary>Returns the type the client sees an instance of <paramref name="type" /> as. Generic controllers get no view of their own, so they are
  /// viewed through the type their marshaler resolves to: their generic type definition, or the nearest non-generic base type (e.g. <c>CraftingElement&lt;T&gt;</c> is viewed as <c>CraftingElement</c>).</summary>
  public static Type? GetViewedType(Type? type);

  public override string ToString();

  public string GetCategory();

  public string GetDisplayText();

  public override void ClearSingleton();

  public void Dispose();
}
