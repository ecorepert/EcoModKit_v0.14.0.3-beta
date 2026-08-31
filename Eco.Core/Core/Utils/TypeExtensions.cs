// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.TypeExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Utils;

public static class TypeExtensions
{
  public static Type GetBaseAbstractType(this Type type);

  public static Type GetNonGenericBaseType(this Type type);

  public static Type GetBaseGenericType(this Type type, Type genericTypeDefinition, Type rootType = null);

  public static string GetPrettyName(this Type type);

  public static T GetStaticPropertyValue<T>(this Type t, string funcName);

  public static T InvokeStaticFunction<T>(this Type t, string funcName, params object[] paramList);
}
