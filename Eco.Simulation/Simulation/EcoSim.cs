// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.EcoSim
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Simulation.Settings;
using Eco.Simulation.Types;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Simulation;

[LocDisplayName("EcoSim")]
[Worker(ThreadPriority = ThreadPriority.BelowNormal, Repeatable = true)]
public class EcoSim : 
  Singleton<
  #nullable disable
  EcoSim>,
  IWorkerPlugin,
  IServerPlugin,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IDisplayablePlugin,
  IHasDisplayTabs,
  IDisplayTab,
  ISaveablePlugin,
  IInitializablePlugin
{
  public static ThreadSafeAction OnParamsUpdated;
  public const float SecondsPerCollection = 600f;
  public static float BaseSkillGainRate;
  public static List<Species> AllSpecies;
  public static Dictionary<string, Species> NameToSpecies;
  public bool ForceCollectStatsNow;

  public EcoDef EcoDef { get; }

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public static PlantSim PlantSim { get; }

  public static AnimalSim AnimalSim { get; }

  public static Species GetSpecies(string name);

  public static void AddSpecies(IEnumerable<Species> list);

  /// <summary>
  /// Creates temporary EcoSim singleton only with configuration. Intention is primary for unit testing.
  /// </summary>
  /// <param name="ecoDef">EcoDef config.</param>
  /// <param name="action">action to be executed with TempEcoSim.</param>
  public static void WithTempEcoSim(EcoDef ecoDef, Action action);

  public void Initialize(TimedTask timer);

  public void ParametersUpdated();

  public void Clear();

  public static void MarkDirty();

  public void Regenerate();

  public Task DoWork(CancellationToken token);

  public int DoTick(EcoSim.TickSample tick);

  public void CollectStats();

  public void UpdateCollectionTime();

  public string GetCategory();

  public string GetStatus();

  public override string ToString();

  public string GetDisplayText();

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public void SaveAll();

  [Localized(true, false, "", false)]
  public class TickSample : ITickSample
  {
    public double TimeTotal { get; set; }

    public double TimeSimulations { get; set; }

    public double TimePredators { get; set; }

    public double TimeStatisticsCollection { get; set; }

    public double TimePlantDecay { get; set; }
  }
}
