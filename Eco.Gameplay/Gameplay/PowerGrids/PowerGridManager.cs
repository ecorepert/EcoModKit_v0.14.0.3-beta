// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.PowerGrids.PowerGridManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using ConcurrentCollections;
using Eco.Core.Plugins.Interfaces;
using Eco.Gameplay.Components;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.PowerGrids;

/// <summary>A central manager for all power grids. It is responsible for handling changes in power grid structure and for ticking all power grids.</summary>
[Serialized]
public class PowerGridManager : 
  Singleton<
  #nullable disable
  PowerGridManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab
{
  public static AutoResetEvent OnQueuedEvent { get; }

  public static void QueueComponentAdded(PowerGridComponent component);

  public static void QueueComponentRemoved(PowerGridComponent component);

  public ConcurrentHashSet<PowerGrid> PowerGrids { get; }

  public void Run();

  public Task ShutdownAsync();

  public string GetCategory();

  public override string ToString();

  public string GetStatus();

  public string GetDisplayText();
}
