// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewPropertySetter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Reflection;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Cached typed-delegate property setters for view updates. Every synced property change goes through this path, so the
/// per-call cost matters at crowd-scale volume. Built on <see cref="M:System.Delegate.CreateDelegate(System.Type,System.Reflection.MethodInfo)" /> rather than compiled
/// expression trees: on Unity's Mono runtime expression trees can fall back to interpretation, costing tens of microseconds per call.</summary>
public static class ViewPropertySetter
{
  /// <summary>Sets <paramref name="property" /> on <paramref name="instance" /> via a cached typed delegate.</summary>
  public static void Set(
  #nullable disable
  object instance, PropertyInfo property, object value);
}
