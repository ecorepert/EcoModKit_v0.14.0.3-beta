// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.TradeTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.Economy;

public class TradeTracker : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public event 
  #nullable disable
  PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public int ItemTypeID { get; set; }

  [SyncToView(null, true)]
  public float SalePrice { get; set; }

  [SyncToView(null, true)]
  public int NumberAvailable { get; set; }

  [SyncToView(null, true)]
  public float WantedPrice { get; set; }

  [SyncToView(null, true)]
  public float NumberWanted { get; set; }

  [SyncToView(null, true)]
  public float MinDurability { get; set; }

  [SyncToView(null, true)]
  public float MaxDurability { get; set; }

  [SyncToView(null, true)]
  public float MinIntegrity { get; set; }

  [SyncToView(null, true)]
  public float MaxIntegrity { get; set; }

  [SyncToView(null, true)]
  public Item ReferencedItem { get; set; }

  [SyncToView(null, true)]
  public Tag Tag { get; set; }

  [SyncToView(null, true)]
  public Settlement Settlement { get; set; }

  [SyncToView(null, true)]
  public ByteColor Color { get; set; }

  [SyncToView(null, true)]
  public string ReferencedItemMarkedUpName { get; }

  public bool IsTagOffer { get; }

  public IHasTradeOffers Source { get; }

  [SyncToView(null, true)]
  public float StoreBalance { get; }

  [SyncToView(null, true)]
  public Vector3 StorePosition { get; }

  [SyncToView(null, true)]
  public bool IsBarter { get; }

  [SyncToView(null, true)]
  public Currency Currency { get; }

  [SyncToView(null, true)]
  public LocString SourceName { get; }

  [SyncToView(null, true)]
  public bool Auth(Player player);

  /// <summary>In-world sale (a For Sale sign on a placed object) rather than a store.</summary>
  [SyncToView(null, true)]
  public bool IsWorldObjectSale { get; }

  /// <summary>The store can't afford the full wanted quantity of its buy offer.</summary>
  [SyncToView(null, true)]
  public bool LimitedFunds { get; }

  /// <summary>The store's deposit inventories can't fit the full wanted quantity. Computed on tracker rebuild.</summary>
  [SyncToView(null, true)]
  public bool LimitedStorage { get; set; }

  /// <summary>Composes the status icons shown in the economy viewer, each a link with a hover tooltip explaining its meaning.</summary>
  [SyncToView(null, true)]
  public string StatusIcons(Player player);

  public string SalePriceAndCurrency { get; }

  public string WantedPriceAndCurrency { get; }

  public bool IsSelling { get; }

  public ref int ControllerID { get; }

  public bool TestEquality(TradeTracker other);

  public LocString ActionDescription { get; }

  public static IEnumerable<TradeTracker> GetAllItemTrackersForSource(IHasTradeOffers source);

  /// <summary> Constructor for item-specific offers. </summary>
  public TradeTracker(IHasTradeOffers source, TradeOffer bestSale, TradeOffer bestWanted);

  /// <summary> Constructor supporting both item-specific and tag-based offers. </summary>
  public TradeTracker(IHasTradeOffers source, TradeOffer bestSale, TradeOffer bestWanted, Tag tag);

  internal void CopyFrom(TradeTracker trade);

  public void Destroy();

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
