// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.SpinLockBuffer`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Pools;
using Eco.Shared.Pools.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>A buffer that uses a SpinLock for locking</summary>
public class SpinLockBuffer<T>
{
  protected readonly PoolableListWrapper<T> Buffer;

  /// <summary>Add an item to the internal buffer.</summary>
  public void Add(T item);

  public void AddRange(ICollection<T> items);

  /// <summary>
  /// Copy the contents to the given list then clear the internal buffer.
  /// </summary>
  public void FlushTo(List<T> list);

  /// <summary>
  /// Copy the contents to the given list then clear the internal buffer.
  /// </summary>
  public void FlushTo(PoolableListWrapper<T> list);

  /// <summary>
  /// Copy the contents to the given queue then clear the internal buffer.
  /// </summary>
  public void FlushTo(Queue<T> queue);

  /// <summary>
  /// Copy the contents to the given set then clear the internal buffer.
  /// </summary>
  public void FlushTo(HashSet<T> set);

  /// <summary>
  /// Flushes buffer content and outputs it as <paramref name="snapshot" />.
  /// Returns a promise which should be disposed to return <paramref name="snapshot" /> back to pool.
  /// </summary>
  public ListPool<T>.ReturnPromise? FlushToSnapshotAndPromiseToReturn(out List<T>? snapshot);

  /// <summary>Returns snapshot of buffer and clears it.</summary>
  protected List<T>? GetSnapshotAndClear();

  /// <summary>Clear the internal buffer.</summary>
  public void Clear();
}
