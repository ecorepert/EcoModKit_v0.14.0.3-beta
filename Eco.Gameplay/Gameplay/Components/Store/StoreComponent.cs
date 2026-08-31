// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Store.StoreComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components.Store.Internal;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using MethodTimer;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Components.Store;

[Serialized]
[Priority(-1)]
[RequireComponent(typeof (NameDataTrackerComponent), null)]
[RequireComponent(typeof (AuthDataTrackerComponent), null)]
[RequireComponent(typeof (CreditComponent), null)]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
[RequireComponent(typeof (MustBeOwnedComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[HasIcon(null)]
[Tag("Economy")]
[Ecopedia(null, null, false, true, null)]
public sealed class StoreComponent : 
  WorldObjectComponent,
  IPersistentData,
  OnOffComponent.IOnOffMessagesContainer,
  IHasTradeOffers,
  ICopyPasteComponent
{
  [Notify]
  public static 
  #nullable disable
  ThreadSafeAction<StoreComponent> BankAccountChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<StoreComponent> BalanceChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<StoreComponent> CurrencyChangedEvent { get; }

  public bool IsStockDirty { get; }

  [Serialized]
  [SyncToView(null, true, Flags = SyncFlags.MustRequest)]
  [NewTooltipChildren(CacheAs.Instance)]
  public StoreItemData StoreData { get; set; }

  [SyncToView(null, true)]
  public OnOffComponent OnOff { get; }

  [SyncToView(null, true)]
  public string CurrencyName { get; }

  [SyncToView(null, true)]
  public float Balance { get; }

  [SyncToView(null, true)]
  public bool IsBarter { get; }

  [SyncToView(null, true)]
  public Currency Currency { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  public override bool ShouldRequestEverything { get; }

  public BankAccount BankAccount { get; }

  public IEnumerable<TradeOffer> AllOffers { get; }

  LocString OnOffComponent.IOnOffMessagesContainer.NotAuthedMessage { get; }

  LocString OnOffComponent.IOnOffMessagesContainer.InvalidStatusMessage { get; }

  /// <summary>
  /// Creates new category and tries to pick best name based on tags
  /// </summary>
  [RPC(AccessType.FullAccess)]
  public void CreateCategoryWithOffers(Player player, List<int> itemIds, bool isBuy);

  /// <summary> Creates a new category with both item and tag-based trade offers in a single category. </summary>
  [RPC(AccessType.FullAccess)]
  public void CreateCategoryWithMixedOffers(
    Player player,
    List<int> itemIds,
    List<string> tagNames,
    bool isBuy);

  public Type CopyPasteGroup { get; }

  public LocString OverwriteWarning { get; }

  public Result CopyFrom(WorldObjectComponent source, Player player);

  public override void Initialize();

  object IPersistentData.PersistentData { get; set; }

  public override void Tick();

  public override void Destroy();

  [RPC(AccessType.None)]
  [Time]
  public bool PerformTrade(User customer, BSONObject tradeData, BankAccount purchaserAccount);

  public Result DoPerformTrade(
    User customer,
    BSONObject tradeData,
    BankAccount purchaserAccount,
    bool dryRun = false);

  [RPC(AccessType.None)]
  public string DryRunPerformTrade(
    User customer,
    BSONObject tradeData,
    BankAccount purchaserAccount);

  /// <summary>How many items of the given sell offer would still fit into the customer's receiving inventories. Used by the client to cap the 'max' purchase quantity.</summary>
  [RPC(AccessType.None)]
  public int CalcMaxFitForOffer(Player player, int offerId);

  bool IHasTradeOffers.EnabledForTrades { get; }

  LocString IHasTradeOffers.SourceName { get; }
}
