// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ServerListExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Utils;

public static class ServerListExtensions
{
  public static 
  #nullable disable
  IEnumerable<(T, T)> Pairs<T>(this IEnumerable<T> list) where T : IComparable;

  public static IEnumerable<(T, T)> PairsEachOrder<T>(this IEnumerable<T> list) where T : IComparable;

  public static IEnumerable<(T, T)> PairsEachOrderNoSame<T>(this IEnumerable<T> list);

  /// <summary>Return pairs between list1 and list2, omitting ones where the values are equal.</summary>
  public static IEnumerable<(T, T)> PairsNoSame<T>(
    this IEnumerable<T> list,
    IEnumerable<T> listother);

  public static T GetOrDefault<T>(this T[] array, int index);

  public static List<T> EnsureSize<T>(this List<T> list, int size, Func<T> makeVal = null);

  public static Tuple<T, float> MaxTuple<T>(
    this IEnumerable<T> enumeration,
    Func<T, float> distanceFunc)
    where T : class;

  public static string Describe<TKey, TValue>(this IDictionary<TKey, TValue> dict);

  public static string ToJSON(this List<string> list, bool quoted);

  public static bool AddUnique<T>(this IList<T> l, T element);

  /// <summary>
  /// We replace all the items that match the specified condition with the specified item.
  /// IMPORTANT: this doesn't preserve the order of the items inside the list.
  /// </summary>
  public static void ReplaceWith<T>(this IList<T> list, Predicate<T> match, T newItem);

  public static bool AddUniqueNonNull<T>(this IList<T> l, T element);

  public static T? FirstOrNull<T>(this IEnumerable<T> sequence, Func<T, bool> func) where T : struct;

  public static T? LastOrNull<T>(this IEnumerable<T> sequence) where T : struct;

  public static T? LastOrNull<T>(this IEnumerable<T> sequence, Func<T, bool> func) where T : struct;

  public static bool SequenceEqual(IEnumerable left, IEnumerable right);

  public static IEnumerable<T> RemoveAll<T>(this IList<T> list, Func<T, bool> p);

  /// <summary> This function is used to ensure correct state of lists. By default it will remove all null elements. It's usefull to not crash the game if there were some errors on saving/migrations. Anyway these errors needs to be investigated.  </summary>
  public static void RemoveAndLogErrors<T>(
    this IList<T> entries,
    string name,
    Func<T, bool> testFunction = null);

  public static T ElementAtOrDefault<T>(this IReadOnlyList<T> list, int index, T defaultValue = null);

  public static T ElementAtOrNearest<T>(this IReadOnlyList<T> list, int index);
}
