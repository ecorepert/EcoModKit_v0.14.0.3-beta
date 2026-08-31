// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.PersistenceManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Serialization;

/// <summary> <see cref="T:Eco.Core.Serialization.PersistenceManager" /> responsible for objects persistence (marking as dirty, delete, persist to DataStore). </summary>
public class PersistenceManager
{
  /// <summary>Splits a storage into named parts for divergence diagnosis. Default: its [Serialized] members. Gameplay swaps in a
  /// WorldObject-aware provider that reports per-component, which is the granularity needed to find a missing dirty mark.</summary>
  public static Func<IStorage, IEnumerable<(string Name, object? Value)>> DiagnosticPartsProvider { get; set; }

  /// <summary>Storages whose continuous drift is deliberately persisted on a throttle (fuel burn, passive XP): the reconciliation
  /// sweep still persists their drift but doesn't report it as a missing dirty mark. Set by gameplay.</summary>
  public static Func<IStorage, bool> DeferredDriftExemption { get; set; }

  public static IEnumerable<(string Name, object? Value)> DefaultDiagnosticParts(IStorage storage);

  /// <summary>Stats of the last <see cref="M:Eco.Core.Serialization.PersistenceManager.PersistAllAsync(Eco.Core.Serialization.DataStore.ExclusiveAccess)" /> pass: how many storages were written and how many of them had actually changed bytes.</summary>
  public (int Persisted, int Changed) LastPersistStats { get; }

  /// <summary> Adds <paramref name="blob" /> to persistence manager. It will be persisted in next call to <see cref="M:Eco.Core.Serialization.PersistenceManager.PersistAllAsync(Eco.Core.Serialization.DataStore.ExclusiveAccess)" />. </summary>
  public void AddBlob(DataBlob blob);

  /// <summary>
  /// Marks storage as dirty using current version.
  /// During persist phase it increases version and only saves objects from previous version.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal void MarkDirty(IStorage storage);

  /// <summary>Registers <paramref name="storage" /> for dirty-tracking reconciliation. Called on dirty transitions and when storages are loaded from disk.</summary>
  internal void Track(IStorage storage);

  /// <summary> Removes <paramref name="storage" /> from <see cref="F:Eco.Core.Serialization.PersistenceManager.pendingStorages" />. It doesn't remove <paramref name="storage" /> immediate, but instead places it in <see cref="F:Eco.Core.Serialization.PersistenceManager.pendingStorages" /> to be processed with <see cref="M:Eco.Core.Serialization.PersistenceManager.PersistAllAsync(Eco.Core.Serialization.DataStore.ExclusiveAccess)" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  internal void Remove(IStorage storage);

  /// <summary>Count of storages waiting to be persisted.</summary>
  internal int PendingCount { get; }

  /// <summary>Top pending storage types by count, for the slow-persist log so the biggest dirty producers are visible.</summary>
  internal string DescribePendingByType(int top);

  /// <summary> Increases version and persists all dirty objects with last version. </summary>
  internal Task PersistAllAsync(DataStore.ExclusiveAccess exclusiveAccess);

  /// <summary>
  /// Serializes every tracked storage that is not currently pending and compares its bytes against the last-persisted hash.
  /// A divergence means state mutated without <see cref="M:Eco.Core.Serialization.PersistenceManager.MarkDirty(Eco.Core.Serialization.IStorage)" /> (missed funnel or a mod writing serialized fields directly):
  /// the storage is marked dirty so the next persist writes it, and it gets reported so the missing call site can be fixed.
  /// With <paramref name="diagnoseParts" /> each storage also keeps per-part hashes so a divergence names the changed parts.
  /// Storages seen for the first time silently record a baseline. Must run on the storage worker (shares the reusable stream with persist).
  /// </summary>
  internal (int Divergent, int DeferredDrift) ReconcileDirtyTracking(
    bool diagnoseParts,
    Action<IStorage, string?> reportDivergent);

  /// <summary>
  /// Clears dirty state for the <paramref name="storage" />.
  /// </summary>
  public void ClearDirtyState(IStorage storage);

  /// <summary>
  /// Checks if the <paramref name="storage" /> is dirty.
  /// </summary>
  public bool IsDirty(IStorage storage);

  private class StorageTracker
  {
    public ulong LastHash;
    public bool HasBaseline;
    public Dictionary<string, ulong>? PartHashes;
  }
}
