// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.EnumUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Utility classes for interacting with Enum instances.</summary>
public static class EnumUtils
{
  public static LocString DisplayName<T>(this T val) where T : Enum;

  public static LocString StyledDisplayName<T>(this T val) where T : Enum;

  public static int Count<T>() where T : Enum;

  public static ImmutableArray<T> Entries<T>() where T : Enum;

  public static ImmutableArray<string> Names<T>() where T : Enum;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool HasAnyFlag<T>(this T keys, T flags) where T : unmanaged, Enum;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ulong ToUInt64<T>(this T value) where T : unmanaged, Enum;

  /// <summary> Maps the contents of an array or a list to a Dictionary of specified enum type. </summary>
  public static Dictionary<TEnum, T> ToEnumMap<TEnum, T>(this IList<T> objectList) where TEnum : Enum;

  /// <summary>Returns a <seealso cref="T:System.Collections.Generic.IEnumerable`1" /> instancing containing the distinct etnries of an Enum object ordered by value.</summary>
  /// <typeparam name="T">Enum type to retrieve the values from</typeparam>
  /// <returns><seealso cref="T:System.Collections.Generic.IEnumerable`1" /> instance containing the distinct values ordered by value.</returns>
  public static IEnumerable<T> SequentialEntries<T>() where T : unmanaged, Enum;

  /// <summary> Gets All descriptions From Enum Type of Enum Values if they have LocDescriptionAttibure else returns null</summary>
  /// <typeparam name="T"> Enum Type to Get descriptions from</typeparam>
  [return: MaybeNull]
  public static LocString[] GetEnumDescriptions<T>() where T : Enum;

  [return: MaybeNull]
  public static (string? Name, LocString Description)[] GetEnumNamesAndDescriptions<T>() where T : Enum;

  /// <summary> Gets All descriptions From Object of type Type of Enum Values if they have LocDescriptionAttibure else returns null</summary>
  /// <param name="type">Tyep Object to get descriptions from</param>
  [return: MaybeNull]
  public static LocString[] GetEnumDescriptions(Type type);

  [return: MaybeNull]
  public static (string? Name, LocString Description)[] GetEnumNamesAndDescriptions(Type type);

  /// <summary>Checks if enum value has an attribute</summary>
  public static bool HasAttribute<T>(this Enum e, bool inherit = true) where T : Attribute;

  /// <summary>Cached information about <see cref="T:System.Enum" /> type. Makes names, values and count requests much cheaper.</summary>
  private static class EnumInfo<TEnum> where TEnum : Enum
  {
    public static readonly ImmutableArray<string> Names;
    public static readonly ImmutableArray<TEnum> Values;
  }
}
