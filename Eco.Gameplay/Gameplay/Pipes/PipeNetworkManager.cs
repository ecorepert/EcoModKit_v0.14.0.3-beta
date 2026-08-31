// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.PipeNetworkManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Gameplay.Wires;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Pipes;

/// <summary>Central registry/observer for liquid pipe networks. Mirrors <see cref="T:Eco.Gameplay.PowerGrids.PowerGridManager" />: a single worker thread drains a
/// queue of topology changes and rebuilds the connected-segment partition (union-find over the WireOutput traces), then exposes it as a "Pipe Networks" status.
/// It does NOT drive fluid movement or machine state — each producer derives its own coherent state from its downstream-capacity traversal during the object tick;
/// this manager is the network-level model (partition, multi-fluid conflict, observability) and the place a future centralized solve would hook in.</summary>
[Serialized]
public class PipeNetworkManager : 
  Singleton<PipeNetworkManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab
{
  public static AutoResetEvent OnQueuedEvent { get; }

  public static void QueueSourceAdded(WireOutput source);

  public static void QueueSourceRemoved(WireOutput source);

  public static void QueueTopologyDirty();

  public IReadOnlyList<PipeSegment> Segments { get; }

  public void Run();

  public Task ShutdownAsync();

  public string GetCategory();

  public override string ToString();

  public string GetStatus();

  public string GetDisplayText();
}
