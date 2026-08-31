// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.TradeOffer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Store.Internal;
using Eco.Gameplay.Items;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary> Represents an offer of the store. Contains description of condition of sell/buy, the price, the kind of item or tag. </summary>
[Serialized]
public class TradeOffer : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public static 
  #nullable disable
  ThreadSafeAction<TradeOffer> ItemUpdatedEvent;

  [SyncToView(null, true)]
  public StoreCategory Category { get; }

  [Serialized]
  [SyncToView(null, true)]
  [WatchSubMember("Item", "OnItemUpdatedEvent", SubPropWatcherFlag.None)]
  public ItemStack Stack { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float Price { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public int Limit { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float MinDurability { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float MaxDurability { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float MinIntegrity { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float MaxIntegrity { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  [AllowNullInView]
  public Settlement Settlement { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ByteColor Color { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public bool Buying { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AllowNullInView]
  public Tag Tag { get; set; }

  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  public object Tooltip { get; }

  /// <summary> True if this offer matches a tag (category of items) rather than a specific item. </summary>
  public bool IsTagOffer { get; }

  public bool HasQualifiers { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public bool IsSet { get; }

  public int MaxNumWanted { get; }

  public bool ShouldLimit { get; }

  public IReadOnlyList<Type> MatchingTypes { get; }

  /// <summary> True if all items in this tag support durability (e.g. food, tools). </summary>
  public bool TagSupportsDurability { get; }

  /// <summary> True if all items in this tag support integrity (e.g. tools). </summary>
  public bool TagSupportsIntegrity { get; }

  /// <summary> True if all items in this tag are spoilage/food items (freshness instead of durability). Synced to client for UI label. </summary>
  [SyncToView(null, true)]
  public bool TagIsFoodTag { get; }

  /// <summary> Checks if a given item satisfies this offer (by tag membership or exact type match). </summary>
  public bool MatchesItem(Item item);

  /// <summary> Returns a display link for notifications and error messages. Works for both item and tag offers. </summary>
  public LocString DisplayLink();

  public TradeOffer();

  public TradeOffer(Item item, bool buying);

  public TradeOffer(Item item, float price, bool buying);

  /// <summary> Creates a tag-based trade offer that matches any item with the given tag. </summary>
  public TradeOffer(Tag tag, bool buying);

  public void SetCategory(StoreCategory category);

  public TradeOffer Clone();

  /// <summary> Checks the durability and integrity ranges of this offer. Items without durability, and bounds left disabled (-1), always pass. </summary>
  public bool MeetsDurabilityRequirements(Item item);

  /// <summary> Validates if the item meets special requirements (durability, color, settlement), or for tag offers, just checks tag membership. </summary>
  public bool MeetsSpecialRequirements(Item item);

  [RPC]
  public void UpdateItemColor(ByteColor color);

  [RPC]
  public void UpdateItemSettlement(Settlement settlement);

  /// <summary> Counts items in the given stacks that match this offer. Uses the optimized stock dictionary when there are no custom params. </summary>
  public int CountMatchingItems(IList<ItemStack> stacks, Dictionary<Type, int> stock);

  /// <summary> Returns a representative item for display purposes. For tag offers, prefers resolved items if available, otherwise falls back to first type in tag. </summary>
  public Item GetRepresentativeItem(
    List<(Item ResolvedItem, int Quantity)> resolvedItems = null);

  /// <summary> Resolves this tag offer into concrete items using FIFO order from inventory stacks. </summary>
  public List<(Item ResolvedItem, int Quantity)> ResolveTagItems(
    int requestedQty,
    IEnumerable<ItemStack> inventoryStacks);

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
