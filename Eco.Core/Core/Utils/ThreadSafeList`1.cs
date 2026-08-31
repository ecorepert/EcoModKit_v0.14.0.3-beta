// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeList`1
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

#nullable enable
namespace Eco.Core.Utils;

[ThreadSafe]
[SerializedAsEnumerable]
[System.Diagnostics.DebuggerDisplay("Count = {Count} ({TypeName})")]
[DebuggerTypeProxy(typeof (ThreadSafeList<>.DebuggerDisplay))]
public class ThreadSafeList<T> : 
  IList<T>,
  ICollection<T>,
  IEnumerable<T>,
  IEnumerable,
  IList,
  ICollection,
  IReadOnlyList<T>,
  IReadOnlyCollection<T>,
  ISnapshotable<T>,
  ISnapshotable
{
  public ICollection<T> Collection { get; }

  public virtual T this[int index] { get; set; }

  public int Count { get; }

  public bool IsReadOnly { get; }

  public bool IsFixedSize { get; }

  public object SyncRoot { get; }

  public bool IsSynchronized { get; }

  object? IList.this[int index] { get; set; }

  public string TypeName { get; }

  public bool Contains(T item);

  public void CopyTo(T[] array, int arrayIndex);

  public virtual int IndexOf(T item);

  /// <summary> Makes atomic ToArray operation. It isn't safe to use <see cref="M:System.Linq.Enumerable.ToArray``1(System.Collections.Generic.IEnumerable{``0})" />, because it gets <see cref="P:Eco.Core.Utils.ThreadSafeList`1.Count" /> as a separate operation (and count may be modified in between). </summary>
  public T[] ToArray();

  /// <summary> Makes atomic ToList operation. It isn't safe to use <see cref="M:System.Linq.Enumerable.ToList``1(System.Collections.Generic.IEnumerable{``0})" />, because it gets <see cref="P:Eco.Core.Utils.ThreadSafeList`1.Count" /> as a separate operation (and count may be modified in between). </summary>
  public List<T> ToList();

  public ThreadSafeList();

  public ThreadSafeList(IEnumerable<T> contents);

  public virtual void Add(T item);

  public virtual void AddRange(IEnumerable<T> items);

  public virtual void Clear();

  public virtual ImmutableList<T> GetAndClear();

  public virtual void Insert(int index, T item);

  public virtual void Sort();

  public virtual void Sort(Comparison<T> comparison);

  public virtual void Sort(IComparer<T> comparer);

  public virtual void Sort(int index, int count, IComparer<T> comparer);

  public virtual void Set(IEnumerable<T> items);

  public virtual void SetAt(int index, T obj);

  /// <summary>Removes an element but doesnt return it (needed for implementing IList).</summary>
  public void RemoveAt(int index);

  /// <summary>Remove the indexed element atomically and return it.</summary>
  public virtual T? RemoveAtAndReturn(int index);

  /// <summary>Replaces first element matching the <paramref name="matcher" /> with <paramref name="item" /> or adds new <paramref name="item" /> if no one matched.</summary>
  public virtual void AddOrReplace(T item, Predicate<T> matcher);

  /// <summary>Removes first item matching the <paramref name="matcher" />. Returns <c>true</c> if item was removed.</summary>
  public virtual bool RemoveFirst(Predicate<T> matcher);

  public virtual bool Remove(T item);

  public virtual bool RemoveRange(IEnumerable<T> items);

  public bool RemoveNulls();

  public virtual int RemoveAll(Predicate<T> match);

  /// <summary>
  /// Removes all elements by <paramref name="match" /> and returns <paramref name="removed" /> elements in output parameter.
  /// This operation is atomic and ensures that all returned elements belonging to this remove operation.
  /// In example if you do something like
  /// <code>var l = items.ToList(); /* items may be added or removed */ items.RemoveAll(predicate); /* items may be added or removed */ var removed = l.Except(items);</code>
  /// then you may have inconsistent results where in `removed` will be items which was added since call to `RemoveAll` or removed since call to `ToList` and may match the predicate
  /// or you may miss some removed items if they added after call to ToList or added back to items since call to RemoveAll.
  /// </summary>
  public virtual void RemoveAll(Predicate<T> match, out ImmutableList<T> removed);

  public virtual void Move(int index, int newIndex);

  public virtual T GetOrCreate(Predicate<T> test, Func<T> create);

  /// <summary>
  /// Allows to execute action with immutable list for thread-safe calculations
  /// I.e. you may want to get Count first and then make some calculations based on number of elements.
  /// For separate Count and GetEnumerator operations you may have state changed between these two calls.
  /// </summary>
  /// <param name="action">Function to execute with read-only list.</param>
  /// <typeparam name="TResult">Result of function applied to immutable list.</typeparam>
  /// <returns></returns>
  public TResult WithSnapshot<TResult>(Func<IReadOnlyList<T>, TResult> action);

  /// <summary>
  /// Same as <see cref="M:Eco.Core.Utils.ThreadSafeList`1.WithSnapshot``1(System.Func{System.Collections.Generic.IReadOnlyList{`0},``0})" /> but for action.
  /// </summary>
  /// <param name="action">Action to execute with read-only list.</param>
  public void WithSnapshot(Action<IReadOnlyList<T>> action);

  /// <summary>
  /// Gets current list read-only snapshot. May be used to get consistent result between different access calls.
  /// </summary>
  public ImmutableList<T> Snapshot { get; }

  public virtual T GetAt(int index);

  public virtual int IndexOf(object? value);

  public ImmutableList<T>.Enumerator GetEnumerator();

  IEnumerator<T> IEnumerable<T>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  int IList.Add(object? value);

  bool IList.Contains(object? value);

  void IList.Insert(int index, object? value);

  void IList.Remove(object? value);

  void ICollection.CopyTo(Array array, int index);

  ICollection<T> ISnapshotable<T>.Snapshot { get; }

  ICollection ISnapshotable.Snapshot { get; }

  private class DebuggerDisplay
  {
    public DebuggerDisplay(IList list);

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public List<object> Items { get; }
  }
}
