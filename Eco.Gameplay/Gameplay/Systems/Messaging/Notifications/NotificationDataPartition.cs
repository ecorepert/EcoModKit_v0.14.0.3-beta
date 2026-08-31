// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Notifications.NotificationDataPartition
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
namespace Eco.Gameplay.Systems.Messaging.Notifications;

/// <summary>Persistent Notification Data. May be used as stand-alone notification storage or as a partition of <see cref="T:Eco.Gameplay.Utils.PartitionedData`2" /> (as used in <see cref="T:Eco.Gameplay.Systems.Messaging.Notifications.NotificationManager" />).</summary>
[Serialized]
public class NotificationDataPartition : 
  IStoredDataPartition<Notification>,
  IDataPartition<Notification>,
  IStorage,
  ISerializable
{
  [Serialized]
  public ThreadSafeList<Notification> Entries { get; }

  public int NumEntries { get; }

  public void AddEntry(Notification notification);

  public IEnumerable<Notification> GetEnumerable();

  /// <inheritdoc cref="M:Eco.Gameplay.Utils.IDataPartition`1.RemoveAll(System.Predicate{`0})" />
  public int RemoveAll(Predicate<Notification> predicate);

  public IPersistent StorageHandle { get; set; }
}
