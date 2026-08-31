// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.EnumerableExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

public static class EnumerableExtensions
{
  /// <summary>Tries to get first element from enumerable (if exists).</summary>
  /// <returns><c>true</c> if <paramref name="enumerable" /> is not empty and <paramref name="element" /> contains the first element, <c>false</c> otherwise.</returns>
  public static bool TryGetFirst<T>(this IEnumerable<T> enumerable, [MaybeNullWhen(false)] out T element);

  /// <summary> Gets the first value matching <paramref name="predicate" /> into an out var, returning true if found. </summary>
  public static bool TryGetFirst<T>(
    this IEnumerable<T> enumerable,
    Func<T, bool> predicate,
    [MaybeNullWhen(false)] out T val);

  /// <summary> Gets the single value into an out var, returning true if found only one value. </summary>
  public static bool TryGetSingle<T>(this IEnumerable<T> enumerable, [MaybeNullWhen(false)] out T val);

  /// <summary> Gets the single value matching <paramref name="predicate" /> into an out var, returning true if found only one value. </summary>
  public static bool TryGetSingle<T>(
    this IEnumerable<T> enumerable,
    Func<T, bool> predicate,
    [MaybeNullWhen(false)] out T val);

  public static bool CompareNullSafe<T>(this IEnumerable<T>? left, IEnumerable<T>? right);

  public static float WeightedAverage<T>(
    this IEnumerable<T> records,
    Func<T, float> value,
    Func<T, float> weight);

  public static bool IsOrdered<TKey, TValue>(
    this IEnumerable<TKey> list,
    Func<TKey, TValue> predicate)
    where TValue : IComparable;

  public static int FirstIndex<T>(this IEnumerable<T> list, Predicate<T> test);

  /// <summary> Checks if collection contains at least 1 not null element </summary>
  public static bool AnyNotNull<T>(this IEnumerable<T>? objects);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool None<T>(this IEnumerable<T> @this, Func<T, bool> predicate);

  public static bool ContainsAll<T>(this IEnumerable<T> objects, IEnumerable<T> mustContain);

  public static IEnumerable<T> Flatten<T>(
    this IEnumerable<T> list,
    Func<T, IEnumerable<T>> generateChildren);

  public static IEnumerable<T> Repeat<T>(Func<T> func, int repeatCount);

  public static BSONArray ToBson(
    this IEnumerable enumeration,
    in BsonSerializationContext context = default (BsonSerializationContext),
    bool doAllParams = false);

  [DebuggerStepThrough]
  public static IEnumerable<T> SingleItemAsEnumerable<T>(this T item);

  public static IEnumerable<T> AppendNullSafe<T>(this IEnumerable<T> source, T element);

  public static bool SequenceEqualNullSafe<T>(this IEnumerable<T>? left, IEnumerable<T>? right);

