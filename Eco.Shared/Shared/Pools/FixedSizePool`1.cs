// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.FixedSizePool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Pools;

/// <summary>Implementation of <see cref="T:Eco.Shared.Pools.ThreadSafeFixedSizePool`1" /> with extended functionality. Obsolete, should be replaced with <see cref="T:Eco.Shared.Pools.PoolService`1" /> when all functionality will be supported.</summary>
public class FixedSizePool<T> : IObjectPool<T> where T : class
{
  public int PoolSize { get; }

  public int Count { get; }

  public float CacheHitPercent { get; }

  public FixedSizePool(int poolSize, bool preAllocate, Func<T> elementConstructor);

  /// <summary>
  /// Returns a object from the pool or null if no objects in the pool.
  /// </summary>
  /// <returns>object from the pool or a new object.</returns>
  public T Get();

  /// <summary>Tries to add object to the pool (if enough capacity in the pool).</summary>
  public bool TryAdd(T obj);
}
