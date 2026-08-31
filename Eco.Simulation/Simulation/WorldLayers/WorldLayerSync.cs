// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.WorldLayerSync
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Simulation.WorldLayers.Layers;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public class WorldLayerSync : AutoSingleton<WorldLayerSync>
{
  public ThreadSafeAction PreTickActions;
  public bool Inited;

  public PluginTickTimer<WorldLayerSync.TickSample> Timer { get; }

  public void Reset();

  public void OnServerStart();

  public void Tick();

  /// <summary>Recalculates the totals for a specific world layer and notifies subscribers. Tick code uses layer.UpdateLayerTotals directly; RecordModifiedLayers handles tick notifications.</summary>
  public static void UpdateLayerTotals(WorldLayer layer);

  [Localized(true, false, "", false)]
  public class TickSample : ITickSample
  {
    public double TimeTotal { get; set; }

    public double PreTick { get; set; }

    public double PreTickActions { get; set; }

    public double PostTick { get; set; }

    public double Climate { get; set; }

    public double RecordHistory { get; set; }

    public double Pull { get; set; }

    public double Push { get; set; }
  }
}
