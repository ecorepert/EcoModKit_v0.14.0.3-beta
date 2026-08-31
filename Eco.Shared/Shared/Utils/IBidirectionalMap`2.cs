// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.IBidirectionalMap`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Interface for bi-directional maps which allow to access key by value in addition to usual by key lookup.</summary>
public interface IBidirectionalMap<TKey, TVal> : 
  IDictionary<TKey, TVal>,
  ICollection<KeyValuePair<TKey, TVal>>,
  IEnumerable<KeyValuePair<TKey, TVal>>,
  IEnumerable
{
  /// <summary>Lookups key by value.</summary>
  bool TryGetByValue(TVal val, [MaybeNullWhen(false)] out TKey key);

  /// <summary>Checks if value is in map.</summary>
  bool ContainsValue(TVal val);

  /// <summary>Gets value by key or adds new mapping if not exits. Value will be created with <paramref name="valueFactory" />.</summary>
  TVal GetOrAdd(TKey key, Func<TVal> valueFactory);

  /// <summary>Gets value by key or adds new mapping if not exits.</summary>
  TVal GetOrAdd(TKey key, TVal value);

  /// <summary>Tries to add two-way mapping between <paramref name="key" /> and <paramref name="value" />. Fails if either key or value already exists in the dictionary.</summary>
  bool TryAdd(TKey key, TVal value);
}
