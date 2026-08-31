// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.RandomAccessQueue`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Debugging;
using Eco.Shared.Utils;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>
/// RandomAccessQueue class is re-implementation of standard .NET Queue class, but with few additions for random access:
/// <see cref="M:Eco.Shared.Collections.RandomAccessQueue`1.Remove(`0)" /> allows to remove element from queue (for standard queue you can only remove first element with Dequeue)
/// <see cref="M:Eco.Shared.Collections.RandomAccessQueue`1.EnqueueFirst(`0)" /> allows to add element at beginning of queue (not possible in standard queue).
/// </summary>
/// <typeparam name="T"></typeparam>
public class RandomAccessQueue<T> : IEnumerable<
#nullable disable
T>, IEnumerable, IStateSnapshotSupport
{
  public RandomAccessQueue(IEqualityComparer<T> equalityComparer, int capacity = 16 /*0x10*/);

  public RandomAccessQueue();

  public RandomAccessQueue(int capacity);

  public RandomAccessQueue(IEnumerable<T> other);

  public int Count { get; }

  public bool IsEmpty { get; }

  public bool Remove(T element);

  /// <summary>Adds all <paramref name="newItems" /> to end of queue.</summary>
  public void EnqueueRange(IEnumerable<T> newItems);

  /// <summary>Removes all elements matching <paramref name="predicate" />.</summary>
  public int RemoveAll<TPredicate>(TPredicate predicate) where TPredicate : IPredicate<T>;

  /// <summary>Add element to the end of queue.</summary>
  /// <param name="el">element to add.</param>
  public void Enqueue(T el);

  /// <summary>Add element before first element in the queue.</summary>
  /// <param name="el">element to add.</param>
  public void EnqueueFirst(T el);

  /// <summary>Remove and return first element from queue.</summary>
  /// <returns>First element in queue.</returns>
  /// <exception cref="T:System.InvalidOperationException">Thrown if queue is empty.</exception>
  public T Dequeue();

  /// <summary>
  /// Tries to <see cref="M:Eco.Shared.Collections.RandomAccessQueue`1.Dequeue" /> element from queue. Safe version which returns <c>false</c> if no element instead of throwing exception.
  /// </summary>
  /// <param name="value">first element of queue if operation succeed, default value otherwise.</param>
  /// <returns><code>true</code> if element exists and outputted in <c>value</c>.</returns>
  public bool TryDequeue(out T value);

  /// <summary>Remove and return last element from queue.</summary>
  /// <returns>Last element in queue.</returns>
  /// <exception cref="T:System.InvalidOperationException">Thrown if queue is empty.</exception>
  public T DequeueLast();

  /// <summary>
  /// Tries to <see cref="M:Eco.Shared.Collections.RandomAccessQueue`1.DequeueLast" /> element from queue. Safe version which returns <c>false</c> if no element instead of throwing exception.
  /// </summary>
  /// <param name="value">last element of queue if operation succeed, default value otherwise.</param>
  /// <returns><code>true</code> if element exists and outputted in <c>value</c>.</returns>
  public bool TryDequeueLast(out T value);

  /// <summary>Tries to Peek next element without dequeing it from the colletions.</summary>
  /// <returns><code>true</code> if collection is not empty, false otherwise</returns>
  public bool TryPeek(out T item);

  /// <summary>Tries to Peek the last element without dequeing it from the colletions.</summary>
  /// <returns><code>true</code> if collection is not empty, false otherwise</returns>
  public bool TryPeekLast(out T item);

  /// <summary>Performs search of given item in the collection.</summary>
  public bool Contains(T item);

  /// <summary>Requeue (take next element and put it back in the end of the queue) the next element and returns it</summary>
  public T Requeue();

  /// <summary>Sorts queue with <paramref name="comparer" />.</summary>
  public void Sort<TComparer>(TComparer comparer) where TComparer : IComparer<T>;

  /// <summary>
  /// Tries to get queue buffer part with items (straighten it if needed to have contiguous array). The buffer only valid until next modification operation!
  /// May be used for optimized operations on whole array (i.e. modify every item and then sort).
  /// </summary>
  public bool TryGetBuffer(out ArraySegment<T> buffer);

  /// <summary>
  /// Tries to get queue buffer part with items (straighten it if needed to have contiguous array). The buffer only valid until next modification operation!
  /// May be used for optimized operations on whole array (i.e. modify every item and then sort).
  /// </summary>
  public bool TryGetBufferSpan(out Span<T> bufferSpan);

  public void Clear();

  public RandomAccessQueue<T>.Enumerator GetEnumerator();

  IEnumerator<T> IEnumerable<T>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  object IStateSnapshotSupport.GetStateSnapshot();

  void IStateSnapshotSupport.SetStateSnapshot(object state);

  /// <summary>Zero allocation and much faster alternative to <see cref="M:System.Linq.Enumerable.Reverse``1(System.Collections.Generic.IEnumerable{``0})" />.</summary>
  public RandomAccessQueue<T>.ReverseEnumerable Reverse();

  public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
  {
    private readonly RandomAccessQueue<T> queue;
    private int index;
    private T current;

    public void Dispose();

    public bool MoveNext();

    public T Current { get; }

    object IEnumerator.Current { get; }

    void IEnumerator.Reset();
  }

  /// <summary>Reverse view of <see cref="T:Eco.Shared.Collections.RandomAccessQueue`1" />.</summary>
  public readonly struct ReverseEnumerable : IEnumerable<
  #nullable enable
  T>, IEnumerable
  {
    private readonly RandomAccessQueue<T> queue;

    public ReverseEnumerable(RandomAccessQueue<T> queue);

    IEnumerator<T> IEnumerable<T>.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator();

    public RandomAccessQueue<
    #nullable disable
    T>.ReverseEnumerator GetEnumerator();
  }

  /// <summary>Reverse enumerator of <see cref="T:Eco.Shared.Collections.RandomAccessQueue`1" />.</summary>
  public struct ReverseEnumerator : IEnumerator<
  #nullable enable
  T>, IEnumerator, IDisposable
  {
    private readonly RandomAccessQueue<T> queue;
    private int index;
    private T? current;

    public bool MoveNext();

    public T Current { get; }

    object IEnumerator.Current { get; }

    void IEnumerator.Reset();

    public void Dispose();
  }
}
