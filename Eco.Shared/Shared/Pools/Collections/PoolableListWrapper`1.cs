// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.Collections.PoolableListWrapper`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Pools.Collections;

public class PoolableListWrapper<T>
{
  public PoolableListWrapper();

  public PoolableListWrapper(ListPool<T> pool);

  /// <summary>
  /// Returns unsafe list snapshot which may be directly accessed with <see cref="T:System.Collections.Generic.List`1" /> API.
  /// This list only safe to use before any modification operation like <see cref="M:Eco.Shared.Pools.Collections.PoolableListWrapper`1.Clear" /> etc.
  /// Also you should guarantee this list won't exceed current <see cref="P:System.Collections.Generic.List`1.Capacity" /> otherwise it may lead to unexpected behavior (including exceptions).
  /// </summary>
  /// <returns>Current snapshot reference. It may be null if Capacity == 0.</returns>
  public List<T>? GetUnsafeListSnapshot();

  /// <summary>
  /// Returns current list snapshot and clear poolable list wrapper.
  /// </summary>
  /// <returns>Current snapshot. It may be null if Capacity == 0.</returns>
  public List<T>? RentSnapshotAndClear();

  /// <summary>
  /// Outputs current list snapshot in <paramref name="snapshot" /> and clear poolable list wrapper. Returns a promise which should be disposed to return a list back to pool.
  /// </summary>
  public ListPool<T>.ReturnPromise? RentSnapshotAndClear(out List<T>? snapshot);

  /// <summary>
  /// Return previously rented snapshot (see <see cref="M:Eco.Shared.Pools.Collections.PoolableListWrapper`1.RentSnapshotAndClear" />).
  /// This method is thread-safe. Usual case you rent list in thread-unsafe content and then return it in another thread.
  /// </summary>
  public void ReturnSnapshot(List<T> snapshot);

  /// <summary>
  /// Same as <see cref="M:Eco.Shared.Pools.Collections.PoolableListWrapper`1.GetUnsafeListSnapshot" />, but ensures required capacity.
  /// </summary>
  /// <param name="minimalCapacity">minimal required capacity for snapshot.</param>
  /// <returns>Current snapshot reference. It may be null if Capacity == 0.</returns>
  public List<T>? GetUnsafeListSnapshot(int minimalCapacity);

  public int Count { get; }

  public void Add(T item);

  public bool Contains(T item);

  public bool Remove(T item);

  public void AddRange(ICollection<T> range);

  public List<T>.Enumerator GetEnumerator();

  public void Clear();
}
