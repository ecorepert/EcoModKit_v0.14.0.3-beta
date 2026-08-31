// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.DataStore
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.FileStorage;
using Eco.Core.Plugins;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Serialization;

public sealed class DataStore : IDisposable
{
  public bool ReadOnly { get; }

  public string Name { get; }

  public StorageConfig StorageConfig { get; }

  public int NumEntries { get; }

  public string Filename { get; }

  public DataStore(string name, StorageConfig storageConfig);

  public DataStore.ExclusiveAccess WaitExclusiveAccess();

  public ValueTask<DataStore.ExclusiveAccess> WaitExclusiveAccessAsync();

  public string GetFileName(string saveName);

  public void OpenZipFile();

  public Task BackupAsync(IFileStorage fileStorage);

  /// <summary>Load a singular entry from the zip file.</summary>
  /// ?
  public MemoryStream? LoadFileAsStream(string fileName);

  /// <summary>Loads file asynchronously from <see cref="T:Eco.Core.Serialization.DataStore" />.</summary>
  public ValueTask<MemoryStream?> LoadFileAsStreamAsync(string fileName);

  /// <summary>Loads file asynchronously from <see cref="T:Eco.Core.Serialization.DataStore" /> as a string.</summary>
  public ValueTask<string?> LoadFileAsStringAsync(string fileName);

  public void Delete(string fileName);

  /// <summary> Checks if non-empty <paramref name="folder" /> exists in the zip archive. </summary>
  public bool FolderExists(string folder);

  /// <summary> Returns file names in zip archive's <paramref name="folder" />. </summary>
  public List<string> GetFileNames(string folder);

  /// <summary>Writes <paramref name="content" /> to the entry with name <paramref name="fileName" />.</summary>
  public ValueTask WriteAsync(string fileName, string content);

  public void Load<T>(string folder, Action<T> onLoad, bool migrate = true) where T : IStorage;

  public void LoadAsync<T>(string folder, Action<T> onLoad) where T : IStorage;

  public IPersistent CreateStorageHandle(string folder, string name);

  public void Dispose();

  /// <summary> <see cref="T:Eco.Core.Serialization.DataStore" /> content accessor which allows to perform safe <see cref="T:Eco.Core.Serialization.DataStore" /> modifications by other classes. </summary>
  public readonly ref struct ContentAccessor
  {
    private readonly 
    #nullable disable
    DataStore dataStore;

    public static ValueTask ExecuteAsync(
      DataStore.ExclusiveAccess exclusiveAccess,
      DataStoreContentAccessorDelegate action);

    /// <summary>Updates entry with <paramref name="name" /> with content written by <paramref name="writeDelegate" />. Aware that <paramref name="writeDelegate" /> may be called multiple times!</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void UpdateEntry(string name, WriteDelegate writeDelegate);

    /// <summary> Deletes entry with given <paramref name="name" /> in <see cref="T:Eco.Core.Serialization.DataStore" />. </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void DeleteEntry(string name);

    public void Flush();
  }

  /// <summary>
  /// Class which should be used for exclusive access to <see cref="F:Eco.Core.Serialization.DataStore.ExclusiveAccess.DataStore" />.
  /// May be obtained with <see cref="M:Eco.Core.Serialization.DataStore.WaitExclusiveAccess" /> or <see cref="M:Eco.Core.Serialization.DataStore.WaitExclusiveAccessAsync" /> to get it with exclusive access.
  /// You can also create with <see cref="M:Eco.Core.Serialization.DataStore.ExclusiveAccess.#ctor(Eco.Core.Serialization.DataStore)" /> constructor (no obtained state) and then <see cref="M:Eco.Core.Serialization.DataStore.ExclusiveAccess.Wait(System.Threading.CancellationToken)" /> or <see cref="M:Eco.Core.Serialization.DataStore.ExclusiveAccess.WaitAsync(System.Threading.CancellationToken)" />.
  /// </summary>
  public sealed class ExclusiveAccess : IDisposable
  {
    public readonly 
    #nullable enable
    DataStore DataStore;

    public ExclusiveAccess(DataStore dataStore);

    internal void Wait(CancellationToken token = default (CancellationToken));

    internal ValueTask WaitAsync(CancellationToken token = default (CancellationToken));

    ~ExclusiveAccess();

    public void Dispose();

    /// <inheritdoc cref="M:Eco.Core.Serialization.DataStore.PurgeAsync(Eco.Core.Serialization.DataStore.ExclusiveAccess,System.String)" />
    public Task PurgeAsync(string folder);

    public void Load<T>(string folder, Action<T> onLoad, bool migrate = true) where T : IStorage;

    /// <inheritdoc cref="M:Eco.Core.Serialization.DataStore.LoadAndRemove``1(Eco.Core.Serialization.DataStore.ExclusiveAccess,System.String,System.Action{``0,System.String})" />
    public void LoadAndRemove<T>(string folder, Action<T?, string> onLoad);

    public void LoadAsync<T>(string folder, Action<T> onLoad) where T : IStorage;

    public void SwitchToWriteMode();
  }
}
