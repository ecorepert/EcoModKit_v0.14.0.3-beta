// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BsonManipulator
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Serialization;

public static class BsonManipulator
{
  public static BSONArray EncodeArgs(INetClient client, params object?[] args);

  public static object?[] DecodeArgs(BSONArray bson, Type[] schema);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? FromBson<T>(BSONValue? value);

  public static object? FromBson(BSONValue? value, Type type);

  /// <summary>Serializes enumerable of key-value pairs as BSON dictionary.</summary>
  public static BSONObject ToBsonDictionary<TKey, TValue>(
    this IEnumerable<KeyValuePair<TKey, TValue>> dictionary,
    in BsonSerializationContext context = default (BsonSerializationContext),
    bool useReflection = false);

  /// <summary>Makes generic dictionary lightweight (no reflection) delegate which just converts first argument from non-generic to generic dictionary and passes all other arguments.</summary>
  public static BsonManipulator.ToBsonDictionaryDelegate MakeGenericDictionarySerializer<TKey, TValue>();

  public static BSONObject ToBson(
    this IDictionary dictionary,
    in BsonSerializationContext context = default (BsonSerializationContext),
    bool useReflection = false);

  /// <summary>Deserializes <paramref name="obj" /> to <paramref name="dictionary" />. <paramref name="dictionary" /> elements will be replaced with new elements from BSON.</summary>
  public static void FromBsonToDictionary<TKey, TValue>(
    BSONObject obj,
    IDictionary<TKey, TValue> dictionary);

  /// <summary>Deserializes <paramref name="obj" /> to <paramref name="dictionary" />. <paramref name="dictionary" /> elements will be replaced with new elements from BSON.</summary>
  public static void FromBsonToDictionary(
    BSONObject obj,
    IDictionary dictionary,
    Type keyType,
    Type valueType);

  public static BSONValue? ToBson(
    object? val,
    in BsonSerializationContext context = default (BsonSerializationContext),
    bool useReflection = false);

  /// <summary>Serialize all properties tagged with Serialized.  If NO properties are tagged as such, serialize ALL properties instead.</summary>
  public static BSONValue ReflectionToBson(in BsonSerializationContext context, object val);

  public static MethodInfo GetListConvertorFromBson(Type type);

  public static BSONObject ToBson(this int[,] array);

  public static int[,] FromBson2DArray(BSONObject bson);

  public delegate BSONObject ToBsonDictionaryDelegate(
    IDictionary dictionary,
    in BsonSerializationContext context,
    bool useReflection);

  /// <summary>FromBson function wrapper used by <see cref="M:Eco.Shared.Serialization.BsonManipulator.FromBson``1(Eco.Shared.Serialization.BSONValue)" />. By default it uses <see cref="M:Eco.Shared.Serialization.BsonManipulator.FromBson(Eco.Shared.Serialization.BSONValue,System.Type)" />, but uses optimized versions registered with <see cref="M:Eco.Shared.Serialization.BsonManipulator.RegisterFromBsonFunctionForValueType``1(System.Linq.Expressions.Expression{System.Func{Eco.Shared.Serialization.BSONValue,``0}})" /> or <see cref="M:Eco.Shared.Serialization.BsonManipulator.RegisterFromBsonFunctionForClassType``1(System.Linq.Expressions.Expression{System.Func{Eco.Shared.Serialization.BSONValue,``0}})" /> when possible. For primitive types it is 3x times faster with optimized version and don't need to use boxing/unboxing form object with extra GC allocation.</summary>
  private static class FromBsonFunction<T>
  {
    public static Func<BSONValue?, T?> Value;
  }
}
