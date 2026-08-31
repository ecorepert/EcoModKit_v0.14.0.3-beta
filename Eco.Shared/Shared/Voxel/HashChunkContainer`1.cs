// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.HashChunkContainer`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Voxel;

/// <summary>
/// This is an alternative class to the OctreeChunkContainer, rather than storing chunks in a tree we store them in a hash table.
/// This will use slightly more memory, but gives a faster speed lookup for single chunks, and similar speed for ranges.
/// 
/// Note: In order to get chunk level locking, rather than lock the whole container during each update, the Count may not always be correct and should only be treaded as a guide.
/// e.g. Don't use Count to create a new array, create a List instead, that way if count is wrong it wont matter as the list will auto expand itself.
/// </summary>
public sealed class HashChunkContainer<T> : IChunkContainer<T>, IDisposable where T : class, IChunk
{
  public HashChunkContainer(bool threadSafe);

  public T this[Vector3i pos] { get; set; }

  public int Count { get; }

  public void Add(Vector3i pos, T chunk);

  public T[] AsArray();

  public void Clear();

  /// <summary>Returns all non-empty chunks in the column. Starts from 0 to <paramref name="maxY" /> (exclusive).</summary>
  public int CollectColumn(Vector2i column, int maxY, Queue<T> buffer);

  /// <summary> Gets chunks at given range to the buffer, this excludes chunks at <see cref="F:Eco.Shared.Math.WorldRange.max" />. </summary>
  /// <param name="worldRange">The range to get the chunks from.</param>
  /// <param name="buffer">The buffer to load the resulting chunks collection to.</param>
  /// <returns>The count of added chunks.</returns>
  public int CollectRange(WorldRange worldRange, Queue<T> buffer);

  public void Remove(T chunk);

  public bool TryGetValue(Vector3i pos, out T chunk);

  public void Dispose();
}
