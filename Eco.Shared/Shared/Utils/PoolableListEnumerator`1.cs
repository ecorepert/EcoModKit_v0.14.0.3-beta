// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.PoolableListEnumerator`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Pools.Collections;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> This allows to iterate through list with return to the pool after end.
/// Uesfull for iterations over not-thread-safe collections in multithread environment. It will create a copy of collection by using lock and pooled list and it will automaticly return the list after Dispose is called. </summary>
public struct PoolableListEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
{
  private PoolableListWrapper<T> list;
  private List<T>.Enumerator enumerator;

  public T Current { get; }

  object IEnumerator.Current { get; }

  public static PoolableListEnumerator<T> Create<TContext, TContext2, TContext3>(
    TContext context,
    TContext2 context2,
    TContext3 context3,
    Action<TContext, TContext2, TContext3, PoolableListWrapper<T>> listBuilder);

  public bool MoveNext();

  public void Dispose();

  public void Reset();
}
