// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.WorldLayerManager
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Simulation.Types;
using Eco.Simulation.WorldLayers.Layers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Simulation.WorldLayers;

[LocDisplayName("WorldLayerManager")]
[Priority(-2)]
public sealed class WorldLayerManager : 
  Singleton<
  #nullable disable
  WorldLayerManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  ICustomUIPlugin,
  ISaveablePlugin,
  IInitializablePlugin,
  IController,
  IViewController,
  IHasUniversalID
{
  public readonly ThreadSafeAction<INetClient, WorldLayer> OnWorldLayerQueried;
  public Dictionary<Type, List<WorldLayerSettings>> TypeToSettings;
  public Dictionary<string, WorldLayerSettings> NameToSettings;
  public BufferPollutionCache BufferPollutionCache;
  public DebrisCache DebrisCache;
  public bool LogTicks;
  public double WorldLayerTickTime;
  public WorldLayerManager.LayerInitOperation Initializing;
  public WorldLayer HeightLayer;

  [SyncToView(null, true)]
  [Notify]
  public Dictionary<string, WorldLayer> VisibleLayers { get; }

  [SyncToView(null, true)]
  [Notify]
  public Dictionary<string, WorldLayer> BiomeLayers { get; }

  public IEnumerable<WorldLayer> Layers { get; }

  public Dictionary<Species, SpeciesLayer> SpeciesToLayers { get; }

  public IEnumerable<WorldLayerSettings> Settings { get; }

  [SyncToView(null, true)]
  public ClimateState Climate { get; }

  public double LastTickTime { get; }

  /// <summary> Special flag to recache web layers. For performance reasons. </summary>
  public bool WebLayersDirty { get; set; }

  public bool Enabled { get; }

  public double NextTick { get; }

  public int Ticks { get; }

  public int DesiredTicks { get; }

  public double LastTickedRealTime { get; }

  public bool FastForwardTicking { get; set; }

  public double DaysPerTick { get; }

  public ThreadSafeAction OnInited { get; }

  public ThreadSafeAction OnTicked { get; }

  public ClimateSim ClimateSim { get; }

  public WorldLayer GetLayer(string layerName);

  public void AddLayer(WorldLayer layer);

  public void RemoveLayer(string layerName);

  public void RemoveLayer(WorldLayer layer);

  public void Initialize(TimedTask timer);

  public void Reset();

  public void Regenerate();

  /// <summary> Sets layer visibility and triggers proper on changed events. So it will be reflected to web and client </summary>
  public void UpdateLayerVisibility(WorldLayer layer, bool value);

  public void UpdateLayerVisibility(WorldLayerSettings layer, bool value);

  public void ForceTick();

  public void Tick();

  /// <summary> Sets the PushPullActive state for a layer, enabling or disabling its activity. </summary>
  public void SetLayerPushPullActive(string layerName, bool pushActive);

  public float PercentHeight(Vector2i pos);

  public LocString DescribePos(Vector2i pos);

  public override string ToString();

  [RPC]
  public void NotificateLayerPick(INetClient client, string layerName);

  public void Run();

  public TimeSpan DoWork();

  public IEnumerable<WorldLayer> SortedDisplayLayers { get; }

  public string GetCategory();

  public string GetStatus();

  public Task ShutdownAsync();

  public string GetDisplayText();

  public object GetCustomUIControl();

  public string GetCustomUIName();

  public void SaveAll();

  ref int IHasUniversalID.ControllerID { get; }

  [Localized(true, false, "", false)]
  private class TickSample : ITickSample
  {
    public double TimeTotal { get; set; }

    public double TickTime { get; set; }

    public double CallbacksTime { get; set; }
  }

  public enum LayerInitOperation
  {
    None,
    LoadExisting,
    MigrateVersion,
    PostWorldgen,
  }
}
