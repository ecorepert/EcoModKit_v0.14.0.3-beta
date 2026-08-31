// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.CollectionExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Utils;

public static class CollectionExtensions
{
  public static void InsertAtIndex<T>(this IList<T> list, int index, T val);

  public static void AddRangeEnsureUnique<T>(this HashSet<T> set, IEnumerable<T> list);

  public static void AddEnsureUnique<T>(this HashSet<T> set, T entry);

  /// <summary>Clear the hash set and assign it the new set.</summary>
  public static void Set<T>(this HashSet<T> set, IEnumerable<T> entries);

  public static bool AddUnique<T>(this ICollection<T> col, T item);

  public static bool ContainsAll<T>(this ICollection<T> source, IEnumerable<T> values);

  /// <summary> Checks if <paramref name="source" /> collection contains any value from <paramref name="values" />. </summary>
  public static bool ContainsAny<T>(this ICollection<T> source, IEnumerable<T> values);

  public static bool ContainsAny<T>(this ICollection<T> source, params T[] values);

  [return: MaybeNull]
  public static T IndexOrDefault<T>(this ICollection<T> list, int index);

  [return: MaybeNull]
  public static T IndexOrDefault<T>(this ICollection<T> list, int index, T defaultVal);

  public static bool HasIndex<T>(this ICollection<T> list, int index);

  /// <summary>Adds element to <paramref name="collection" /> only if it isn't null. Returns <c>true</c> if element was added.</summary>
  public static bool AddNotNull<T>(this ICollection<T> collection, T? element) where T : class;
}
