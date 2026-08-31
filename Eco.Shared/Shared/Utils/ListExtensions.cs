// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ListExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Utils;

public static class ListExtensions
{
  /// <summary>Add to the hashset if it's not null.</summary>
  public static void AddNonNull<T>(this ISet<T> set, T val);

  /// <summary>Add to the dictionary if the key is not null.</summary>
  public static void AddNonNullKey<TK, TV>(this IDictionary<TK, TV> dict, TK key, TV val);

  public static (List<T> Passes, List<T> Fails) SplitOnPredicate<T>(
    this IEnumerable<T> list,
    Func<T, bool> predicate);

  public static IEnumerable<T> EveryNthElement<T>(this IEnumerable<T> list, int n);

  public static IEnumerable<Type> Types<T>(this IEnumerable<T> set) where T : notnull;

  [return: MaybeNull]
  public static T GetAtIndexOrDefault<T>(this IList<T> list, int index);

  [return: MaybeNull]
  public static T GetAtIndexOrDefault<T>(this T[] array, int index);

  public static int IndexOf<T>(this IEnumerable<T> list, Predicate<T> test);

  public static (bool Same, T? Value) AllSame<T>(this IEnumerable<T>? set);

  public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable;

  public static IEnumerable<T> EnsureMinLength<T>(this IEnumerable<T> list, int len) where T : struct;

  public static int Count(this IEnumerable source);

  public static int FirstIndex<T>(this IList<T> list, Predicate<T> func);

  public static bool TryGetFirst<T>(this IList<T> list, Predicate<T> func, out T? value);

  public static bool AddUniqueRange<T>(this IList<T> list, IEnumerable<T> items);

  public static void AddOrUpdate<T>(
    this IList<T> list,
    Func<T, bool> match,
    Func<T> create,
    Action<T> update);

  public static T GetOrAdd<T>(this IList<T> list, Func<T, bool> match) where T : new();

  public static T GetOrAdd<T>(this IList<T> list, Func<T, bool> match, Func<T> create);

  /// <summary>Picks random element from list based on weights</summary>
  /// <param name="weightSelector"> weight to be evaluated </param>
  /// 
  ///             e.g.: [(Salmon, 50), (Crab, 10)] salmon has bigger chance than crab
  public static T RandomWeighted<T>(this IEnumerable<T> source, Func<T, float> weightSelector);

  public static T Random<T>(this IList<T> list);

  public static T Random<T>(this IList<T> list, System.Random random);

  public static void FromBson<T>(this IList<T?> list, BSONArray bsonArray);

  public static IEnumerable<T?> Enumerate<T>(this BSONArray bsonArray);

  [return: MaybeNull]
  public static T MinObj<T>(this IList<T> list, Func<T, float> distanceFunc);

  [return: MaybeNull]
  public static T MaxObj<T>(this IList<T> list, Func<T, double> distanceFunc);

  [return: MaybeNull]
  public static T MaxObj<T>(this IList<T> list, Func<T, float> distanceFunc);

  [return: MaybeNull]
  public static T MinIndex<T>(this IList<T> list) where T : IComparable;

  public static int MinIndex<T>(this IList<T> list, IComparer<T> comparer);

  public static void ForEachIndex<T>(this IList<T> list, Action<T, int> handler);

  public static void ForEach<T>(this IList<T> list, Action<T> action);

  public static bool AddOnce<T>(this IList<T> list, T entry);

  /// <summary>
  /// Removes first item in <paramref name="list" /> matching <paramref name="matcher" /> and calls <paramref name="onRemove" /> action if provided for the removed item.
  /// This method may be used with allocation-free struct based predicates instead of closures. Also it may inline predicate body for better performance.
  /// </summary>
  public static void RemoveAll<T, TPredicate>(
    this List<T> list,
    TPredicate matcher,
    Action<T>? onRemove = null)
    where TPredicate : IPredicate<T>;

  /// <summary>
  /// Removes first item in <paramref name="list" /> matching <paramref name="matcher" /> and calls <paramref name="onRemove" /> action if provided for the removed item.
  /// This method may be used with allocation-free struct based predicates instead of closures. Also it may inline predicate body for better performance.
  /// </summary>
  public static bool RemoveFirst<T, TPredicate>(
    this List<T> list,
    TPredicate matcher,
    Action<T>? onRemove = null)
    where TPredicate : IPredicate<T>;

  /// <summary>Removes first item matching the <paramref name="matcher" />. Returns <c>true</c> if item was removed.</summary>
  public static bool RemoveFirst<T>(this IList<T> list, Predicate<T> matcher);

  /// <summary>Replaces first element matching the <paramref name="matcher" /> with <paramref name="item" /> or adds new <paramref name="item" /> if no one matched.</summary>
  public static void AddOrReplace<T>(this IList<T> list, T item, Predicate<T> matcher);

  public static void ZipApply<T>(
    this IEnumerable<T> left,
    IEnumerable<T> right,
    Action<T, T> zipFunc);

  public static List<(T1 Left, T2 Right)>? ZipTuples<T1, T2>(this IList<T1> list1, IList<T2> list2);

  public static IEnumerable<(T1 Left, T2 Right)>? ZipTuples<T1, T2>(
    this IEnumerable<T1> list1,
    IEnumerable<T2> list2);

  /// <summary> Returns first item of type <typeparamref name="T" /> or default value if not found. It is a list specific implementation to avoid GC-allocations. </summary>
  [return: MaybeNull]
  public static T FirstOfTypeOrDefault<TElement, T>(this List<TElement> list) where T : TElement;

  /// <summary> Returns median value for <paramref name="list" />. If <paramref name="sorted" /> is <c>false</c> then it makes sorted copy of list to find the median otherwise it just returns medium element. </summary>
  [return: MaybeNull]
  public static T Median<T>(this IList<T> list, bool sorted = false) where T : IComparable<T>;

  /// <summary>Returns an enumerable of each index that has a null value in the passed list.</summary>
  public static IEnumerable<int> NullIndices<T>(this IEnumerable<T> list);

  /// <summary>Finds nearest value in collection</summary>
  [return: MaybeNull]
  public static T FindNearestValue<T>(this IList<T> array, T value, Func<T, T, float> distanceFunc);

  /// <summary>Finds nearest value and distance in collection</summary>
  [return: MaybeNull]
  public static (T Value, float Distance) FindNearestValueAndDistance<T>(
    this IList<T> array,
    T value,
    Func<T, T, float> distanceFunc);

  /// <summary>Finds nearest value index in collection</summary>
  public static int FindNearestValueIndex<T>(
    this IList<T> array,
    T value,
    Func<T, T, float> distanceFunc);

  /// <summary>Finds nearest value index and distance in collection</summary>
  public static (int Index, float Distance) FindNearestValueIndexAndDistance<T>(
    this IList<T> array,
    T value,
    Func<T, T, float> distanceFunc);

  /// <summary>"Rotates" list by <paramref name="offset" />. Every element has it's index shifted left by offset, if it results in negative index then it pushes to end of the list.</summary>
  /// <example><code>
  /// new[] { 1, 2, 3, 4 }.RotateLeft(2) // =&gt; 3, 4, 1, 2
  /// </code></example>
  public static IEnumerable<T> RotateLeft<T>(this IList<T> list, int offset);
}
