// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.ObjectPoolExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Pools;

/// <summary>Extension methods for <see cref="T:Eco.Shared.Pools.IObjectPool`1" /> instances.</summary>
public static class ObjectPoolExtensions
{
  /// <summary>
  /// Wraps <paramref name="pool" /> with <see cref="T:Eco.Shared.Pools.PoolService`1" /> with default constructor for new pool elements and optional <paramref name="onReturn" /> cleanup method.
  /// With this factory method <code><![CDATA[new PoolService<MyClass>(new MyPool<MyClass>(), () => new MyClass(), onReturn)]]></code> can be rewritten as <code><![CDATA[new MyPool<MyClass>().AsService(onReturn)]]></code>.
  /// </summary>
  public static PoolService<T> AsService<T>(this IObjectPool<T> pool, Action<T>? onReturn = null) where T : class, new();

  /// <summary>
  /// Wraps <paramref name="pool" /> with <see cref="T:Eco.Shared.Pools.PoolService`1" /> with <paramref name="factory" /> for new pool elements and optional <paramref name="onReturn" /> cleanup method.
  /// With this factory method <code><![CDATA[new PoolService<MyClass>(new MyPool<MyClass>(), () => new MyClass("abc"))]]></code> can be rewritten as <code><![CDATA[new MyPool<MyClass>().AsService(() => new MyClass("abc"))]]></code>.
  /// </summary>
  public static PoolService<T> AsService<T>(
    this IObjectPool<T> pool,
    Func<T> factory,
    Action<T>? onReturn = null)
    where T : class;
}
