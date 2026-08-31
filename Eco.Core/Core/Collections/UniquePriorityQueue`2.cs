// Decompiled with JetBrains decompiler
// Type: Eco.Core.Collections.UniquePriorityQueue`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Priority_Queue;
using System;

#nullable disable
namespace Eco.Core.Collections;

/// <summary> Thread-unsafe Unique Priority Queue implementation. It only allows to put non-null unique elements. </summary>
public class UniquePriorityQueue<TItem, TPriority> where TPriority : IComparable<TPriority>
{
  /// <summary> Enqueues new item with given priority. Item ignored if already present in queue and method returns false in this case. </summary>
  public bool EnqueueUnique(TItem item, TPriority priority);

  /// <summary> Tries to dequeue item from the queue (if any). Returns <c>true</c> and item with it's priority as output parameters. <c>false</c> otherwise. </summary>
  public bool TryDequeue(out TItem item, out TPriority priority);

  /// <summary> Clears whole queue. </summary>
  public void Clear();

  private class BasicNode : GenericPriorityQueueNode<TPriority>
  {
    public TItem Data { get; }

    public BasicNode(TItem data);
  }
}
