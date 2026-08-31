// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ReflectionCache
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;

#nullable enable
namespace Eco.Shared.Utils;

public static class ReflectionCache
{
  /// <summary> Get Serializable Properties of Type using cache </summary>
  public static IEnumerable<PropertyInfo> GetSerializableProperties(this Type type);

  /// <summary> Get cached Type Properties, prefer over Type.GetProperties </summary>
  public static ImmutableArray<PropertyInfo> GetPropertiesCached(this Type type);

  /// <summary> Get cached Assembly types, prefer over Assembly.GetTypes </summary>
  public static ImmutableArray<Type> GetTypesCached(this Assembly assembly);

  /// <summary>Returns all extensions methods for <paramref name="type" /> including those which assignable from <paramref name="type" />.</summary>
  public static IEnumerable<MethodInfo> GetExtensionMethods(this Type type);

  /// Cache defined Attributes per MemberInfo, for inherited and non-inherited check
  public static bool HasAttribute(this MemberInfo member, Type attributeType, bool inherit = true);

  /// <summary>Derived types of a base type within one assembly, cached — an assembly's type set never changes so entries stay valid even as mod assemblies register later.</summary>
  public static ImmutableArray<Type> GetDerivedTypesCached(this Assembly assembly, Type baseType);

  /// <summary>Cached check for a public parameterless constructor.</summary>
  public static bool HasDefaultConstructorCached(this Type type);

  /// <summary>Returns element type for array, or first implemented <see cref="T:System.Collections.Generic.IEnumerable`1" /> interface, or of type itself if it is <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
  public static Type? GetEnumerableType(this Type enumerableType);

  public static IEnumerable<Assembly> GetGameAssemblies();

  /// <summary>
  /// Register assemblies required by Eco for reflection.
  /// Called during Server startup as the various Plugins are added which may add new assemblies to <see cref="M:Eco.Shared.Utils.ReflectionCache.GetAssemblies" />.
  /// Also called during Client startup.
  /// </summary>
  public static void RegisterBaseAssemblies();

  /// <summary> Register assemblies for reflection. Used to add mod assemblies at ModKit DLL load. </summary>
  public static void RegisterAssemblies(IEnumerable<Assembly> assemblies);

  /// <summary> Get all assemblies </summary>
  public static IEnumerable<Assembly> GetAssemblies();

  public static IEnumerable<Type> GetGameAssembliesTypes();
}
