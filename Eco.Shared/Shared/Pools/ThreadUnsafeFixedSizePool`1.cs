// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

#nullable enable
namespace Eco.Shared.Pools;

/// <summary>
/// Thread-unsafe lock free <see cref="T:System.Collections.Generic.Stack`1" /> based pool implementation. It implements <see cref="T:Eco.Shared.Pools.IObjectPool`1" /> interface and has fixed pool size.
/// You should prefer it to use over thread-safe pool implementations where you're sure it won't be used from multiple threads (in example in Unity components).
/// </summary>
public class ThreadUnsafeFixedSizePool<T> : IObjectPool<T>, IEnumerable<T>, IEnumerable where T : class
{
  /// <summary>
  /// Max number of elements in pool.
  /// It actually may be less than actual number of elements if <see cref="P:Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1.MaxSize" /> was reduced when <see cref="P:Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1.Count" /> &gt; <see cref="P:Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1.MaxSize" />.
  /// In this case it will not add objects with <see cref="M:Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1.TryAdd(`0)" /> until <see cref="P:Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1.Count" /> go below <see cref="P:Eco.Shared.Pools.ThreadUnsafeFixedSizePool`1.MaxSize" />.
  /// </summary>
  public int MaxSize { get; set; }

  public int Count { get; }

  public ThreadUnsafeFixedSizePool(int maxSize);

  public T? Get();

  public bool TryAdd(T obj);

  public void Clear();

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public void CheckIsDuplicated(T obj);

  IEnumerator<T> IEnumerable<T>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public Stack<T>.Enumerator GetEnumerator();
}
