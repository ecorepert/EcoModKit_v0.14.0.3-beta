// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.IChunkContainer`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Voxel;

public interface IChunkContainer<T>
{
  T[] AsArray();

  void Add(Vector3i pos, T chunk);

  void Remove(T chunk);

  void Clear();

  bool TryGetValue(Vector3i pos, out T chunk);

  T this[Vector3i pos] { get; set; }

  int CollectRange(WorldRange worldRange, Queue<T> buffer);

  /// <summary>Collects all chunks in <paramref name="column" /> bounded by <paramref name="maxY" />.</summary>
  int CollectColumn(Vector2i column, int maxY, Queue<T> buffer);

  int Count { get; }
}
