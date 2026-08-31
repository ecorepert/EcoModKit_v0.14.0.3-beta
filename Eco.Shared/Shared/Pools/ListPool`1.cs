// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.ListPool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Pools;

public abstract class ListPool<T>
{
  public static ListPool<T> Shared { get; }

  public static ListPool<T> Create();

  public static ListPool<T> Create(int maxCapacity, int maxListsPerBucket);

  public abstract List<T> Rent(int minimumCapacity);

  /// <summary>Rents <paramref name="list" /> and promises to return it back to pool when <see cref="T:Eco.Shared.Pools.ListPool`1.ReturnPromise" /> disposed.</summary>
  public ListPool<T>.ReturnPromise RentAndPromiseToReturn(int minimumCapacity, out List<T> list);

  /// <summary>
  /// Use this with caution! If you will return list which was exceeded requested capacity then you can give an exception.
  /// </summary>
  /// <param name="list">list which was rented from pool.</param>
  public abstract void Return(List<T> list);

  /// <summary>Disposable return promise which returns <see cref="F:Eco.Shared.Pools.ListPool`1.ReturnPromise.Value" /> when disposed.</summary>
  public readonly struct ReturnPromise : IDisposable
  {
    public readonly List<T> Value;
    private readonly ListPool<T> pool;

    public ReturnPromise(ListPool<T> pool, List<T> value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose();
  }
}
