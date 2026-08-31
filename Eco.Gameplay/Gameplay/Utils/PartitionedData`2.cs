// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PartitionedData`2
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

/// <summary>Partitioned data is used for high update frequency data such as Chat and Notifications. For each new day, a new data partition will be created and since each individual data partition
/// is <see cref="T:Eco.Core.Serialization.IStorage" />, they are saved separately and that heavily enhances serialization speed, because only the active partition needs to be saved on updates as the previous ones are locked.</summary>
public class PartitionedData<TPartition, TEntry> : IDataPartition<
#nullable disable
TEntry>
  where TPartition : IStoredDataPartition<TEntry>, new()
  where TEntry : ISerializable, IHasCreationTime
{
  /// <summary>Loads data from storage or creates new.</summary>
  public static PartitionedData<TPartition, TEntry> LoadOrCreate(string folder);

  public int NumEntries { get; }

  public void AddEntry(TEntry entry);

  public IEnumerable<TEntry> GetEnumerable();

  /// <summary>Yields entries newest-first (last partition and last entry first), lazily. Used for paged history reads that stop early without materializing the whole log.</summary>
  public IEnumerable<TEntry> GetReverseEnumerable();

  /// <inheritdoc cref="M:Eco.Gameplay.Utils.IDataPartition`1.RemoveAll(System.Predicate{`0})" />
  /// <remarks>Removes entries from actual partitions by recursing the RemoveAll call into them.</remarks>
  public int RemoveAll(Predicate<TEntry> predicate);
}
