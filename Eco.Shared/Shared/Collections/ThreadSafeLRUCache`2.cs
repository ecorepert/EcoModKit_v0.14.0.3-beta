// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.ThreadSafeLRUCache`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>Thread safe version of <see cref="T:Eco.Shared.Collections.LRUCache`2" />.</summary>
/// <remarks>This is a very simple implementation based on a lock that synchronizes all access to the internal cache.</remarks>
public class ThreadSafeLRUCache<TKey, TValue> where TKey : notnull
{
  public ThreadSafeLRUCache(int size);

  /// <summary>Number of cached items.</summary>
  public int Count { get; }

  /// <summary>List of all keys used to store items in this cache.</summary>
  public List<TKey> Keys { get; }

  /// <summary>Tries to get cached <paramref name="value" /> by the <paramref name="key" />.</summary>
  public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);

  /// <summary>Adds or updates cached <paramref name="value" /> by the <paramref name="key" />.</summary>
  public void AddOrUpdate(TKey key, TValue value);

  public bool TryRemove(TKey key);

  /// <summary>Clears the cache.</summary>
  public void Clear();

  /// <summary>Finds all entries where key and value match specified criteria.</summary>
  /// <param name="keyMatch">Function that receives key and returns true if it matches the search criteria.</param>
  /// <param name="valueMatch">Function that receives value and returns true if it matches the search criteria.</param>
  public List<KeyValuePair<TKey, TValue>> GetMatchingEntries(
    Func<TKey, bool> keyMatch,
    Func<TValue, bool> valueMatch);
}
