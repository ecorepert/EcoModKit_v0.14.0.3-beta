// Decompiled with JetBrains decompiler
// Type: Eco.Core.Backup.BackupPlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.FileStorage;
using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Backup;

[LocDisplayName("BackupPlugin")]
public class BackupPlugin : 
  Singleton<
  #nullable disable
  BackupPlugin>,
  ICommandablePlugin,
  IServerPlugin,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IThreadedPlugin,
  IShutdownablePlugin
{
  public static ConcurrentBag<Func<IFileStorage, Task>> BackupActions;
  public static ThreadSafeAction BackupCreated;

  public IPluginConfig PluginConfig { get; }

  public BackupConfig Config { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public Task RestoreBackupAsync(string backupName);

  /// <summary>Returns all backup storages ordered by chronological order.</summary>
  public Task<IEnumerable<IFileStorage>> GetBackupStoragesAsync(string gameName);

  /// <summary>Restores most recent backup for <paramref name="gameName" />. It starts with head backup and then continues with every backup in reverse chronological
  /// order using <paramref name="checkBackup" /> for backup validation. If the check function not provided then just returns first backup.
  /// It copies backup to Storage directory before each call to the check function.</summary>
  public Task<bool> RestoreMostRecentBackupAsync(string gameName, Func<string, bool> checkBackup = null);

  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public string GetStatus();

  /// <summary>
  /// Need to make head backup just before server shutdown, it will guarantee we will be able to start from the same place.
  /// </summary>
  public Task ShutdownAsync();

  /// <summary>
  /// Starts backups, we don't want to do make it in constructor or Initialize section because in case of long start-up we don't want to have backups during this phase.
  /// </summary>
  public void Run();

  public Task BackupAsArchiveToAsync(IFileStorage archiveStorage, string archiveName);

  public Task DoHeadBackupAsync();

  public Task DoBackupAsync();

  public Task RemoveOldBackupsAsync();

  public override string ToString();

  public string GetCategory();

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);
}
