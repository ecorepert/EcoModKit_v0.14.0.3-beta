// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.QuadTreePerType
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Plugins.Networking;

public class QuadTreePerType : INetObjectCollection
{
  public INetObject this[int id] { get; }

  public IDictionary<int, INetObject> Objects { get; }

  public int Count { get; }

  public void Add(INetObject netObject, int id, double time);

  /// <summary> Stop sending of updates for Obj </summary>
  public void PauseSendUpdates(INetObject obj);

  /// <summary> Starts again sending of updates for Obj </summary>
  public void ResumeSendUpdates(INetObject obj);

  /// <summary> Each type will generate its own tree. It will allow to make faster search by type, such as IPrey.  </summary>
  public QuadTreePerType(params Type[] types);

  public void Clear();

  public void CollectUpdatedObjects(INetObjectViewer viewer, List<INetObject> buffer);

  public bool Contains(int id);

  public IEnumerable<INetObject> GetNewRelevantObjects(
    INetObjectViewer viewer,
    INetObjectContainer alreadyRelevant,
    bool fullSearch);

  public IEnumerable<T> GetObjectsOfType<T>();

  public void Initialize(Vector2 size);

  public IEnumerable<INetObject> GetObjectsWithin(Vector2 position, float range);

  public IEnumerable<T> GetObjectsWithin<T>(Vector2 position, float range) where T : INetObjectPosition;

  public void OnObjectMoved(INetObjectPosition obj);

  public bool Remove(INetObject netObject);

  public bool TryGetValue(int id, out INetObject value);
}
