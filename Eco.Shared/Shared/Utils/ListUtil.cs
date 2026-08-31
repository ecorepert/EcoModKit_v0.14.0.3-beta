// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ListUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

public static class ListUtil
{
  /// <summary>For-each across two enumerables, stopping when either ends.</summary>
  public static IEnumerable<(T1 Left, T2 Right)> ForEachTuple<T1, T2>(
    this IEnumerable<T1> first,
    IEnumerable<T2> second);

  public static T? OneOrNull<T>(this IEnumerable<T> list);

  public static IEnumerable<TEntry> TakeSame<TEntry, TVal>(
    this IEnumerable<TEntry> list,
    Func<TEntry, TVal> testSame)
    where TVal : IComparable;

  /// <summary>Take First numToTake of items in IEnumerable and apply function doForRest on the elements left in IEnumerable.</summary>
  public static System.Collections.Generic.List<T> TakeAndCalculateForRest<T>(
    this IEnumerable<T> list,
    int numToTake,
    Func<T, int> doForRest);

  /// <summary>Take first <paramref name="numToTake" /> of items in IEnumerable, transform it with Func <paramref name="doWithTaken" /> and apply Func <paramref name="doForRest" /> on the elements left in IEnumerable.</summary>
  public static System.Collections.Generic.List<TResult> TakeSelectAndCalcRest<T, TResult>(
    this IEnumerable<T> list,
    int numToTake,
    Func<T, TResult> doWithTaken,
    Func<T, int> doForRest);

  public static bool IsSortedAscending<T>(this IEnumerable<T> list) where T : IComparable;

  public static IEnumerable<(T Prev, T Current)> GetPrevAndCurrentPairs<T>(this IEnumerable<T> list);

  public static IEnumerable<(T Node, int Level)> DepthFirstTraversal<T>(
    this T root,
    Func<T, IEnumerable<T>> getChildren);

  public static IEnumerable<T> List<T>(params T[] list);

  public static IEnumerable<T> NonNull<T>(params T[] list);

  public static string CommaListNonNull<T>(params LocString[] list);

  /// <summary>Converts container into 64bit data.</summary>
  /// <remarks>Saves the bit if container element comparer returns true</remarks>
  /// <param name="compareFunc">Comparer for saving the bit</param>
  /// <exception cref="T:System.IndexOutOfRangeException">If container size is more than 64</exception>
  public static ulong ConvertToBits<T>(this IList<T> list, Func<T, bool> compareFunc);
}
