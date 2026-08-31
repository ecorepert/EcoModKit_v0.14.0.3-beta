// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pools.ThreadUnsafePool`1
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
/// Thread-unsafe lock free <see cref="T:System.Collections.Generic.Stack`1" /> based pool implementation. It implements <see cref="T:Eco.Shared.Pools.IObjectPool`1" /> interface and has unlimited pool size.
/// You should prefer it to use over thread-safe pool implementations where you're sure it won't be used from multiple threads (in example in Unity components).
/// </summary>
public class ThreadUnsafePool<T> : IObjectPool<T>, IEnumerable<T>, IEnumerable where T : class
{
  public int Count { get; }

  public T? Get();

  public bool TryAdd(T obj);

  IEnumerator<T> IEnumerable<T>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public Stack<T>.Enumerator GetEnumerator();

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public void CheckIsDuplicated(T obj);
}
