// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.INetObjectCollection
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Networking;

public interface INetObjectCollection
{
  IDictionary<int, INetObject> Objects { get; }

  int Count { get; }

  INetObject this[int id] { get; }

  bool TryGetValue(int id, out INetObject value);

  IEnumerable<T> GetObjectsOfType<T>();

  void ResumeSendUpdates(INetObject netObject);

  void PauseSendUpdates(INetObject netObject);

  void Add(INetObject netObject, int id, double time);

  bool Remove(INetObject netObject);

  bool Contains(int id);

  void Clear();

  void OnObjectMoved(INetObjectPosition obj);

  IEnumerable<INetObject> GetObjectsWithin(Vector2 position, float range);

  IEnumerable<T> GetObjectsWithin<T>(Vector2 position, float range) where T : INetObjectPosition;

  IEnumerable<INetObject> GetNewRelevantObjects(
    INetObjectViewer viewer,
    INetObjectContainer alreadyRelevant,
    bool fullSearch);

  void CollectUpdatedObjects(INetObjectViewer viewer, List<INetObject> buffer);
}
