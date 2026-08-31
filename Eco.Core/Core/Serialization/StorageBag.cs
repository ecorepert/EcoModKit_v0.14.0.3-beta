// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.StorageBag
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary><see cref="T:Eco.Core.Serialization.StorageBag" /> is a serializable unordered container for items. Used by <see cref="T:Eco.Core.Serialization.StorageBagDirectory`1" /> as minimal serializable unit for save file entry.</summary>
[Serialized]
internal class StorageBag : IStorage, ISerializable
{
  public IEnumerable<object> Items { get; }

  public int Count { get; }

  public IPersistent StorageHandle { get; set; }

  public void Add(object item);

  public void Remove(object item);
}