  public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, T oldElement, T newElement) where T : notnull;

  public static IEnumerable<T> Swap<T>(this IEnumerable<T> source, T element1, T element2) where T : notnull;

  /// <summary> Same as <see cref="M:Eco.Shared.Utils.EnumerableExtensions.ConcatNullSafe``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})" />, but returns <c>null</c> if both are <c>null</c> and <paramref name="nullAllowed" />. </summary>
  [return: MaybeNull]
  public static IEnumerable<T> ConcatNullSafe<T>(
    this IEnumerable<T>? left,
    IEnumerable<T>? right,
    bool nullAllowed);

  /// <summary>
  /// Concat two enumerable if possible (both not null). If any enum is null then it will be omitted from concatenation and only non-null enumerable elements will be returned.
  /// If both null then it will return empty enumerable.
  /// </summary>
  public static IEnumerable<T> ConcatNullSafe<T>(this IEnumerable<T>? left, IEnumerable<T>? right);

  [return: MaybeNull]
  public static IEnumerable<T> MinSet<T>(this IEnumerable<T> enumeration, Func<T, float> valFunc);

  [return: MaybeNull]
  public static IEnumerable<T> MaxSet<T>(this IEnumerable<T> enumeration, Func<T, float> valFunc);

  /// <summary>Returns first item with minimal value of <paramref name="distanceFunc" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? MinObj<T>(this IEnumerable<T> enumeration, Func<T, float> distanceFunc);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static (T?, float)? MinObjAndDist<T>(
    this IEnumerable<T> enumeration,
    Func<T, float> distanceFunc);

  /// <summary>Tries to get minimal element from <paramref name="enumerable" /> if it has elements. Returns <c>false</c> otherwise.</summary>
  public static bool TryGetMinBy<TKey, TValue>(
    this IEnumerable<TKey> enumerable,
    Func<TKey, TValue> valueSelector,
    [NotNullWhen(true)] out (TKey? Key, TValue Value) result)
    where TValue : struct;

  [return: MaybeNull]
  public static T MaxObj<T>(this IEnumerable<T> enumeration, Func<T, double> distanceFunc);

  [return: MaybeNull]
  public static T MaxObj<T>(this IEnumerable<T> enumeration, Func<T, float> distanceFunc);

  /// <summary> Returns up to <paramref name="n" /> minimal elements from <paramref name="enumerable" />. From smallest to larger. </summary>
  public static T[] MinRange<T>(this IEnumerable<T> enumerable, int n, IComparer<T> comparer);

  public static void ForEachIndex<T>(this IEnumerable<T> enumerable, Action<T, int> handler);

  [return: MaybeNull]
  public static T MinIndex<T>(this IEnumerable<T> enumeration) where T : IComparable;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IEnumerable<TSource> GetDistinctBy<TSource, TKey>(
    this IEnumerable<TSource> source,
    Func<TSource, TKey> keySelector);

  public static Eco.Shared.Math.Range Range<T>(this IEnumerable<T> enumeration, Func<T, float> func);

  /// <summary> Specialized version for <see cref="T:System.Collections.Generic.List`1" />. No allocations. </summary>
  public static bool Any<T>(this List<T> list, Func<T, bool> predicate);

  /// <summary> Returns first value in list of type <typeparamref name="T" /> or default value. No allocations. </summary>
  [return: MaybeNull]
  public static T FirstOfTypeOrDefault<T>(this IList list);

  public static IEnumerable<T> OfTypeList<T>(this IEnumerable<T> e, IEnumerable<Type> types) where T : notnull;

  public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action);

  public static void ForEachReverse<T>(this IList<T> list, Action<T> action);

  public static T? CountFromLast<T>(this IEnumerable<T> list, int i);

  public static IEnumerable<T> Random<T>(this IEnumerable<T> list, int entries);

  public static T? Random<T>(this IEnumerable<T> enumerable);

  public static T? RandomExcept<T>(this IEnumerable<T> enumerable, int i);

  public static T[] Shuffled<T>(this IEnumerable<T> enumerable);

  public static IEnumerable<T> Duplicates<T, TR>(this IEnumerable<T> list, Func<T, TR> keySelector);

  /// <summary>
  /// Calls action for each entry with the context for a dictionary.
  /// </summary>
  /// <param name="dict">dictionary.</param>
  /// <param name="context">context.</param>
  /// <param name="action">action.</param>
  /// <typeparam name="TKey">key type.</typeparam>
  /// <typeparam name="TValue">value type.</typeparam>
  /// <typeparam name="TContext">context type.</typeparam>
  public static void ForEach<TKey, TValue, TContext>(
    this Dictionary<TKey, TValue> dict,
    TContext context,
    Action<KeyValuePair<TKey, TValue>, TContext> action)
    where TKey : notnull;

  /// <summary>
  /// Calls action for each entry with the context for a dictionary preferring no-alloc enumerator version (avoiding boxing).
  /// </summary>
  /// <param name="dict">dictionary.</param>
  /// <param name="context">context.</param>
  /// <param name="action">action.</param>
  /// <typeparam name="TKey">key type.</typeparam>
  /// <typeparam name="TValue">value type.</typeparam>
  /// <typeparam name="TContext">context type.</typeparam>
  public static void ForEach<TKey, TValue, TContext>(
    this IDictionary<TKey, TValue> dict,
    TContext context,
    Action<KeyValuePair<TKey, TValue>, TContext> action)
    where TKey : notnull;

  /// <summary>
  /// Calls action for each element with the context for a list.
  /// </summary>
  /// <param name="list">list.</param>
  /// <param name="context">context.</param>
  /// <param name="action">action.</param>
  /// <typeparam name="T">item type.</typeparam>
  /// <typeparam name="TContext">context type.</typeparam>
  public static void ForEach<T, TContext>(
    this List<T> list,
    TContext context,
    Action<T, TContext> action);

  /// <summary>
  /// Calls action for each element with context preferring no-alloc enumerator version (avoiding boxing).
  /// </summary>
  /// <param name="enumerable">enumerable.</param>
  /// <param name="context">context.</param>
  /// <param name="action">action.</param>
  /// <typeparam name="T">item type.</typeparam>
  /// <typeparam name="TContext">context type.</typeparam>
  public static void ForEach<T, TContext>(
    this IEnumerable<T> enumerable,
    TContext context,
    Action<T, TContext> action);

  /// <summary>
  /// Calls parallel action for each element with context preferring no-alloc enumerator version (avoiding boxing).
  /// </summary>
  /// <param name="enumerable">enumerable.</param>
  /// <param name="context">context.</param>
  /// <param name="action">action.</param>
  /// <typeparam name="T">item type.</typeparam>
  /// <typeparam name="TContext">context type.</typeparam>
  public static void ParallelForEach<T, TContext>(
    this IEnumerable<T> enumerable,
    TContext context,
    Action<T, TContext> action);

  public static void ParallelForEach<T>(this IEnumerable<T> enumerable, Action<T> action);

  public static bool ForEachUntil<T>(this IEnumerable<T> list, Func<T, bool> predicate);

  public static IEnumerable<T> TakeUntilIncluding<T>(
    this IEnumerable<T> list,
    Func<T, bool> predicate);

  [return: MaybeNull]
  public static T MaxOrDefault<T>(this IEnumerable<T> container, [AllowNull] T def = null);

  public static T? MinOrDefault<T>(this IEnumerable<T> container, T? def = null);

  [return: NotNullIfNotNull("def")]
  public static TVal? MaxOrDefault<T, TVal>(
    this IEnumerable<T> container,
    Func<T, TVal> selector,
    TVal? def = null);

  [return: NotNullIfNotNull("def")]
  public static TVal? MinOrDefault<T, TVal>(
    this IEnumerable<T> container,
    Func<T, TVal> selector,
    TVal? def = null);

  [return: NotNullIfNotNull("list")]
  public static IEnumerable<T>? NonNull<T>(this IEnumerable<T?>? list);

  public static void RemoveNulls<T>(this List<T> list) where T : class?;

  public static float Mult(this IEnumerable<float> list);

  public static List<T> DependencySorted<T>(
    this IEnumerable<T> items,
    Func<T, IEnumerable<T>> dependencyFunc)
    where T : notnull;

  public static IEnumerable<TResult> SelectNonNull<T, TResult>(
    this IEnumerable<T> sequence,
    Func<T, TResult?> projection,
    TResult? ifEmpty = null)
    where TResult : class;

  public static IEnumerable<T> Recursive<T>(
    this IEnumerable<T> list,
    Func<T, IEnumerable<T>> getChildren);

  /// <summary> Returns median value for <paramref name="enumerable" />. If <paramref name="sorted" /> is <c>false</c> then it makes sorted copy of enumerable to find the median otherwise it just returns medium element. </summary>
  [return: MaybeNull]
  public static T Median<T>(this IEnumerable<T> enumerable, bool sorted = false) where T : IComparable<T>;

  /// <summary> Same as ToDictionary, but only adds entry with first distinct key. </summary>
  public static Dictionary<TKey, TElement> ToDictionaryWithDistinctKeys<TSource, TKey, TElement>(
    this IEnumerable<TSource> source,
    Func<TSource, TKey> keySelector,
    Func<TSource, TElement> elementSelector)
    where TKey : notnull;

  public static Dictionary<TKey, TElement> ToDictionaryNonNullKeys<TSource, TKey, TElement>(
    this IEnumerable<TSource> source,
    Func<TSource, TKey> keySelector,
    Func<TSource, TElement> elementSelector)
    where TKey : notnull;

  /// <summary> Represents enumerable as <see cref="T:System.Collections.Generic.ICollection`1" /> avoiding copy creation if not necessary. </summary>
  public static ICollection<T> AsCollection<T>(this IEnumerable<T> @this);

  public static IList<T> AsList<T>(this IEnumerable<T> @this);

  /// <summary> Represents enumerable as <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> avoiding copy creation if not necessary. </summary>
  public static IReadOnlyList<T> AsReadOnlyList<T>(this IEnumerable<T> @this);

  public static IEnumerable<TValue> SelectFrom<TKey, TValue>(
    this IEnumerable<TKey> keys,
    IDictionary<TKey, TValue> dict);

  public static IEnumerable<TValue> SelectFrom<T, TKey, TValue>(
    this IEnumerable<T> items,
    IDictionary<TKey, TValue> dict,
    Func<T, TKey> keyFunc);

  /// <summary>Casts <paramref name="enumerable" /> to <see cref="T:System.Collections.Generic.IEnumerable`1" />. Is useful when you need to cast to specific runtime type, but can't use generic type arguments.</summary>
  public static IEnumerable Cast(this IEnumerable enumerable, Type type);

  /// <summary>Fallback to another enumerable provided by <paramref name="fallbackProvider" /> if <paramref name="enumerable" /> is empty.</summary>
  public static IEnumerable<T> FallbackIfEmpty<T>(
    this IEnumerable<T> enumerable,
    Func<IEnumerable<T>> fallbackProvider);

  public static float AverageOrDefault(this IEnumerable<float> source, float defaultValue = 0.0f);

  /// <summary>Improved version of <see cref="M:System.Linq.Enumerable.Except``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})" />, but with nullable <paramref name="except" /> support. If it is <c>null</c> then <paramref name="source" /> returned unmodified.</summary>
  public static IEnumerable<T> NullableExcept<T>(this IEnumerable<T> source, IEnumerable<T>? except);

  private class DependencyNode<T>
  {
    public T Obj { get; }

    public List<EnumerableExtensions.DependencyNode<T>> Dependencies { get; }

    public List<EnumerableExtensions.DependencyNode<T>> Dependers { get; }

    public DependencyNode(T obj);
  }
}
