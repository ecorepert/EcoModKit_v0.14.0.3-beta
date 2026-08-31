// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.LRUCache`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>
/// Fixed size cache. When overflows then removes least-recently used (LRU) items.
/// Significantly faster than classic LRU implementation on linked list (2.5 times on AddOrUpdate operation) and allocation free (0 bytes vs 72 000 bytes for 1000 inserts).
/// </summary>
/// <remarks>It isn't thread safe!</remarks>
public class LRUCache<TKey, TValue> where TKey : notnull
{
  /// <summary>Number of cached items.</summary>
  public int Count { get; }

  /// <summary>Collection of all keys used to store items in this cache.</summary>
  public Dictionary<TKey, int>.KeyCollection Keys { get; }

  /// <summary>All cached items.</summary>
  /// <remarks>Accessing cached items via this property doesn't count as 'using' them in the context of how LRUCache works.</remarks>
  public IEnumerable<TValue> Values { get; }

  public LRUCache(int size);

  /// <summary>Tries to get cached <paramref name="value" /> by the <paramref name="key" />.</summary>
  public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);

  /// <summary>Adds or updates cached <paramref name="value" /> by the <paramref name="key" />.</summary>
  public void AddOrUpdate(TKey key, TValue value);

  public bool TryRemove(TKey key);

  /// <summary>Clears the cache.</summary>
  public void Clear();

  /// <summary>Node for cache array-based linked list.</summary>
  private struct Node
  {
    public TKey Key;
    public TValue Value;
    public int PrevIndex;
    public int NextIndex;
  }
}
