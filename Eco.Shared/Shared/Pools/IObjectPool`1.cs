// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.IObjectPool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Pools;

/// <summary> Minimal Pool interface. If you wanna to have more advanced pool management you can use <see cref="T:Eco.Shared.Pools.PoolService`1" />. </summary>
public interface IObjectPool<T> where T : class
{
  /// <summary> Current number of elements in pool. </summary>
  int Count { get; }

  /// <summary> Returns object from pool (if any) or <c>null</c> if pool is empty. It doesn't create new instance. </summary>
  T? Get();

  /// <summary> Tries to add <paramref name="obj" /> to pool. If succeed then it returns <c>true</c>, otherwise (if pool is full or object is incompatible with pool) it will return <c>false</c>. You can handle return value for final object cleanup. </summary>
  bool TryAdd(T obj);
}
