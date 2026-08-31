// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.IStoredDataPartition`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary>A minimalistic list interface with thread safe entries list for storage purposes.</summary>
/// <remarks>Use this when implementing actual data partition for use with <see cref="T:Eco.Gameplay.Utils.PartitionedData`2" />.</remarks>
public interface IStoredDataPartition<T> : IDataPartition<T>, IStorage, ISerializable
{
  [Serialized]
  ThreadSafeList<T> Entries { get; }
}
