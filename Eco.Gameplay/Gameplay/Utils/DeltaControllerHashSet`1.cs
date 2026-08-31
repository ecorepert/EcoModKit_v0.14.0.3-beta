// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.DeltaControllerHashSet`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

/// <summary>
/// Set of controllers supporting delta updates.
/// It need to register all consumers (clients) who work with set (i.e. when Player login/logout) and then regular call<see cref="M:Eco.Gameplay.Utils.DeltaControllerHashSet`1.SyncDeltas" /> to sync updates and initial states for new consumers.
/// </summary>
[ForceCreateView(ViewTypeName = "DeltaControllerHashSetView")]
public class DeltaControllerHashSet<T> : DeltaControllerHashSetBase where T : IController
{
  /// <summary>Adds new item.</summary>
  public bool Add(T value);

  /// <summary>Bulk-adds items in a single lock acquisition. Returns count of newly inserted items.</summary>
  public int AddRange(IEnumerable<T> values);

  /// <summary>Removes item. Null is treated as a no-op so callers that may not have registered an object yet do not have to null-check.</summary>
  public bool Remove(T value);

  /// <summary>Returns a detached snapshot of the current items. Single-lock read; caller may iterate without contention.</summary>
  public List<T> Snapshot();

  /// <summary>Check if items contain a certain key.</summary>
  public bool ContainsKey(T value);

  public void RemoveConsumer(INetClient client);

  /// <summary>Syncs deltas for all consumers.</summary>
  public void SyncDeltas();

  /// <summary>Gets all the objects that have been added, clients must call this to setup the hash set initially.
  /// This is the only way for a consumer to register for updates.</summary>
  [RPC]
  public override List<object> AddConsumerAndGetFullSet(INetClient consumer);
}
