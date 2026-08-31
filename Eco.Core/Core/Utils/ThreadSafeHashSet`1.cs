// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeHashSet`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using NetFabric.Hyperlinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

#nullable disable
namespace Eco.Core.Utils;

[ThreadSafe]
[SerializedAsEnumerable]
[System.Diagnostics.DebuggerDisplay("Count = {Count} ({TypeName})")]
[DebuggerTypeProxy(typeof (ThreadSafeHashSet<>.DebuggerDisplay))]
public class ThreadSafeHashSet<T> : 
  IHashSet,
  IEnumerable,
  IReadOnlySet<T>,
  IEnumerable<T>,
  IReadOnlyCollection<T>,
  ISnapshotable<T>,
  ISnapshotable,
  IValueEnumerable<T, ImmutableHashSet<T>.Enumerator>
{
  public string TypeName { get; }

  public int Count { get; }

  public ImmutableHashSet<T> Snapshot { get; }

  public ThreadSafeHashSet();

  public ThreadSafeHashSet(IEnumerable<T> items);

  public bool SetEquals(IEnumerable<T> other);

  public bool ContainsCast(object item);

  public bool Contains(T item);

  public bool Contains(IEnumerable<T> items);

  public IReadOnlySet<T> SnapshotAndClear();

  public virtual void Clear();

  public virtual void UnionWith(IEnumerable<T> e);

  public virtual void Set(IEnumerable<T> e);

  public void Set(IEnumerable objs);

  public virtual bool Add(T item);

  public virtual void AddRange(IEnumerable<T> e);

  public virtual bool Remove(T item);

  /// <summary> Removes all items matching <paramref name="match" /> predicate and returns count of removed items. </summary>
  public virtual int RemoveAll(Func<T, bool> match);

  /// <summary>Remove from the hashset any entries passing the given match test, and return them.</summary>
  public virtual IEnumerable<T> RemoveAllAndReturn(Func<T, bool> match);

  /// <summary>Remove all items contained in <paramref name="range" /> if they are present in the hash set.</summary>
  public virtual void RemoveRange(IEnumerable<T> range);

  /// <summary>Remove all items contained in <paramref name="range" /> if they are present in the hash set.</summary>
  /// <returns>Items that were removed.</returns>
  public virtual IEnumerable<T> RemoveRangeAndReturn(IEnumerable<T> range);

  public virtual ImmutableHashSet<T> GetAndClear();

  public virtual IEnumerable<T> GetAndClearMatching(Func<T, bool> test);

  public ImmutableHashSet<T>.Enumerator GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  IEnumerator<T> IEnumerable<T>.GetEnumerator();

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  ICollection<T> ISnapshotable<T>.Snapshot { get; }

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  ICollection ISnapshotable.Snapshot { get; }

  void IHashSet.Add(object obj);

  void IHashSet.Remove(object obj);

  bool IReadOnlySet<T>.IsProperSubsetOf(IEnumerable<T> other);

  bool IReadOnlySet<T>.IsProperSupersetOf(IEnumerable<T> other);

  bool IReadOnlySet<T>.IsSubsetOf(IEnumerable<T> other);

  bool IReadOnlySet<T>.IsSupersetOf(IEnumerable<T> other);

  bool IReadOnlySet<T>.Overlaps(IEnumerable<T> other);

  private class DebuggerDisplay
  {
    public DebuggerDisplay(IHashSet hashSet);

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public List<object> Items { get; }
  }
}
