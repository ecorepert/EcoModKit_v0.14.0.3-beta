// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.SchemaUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

public static class SchemaUtils
{
  /// <summary>Returns schema name corresponding to type. It uses generation rules or built-in name if available.</summary>
  public static string GetSchemaType(Type type);

  internal static string NormalizeGenericClassTypeName(Type type);

  /// <summary>Returns class schema type. If <paramref name="typeNameOrSchemaType" /> already class schema type then returns as is otherwise assume it is type name and builds schema type from the type name.</summary>
  public static string AsClassSchemaType(string typeNameOrSchemaType);

  /// <summary>Returns class schema type for <paramref name="typeName" />. If <paramref name="typeName" /> is generic type name then it will be converted to schema compatible name like List`1[[System.String, Version=1.0.0.0, PublicToken=null, Culture=neutral]] -&gt; class[List{string}].</summary>
  public static string GetClassSchemaType(string typeName);

  public static string MakeGenericClassSchemaType(string typeName, string genericArgSchemaType);

  public static string MakeGenericClassSchemaType(
    string typeName,
    string genericArgSchemaType1,
    string genericArgSchemaType2);

  public static string MakeGenericClassSchemaType(
    string typeName,
    string genericArgSchemaType1,
    string genericArgSchemaType2,
    string genericArgSchemaType3);

  public static string MakeEnumSchemaType(string enumType);

  public static string MakeArraySchemaType(string elementSchemaType);

  public static string MakeEnumerableSchemaType(string elementSchemaType);

  public static string MakeDictionarySchemaType(string keySchemaType, string valueSchemaType);

  public static bool IsArraySchemaType(string schemaType);

  public static bool IsArray2DSchemaType(string schemaType);

  public static bool IsEnumerableSchemaType(string schemaType);

  public static bool IsDictionarySchemaType(string schemaType);

  public static bool IsClassSchemaType(string schemaType);

  public static bool IsEnumSchemaType(string schemaType);

  public static string GetArrayElementSchemaType(string schemaType);

  public static string GetArray2DElementSchemaType(string schemaType);

  public static string GetDictionaryKeySchemaType(string schemaType);

  public static string GetDictionaryValueSchemaType(string schemaType);

  public static string GetEnumerableElementSchemaType(string schemaType);

  public static bool TryGetClassName(string schemaType, [NotNullWhen(true)] out string? className);

  public static string GetClassName(string schemaType);

  public static bool IsSchemaType(string value);

  public static string WrapClassSchemaType(string className);

  /// <summary> Converts old schema type for generic types into new one. </summary>
  /// <example>
  /// <code>class[Eco.Core.Systems.GeneratedRegistrarWrapper`1[[Eco.Gameplay.Items.TagManager, Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]]</code>
  /// will be converted into.
  /// <code>class[Eco.Core.Systems.GeneratedRegistrarWrapper{class[Eco.Gameplay.Items.TagManager]}]</code>
  /// </example>
  internal static string FixOldFormatGenericSchemaType(string schemaType);
}
