// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.Internal.WatchBaseAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.PropertyHandling.Internal;

public abstract class WatchBaseAttribute : Attribute
{
  /// <summary>Which property we're watching, or 'determine from context' if null.</summary>
  public readonly string? MemberName;
  /// <summary>If set, ignore the SubPropName and instead watch all properties on the root.</summary>
  public readonly bool WatchAllMembers;
  /// <summary>Which sub member we're watching, or none if null.</summary>
  public readonly string? SubMemberName;
  /// <summary>If set, ignore the SubMemberName and watch all sub properties.</summary>
  public readonly bool WatchAllSubMembers;
  /// <summary>Only watch types that are derived from this specific class or interface.</summary>
  /// 
  ///             Ex. ElectedTitle has a property of type IAlias called EligibleCandidates (it can accept values of type User, ElectedTitle,...) but we only want to watch the property if it implement the IProposable interface.
  public readonly Type? MemberTypeMustDerive;
  /// <summary>
  /// This is used with <see cref="T:Eco.Core.PropertyHandling.TooltipAffectedByAttribute" /> and specifically when watching an event on a method that has a NewTooltip attribute and an override type.
  /// This can be removed when we move the NewTooltip to Eco.Core, which then we can just make a function as an extansion of <see cref="T:System.Reflection.MethodInfo" />
  /// which give us the real root type of that method (Detect whether that method has a NewTooltip attribute and return the Override property.
  /// </summary>
  public Type? OverridenType;

  protected WatchBaseAttribute(
    Type? rootType,
    string? memberName,
    bool watchAllMembers,
    string? subMemberName,
    bool watchAllSubMembers,
    Type? memberTypeMustDerive = null);

  /// <summary>Child class must define what this does.</summary>
  public abstract PropertyChangedBeforeAfterEventHandler GetCallback(
    MemberInfo memberWithAttribute,
    out Type? expectedCallbackParam);

  /// <summary>Give the member we're an attribute on, determine what root type and property we're subscribing to.</summary>
  public (Type RootType, MemberInfo? RootMember) GetRootTypeAndMember(MemberInfo memberWithAttribute);

  /// <summary>Get the type of the property that we're watching.</summary>
  public Type? GetWatchedPropType(MemberInfo? rootMember);

  public PropertyInfo? GetWatchedSubMember(MemberInfo? rootMember);

  public Type? GetWatchedSubPropType(MemberInfo? rootMember);

  /// <summary>We check if the type of the object is what we are expecting using any specified conditions.</summary>
  public bool ObjectIsExpectedType(object? obj);

  /// <summary>
  /// This is used when watching an event with a param to see whether we want to pass the param of that event to the callback or pass type of the root class instead.
  /// True  -&gt; assign param.
  /// False -&gt; assign type.
  /// </summary>
  public virtual bool PassEventFirstParamToCallback(Type firstParamType, Type rootType);
}
