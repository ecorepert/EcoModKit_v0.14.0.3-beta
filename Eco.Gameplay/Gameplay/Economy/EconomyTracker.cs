// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.EconomyTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.Trackers;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy;

[LocDisplayName("EconomyTracker")]
public class EconomyTracker : 
  Singleton<
  #nullable disable
  EconomyTracker>,
  IController,
  IViewController,
  IHasUniversalID,
  IServerPlugin,
  IThreadedPlugin,
  IShutdownablePlugin
{
  public static ThreadSafeAction<IEnumerable<TradeTracker>> NewTradesAddedEvent;
  public static ThreadSafeAction<IEnumerable<Item>> OnItemsChangedInTrades;
  public ThreadSafeList<ItemDistributionComponent> DistributionStations;
  public bool ForceCollectStatsNow;

  public ExchangeRates ExchangeRates { get; }

  public void AddRepairTracker(RepairTracker repair);

  public void RemoveRepairTracker(RepairTracker repair);

  public void AddPickupTracker(PickupTracker pickup);

  public void RemovePickupTracker(PickupTracker pickup);

  public void AddStation(ItemDistributionComponent obj);

  public void RemoveStation(ItemDistributionComponent obj);

  public void StationsChanged(User obj);

  public static void AddTable(CraftingComponent crafting);

  public static void RemoveTable(CraftingComponent crafting);

  public static void AddContract(Contract contract);

  public static void RemoveContract(Contract contract);

  public static void UpdateSource(IHasTradeOffers store, bool playerChange);

  public void Run();

  public Task ShutdownAsync();

  public void DoWork();

  public static void RemoveSource(IHasTradeOffers store);

  public (List<LocString> Offers, LocString Summary, LocString Worth) FindSaleOffers(
    User user,
    int id,
    Func<TradeTracker, bool> filter = null);

  public (List<LocString> Offers, LocString Summary, LocString Worth) FindBuyOffers(
    User user,
    int id,
    Func<TradeTracker, bool> filter = null);

  public (List<LocString> Offers, LocString Summary, LocString Worth) FindSaleOffersByTag(
    User user,
    Tag tag);

  public (List<LocString> Offers, LocString Summary, LocString Worth) FindBuyOffersByTag(
    User user,
    Tag tag);

  /// <summary>The stores a user owns that currently have offers, nearest first. Stores with nothing listed are left out - they're of no use to a shopper.</summary>
  public IEnumerable<WorldObject> StoresOwnedBy(User owner, User viewer);

  public int ItemTypesForSale { get; }

  public int ItemsForSale { get; }

  public int ActiveStores { get; }

  public string GetCategory();

  public string GetStatus();

  public override string ToString();

  public static int ContractCount { get; }

  public static string BrowserDesc { get; }

  public static string DistributionStationDesc { get; }

  public ref int ControllerID { get; }
}
