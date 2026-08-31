// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Extensions.ReadOnlySpanExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Extensions;

/// <summary>Set of extension methods for <see cref="T:System.ReadOnlySpan`1" />.</summary>
public static class ReadOnlySpanExtensions
{
  /// <summary>Returns new <see cref="T:System.Collections.Generic.HashSet`1" /> containing all items from <paramref name="span" />.</summary>
  public static HashSet<T> ToSet<T>(this ReadOnlySpan<T> span);

  /// <summary>Returns new <see cref="T:System.Collections.Generic.List`1" /> containing all items from <paramref name="span" />.</summary>
  public static List<T> ToList<T>(this ReadOnlySpan<T> span);
}
