// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ArrayExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Utils;

public static class ArrayExtensions
{
  public static IEnumerable<T> XYIter<T>(this T[,] array);

  /// <summary>Pass forward sorted array for large middle numbers for example {1,2,3,4,5} would be {1,3,5,4,2}, or reverse sorted array for large side numbers for example {5,4,3,2,1} would be {5,3,1,2,4}, this is useful for aligning trees based on depth, this is a special iterator that jumps through enumerable check this explanation: https://stackoverflow.com/a/3796619</summary>
  /// <example>One of the cases this is used on is the tech tree visualizer where nodes with higher total rank go in the top and bottom for a better aethestic and line drawing:
  /// <code>listToOrder.OrderByDescending(tree =&gt; GetTotalRank(tree)).ToArray().CurveOrder();</code>
  /// </example>
  public static IEnumerable<T> CurveOrder<T>(this T[] listToOrder);

  [return: MaybeNull]
  public static T MinObj<T>(this T[] enumeration, Func<T, float> distanceFunc);

  [return: MaybeNull]
  public static T MaxObj<T>(this T[] array, Func<T, double> distanceFunc);

  [return: MaybeNull]
  public static T MaxObj<T>(this T[] array, Func<T, float> distanceFunc);

  [return: MaybeNull]
  public static T MinIndex<T>(this T[] array) where T : IComparable;

  public static void ForEachIndex<T>(this T[] array, Action<T, int> handler);

  public static void ForEach<T>(this T[] enumeration, Action<T> action);

  public static int GetArrayHashCode<T>(this T[] array) where T : notnull;

  public static bool ArrayEquals<T>(this T[] array, T[] otherArray);
}
