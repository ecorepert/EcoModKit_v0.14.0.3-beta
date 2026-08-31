// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.DictionaryExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

public static class DictionaryExtensions
{
  public static TValue RandomValue<TKey, TValue>(this IDictionary<TKey, TValue> dict);

  public static void CleanNullValues<TKey, TElement>(this IDictionary<TKey, TElement> source);

  public static Dictionary<TKey, TElement> ToDictionaryIndex<TSource, TKey, TElement>(
    this IEnumerable<TSource> source,
    Func<TSource, int, TKey> keySelector,
    Func<TSource, int, TElement> elementSelector)
    where TKey : notnull;

  public static void Deconstruct<T1, T2>(this KeyValuePair<T1, T2> tuple, out T1 key, out T2 value);

  public static void Filter<TKey, TValue>(
    this IDictionary<TKey, TValue> dict,
    Func<TKey, TValue, bool> test);

  /// <summary>Remove matching the given predicate and return true if any were removed.</summary>
  public static bool RemoveWhere<TKey, TValue>(
    this IDictionary<TKey, TValue> dict,
    Func<TKey, TValue, bool> test);

  public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
    where TKey : notnull
    where TValue : new();

  public static TValue GetOrAdd<TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    TKey key,
    Func<TValue> addFunc)
    where TKey : notnull;

  public static TValue GetOrAdd<TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    TKey key,
    Func<TKey, TValue> addFunc)
    where TKey : notnull;

  public static void AddUnique<TKey, TValue>(
    this IDictionary<TKey, TValue> dict,
    TKey key,
    TValue value);

  public static object? GetOrDefault(this IDictionary dict, object? key);

  public static TValue? GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey? key);

  [return: NotNullIfNotNull("def")]
  public static TValue? GetOr<TKey, TValue>(
    this IDictionary<TKey, TValue> dict,
    TKey? key,
    TValue? def = null);

  public static TResult GetOrResult<TKey, TValue, TResult>(
    this IDictionary<TKey, TValue> dict,
    TKey key,
    TResult defaultVal)
    where TValue : TResult;

  /// <summary>Add a new element to a dictionary, or update an existing one if the key already exists.
  /// <paramref name="updateFunc" /> is a function that accepts the existing value and passed value (in that order), and returns the new value to store.</summary>
  public static TValue AddOrUpdate<TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    TKey key,
    TValue value,
    Func<TValue, TValue, TValue> updateFunc)
    where TKey : notnull;

  /// <summary>Add a default entry to a dictionary if it doesnt exist. Then, whether or not it existed, updated it.</summary>
  /// <param name="updateFunc">Accepts the current value and returns the new value to store in the dictionary</param>
  public static TValue AddDefaultIfNeededThenUpdate<TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    TKey key,
    Func<TValue, TValue> updateFunc)
    where TKey : notnull;

  /// <summary>Add an entry to a dictionary if it doesnt exist, using the past 'addFunc' to create it. Then, whether or not it existed, updated it.</summary>
  /// <param name="updateFunc">Accepts the current value and returns the new value to store in the dictionary</param>
  /// <param name="addFunc">Function to create the new entry. If null, use the 'default' value.</param>
  public static TValue AddIfNeededThenUpdate<TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    TKey key,
    Func<TValue, TValue> updateFunc,
    Func<TValue>? addFunc)
    where TKey : notnull;

  public static void ToDictionaryAppendUnique<TElement, TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    IEnumerable<TElement> list,
    Func<TElement, TKey> keySelector,
    Func<TElement, TValue> valSelector)
    where TKey : notnull;

  public static void AddToList<TKey, TValue>(
    this IDictionary<TKey, List<TValue>> dict,
    TKey k,
    TValue v,
    bool unique = true);

  public static bool RemoveFromList<TKey, TValue>(
    this IDictionary<TKey, List<TValue>?> dict,
    TKey k,
    TValue v,
    bool removeKeyIfEmptyList);

  public static void AddRangeToList<TKey, TValue>(
    this IDictionary<TKey, List<TValue>> dict,
    TKey k,
    IEnumerable<TValue> v);

  public static void AddToSet<TKey, TValue>(
    this IDictionary<TKey, HashSet<TValue>> dict,
    TKey k,
    TValue v);

  public static bool RemoveFromSet<TKey, TValue>(
    this IDictionary<TKey, HashSet<TValue>> dict,
    TKey k,
    TValue v);

  public static void AddRangeToSet<TKey, TValue>(
    this Dictionary<TKey, HashSet<TValue>> dict,
    TKey k,
    IEnumerable<TValue>? v)
    where TKey : notnull;

  public static IEnumerable<TValue> SelectValues<TValue, TKey>(
    this IDictionary<TKey, TValue> @this,
    IEnumerable<TKey> keys);

  /// <summary>
  /// Checks if all values in <paramref name="dict" /> matches <paramref name="predicate" />.
  /// We are using explicit <see cref="T:System.Collections.Generic.Dictionary`2" /> here and don't use LINQ to avoid garbage creation for enumerator.
  /// We are using this method in Unity, so it is critical to not have extra GC-allocations.
  /// </summary>
  public static bool AllValues<TKey, TValue>(
    this Dictionary<TKey, TValue> dict,
    Predicate<TValue> predicate)
    where TKey : notnull;

  /// <summary>Updates <paramref name="dictionary" /> with all entries from <paramref name="entries" />. Not existing entries will be created and matching existing entries overwritten.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Update<TKey, TValue>(
    this Dictionary<TKey, TValue> dictionary,
    Dictionary<TKey, TValue> entries)
    where TKey : notnull;

  /// <summary> returns new dictionary with all left values and adds right distinct ones </summary>
  public static Dictionary<TKey, TValue> LeftJoin<TKey, TValue>(
    this Dictionary<TKey, TValue> left,
    Dictionary<TKey, TValue> right)
    where TKey : notnull;
}
