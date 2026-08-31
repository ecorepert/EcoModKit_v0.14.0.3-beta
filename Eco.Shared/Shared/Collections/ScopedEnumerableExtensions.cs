// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.ScopedEnumerableExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>Extension methods for <see cref="T:Eco.Shared.Collections.ScopedEnumerable`1" />.</summary>
public static class ScopedEnumerableExtensions
{
  /// <summary>Represents <paramref name="enumerable" /> as owned for methods with ownership awareness. If these methods need to save enumerable content they have to use <see cref="M:Eco.Shared.Collections.IScopeAwareEnumerable`1.ToUnscopedCollection" /> to make defensive copy.</summary>
  public static ScopedEnumerable<T> Scoped<T>(this IEnumerable<T> enumerable);
}
