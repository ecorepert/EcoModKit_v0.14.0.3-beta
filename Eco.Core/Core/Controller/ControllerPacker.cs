// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerPacker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller.Internal;
using Eco.Shared.Localization;
using Eco.Shared.Pools.Collections;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Manages all controllers on server-side. Controllers are server objects which has view on the client.</summary>
/// <remarks>For debugging purposes you may run build with /p:DefineConstants=LOG_VIEW_SYSTEM or you can enable it in .csproj file. In this mode it will produce ViewData-{date}.txt file with sorted view data in stable order.</remarks>
[LocDisplayName("ControllerManager")]
public sealed class ControllerPacker : IDisposable
{
  public ControllerPacker(ControllerMarshalerService marshalerService);

  /// <summary>Package all changes into bson. It generates BSON-&gt;Clients since same BSON can be notifies to multiply clients.
  /// Pass specific clients if you want to restrict notification to somebody in particular. Otherwise it will create notifications for all subscribed clients to that property.
  /// Its Needed for optimizations reasons, so it wont notify everybody just because somebody subscribed to mustrequest property. </summary>
  internal void PackageChangesInternal(
    IController controller,
    string propertyName,
    PoolableListWrapper<ClientNotification> notifications,
    IMvcNetClient[]? clients = null);

  /// <summary>Removes and returns the per-player members skipped for <paramref name="client" /> while it had no observer.</summary>
  internal IReadOnlyCollection<(IController Controller, string Member)> DrainDeferredObserverMembers(
    IMvcNetClient client);

  /// <summary> Entry point into packing. It collects all views related to packing and sends them at once to pending views of client. It won't be called recursively. </summary>
  [return: NotNullIfNotNull("controller")]
  internal (BSONValue? Bson, ControllerPacker.ControllerPackingPendingViews? Results) PackageControllerAndGetPendingViews(
    IController? controller,
    in BsonSerializationContext context,
    PackageFlags flags = PackageFlags.None);

  internal void ReturnControllerPackingContextToPool(
    ControllerPacker.ControllerPackingPendingViews context);

  public bool IsIndsideOfPackingRecursion { get; }

  /// <summary>Package up the given controller for the given client. In difference of PackageControllerInternal it may be called recursively.
  /// This function will:
  ///  - Generate an ID for the controller if it doesnt exist
  ///  - Generate a ControllerInstanceInfo and add it to the 'controllers' dictionary if it's not in there yet.
  ///  - Bind the client to the controller, if they aren't already bound.</summary>
  [return: NotNullIfNotNull("controller")]
  internal BSONValue? PackageControllerRecursivelyAndCollectPendingViews(
    IController? controller,
    in BsonSerializationContext context,
    PackageFlags flags = PackageFlags.None);

  /// <summary>Used in <see cref="M:Eco.Core.PropertyHandling.PropertyChanges.GlobalSubscribe(System.Type,Eco.Core.PropertyHandling.PropertyChangedBeforeAfterEventHandler)" /> as all controllers property changes handler.</summary>
  internal void OnControllerPropertyChanged(object? source, PropertyChangedEventArgs args);

  public void Dispose();

  internal class ControllerPackingPendingViews
  {
    public List<BSONValue> Views;
    public List<(ControllerInstanceInfo, ControllerBoundingLevel, ControllerBoundingLevel)> Bindings;
    public HashSet<int> PendingBlobs;

    public void PrepareForPool();
  }
}
