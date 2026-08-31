// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.DependsOnSubMemberAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary>An override for fody's 'DependsOn' attirbute that allows watching a specific sub prop, and the prop or subprop could either be events.
/// NOTE: If you are watching subproperties on a getter-only property, the sub properties wont start tracking until the first property change notification
/// goes out for that root property.  Youll need to manually make sure this happens, or set up its dependencies to detect other members changing and do its
/// initialization there.
/// See wiki guide here: https://github.com/StrangeLoopGames/Eco/wiki/Watching-System /// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
public class DependsOnSubMemberAttribute : DependsOnMemberBaseAttribute
{
  public DependsOnSubMemberAttribute(string subPropName);

  public DependsOnSubMemberAttribute(bool watchAllSubProps);

  public DependsOnSubMemberAttribute(string propName, string subPropName);

  public DependsOnSubMemberAttribute(string propName, bool watchAllSubProps);

  public DependsOnSubMemberAttribute(string propName, string subPropName, Type mustDerive);
}
