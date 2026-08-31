// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.CoreReflectionUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable enable
namespace Eco.Core.Utils;

public static class CoreReflectionUtils
{
  public static 
  #nullable disable
  string DebugName(this MemberInfo member);

  public static bool IsStatic(this MemberInfo member);

  public static bool Cloneable(this MemberInfo member);

  public static object GetValueIndexed(this PropertyInfo prop, object parent, int index);

  public static Type GetPropertyTypeIndexed(this PropertyInfo prop, int index);

  public static IEnumerable<Type> AllBaseClasses(this Type type);

  public static (Type Type, T Attr)[] AllClassesWithAttribute<T>() where T : Attribute;

  public static IEnumerable<(Type Type, T Attr)> AllControllerClassesWithAttribute<T>(
    bool syncedTypesOnly)
    where T : Attribute;

  /// <summary>Is the given thing a referene?  Return FALSE if it's a container, even if it contains references.</summary>
  public static bool IsReference(this MemberInfo member, int index = -1);

  /// <summary>Is the given thing a referene?  Return TRUE if it's a container that can contain references.</summary>
  public static bool IsReferenceOrReferenceContainer(this MemberInfo member, int index = -1);

  public static IEnumerable<(PropertyInfo Property, object Value)> RecursivePropertiesAndValues(
    this Type type,
    object obj,
    Func<PropertyInfo, bool> test);

  public static IEnumerable<T> InstancesOfCreatableTypes<T>(
    Assembly assembly = null,
    bool includeSelf = false,
    params object[] constructorParams);

  public static T[] InstancesOfCreatableTypesParallel<T>(
    this Type baseType,
    Assembly assembly = null,
    bool includeSelf = false);

  public static CoreReflectionUtils.ActionWithRefParam<T, object> CreateSetterDelegate<T>(
    this MethodInfo method);

  /// <summary>Given a method info, make a delegate that calls it on the given target. Handles methods with or without return values,
  /// as well as variable numbers of parameters.</summary>
  public static Delegate CreateDelegate(this MethodInfo methodInfo, object target);

  public static Func<T, object> CreateGetterDelegate<T>(this MethodInfo method);

  public static Type GetParentClassWithAttribute(Type attr, Type type);

  public static Type GetUnderlyingType(this MemberInfo member, int index = -1);

  public static LocString BuildComparisonString(object oldObj, object newObj, bool recursive);

  public delegate void ActionWithRefParam<T, TParam>(ref T target, TParam param);

  private delegate TReturn FuncWithRefParam<T, TReturn>(ref T target);
}
