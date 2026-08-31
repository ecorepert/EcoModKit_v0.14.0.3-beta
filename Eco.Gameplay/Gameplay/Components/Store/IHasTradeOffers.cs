// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Store.IHasTradeOffers
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components.Store.Internal;
using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components.Store;

/// <summary>Handles defining a set of trade offers, which can be done at a store, or on a placed object.  Also
/// provides a set of functions in the form of the default interace to process transactions.</summary>
public interface IHasTradeOffers
{
  #nullable disable
  IEnumerable<TradeOffer> AllOffers { get; }

  Currency Currency { get; }

  float Balance { get; }

  WorldObject Parent { get; }

  bool IsBarter { get; }

  IAlias Owners { get; }

  bool EnabledForTrades { get; }

  LocString SourceName { get; }

  LocString SoldOutNotice { get; }

  IEnumerable<Inventory> StockInventories { get; }

  IEnumerable<Inventory> DepositInventories { get; }

  /// <summary>Get all linked inventories that work for any user in the alias.</summary>
  /// <param name="includeStoreStorage">Do we want to include the store own storage ?</param>
  protected IEnumerable<Inventory> GetLinkedInventories(
    IAlias alias,
    bool source = false,
    bool target = false,
    bool includeStoreStorage = true);

  /// <summary>Customer inventories a trade would use: targets that receive bought items (forBuying) or sources that supply sold items. Store stock inventories are excluded to avoid double-counting.</summary>
  protected List<Inventory> CustomerTradeInventories(User customer, bool forBuying);

  /// <summary>Splits buy-destination inventories into the collections that accept carried vs non-carried items.</summary>
  protected static (IEnumerable<Inventory> Carried, IEnumerable<Inventory> NonCarried) SplitByCarried(
    IEnumerable<Inventory> invs);

  /// <summary>How many items of a sell <paramref name="offer" /> the customer could actually receive, limited by free space in the inventories a purchase would deliver to.</summary>
  int MaxFitForOffer(User customer, TradeOffer offer);

  GameActionPack PerformTradeInPack(PurchaseData data, GameActionPack pack = null);

  /// <summary> Caps tag offer quantities to match what was actually resolved, so currency validation uses correct amounts. </summary>
  static void AdjustTagOfferQuantities(
    Dictionary<TradeOffer, int> offers,
    Dictionary<TradeOffer, List<(Item ResolvedItem, int Quantity)>> resolved);

  void AnnounceTrade(PurchaseData data, GameActionPack pack, bool contentsSold);

  Result Validate(PurchaseData data);

  Result ValidateOffers(PurchaseData data);

  Result ValidateCurrency(PurchaseData data);

  GameActionPack PerformTradeWithPurchaseData(PurchaseData data, GameActionPack pack = null);
}
