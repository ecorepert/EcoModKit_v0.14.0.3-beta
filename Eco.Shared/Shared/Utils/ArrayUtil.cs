// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ArrayUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

public static class ArrayUtil
{
  /// <summary>Returns the columns of the given row index</summary>
  public static IEnumerable<T> ValuesAtX<T>(this T[,] array, int x);

  /// <summary>Returns the rows of the given column index</summary>
  public static IEnumerable<T> ValuesAtY<T>(this T[,] array, int y);

  /// <summary>Assigns the given value to the whole row</summary>
  public static void SetValuesAtX<T>(this T[,] array, int x, T val);

  /// <summary>Assigns the given value to the whole column</summary>
  public static void SetValuesAtY<T>(this T[,] array, int y, T val);

  public static T SecondLast<T>(this T[] array);

  /// <summary> Make an array and fill it with 'new'd entries. </summary>
  public static T[] MakeNew<T>(int count) where T : new();
}
