// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.QuadTreeNetObjectCollection
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Plugins.Networking;

public class QuadTreeNetObjectCollection : INetObjectCollection
{
  public QuadTreeNetObjectCollection(bool trackRecentObjects = true);

  public 
  #nullable disable
  INetObject this[int id] { get; }

  public int Count { get; }

  public IDictionary<int, INetObject> Objects { get; }

  public bool TryGetValue(int id, out INetObject value);

  public IEnumerable<T> GetObjectsOfType<T>();

  /// <summary> Stops object from periodic checks "IsUpdated". Exists for performance reasons. </summary>
  public void PauseSendUpdates(INetObject obj);

  /// <summary> Object starts to be checked for IsUpdated again. </summary>
  public void ResumeSendUpdates(INetObject obj);

  public void Add(INetObject netObject, int id, double time);

  public bool Remove(INetObject netObject);

  public bool Contains(int id);

  public void Clear();

  public void OnObjectMoved(INetObjectPosition obj);

  public IEnumerable<INetObject> GetObjectsWithin(Vector2 position, float range);

  public IEnumerable<T> GetObjectsWithin<T>(Vector2 position, float range) where T : INetObjectPosition;

  /// <summary> Get the objects that are relevant to us.  Objects newly added to the world are found by looking at time stamp of recently added ones.  Objects that are
  /// not new but have become relevant because of distance are returned via quadtree query, and only sought if 'full search' is checked, because its a little slower.</summary>
  public IEnumerable<INetObject> GetNewRelevantObjects(
    INetObjectViewer viewer,
    INetObjectContainer alreadyRelevant,
    bool fullSearch);

  public void CollectUpdatedObjects(INetObjectViewer viewer, List<INetObject> buffer);

  public void Initialize(Vector2 size);

  private readonly struct QueryCacheKey : IEquatable<QuadTreeNetObjectCollection.QueryCacheKey>
  {
    public QueryCacheKey(int CellX, int CellZ, int ViewDistance);

    public int CellX { get; init; }

    public int CellZ { get; init; }

    public int ViewDistance { get; init; }

    [CompilerGenerated]
    public override string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      QuadTreeNetObjectCollection.QueryCacheKey left,
      QuadTreeNetObjectCollection.QueryCacheKey right);

    [CompilerGenerated]
    public static bool operator ==(
      QuadTreeNetObjectCollection.QueryCacheKey left,
      QuadTreeNetObjectCollection.QueryCacheKey right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(QuadTreeNetObjectCollection.QueryCacheKey other);

    [CompilerGenerated]
    public void Deconstruct(out int CellX, out int CellZ, out int ViewDistance);
  }

  private class QueryCacheEntry
  {
    public List<INetObjectPosition> Results;
    public double ComputedAt;
  }
}
