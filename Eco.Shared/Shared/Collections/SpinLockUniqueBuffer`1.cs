// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.SpinLockUniqueBuffer`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Collections;

/// <summary>
/// Unique thread-safe buffer for cases when multiple copies of same item may be added.
/// It is optimized for scenarios with one or more producers and a single consumer.
/// In such cases buffer returned from <see cref="M:Eco.Shared.Collections.SpinLockUniqueBuffer`1.Flush" /> may be returned with <see cref="M:Eco.Shared.Collections.SpinLockUniqueBuffer`1.ReturnSet(System.Collections.Generic.HashSet{`0})" /> and reused (avoiding allocations).
/// If multiple <see cref="M:Eco.Shared.Collections.SpinLockUniqueBuffer`1.ReturnSet(System.Collections.Generic.HashSet{`0})" /> used then it will only use first buffer.
/// </summary>
public class SpinLockUniqueBuffer<T>
{
  /// <summary>Add an <paramref name="item" /> to buffer.</summary>
  public bool Add(T item);

  /// <summary>Remove an item from buffer.</summary>
  public bool Remove(T item);

  /// <summary>Flushes buffer as set (which may be null if buffer is empty).</summary>
  public HashSet<T>? Flush();

  /// <summary>Returns a set flushed with <see cref="M:Eco.Shared.Collections.SpinLockUniqueBuffer`1.Flush" /> for reusing.</summary>
  public void ReturnSet(HashSet<T> flushedSet);

  /// <summary>Same as <see cref="M:Eco.Shared.Collections.SpinLockUniqueBuffer`1.Flush" /> and then <see cref="M:Eco.Shared.Collections.SpinLockUniqueBuffer`1.ReturnSet(System.Collections.Generic.HashSet{`0})" /> when promise disposed.</summary>
  public SpinLockUniqueBuffer<
  #nullable disable
  T>.ReturnPromise FlushAndPromiseToReturn(out 
  #nullable enable
  HashSet<T>? set);

  /// <summary>Flushed buffer return promise for disposable patterns.</summary>
  public readonly struct ReturnPromise : IDisposable
  {
    private readonly SpinLockUniqueBuffer<T> buffer;
    private readonly HashSet<T>? set;

    public ReturnPromise(SpinLockUniqueBuffer<T> buffer, HashSet<T>? set);

    public void Dispose();
  }
}
