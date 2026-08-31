// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.OctreeNode`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Voxel;

public class OctreeNode<T> : IEnumerable<
#nullable disable
T>, IEnumerable
{
  public WorldRange Bounds { get; }

  public Vector3i Position { get; }

  public OctreeNode(WorldRange bounds, Vector3i pos, T obj);

  public OctreeNode(WorldRange bounds, Vector3i pos, OctreeNode<T> child);

  /// <summary>Set the value at the specified position.</summary>
  /// <returns>True if a new value was added, false if a value was replaced.</returns>
  public bool Set(Vector3i pos, T obj);

  public bool TryGet(Vector3i pos, out T obj);

  public bool ContainsPosition(Vector3i pos);

  public T this[Vector3i pos] { get; }

  public IEnumerable<T> GetRangeEnumerable(WorldRange range);

  public IEnumerable<T> GetRangeExclusiveOfEnumerable(WorldRange range);

  public int CollectAll(Queue<T> buffer);

  public int CollectRange(WorldRange range, Queue<T> buffer);

  public int CollectRangeExclusiveOf(WorldRange range, Queue<T> buffer);

  public IEnumerator<T> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
