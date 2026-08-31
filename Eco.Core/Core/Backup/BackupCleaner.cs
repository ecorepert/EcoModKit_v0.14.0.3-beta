// Decompiled with JetBrains decompiler
// Type: Eco.Core.Backup.BackupCleaner
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.FileStorage;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Backup;

public class BackupCleaner
{
  public 
  #nullable disable
  IFileStorage BackupFileStorage { get; set; }

  public string SaveName { get; set; }

  public int MaxBackupsInLastHour { get; set; }

  public int MaxHourlyBackups { get; set; }

  public int MaxDailyBackups { get; set; }

  public int MaxWeeklyBackups { get; set; }

  public Task DoCleanupAsync();

  public Task DoCleanupAsync(DateTime relatedTo);
}
