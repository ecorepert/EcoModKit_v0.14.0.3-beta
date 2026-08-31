// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.DefaultNetObjectCollection
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Networking;

public class DefaultNetObjectCollection : INetObjectCollection
{
  public IDictionary<int, INetObject> Objects { get; }

  public INetObject this[int id] { get; }

  public int Count { get; }

  public bool TryGetValue(int id, out INetObject value);

  public IEnumerable<T> GetObjectsOfType<T>();

  public void Add(INetObject netObject, int id, double time);

  public bool Remove(INetObject netObject);

  public bool Contains(int id);

  public void Clear();

  public void OnObjectMoved(INetObjectPosition obj);

  public IEnumerable<INetObject> GetObjectsWithin(Vector2 position, float range);

  public IEnumerable<T> GetObjectsWithin<T>(Vector2 position, float range) where T : INetObjectPosition;

  public IEnumerable<INetObject> GetNewRelevantObjects(
    INetObjectViewer viewer,
    INetObjectContainer alreadyRelevant,
    bool fullSearch);

  public void CollectUpdatedObjects(INetObjectViewer viewer, List<INetObject> buffer);

  /// <summary> Enables periodical updates for object </summary>
  public void ResumeSendUpdates(INetObject netObject);

  /// <summary> Disables periodical updates for object </summary>
  public void PauseSendUpdates(INetObject netObject);
}
