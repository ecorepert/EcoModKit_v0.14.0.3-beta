// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetObjectManager
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable
namespace Eco.Shared.Networking;

public class NetObjectManager : INetObjectManager
{
  public const int MaxNewObjectsPerUpdate = 120;
  public const int RefillObjectsPerUpdate = 120;
  public const int BaselineObjectsBurst = 30;
  public const 
  #nullable disable
  string NewObjectsKey = "newObjs";
  public const string DestroyedObjectsKey = "destroyed";
  public const string UpdatedObjectsKey = "objs";
  public Func<int, BSONObject, INetObject> OnNewNetworkObject;
  public Action<int> OnRemoveNetworkObject;

  public static NetObjectManager Default { get; set; }

  public Func<INetObjectViewer, object, BSONValue, BSONValue> PrepareNetworkTrafficPayload { get; set; }

  public int NumObjects { get; }

  public void OnObjectMoved(INetObjectPosition obj);

  public IEnumerable<INetObject> GetObjectsWithin(Vector2 position, float range);

  public IEnumerable<T> GetObjectsWithin<T>(Vector2 position, float range) where T : INetObjectPosition;

  public IEnumerable<INetObject> GetObjectsWithin(WrappedPosition3 position, float range);

  public T GetObject<T>(int id) where T : class;

  public IEnumerable<T> GetNetObjectsOfType<T>();

  public INetObject GetNetObject(int id);

  public bool TryGetNetObject(int id, out INetObject obj);

  public NetObjectManager(
    INetObjectViewerCollection viewerCollection = null,
    INetObjectCollection collection = null,
    bool allowNewObjects = true);

  public void ResumeSendUpdates(INetObject obj);

  public void PauseSendUpdates(INetObject obj);

  public void Clear();

  public int GetNextID();

  public void Add(INetObject netObj, int id);

  public void Remove(INetObject netObject);

  public void HandleNewObject(BSONObject bsonObj);

  public void HandleUpdateObject(BSONObject bsonObj);

  public void HandleDestroyObject(int id);

  public void UpdateObjects(BSONObject bsonRoot);

  public BSONArray GetUpdatedObjects(INetObjectViewer viewer = null);

  public IEnumerable<INetObject> GetNewRelevantObjects(
    INetObjectViewer viewer,
    INetObjectContainer alreadyRelevant,
    bool fullSearch);

  public void GetObjectUpdates(
    IEnumerable<INetObject> objects,
    INetObjectViewer viewer,
    ClientUpdate[] clientUpdates);

  public void GetInitialObjectStates(
    IEnumerable<INetObject> newObjects,
    INetObjectViewer viewer,
    INetObjectContainer monitored,
    ClientUpdate[] clientUpdates);

  public void ForEachViewer(Action<INetObjectViewer> action);

  /// <summary> Collect stats about existing network objects in <see cref="T:Eco.Shared.Networking.NetObjectManager" />. May be used for statistic and leaks detection. </summary>
  public IEnumerable<IGrouping<string, INetObject>> CollectObjectStats();
}
