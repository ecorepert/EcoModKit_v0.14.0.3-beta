// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.StorageBagDirectory`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins;
using System;

#nullable enable
namespace Eco.Core.Serialization;

/// <summary>
/// <see cref="T:Eco.Core.Serialization.StorageBagDirectory`1" /> represents a directory in <see cref="P:Eco.Core.Serialization.StorageBagDirectory`1.StorageManager" /> with set of <see cref="T:Eco.Core.Serialization.StorageBag" /> entries. Each bag contains up to <see cref="P:Eco.Core.Serialization.StorageBagDirectory`1.MaxItemsPerBag" /> items.
/// Intended for cases where lot of items may exists to reduce number of storage handles in Zip Archive. Zip archive slow downs and can even crash if too many entries.
/// </summary>
public class StorageBagDirectory<T> where T : notnull
{
  public StorageManager StorageManager { get; }

  public string Name { get; }

  public int MaxItemsPerBag { get; }

  public int Count { get; }

  public StorageBagDirectory(StorageManager storageManager, string name, int maxItemsPerBag);

  /// <summary>Loads all storage dir items in parallel.</summary>
  public void LoadInParallel();

  /// <summary>Adds <paramref name="item" /> to one of storage bags in the directory.</summary>
  public void Add(T item);

  /// <summary>Removes <paramref name="item" /> from the directory.</summary>
  /// <returns><c>false</c> if item wasn't added to the directory.</returns>
  public bool Remove(T item);

  /// <summary>Modifies <paramref name="obj" /> in a way preventing partial object saving.</summary>
  public void Modify<TObj>(TObj obj, Action<TObj> modify) where TObj : T;

  public void MarkDirty(T item);

  /// <summary>Marks all storage bags as dirty to be re-saved.</summary>
  public void MarkAllDirty();
}
