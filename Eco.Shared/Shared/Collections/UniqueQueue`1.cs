// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.UniqueQueue`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Collections;

/// <summary>Thread-unsafe Unique Queue implementation. It only allows enqueueing unique elements. Duplicate elements are ignored.</summary>
public class UniqueQueue<TItem> : IEnumerable<TItem>, IEnumerable
{
  public int Count { get; }

  /// <summary>Enqueue new item. Item is ignored if already present in queue, and method returns false if that is the case.</summary>
  public bool TryEnqueue(TItem item);

  public TItem Dequeue();

  public TItem Peek();

  public bool TryDequeue(out TItem item);

  public void Clear();

  public IEnumerator<TItem> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public void Add(TItem item);
}
