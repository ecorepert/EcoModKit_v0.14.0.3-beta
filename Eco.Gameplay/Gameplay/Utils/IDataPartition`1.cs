// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.IDataPartition`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary>This interface provides a minimalistic list interface and acts as a unified base for both the partitioned data and each individual data partition.</summary>
/// <remarks>Used exclusively by <see cref="T:Eco.Gameplay.Utils.PartitionedData`2" />. See <see cref="T:Eco.Gameplay.Utils.IStoredDataPartition`1" /> when looking to implement a data partition.</remarks>
public interface IDataPartition<T>
{
  int NumEntries { get; }

  void AddEntry(T entry);

  IEnumerable<T> GetEnumerable();

  /// <summary>Removes all entries matching <paramref name="predicate" /> and returns number of removed entries.</summary>
  int RemoveAll(Predicate<T> predicate);
}
