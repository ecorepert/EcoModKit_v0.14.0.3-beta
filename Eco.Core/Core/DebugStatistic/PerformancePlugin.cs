// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.PerformancePlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.DebugStatistic.Collectors;
using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.DebugStatistic;

/// <summary>Tracks potential performance problems in the server and generates a report.  Eventually we can make these reports output from the server and track them across builds.</summary>
[LocDisplayName("PerformancePlugin")]
public class PerformancePlugin : 
  Singleton<PerformancePlugin>,
  IHasDisplayTabs,
  IGUIPlugin,
  IServerPlugin,
  IInitializablePlugin,
  IThreadedPlugin,
  IShutdownablePlugin,
  IConfigurablePlugin,
  IEditablePlugin
{
  /// <summary>Configured interval times used by the PerformancePlugin. These values must be multiples of each other.</summary>
  public static readonly double[] IntervalTimes;
  public static int[] IntervalCounters;

  /// <summary> Enable/disable performance reports data collection </summary>
  public void SetCaptureData(bool enable);

  /// <summary> Flag to collect controller stats when a data is being captured or the controller stats tab is open. </summary>
  public bool CollectControllerStats { get; }

  public IEnumerable<IDisplayTab> DisplayTabs { get; }

  public void Initialize(TimedTask timer);

  public Task ShutdownAsync();

  public string GetStatus();

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  /// <summary>Registers a new metric collector with the performance plugin instance.</summary>
  /// <typeparam name="T"><seealso cref="T:Eco.Core.DebugStatistic.Collectors.IMetricCollector" /> type to instantiate/register</typeparam>
  public void AddMetricCollector<T>() where T : IMetricCollector, new();

  /// <summary></summary>
  /// <param name="type"></param>
  /// <returns></returns>
  public bool HasMetricCollector(Type type);

  /// <summary>Removes an existing metric collector instance from the performance plugin.</summary>
  /// <param name="type"><seealso cref="T:Eco.Core.DebugStatistic.Collectors.IMetricCollector" /> type to remove.</param>
  public void RemoveMetricCollector(Type type);

  /// <summary>Stores a generic key/value metric for generating reports/publishing to external sources.</summary>
  /// <param name="name">Name of the metric to store</param>
  /// <param name="value">Current value of the metric.</param>
  public void StoreValueMetric(string name, double value);

  /// <summary>Retrieves the generic key/value metric currently being stored for reports/publishing.</summary>
  /// <param name="name">Name of the metric to retrieve</param>
  /// <returns>Stored value if the metric exists. Otherwise 0.</returns>
  public double GetValueMetric(string name);

  public void StoreIntervalMetric(
    string name,
    int count,
    double ms,
    int controllerId,
    int playerId);

  /// <summary>Retrieves the currently stored metrics and metrics being tracked by our <seealso cref="T:Eco.Shared.Tools.PerformanceManager" /> instance for use in external metric publishing.</summary>
  public Dictionary<string, double> GetMonitoredMetrics();

  /// <summary>Starts our <seealso cref="T:Eco.Core.Utils.Threading.IWorker" /> instance for generating performance reports.</summary>
  public void Run();

  /// <summary> This one is exposed via API to provide the historical data of metrics.</summary>
  public string GetStoredMetrics();

  /// <summary>Returns the Controller Metrics report for displaying on the "Controller Stats" DisplayTab for the server GUI.</summary>
  public string GetControllerMetricsReport();

  /// <summary>Returns the <seealso cref="T:Eco.Shared.Tools.PerformanceManager" /> GetReport results for displaying on the "Performance Manager" DisplayTab for the server GUI.</summary>
  public string GetPerformanceManagerReport();

  /// <summary>Generates and returns the report used in the "Metrics Stats" DisplayTab for the server GUI.</summary>
  public string GetMetricsReport();

  public string GetRepeatedNotificationsReport();

  public string GetCountOfObjectsReport();

  /// <summary>Returns a string that represnets this object. Used by the Eco server to properly localize the plugin instance.</summary>
  /// <returns>Returns a string that represnets this object. </returns>
  public override string ToString();

  public string GetCategory();

  public IPluginConfig PluginConfig { get; }

  public PerformanceConfig Config { get; }
}
