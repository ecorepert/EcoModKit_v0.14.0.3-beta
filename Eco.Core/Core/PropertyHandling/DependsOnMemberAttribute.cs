// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.DependsOnMemberAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary>[PropertyChanged.DependsOn] will only perform triggers on properties. This attribute does the same, but can provide triggers on methods as well.
/// It also can watch things besides props: events and anything notifying.
/// See wiki guide here: https://github.com/StrangeLoopGames/Eco/wiki/Watching-System </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
public class DependsOnMemberAttribute : DependsOnMemberBaseAttribute
{
  public DependsOnMemberAttribute(string propName);

  public DependsOnMemberAttribute(string propName, string subPropName);
}
