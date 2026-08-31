// Decompiled with JetBrains decompiler
// Type: Eco.Core.Agents.WorldObserver
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Core.Agents;

public abstract class WorldObserver : 
  NetEntity,
  IWorldObserver,
  INetObjectViewer,
  INotifyNetObjectDestroy,
  INetObjectPriority,
  INetObject
{
  public ThreadSafeAction OnDestroy;
  public ThreadSafeAction<INetObjectViewer> OnDestroyThis;

  public float Priority { get; }

  public double LastSentUpdateTime { get; set; }

  public MonitoredObjectsContainer MonitoredObjects { get; }

  public ViewDistance ViewDistance { get; }

  public ViewDistance ChunkViewDistance { get; }

  public ViewDistance SimulationViewDistance { get; }

  public float KeepAliveTime { get; }

  public abstract INetClient Client { get; }

  public virtual Vector3 FacingDir { get; }

  public abstract string Name { get; }

  public abstract void InfoBox(string msg);

  public int ChangedChunksSendCapacity { get; set; }

  public int NetworkObjectsCapacity { get; set; }

  public int ChunkColumnsSendCapacity { get; set; }

  public Vector3 LastCheckedPosition { get; set; }

  public float LastCheckedViewDistance { get; set; }

  public abstract bool IsAdmin();

  public abstract object ConvertToType(System.Type type);

  public abstract void Error(LocString msg);

  Vector3 IWorldObserver.Position { get; }

  public virtual bool IsInitialized { get; set; }

  public WorldObserver(string type);

  [RPC]
  public void SetViewDistance(float viewDistance);

  public void OnRemoveObject(INetObject obj);

  public void AddDestroyAction(Action action);

  public void RemoveDestroyAction(Action action);

  public void AddDestroyAction(Action<INetObjectViewer> action);

  public void RemoveDestroyAction(Action<INetObjectViewer> action);

  public void RemoveIrrelevantObjects();

  public void GetDestroyedObjects(ClientUpdate[] clientUpdates);

  public override bool IsRelevant(INetObjectViewer viewer);

  public override void Destroy();

  public virtual void SimulationInteract(
    INetObject interactor,
    WorldObserver.SimulationInteractType interactionType);

  public enum SimulationInteractType
  {
    EatFoodInHand,
  }
}
