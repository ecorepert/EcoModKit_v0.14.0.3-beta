// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeQueue`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Core.Utils;

/// <summary>
/// Only use this collection when absolutely necessary when you can't use <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> instead.
/// It known to have very bad performance and memory usage for often updated big collections, because all new elements added to stack which then reversed when you need to dequeue element.
/// </summary>
[ThreadSafe]
public class ThreadSafeQueue<T> : IEnumerable<T>, IEnumerable
{
  public ThreadSafeQueue();

  public ThreadSafeQueue(IEnumerable<T> items);

  public ImmutableQueue<T> Snapshot { get; }

  public bool IsEmpty { get; }

  public T Peek();

  public void Enqueue(T item);

  public T Dequeue();

  public bool TryDequeue([MaybeNullWhen(false)] out T item);

  /// <summary>
  /// Tries to dequeue item from the <see cref="T:Eco.Core.Utils.ThreadSafeQueue`1" /> if it is matching <paramref name="predicate" />.
  /// It is atomic thread-safe alternative of sequence <code>if (!queue.IsEmpty &amp;&amp; predicate(queue.Peek())) value = queue.Dequeue();</code>
  /// </summary>
  public bool TryDequeue(Func<T, bool> predicate, [MaybeNullWhen(false)] out T item);

  public virtual void Clear();

  public IEnumerator<T> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
