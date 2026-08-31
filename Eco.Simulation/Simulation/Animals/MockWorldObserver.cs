// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Animals.MockWorldObserver
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Networking;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Animals;

public class MockWorldObserver : IWorldObserver, INetObjectViewer, INotifyNetObjectDestroy
{
  public ViewDistance ViewDistance { get; }

  public ViewDistance ChunkViewDistance { get; }

  public ViewDistance SimulationViewDistance { get; }

  public Vector3 Position { get; set; }

  public Vector3 FacingDir { get; set; }

  public int ChangedChunksSendCapacity { get; set; }

  public int ChunkColumnsSendCapacity { get; set; }

  public Vector3 LastCheckedPosition { get; set; }

  public float LastCheckedViewDistance { get; set; }

  public bool IsInitialized { get; set; }

  public INetClient Client { get; }

  public double LastSentUpdateTime { get; set; }

  public string Name { get; }

  public int ID { get; }

  public void AddDestroyAction(Action<INetObjectViewer> action);

  public void AddDestroyAction(Action action);

  public object ConvertToType(Type type);

  public void Error(LocString msg);

  public bool IsAdmin();

  public void InfoBox(string msg);

  public void OnRemoveObject(INetObject netObject);

  public void RemoveDestroyAction(Action<INetObjectViewer> action);

  public void RemoveDestroyAction(Action action);
}
