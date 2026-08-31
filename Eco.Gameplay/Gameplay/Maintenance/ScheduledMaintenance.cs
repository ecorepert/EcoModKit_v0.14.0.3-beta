// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Maintenance.ScheduledMaintenance
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Maintenance;

/// <summary>Represents a scheduled maintenance period.</summary>
public struct ScheduledMaintenance
{
  /// <summary>Determines the reason for application shutdown.</summary>
  public MaintenanceReason MaintenanceReason;

  /// <summary>Defines the date and time of automatic shutdown. This value is in UTC.</summary>
  public DateTime ScheduledTime { get; set; }

  /// <summary>Defines the date and time of thew automatic shutdown. This value is in local machine time.</summary>
  public DateTime LocalScheduledTime { get; }

  /// <summary><see cref="T:System.TimeSpan" /> representing the remaining time until maintenance.</summary>
  public TimeSpan TimeRemaining { get; }

  /// <summary>Integer representing the amount of seconds remaining before this maintenance window.</summary>
  public int SecondsRemaining { get; }

  /// <summary>Reason for maintenance/shutdown.</summary>
  public string MaintenanceMessage { get; set; }

  /// <summary>Boolean flag determining if this maintenance period is expired.</summary>
  public bool IsExpired { get; }

  /// <summary>Boolean flag determining if this maintenance period is set.</summary>
  public bool IsSet { get; }
}
