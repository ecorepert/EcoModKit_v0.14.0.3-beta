// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.SetExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable enable
namespace Eco.Shared.Utils;

public static class SetExtensions
{
  public static void AddRange<T>(this ISet<T> set, IEnumerable<T> items);

  public static void RemoveRange<T>(this ISet<T> set, IEnumerable<T> items);

  public static HashSet<T> MakeHashSet<T>(params IEnumerable<T>[] lists);

  /// <summary> No alloc version of Enumerable.First() for HashSet. </summary>
  /// <exception cref="T:System.InvalidOperationException">If no elements in HashSet.</exception>
  public static T First<T>(this HashSet<T> set);

  /// <summary> Maps <see cref="T:System.Linq.IGrouping`2" /> key to new value (in example id may be resolved to name). </summary>
  public static IEnumerable<IGrouping<TKey, TElement>> MapGroupingKey<TOldKey, TKey, TElement>(
    this IEnumerable<IGrouping<TOldKey, TElement>> enumerable,
    Func<TOldKey, TKey> map);

  /// <summary> Returns the passed enumerable omitting any entries repeated in the sequence. Only checks sequential repeats, not list-wide repeats (like 'Distinct()' would).</summary>
  public static IEnumerable<T> IgnoreRepeats<T>(this IEnumerable<T> list) where T : IEquatable<T>;

  public static Vector3i? AveragePosWrapped(this IEnumerable<Vector3i> list);

  public static IEnumerable<Vector3i> Unwrapped(this IEnumerable<Vector3i> list);

  public static T? GetAtIndexOrLast<T>(this IEnumerable<T> list, int index);

  /// <summary>Get the element at the given index, or null. Note that this is O(N), and should only be used when generic version of IEnumerable isnt available.</summary>
  public static object? EnumerableElementAt(this IEnumerable list, int index);

  /// <summary>Return the index of the given value in a non-generic enumerable. Note that this is O(N), and should only be used when generic version of IEnumerable isnt available.</summary>
  public static int EnumerableIndexOf(this IEnumerable list, object obj);

  public static IEnumerable<TValue> LimitGroups<TKey, TValue>(
    this IEnumerable<IGrouping<TKey, TValue>> groups,
    Func<TValue, int> getCountAllowed);

  public static HashSet<T> XOR<T>(this IEnumerable<T> left, IEnumerable<T> right);

  /// <summary>Execute a comparison between every element in the list (not caring for ordering)</summary>
  public static void CompareAll<T>(this List<T> list, Action<T, T> doCompare);

  /// <summary>
  /// Converts an enumerable to a list, avoiding allocation if it's already a list.
  /// Returns the existing list if input is IList&lt;T&gt;, otherwise creates a new list.
  /// </summary>
  public static IList<T> ToExistingOrNewList<T>(this IEnumerable<T>? enumerable);
}
