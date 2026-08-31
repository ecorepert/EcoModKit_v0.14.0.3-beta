// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatDataPartition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Gameplay.Utils;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>Persistent Chat Data. May be used as stand-alone chat messages storage or as a partition of <see cref="T:Eco.Gameplay.Utils.PartitionedData`2" /> (as used in <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.ChatManager" />).</summary>
[Serialized]
public class ChatDataPartition : 
  IStoredDataPartition<ChatMessage>,
  IDataPartition<ChatMessage>,
  IStorage,
  ISerializable
{
  [Serialized]
  public ThreadSafeList<ChatMessage> Entries { get; }

  public int NumEntries { get; }

  public void AddEntry(ChatMessage message);

  public IEnumerable<ChatMessage> GetEnumerable();

  /// <inheritdoc cref="M:Eco.Gameplay.Utils.IDataPartition`1.RemoveAll(System.Predicate{`0})" />
  public int RemoveAll(Predicate<ChatMessage> predicate);

  public IPersistent StorageHandle { get; set; }
}
