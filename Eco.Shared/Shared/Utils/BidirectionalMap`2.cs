// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.BidirectionalMap`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

public sealed class BidirectionalMap<TKey, TVal> : 
  IBidirectionalMap<TKey, TVal>,
  IDictionary<TKey, TVal>,
  ICollection<KeyValuePair<TKey, TVal>>,
  IEnumerable<KeyValuePair<TKey, TVal>>,
  IEnumerable
{
  public BidirectionalMap();

  public BidirectionalMap(IEqualityComparer<TKey> keyEqualityComparer);

  public BidirectionalMap(
    IEqualityComparer<TKey> keyEqualityComparer,
    IEqualityComparer<TVal> valueEqualityComparer);

  public BidirectionalMap(int capacity);

  public BidirectionalMap(
    int capacity,
    IEqualityComparer<TKey> keyEqualityComparer,
    IEqualityComparer<TVal> valueEqualityComparer);

  public void Add(TKey key, TVal val);

  public IEnumerable<KeyValuePair<TKey, TVal>> All { get; }

  public ICollection<TKey> Keys { get; }

  public ICollection<TVal> Values { get; }

  public int Count { get; }

  bool ICollection<KeyValuePair<TKey, TVal>>.IsReadOnly { get; }

  public TVal this[TKey key] { get; set; }

  public TKey GetKey(TVal val);

  public bool TryAdd(TKey key, TVal val);

  /// <summary> Tries to get <paramref name="val" /> by the <paramref name="key" />. </summary>
  public bool TryGetValue(TKey key, out TVal val);

  /// <summary> Tries to get <paramref name="key" /> by the <paramref name="val" />. </summary>
  public bool TryGetByValue(TVal val, out TKey key);

  public bool ContainsValue(TVal val);

  public TVal GetOrAdd(TKey key, Func<TVal> valueFactory);

  public TVal GetOrAdd(TKey key, TVal value);

  public bool ContainsKey(TKey key);

  public bool Remove(TKey key);

  public bool RemoveByValue(TVal val, out TKey key);

  void ICollection<KeyValuePair<TKey, TVal>>.Add(KeyValuePair<TKey, TVal> item);

  public void Clear();

  bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> item);

  void ICollection<KeyValuePair<TKey, TVal>>.CopyTo(
    KeyValuePair<TKey, TVal>[] array,
    int arrayIndex);

  bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> item);

  public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
