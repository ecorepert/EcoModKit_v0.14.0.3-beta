// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.IControllerMarshaler
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

/// <summary>Base interface for all controller marshalers (enums, IController classes, primitive types).</summary>
public interface IControllerMarshaler
{
  IControllerMarshaler? BaseMarshaler { get; }

  Type ControllerType { get; }

  string ViewTypeName { get; }

  ViewClassInfo ClassInfo { get; }

  Dictionary<string, ViewMemberInfo> NameToProperty { get; }

  bool GeneratesView { get; }

  bool IsConstant { get; }

  /// <summary>Returns all sync property infos for the marshaled type as pairs of (nameId, memberSyncInfo).</summary>
  IEnumerable<KeyValuePair<int, ISyncMemberInfo>> GetSyncMemberInfos();

  /// <summary>Tries to get sync info for member with <paramref name="nameId" />.</summary>
  bool TryGetSyncMemberInfo(int nameId, [MaybeNullWhen(false)] out ISyncMemberInfo info);

  /// <summary>Tries to get other members which depends on <paramref name="memberName" />.</summary>
  bool TryGetDependentMembers(string memberName, [MaybeNullWhen(false)] out string[] dependencies);

  /// <summary>Returns all interfaces implemented by class.</summary>
  IEnumerable<Type> GetAllInterfaces();

  /// <summary>Returns only own interfaces implemented by class (non-inherited).</summary>
  IEnumerable<Type> GetOwnInterfaces();

  /// <summary>Creates instance of controller.</summary>
  object? CreateInstance();
}
