// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeLimitedHistory`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>
/// Limited size history which automatically ejects old elements when more than N elements added.
/// New elements added to top of the history (as most recent) and will be returned first while enumeration.
/// Elements can't be directly removed from history one by one, but you can <see cref="M:Eco.Core.Utils.ThreadSafeLimitedHistory`1.Clear" /> whole history.
/// </summary>
[ThreadSafe]
[SerializedAsEnumerable]
public class ThreadSafeLimitedHistory<T> : 
  IEnumerable<T>,
  IEnumerable,
  ISnapshotable<T>,
  ISnapshotable
{
  public ThreadSafeLimitedHistory(int size);

  public int Count { get; }

  /// <summary>Adds new <paramref name="element" /> and ejects any elements which is behind <see cref="F:Eco.Core.Utils.ThreadSafeLimitedHistory`1.size" />.</summary>
  public void Add(T element);

  public void Clear();

  /// <summary>Returns elements in order they was added. If you need to get most recent elements first then you need to use Reverse function.</summary>
  public IEnumerator<T> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public ICollection<T> Snapshot { get; }

  ICollection ISnapshotable.Snapshot { get; }
}
