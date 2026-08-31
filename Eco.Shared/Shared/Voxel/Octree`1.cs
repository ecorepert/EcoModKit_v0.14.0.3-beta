// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.Octree`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Utils;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Voxel;

/// <summary>Implements a cubic Octree.</summary>
/// <remarks>
/// An octree implemented over cubes indexed by integer values.  The tree will automatically grow to accommodate
/// any added entries.  Optionally thread-safe.  Where ranges are used, they are interpreted as [min,max).
/// </remarks>
/// <typeparam name="T">The type of data to store in the tree.</typeparam>
public class Octree<T> : IEnumerable<T>, IEnumerable, IDisposable where T : class
{
  public Octree(bool threadSafe = false);

  public void Set(Vector3i pos, T obj);

  public bool TryGetValue(Vector3i pos, out T obj);

  public DisposableUtils.DisposableActionEnumerator<T> GetEnumerator();

  IEnumerator<T> IEnumerable<T>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public DisposableUtils.DisposableActionEnumerable<T> GetRangeEnumerable(WorldRange range);

  public DisposableUtils.DisposableActionEnumerable<T> GetRangeExclusiveOfEnumerable(
    WorldRange range);

  public int CollectAll(Queue<T> buffer);

  public int CollectRange(WorldRange range, Queue<T> buffer);

  public int CollectRangeExclusiveOf(WorldRange range, Queue<T> buffer);

  public T[] AsArray();

  public void Clear();

  public T this[Vector3i pos] { get; set; }

  public int Count { get; }

  public WorldRange Extents { get; }

  public bool IsThreadSafe { get; }

  protected virtual void Dispose(bool disposing);

  public void Dispose();
}
