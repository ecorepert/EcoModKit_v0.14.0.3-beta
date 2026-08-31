// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.PerformanceConfig
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Core.DebugStatistic;

[Localized(true, false, "", false)]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class PerformanceConfig : IController, IViewController, IHasUniversalID
{
  [LocDescription("Maximum number of tooltip parts stored in server's cache. Lowering this number can reduce RAM usage, but may impact response time for user's tooltip requests. Changing this setting will take effect after server restart.")]
  public int MaxTooltipCacheSize { get; set; }

  [LocDescription("Count of reports to be saved and exposed via api. Reports are generated each minute. 0 to not save any history. ")]
  public int CountOfLastReportsToSave { get; set; }

  [LocDescription("Monitors the overall network stability, making all clients send RPC request once in 10 seconds to measure response time. Could be expensive. ")]
  public bool MonitorStability { get; set; }

  [LocDescription("Uses verbose logs of inventory change set. Can affect performance.")]
  public bool VerboseLogsOfInventoryChangeSets { get; set; }

  [LocDescription("EXPERIMENTAL. Use server garbage collection: much better multi-core utilization at the cost of higher memory usage. If your server hangs at boot and doesn't initialize or you notice other issues, try to turn this setting off first. Not recommended when several servers share one machine. The -servergc=true/false launch argument overrides this. Takes effect after server restart.")]
  public bool ServerGC { get; set; }

  [LocDescription("EXPERIMENTAL. Raise the minimum thread pool size so bursts of parallel work are not throttled while the pool grows. If your server hangs at boot and doesn't initialize or you notice other issues, try to turn this setting off first. Not recommended when several servers share one machine. The -threadboost=true/false launch argument overrides this. Takes effect after server restart.")]
  public bool BoostThreadPool { get; set; }

  public ref int ControllerID { get; }
}
