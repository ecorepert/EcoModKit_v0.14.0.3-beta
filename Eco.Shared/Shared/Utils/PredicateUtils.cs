// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.PredicateUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Utility methods for combining predicate functions together.</summary>
public static class PredicateUtils
{
  /// <summary>Combines <paramref name="left" /> and <paramref name="right" /> by <c>&amp;&amp;</c> operator. Uses same naming as <see cref="M:System.Linq.Expressions.Expression.AndAlso(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)" />.</summary>
  public static Func<T, bool> AndAlso<T>(this Func<T, bool> left, Func<T, bool> right);

  /// <summary>Checks if <paramref name="item" /> matches all <paramref name="predicates" />. Returns <c>true</c> if no predicates.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool MatchesAll<TEnumerable, T>(this T item, TEnumerable predicates) where TEnumerable : IEnumerable<Func<T, bool>>;

  /// <summary>Checks if <paramref name="item" /> matches all <paramref name="predicates" />. Returns <c>true</c> if no predicates.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool MatchesAll<T>(this T item, params Func<T, bool>[] predicates);

  /// <summary>Checks if <paramref name="item" /> matches any of <paramref name="predicates" />. Returns <c>false</c> if no predicates.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool MatchesAny<TEnumerable, T>(this T item, TEnumerable predicates) where TEnumerable : IEnumerable<Func<T, bool>>;
}
