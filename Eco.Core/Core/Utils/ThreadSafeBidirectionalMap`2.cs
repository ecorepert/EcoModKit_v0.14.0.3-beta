// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeBidirectionalMap`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Core.Utils;

[ThreadSafe]
public class ThreadSafeBidirectionalMap<TKey, TVal> : 
  IBidirectionalMap<TKey, TVal>,
  IDictionary<TKey, TVal>,
  ICollection<KeyValuePair<TKey, TVal>>,
  IEnumerable<KeyValuePair<TKey, TVal>>,
  IEnumerable
  where TKey : notnull
  where TVal : notnull
{
  public ThreadSafeBidirectionalMap<
  #nullable disable
  TKey, TVal>.State Snapshot { get; }

  /// <summary>
  /// Thread-safe implementation of GetOrAdd pattern with <paramref name="valueFactory" />.
  /// Please be aware that <paramref name="valueFactory" /> may be called even when value not inserted, because of nature of lock-free algorithms.
  /// </summary>
  public 
  #nullable enable
  TVal GetOrAdd(TKey key, Func<TVal> valueFactory);

  /// <summary>Thread-safe implementation of GetOrAdd pattern.</summary>
  public TVal GetOrAdd(TKey key, TVal value);

  public bool TryGetByValue(TVal value, [MaybeNullWhen(false)] out TKey key);

  public bool ContainsValue(TVal val);

  public bool ContainsKey(TKey key);

  public void Add(TKey key, TVal value);

  public bool TryAdd(TKey key, TVal value);

  public bool Remove(TKey key);

  public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TVal value);

  public TVal this[TKey key] { get; set; }

  public ICollection<TKey> Keys { get; }

  public ICollection<TVal> Values { get; }

  public ImmutableDictionary<TKey, TVal>.Enumerator GetEnumerator();

  IEnumerator<KeyValuePair<TKey, TVal>> IEnumerable<KeyValuePair<TKey, TVal>>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public void Add(KeyValuePair<TKey, TVal> item);

  public void Clear();

  public bool Contains(KeyValuePair<TKey, TVal> item);

  public void CopyTo(KeyValuePair<TKey, TVal>[] array, int arrayIndex);

  public bool Remove(KeyValuePair<TKey, TVal> item);

  public int Count { get; }

  public bool IsReadOnly { get; }

  public class State
  {
    public readonly ImmutableDictionary<TKey, TVal> KeyToValue;
    public readonly ImmutableDictionary<TVal, TKey> ValueToKey;

    public State(
      ImmutableDictionary<TKey, TVal> keyToValue,
      ImmutableDictionary<TVal, TKey> valueToKey);
  }
}
