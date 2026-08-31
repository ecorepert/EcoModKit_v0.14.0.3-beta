// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.IPredicate`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Interface for allocation-free predicates. You can add a struct which implements the predicate and then use with generic function which uses struct at compile time.</summary>
/// <example><![CDATA[
/// public struct ContainsStringPredicate : IPredicate<string>
/// {
///     public string SubString { get; set; }
///     public bool Match(string s) => s.Contains(this.SubString);
/// }
/// 
/// public static class Test
/// {
///     public int CountByFilter<T, TPredicate>(List<T> items, TPredicate filter) where TPredicate : IPredicate<T>
///     {
///         var count = 0;
///         for (var item in items)
///           if (filter(item)) count++;
///         return count;
///     }
/// 
///     public static void CountBySubString(List<string> items, string subStr) => CountByFilter(items, new ContainsStringPredicate { SubString = subStr } );
/// }
/// ]]></example>
public interface IPredicate<in T>
{
  /// <summary>Checks if item matches the predicate.</summary>
  bool Match(T item);

  /// <summary>Converts to <see cref="T:System.Func`2" /> delegate.</summary>
  Func<T, bool> ToDelegate();

  /// <summary>Converts to <see cref="T:System.Predicate`1" /> delegate.</summary>
  Predicate<T> ToPredicate();
}
