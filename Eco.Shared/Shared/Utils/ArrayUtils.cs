// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ArrayUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

public static class ArrayUtils
{
  public static bool UseParallel;

  public static 
  #nullable disable
  IEnumerable<object> Objects(this Array array);

  public static IEnumerable<T> Enumerable<T>(params T[] entries);

  public static T[,] To2DArray<T>(this IEnumerable<IEnumerable<T>> source);

  public static int Index(Vector3i dimensions, int x, int y, int z);

  public static T SafeGet<T>(
    this T[] source,
    int x,
    int y,
    int z,
    Vector3i dimensions,
    T outsideBoundsValue = null);

  public static void OrderByInPlaceUnstable<TKey, TValue>(
    this TKey[] list,
    Func<TKey, TValue> predicate)
    where TValue : IComparable;

  public static void OrderByInPlaceUnstableDescending<TKey, TValue>(
    this TKey[] list,
    Func<TKey, TValue> predicate)
    where TValue : IComparable;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Fill<T>(this T[] @this, T value);

  public static T[] RemoveAll<T>(this T[] @this, Func<T, bool> predicate);

  /// <summary>Create an array of the given size, and instantiate the given type into each entry.</summary>
  public static T[] CreateWithNewEntries<T>(int size) where T : new();

  public static T[] CreateFilled<T>(int size, T value);

  public static void Concat<T>(ref T[] lhs, T[] rhs);

  public static T[] CopyOf<T>(T[] array);
}
