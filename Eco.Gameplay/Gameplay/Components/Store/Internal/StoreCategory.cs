// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Store.Internal.StoreCategory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components.Store.Internal;

/// <summary> Subgroup of offers at the store. Each group will be showed and handled separated by UI, allowing users to group similar elements as they want.  </summary>
[Eco.Shared.Networking.Eco(true)]
[Serialized]
public class StoreCategory : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers,
  IClearOnTrade,
  IOwned,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IRPCAuthChecks
{
  public readonly 
  #nullable disable
  ThreadSafeAction OffersChangedEvent;
  public ThreadSafeAction ChangedEvent;
  public StoreComponent StoreComponent;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public IAlias Owners { get; }

  [SyncToView(null, true)]
  protected bool IsAuthorizedFullAccess(Player player);

  [SyncToView(null, true)]
  [Serialized]
  public bool IsBuy { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public string Name { get; set; }

  [Serialized]
  public string GeneratedName { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<TradeOffer> Offers { get; set; }

  Deed IOwned.Deed { get; }

  public StoreCategory();

  public StoreCategory(StoreComponent component, bool isBuy);

  public void AddCallbacks();

  public void OnDestroy();

  public StoreCategory Clone(StoreComponent target);

  [RPC(AccessType.FullAccess)]
  public void RemoveTrade(TradeOffer offer);

  /// <summary> Updates offers list to match the given item IDs and tag names, preserving the existing order of surviving offers. </summary>
  [RPC(AccessType.FullAccess)]
  public bool SetMixedTrades(Player player, List<int> itemIDs, List<string> tagNames);

  /// <summary> Choose the best title for the category based on the offers. </summary>
  [RPC(AccessType.FullAccess)]
  public void GetBestName(List<int> itemIDs, List<string> tagNames);

  /// <summary>Adds a single tag-based trade offer. Used for drag and drop of tag offers between categories.</summary>
  [RPC(AccessType.FullAccess)]
  public void AddTagTradeOffer(
    string tagName,
    float price,
    int limit,
    float minDurability,
    float maxDurability,
    float minIntegrity,
    float maxIntegrity);

  [RPC(AccessType.FullAccess)]
  public void AddTradeOffer(
    int itemId,
    float minDurability,
    float maxDurability,
    float price,
    int limit,
    Settlement settlement,
    ByteColor color,
    float minIntegrity,
    float maxIntegrity);

  [RPC(AccessType.FullAccess)]
  public void AddTradeOffer(int itemId, float price, ByteColor color);

  [RPC(AccessType.FullAccess)]
  public void AddTradeOffer(int itemId, float price);

  public bool IsRPCAuthorized(IWorldObserver observer, AccessType requiredAccess, object[] args);

  public ref int ControllerID { get; }
}
