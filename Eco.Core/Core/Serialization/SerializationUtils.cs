// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.SerializationUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

#nullable disable
namespace Eco.Core.Serialization;

public static class SerializationUtils
{
  public static T Clone<T>(T obj);

  public static JsonSerializerSettings CreateSerializerSettings(
    bool preserveReferences = false,
    bool isWriting = false);

  /// <summary>Creates <see cref="T:Newtonsoft.Json.JsonSerializer" /> using settings created with <see cref="M:Eco.Core.Serialization.SerializationUtils.CreateSerializerSettings(System.Boolean,System.Boolean)" />.</summary>
  public static JsonSerializer CreateSerializer(
    bool preserveReferences = false,
    bool isWriting = false,
    ObjectCreationHandling objectCreationHandling = 0);

  public static string SerializeJson(object obj, bool preserveReferences = false);

  public static T DeserializeJson<T>(string json);

  public static object DeserializeJson(string json, Type type);

  public static string SerializeRawJson(object obj);

  public static string SerializeRawJsonIndented(object obj);

  public static void UpdateAllConfigTemplates();

  /// <summary>Populate json from the string (jsonText)</summary>
  public static void PopulateObjectWithJson(
    string json,
    object instance,
    ObjectCreationHandling objectCreationHandling = 0);

  /// <summary>Populate json from the JObject. Useful if you need to change json on the way so it won't need to read it twice</summary>
  public static void PopulateObjectWithJson(
    JObject json,
    object instance,
    ObjectCreationHandling objectCreationHandling = 0);

  public static Type GetClassMigrationSerializerType(Type type);
}
