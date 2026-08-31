// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.DependsOnMemberBaseAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling.Internal;
using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary>Abstract root to share an implementation for our watchers that trigger change notifications.</summary>
public abstract class DependsOnMemberBaseAttribute : WatchBaseAttribute
{
  protected DependsOnMemberBaseAttribute(
    Type? rootType,
    string? propName,
    bool watchAllProps,
    string? subPropName,
    bool watchAllSubProps,
    Type? propTypeMustDerive = null);

  public override PropertyChangedBeforeAfterEventHandler GetCallback(
    MemberInfo memberWithAttribute,
    out Type? expectedCallbackParam);
}
