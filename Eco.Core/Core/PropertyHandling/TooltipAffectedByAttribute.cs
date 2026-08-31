// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.TooltipAffectedByAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling.Internal;
using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary>Put on an extension method with NewTooltipAttribute to mark that tooltip part as dirty when CallWhenChangedAttribute.Property
/// changes in any instance of the extension method's type.</summary>
/// <remarks>
/// Can't be used when tooltip use CacheAs.User. See 'Tooltip.md' for more info.
/// See wiki guide here: https://github.com/StrangeLoopGames/Eco/wiki/Watching-System
/// Requirements:
/// - Can use on static extension methods. No need to pass the type being watched if its the same as the 'this' for the extension method.
/// - If you're watching an event with params on a tooltip that's using CacheAs.Instance then the event param type must be the tooltip parent (TO DO : we should
/// make an assert for this when tooltips are moved to Core instead of Gameplay).
/// </remarks>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TooltipAffectedByAttribute : WatchBaseAttribute
{
  public TooltipAffectedByAttribute(
    string memberName,
    string? subMemberName = null,
    Type? memberTypeMustDerive = null);

  public TooltipAffectedByAttribute(string memberName, bool watchAllSubMembers);

  public TooltipAffectedByAttribute(bool watchAllMembers);

  public TooltipAffectedByAttribute(
    Type rootType,
    string memberName,
    string? subMemberName = null,
    Type? mustBeDerivedFrom = null);

  public TooltipAffectedByAttribute(Type rootType, string memberName, bool watchAllSubMembers);

  public TooltipAffectedByAttribute(Type rootType, bool watchAllMembers);

  public override PropertyChangedBeforeAfterEventHandler GetCallback(
    MemberInfo memberWithAttribute,
    out Type? expectedCallbackParam);

  public override bool PassEventFirstParamToCallback(Type firstParamType, Type rootType);
}
