// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.SingleValueOrList`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>
/// Special kind of "collection" which may be either single value or list of values. May be useful when in most cases you have just a single value and in rare cases it may be a list.
/// When it is a single value of reference type then there no allocations (but for value types there will be boxing).
/// </summary>
public struct SingleValueOrList<T>
{
  private object? state;

  public T? FirstValue { get; }

  public int Count { get; }

  public bool IsList { get; }

  /// <summary>Converts <see cref="T:Eco.Shared.Collections.SingleValueOrList`1" /> to list (if it wasn't).</summary>
  public List<T?> AsList();

  public static explicit operator SingleValueOrList<T>(T? item);

  public static explicit operator SingleValueOrList<T>(List<T?> list);
}
