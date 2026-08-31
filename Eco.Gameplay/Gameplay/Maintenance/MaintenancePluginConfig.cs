// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Maintenance.MaintenancePluginConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Maintenance;

/// <summary>Defines the configuration options used by <seealso cref="T:Eco.Gameplay.Maintenance.MaintenancePlugin" /></summary>
[Localized(true, false, "", false)]
public class MaintenancePluginConfig
{
  [LocDescription("Specifies what hour of the day automatic shutdown should occur. This is best paired with systems that automatically restart the server.")]
  public int AutoShutdownHour { get; set; }

  [LocDescription("Specifies the message to be sent when the automatic shutdown occurs.")]
  public string AutoShutdownMessage { get; set; }

  [LocDescription("Specifies the reason for the automatic shutdown. Controls what exit code the application closes with.")]
  public MaintenanceReason ReasonForAutoShutdown { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Specifies how many seconds until the shutdown counter starts.")]
  public int CountdownStart { get; set; }

  /// <summary>Defines the announcement countdown intervals in minutes. The 30 second countdown is handled internally by code.</summary>
  [IgnoreHostedWorlds]
  [LocDescription("Defines the announcement countdown intervals in minutes. The second countdown is handled by the CountdownStart setting.")]
  public int[] CountdownIntervals { get; set; }
}
