// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Maintenance.MaintenancePlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using Eco.Shared.Utils;
using JetBrains.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Maintenance;

/// <summary>
/// Server plugin instance for handling automatic shutdown/maintenance notifications for Eco Server.
/// It will automatically post a notification on the configured countdown intervals found in the Maintenance configuration options under <see cref="P:Eco.Gameplay.Maintenance.MaintenancePluginConfig.CountdownIntervals" />
/// </summary>
public class MaintenancePlugin : 
  Singleton<MaintenancePlugin>,
  IServerPlugin,
  IWorkerPlugin,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IDisplayablePlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IShutdownablePlugin
{
  /// <summary>Determines if an automatic maintenenace window is set.</summary>
  public bool AutoRestartScheduled { get; }

  /// <summary>Determines if a user defined maintenance window is set. </summary>
  public bool UserShutdownScheduled { get; }

  public IPluginConfig PluginConfig { get; }

  public object GetEditObject();

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  [UsedImplicitly]
  public MaintenancePlugin();

  public MaintenancePlugin(Eco.Core.Plugins.PluginConfig<MaintenancePluginConfig> config);

  public void OnEditObjectChanged(object o, string param);

  public string GetStatus();

  public string GetDisplayText();

  public Task DoWork(CancellationToken token);

  public Task ShutdownAsync();

  internal Task PerformScheduledMaintenanceAsync(
    ScheduledMaintenance maintenance,
    Action<int> countdown,
    Func<int, CancellationToken, Task> delay);

  internal void SendCountdownNotification(ScheduledMaintenance maintenance, int remainingSeconds);

  internal void GetServerNotification(
    ScheduledMaintenance maintenance,
    int remainingSeconds,
    out bool shouldNotify,
    out LocString message,
    out NotificationStyle style);

  /// <summary>Tries to retrieve the next scheduled maintenance if any</summary>
  internal bool TryGetNextSchedule(out ScheduledMaintenance maintenance);

  /// <summary>Schedules a new user defined maintenance period</summary>
  /// <param name="time"><seealso cref="T:System.DateTime" /> the maintenance shutdown should occur.</param>
  /// <param name="message">Message stating message of shutdown.</param>
  /// <param name="reason">Reason for the maintenance. Defaults to <see cref="F:Eco.Gameplay.Maintenance.MaintenanceReason.Shutdown" /></param>
  /// <returns>true if the maintenance was scheduled. Otherwise returns false</returns>
  public Result ScheduleUserMaintenance(
    DateTime time,
    string message,
    MaintenanceReason reason = MaintenanceReason.Shutdown,
    bool notify = true);

  /// <inheritdoc cref="M:Eco.Gameplay.Maintenance.MaintenancePlugin.ScheduleUserMaintenance(System.DateTime,System.String,Eco.Gameplay.Maintenance.MaintenanceReason,System.Boolean)" />
  /// <param name="timeStr">DateTime string to schedule the maintenance for.</param>
  public Result ScheduleUserMaintenance(string timeStr, string message, MaintenanceReason reason = MaintenanceReason.Shutdown);

  /// <summary>Clears the currently setup user maintenance periods.</summary>
  public void CancelUserMaintenance(bool notify = true);

  public override string ToString();

  public string GetCategory();
}
