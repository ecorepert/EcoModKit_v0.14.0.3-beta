// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.PoolService`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Pools;

/// <summary>
/// <see cref="T:Eco.Shared.Pools.IObjectPool`1" /> manager which simplifies pool usage, adding methods for automatic objects creation and cleaning up when returned to pool.
/// When <see cref="T:Eco.Shared.Pools.PoolService`1" /> created you should provide <see cref="F:Eco.Shared.Pools.PoolService`1.factory" /> method for new object instantiation (if pool is empty) and optionally
/// <see cref="F:Eco.Shared.Pools.PoolService`1.onReturn" /> method which will be called on an object when it returned (added) to pool.
/// </summary>
public class PoolService<T> where T : class
{
  public PoolService(IObjectPool<T> pool, Func<T> factory, Action<T>? onReturn = null);

  /// <summary> Rents object from pool or creates new instance using <see cref="F:Eco.Shared.Pools.PoolService`1.factory" />. </summary>
  public T Rent();

  /// <summary>
  /// Returns (add) <paramref name="value" /> to the pool. If <see cref="F:Eco.Shared.Pools.PoolService`1.onReturn" /> method was provided then it will be called on <paramref name="value" /> <b>before</b> adding to pool.
  /// Also it may fail to add <paramref name="value" /> to <see cref="F:Eco.Shared.Pools.PoolService`1.pool" /> (in example if <see cref="F:Eco.Shared.Pools.PoolService`1.pool" /> is fixed size and already full).
  /// In this case <see cref="F:Eco.Shared.Pools.PoolService`1.onReturn" /> will be called anyway, but method return <c>false</c>. It returns <c>true</c> if object was actually added to pool, you can check return value for final object cleanup.
  /// </summary>
  public bool Return(T value);

  /// <summary>
  /// <c>using</c> operator friendly <see cref="M:Eco.Shared.Pools.PoolService`1.Rent" />.
  /// One of common cases is when you need to rent an object only for scope of the function and then return it by the end of the function like:
  /// <code>
  /// void MyFunc()
  /// {
  ///     var obj = poolService.Rent();
  ///     try
  ///     {
  ///         DoSomethingWithObject(obj);
  ///     }
  ///     finally
  ///     {
  ///         poolService.Return(obj);
  ///     }
  /// }
  /// </code>
  /// This method let you optimize a layout and don't care about <c>Return</c> by the end of function like:
  /// <code>
  /// void MyFunc()
  /// {
  ///     using var promise = poolService.RentAndPromiseToReturn(out var obj);
  ///     DoSomethingWithObject(obj);
  /// }
  /// </code>
  /// or
  /// <code>
  /// void MyFunc()
  /// {
  ///     using (poolService.RentAndPromiseToReturn(out var obj))
  ///         DoSomethingWithObject(obj);
  /// }
  /// </code>
  /// </summary>
  public PoolService<
  #nullable disable
  T>.ReturnPromise RentAndPromiseToReturn(out 
  #nullable enable
  T value);

  public readonly struct ReturnPromise : IDisposable
  {
    private readonly PoolService<T> service;
    private readonly T value;

    public ReturnPromise(PoolService<T> service, T value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose();
  }
}
