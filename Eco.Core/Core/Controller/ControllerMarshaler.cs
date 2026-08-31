// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerMarshaler
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Core.Controller;

/// <summary><see cref="T:Eco.Core.Controller.ControllerMarshaler" /> helps to convert controller to client view.</summary>
/// <inheritdoc cref="T:Eco.Core.Controller.IControllerMarshaler" />
public class ControllerMarshaler : IControllerMarshaler
{
  public readonly Dictionary<string, string[]> Dependencies;
  public readonly Dictionary<int, ISyncMemberInfo> ControllerInfo;
  public readonly List<ViewRPC> RPCs;

  public Dictionary<string, ViewMemberInfo> NameToProperty { get; }

  public IControllerMarshaler? BaseMarshaler { get; set; }

  public Type ControllerType { get; }

  public string ViewTypeName { get; }

  public ViewClassInfo ClassInfo { get; set; }

  public bool GeneratesView { get; set; }

  public bool IsConstant { get; }

  public ControllerMarshaler(Type controllerType, string? viewTypeName = null);

  /// <summary>Returns own implemented interfaces (not inherited from base types).</summary>
  public IEnumerable<Type> GetAllInterfaces();

  /// <summary>Returns own implemented interfaces (not inherited from base types).</summary>
  public IEnumerable<Type> GetOwnInterfaces();

  public object? CreateInstance();

  public IEnumerable<KeyValuePair<int, ISyncMemberInfo>> GetSyncMemberInfos();

  public bool TryGetSyncMemberInfo(int nameId, [MaybeNullWhen(false)] out ISyncMemberInfo info);

  public bool TryGetDependentMembers(string memberName, [MaybeNullWhen(false)] out string[] dependencies);
}
