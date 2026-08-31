// Decompiled with JetBrains decompiler
// Type: Eco.Core.Backup.BackupConfig
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Core.Backup;

[Localized(true, false, "", false)]
[IgnoreHostedWorlds]
public class BackupConfig
{
  [LocDescription("Whether or not to keep backups.")]
  public bool Enabled { get; set; }

  [LocDescription("How many backups to store for the last hour.")]
  public int MaxBackupsInLastHour { get; set; }

  [LocDescription("How many hourly backups to store. Hourly backup is the first backup in a hour.")]
  public int MaxHourlyBackups { get; set; }

  [LocDescription("How many daily backups to store. Daily backup is the first hourly backup in a day.")]
  public int MaxDailyBackups { get; set; }

  [LocDescription("How many weekly backups to store. Weekly backup is the first daily backup in a week.")]
  public int MaxWeeklyBackups { get; set; }

  [LocDescription("How often make backups in hours. May be a fractional number. Ex.: 0.5 - every half hour, 2 - every two hours")]
  public float BackupFrequencyInHours { get; set; }

  [LocDescription("Special kind of backup which always contains current 'HEAD' state and overwrites every time. It happens often enough to minimize data lose")]
  public bool HeadBackupEnabled { get; set; }
}
