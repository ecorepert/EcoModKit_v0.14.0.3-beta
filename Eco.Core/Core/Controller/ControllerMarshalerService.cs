// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerMarshalerService
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>
/// Service for managing <see cref="T:Eco.Core.Controller.IControllerMarshaler" /> creation and providing marshaling info for <see cref="T:Eco.Core.Controller.ControllerManager" /> and <see cref="T:Eco.Core.Controller.ViewCodeGenerator" />.
/// Marshaling info then used for generating views for the client and syncing view data using <see cref="T:Eco.Core.Controller.ISyncMemberInfo" /> members.
/// </summary>
/// <sample>
/// // controller class
/// class MyObject : IController
/// {
///     [SyncToView] public string Name { get; set; }
/// }
/// // view generated for the client by info gathered by ControllerMarshalerService using ViewCodeGenerator
/// class MyObjectView : View
/// {
///     public string Name { get; set; }
/// }
/// </sample>
public class ControllerMarshalerService
{
  internal readonly ConcurrentDictionary<string, int> MemberNameToID;

  /// <summary>Returns all unique controller marshalers. Only available after <see cref="M:Eco.Core.Controller.ControllerMarshalerService.CreateMarshalers" />.</summary>
  public IReadOnlyCollection<IControllerMarshaler> GetMarshalers();

  /// <summary>Returns <paramref name="syncPropertyInfo" /> for <paramref name="propertyName" /> (either property or sync-to-view method) of <paramref name="controllerType" /> if available.</summary>
  internal bool TryGetSyncMemberInfo(
    Type controllerType,
    string propertyName,
    [MaybeNullWhen(false)] out ISyncMemberInfo syncPropertyInfo);

  /// <summary> Calculate and cache all the data needed to manage syncing of controllers. </summary>
  public void CreateMarshalers();

  /// <summary>Returns existing <see cref="T:Eco.Core.Controller.IControllerMarshaler" /> (previously created with <see cref="M:Eco.Core.Controller.ControllerMarshalerService.CreateMarshalers" />).</summary>
  public bool TryGetMarshaler(Type type, [MaybeNullWhen(false)] out IControllerMarshaler marshaler);

  internal IEnumerable<Type> GetControllerInterfaces(Type controllerType);

  public IEnumerable<PropertyInfo> GetInterfaceProperties(Type type);

  public IEnumerable<PropertyInfo> GetLocalControllerProperties(Type type);

  public IEnumerable<PropertyInfo> GetAllControllerProperties(Type type);

  public IEnumerable<MethodInfo> GetLocalControllerMethods(Type type);

  public IEnumerable<MethodInfo> GetAllControllerMethods(Type type);

  public IEnumerable<RPCMethod> GetLocalRPCs(Type type);

  /// <summary>Returns view type name compatible with old controller type based implementation (returning view type name if it doesn't exists on the client). Should be eventually refactored.</summary>
  internal string? GetLegacyViewTypeName(Type? type);

  /// <summary>Returns view type name for <paramref name="type" /> either from corresponding marshaler or auto-generated with <see cref="M:Eco.Core.Controller.ControllerMarshalerService.GenerateDefaultViewTypeName(System.Type)" />.</summary>
  internal string GetViewTypeName(Type type);
}
