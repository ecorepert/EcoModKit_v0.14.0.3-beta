// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeDictionary`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Utils;

[ThreadSafe]
[SerializedAsEnumerable]
[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof (ThreadSafeDictionary<,>.DebuggerDisplay))]
public class ThreadSafeDictionary<TKey, TValue> : 
  IDictionary<
  #nullable disable
  TKey, TValue>,
  ICollection<KeyValuePair<TKey, TValue>>,
  IEnumerable<KeyValuePair<TKey, TValue>>,
  IEnumerable,
  IDictionary,
  ICollection,
  ISnapshotable<KeyValuePair<TKey, TValue>>,
  ISnapshotable
{
  ICollection<KeyValuePair<TKey, TValue>> ISnapshotable<KeyValuePair<TKey, TValue>>.Snapshot { get; }

  ICollection ISnapshotable.Snapshot { get; }

  public ImmutableDictionary<TKey, TValue> Snapshot { get; }

  public IEnumerable<TKey> Keys { get; }

  public IEnumerable<TValue> Values { get; }

  public int Count { get; }

  public bool IsEmpty { get; }

  public IEnumerable<KeyValuePair<TKey, TValue>> Entries { get; }

  public virtual TValue this[TKey key] { get; set; }

  public bool Contains(KeyValuePair<TKey, TValue> pair);

  public bool ContainsKey(TKey key);

  public virtual void Set(Dictionary<TKey, TValue> val);

  public virtual void Set(ImmutableDictionary<TKey, TValue> val);

  public bool ContainsValue(TValue value);

  public bool TryGetKey(TKey key, out TKey actualKey);

  public bool TryGetValue(TKey key, out TValue value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public TValue GetOrDefault(TKey key);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public TValue GetOr(TKey key, TValue defaultVal);

  /// <summary>Creates a shallow copy of this ThreadSafeDictionary with a snapshot of the current dictionary state.</summary>
  public ThreadSafeDictionary<TKey, TValue> Clone();

  public virtual void Add(TKey key, TValue value);

  public void Add(KeyValuePair<TKey, TValue> pair);

  public virtual TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory);

  public virtual void AddRange(IEnumerable<KeyValuePair<TKey, TValue>> pairs);

  public virtual bool TryAdd(TKey key, TValue value);

  public virtual TValue AddOrUpdate(
    TKey key,
    TValue addValue,
    Func<TKey, TValue, TValue> updateValueFactory);

  public virtual TValue AddOrUpdate(
    TKey key,
    Func<TValue> createFunc,
    Func<TValue, TValue> updateFunc);

  /// <summary>Sets the specified key to <paramref name="newValue" /> if the specified key already is set to <paramref name="comparisonValue" />.</summary>
  /// <returns>True if update succeeds.</returns>
  public virtual bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue);

  public virtual bool Remove(TKey key);

  /// <summary>Remove the specified keys from the dictionary. Returns a list of all the removed keys or null if no key was removed.</summary>
  public virtual ImmutableDictionary<TKey, TValue> RemoveRange(IEnumerable<TKey> keys);

  public virtual bool TryRemove(TKey key, out TValue value);

  public bool TryRemove(TKey key);

  public virtual bool TryRemove(KeyValuePair<TKey, TValue> pair);

  public virtual void SetItem(TKey key, TValue value);

  public virtual void SetItems(IEnumerable<KeyValuePair<TKey, TValue>> items);

  public virtual void Clear();

  public virtual IReadOnlyDictionary<TKey, TValue> GetSnapshotAndClear();

  public virtual TValue GetOrAdd(TKey key, TValue value);

  public TValue GetOrAdd(TKey key, Func<TValue> createFunc);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public TValue GetOrAdd(TKey key);

  public ImmutableDictionary<TKey, TValue>.Enumerator GetEnumerator();

  IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public bool IsSynchronized { get; }

  public object SyncRoot { get; }

  object IDictionary.this[object key] { get; set; }

  ICollection<TKey> IDictionary<TKey, TValue>.Keys { get; }

  ICollection<TValue> IDictionary<TKey, TValue>.Values { get; }

  public bool IsReadOnly { get; }

  ICollection IDictionary.Keys { get; }

  ICollection IDictionary.Values { get; }

  public bool IsFixedSize { get; }

  bool IDictionary.Contains(object key);

  void IDictionary.Add(object key, object value);

  void IDictionary.Remove(object key);

  /// <summary>Removes <paramref name="item" /> from dictionary if it matches both key and value of <paramref name="item" />.</summary>
  public bool Remove(KeyValuePair<TKey, TValue> item);

  public void CopyTo(Array array, int index);

  public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);

  IDictionaryEnumerator IDictionary.GetEnumerator();

  private class DebuggerDisplay
  {
    public DebuggerDisplay(IDictionary dict);

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public List<object> Items { get; }
  }
}
