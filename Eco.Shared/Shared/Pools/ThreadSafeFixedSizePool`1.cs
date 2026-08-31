// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.ThreadSafeFixedSizePool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Diagnostics;

#nullable enable
namespace Eco.Shared.Pools;

/// <summary>
/// Fixed Size Pool used to avoid any extra-GC allocations, unless requesting more items from pool than are available.
/// It uses circular buffer where
/// `tail` points to first element which will be retrieved from pool on request (read position)
/// `head` points to next write position which will be used for returning element to pool (write position)
/// when `head` == `tail` then buffer is empty
/// when `head` == `tail - 1` then buffer is full
/// we're using `poolSize + 1` for capacity to maintain full buffer scenario, because otherwise we can have two situations when write position == read position (empty and full).
/// 
/// Performance:
/// ~2x faster in concurrent environment than basic Stack based pool implementation with lock
/// ~10% faster in single-thread environment than basic Stack based pool implementation with lock.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ThreadSafeFixedSizePool<T> : IObjectPool<T> where T : class
{
  public const int MaxPoolSize = 65533;

  /// <summary>Max number of elements in the pool.</summary>
  public int MaxSize { get; }

  public int Count { get; }

  public ThreadSafeFixedSizePool(int poolSize, bool ensureReturnFromSameThread = false);

  /// <summary>
  /// Returns a object from the pool or null if no objects in the pool.
  /// </summary>
  /// <returns>object from the pool or a new object.</returns>
  public T? Get();

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public void CheckDuplicates(T obj, long writePos);

  /// <summary>
  /// Tries to add object to the pool (if enough capacity in the pool).
  /// </summary>
  /// <param name="obj"></param>
  public bool TryAdd(T obj);

  /// <summary>Clears cache.</summary>
  public void Clear();
}
