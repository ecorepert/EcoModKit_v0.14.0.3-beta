// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.StorageManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.FileStorage;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Plugins;

[LocDisplayName("StorageManager")]
[Priority(-200)]
public sealed class StorageManager : 
  Singleton<
  #nullable disable
  StorageManager>,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IConfigurablePlugin,
  IEditablePlugin,
  ICommandablePlugin,
  IThreadedPlugin,
  IShutdownablePlugin,
  IStorageManager,
  IDisposable
{
  public static bool GeneratingNewWorld;

  public static event Action OnSaveAllComplete;

  public static event Action OnPersistAsync;

  public static IFileStorage Storage { get; }

  public static StorageConfig Config { get; }

  public static string SaveName { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public IPluginConfig PluginConfig { get; }

  public string GetCategory();

  public StorageManager();

  public StorageManager(
    Eco.Core.Plugins.PluginConfig<StorageConfig> config,
    IFileStorage baseStorage,
    bool enableBackups = false);

  public static Singleton<StorageManager>.Temp TempStorageManager(IFileStorage fileStorage);

  public static void WithTempStorageManager(IFileStorage fileStorage, Action action);

  /// <summary>Unlocks storage for writing and persists everything.</summary>
  internal Task UnlockPersistAsync();

  public static Task UnlockSaveAndFlushAsync();

  public static Task SaveAndFlushAsync();

  /// <summary> Persists all pending storages asynchronously. </summary>
  public Task<TimeSpan> PersistAsync();

  public static Stream Load(string fileName);

  public static void Save(string fileName, Stream data);

  public static void Save(string fileName, string data);

  public static void Delete(string fileName);

  public static bool FolderExists(string folder);

  public static List<string> GetFiles(string folder);

  public static TStorageType LoadOrCreate<TStorageType>(
    string folder,
    Action<TStorageType> onCreate = null)
    where TStorageType : class, IStorage;

  public static void Load<T>(string folder, Action<T> onLoad) where T : IStorage;

  public void LoadAsync<T>(string folder, Action<T> onLoad) where T : IStorage;

  /// <summary>Loads object and removes entries from <see cref="F:Eco.Core.Plugins.StorageManager.dataStore" />. May be used during conversion pass from old zip entries to new zip entries.</summary>
  public void LoadAndRemove<T>(string folder, Action<T, string> onLoad);

  public IPersistent CreateTransientHandle();

  public IPersistent CreateStorageHandle(string folder, string name);

  public static Task PurgeAsync(string folder);

  public override string ToString();

  /// <summary>Registers a loaded storage for dirty-tracking reconciliation without marking it dirty.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Track(IStorage storage);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void MarkDirty(IStorage storage);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Remove(IStorage storage);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void ClearDirtyState(IStorage storage);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool IsDirty(IStorage storage);

  public string GetStatus();

  public void Run();

  public Task ShutdownAsync();

  public string GetDisplayText();

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public void Dispose();
}
