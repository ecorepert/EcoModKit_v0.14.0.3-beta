// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ForSaleComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Auth;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>A component that allows purchase + pickup of a world object.</summary>
[Serialized]
[HasIcon(null)]
[CreateComponentTabLoc("For Sale", true)]
[LocDescription("Allows setting this object for sale, so other citizens can buy it.")]
[MayHaveComponent(typeof (InOutLinkedInventoriesComponent), null)]
[MayHaveComponent(typeof (LinkComponent), null)]
public class ForSaleComponent : 
  WorldObjectComponent,
  IHasEnvVars,
  IPersistentData,
  IHasTradeOffers,
  ICopyPasteComponent,
  ICanOverrideAuth
{
  public 
  #nullable disable
  ThreadSafeAction<User, Currency, float, LocString> SoldEvent;
  public ThreadSafeList<Func<Result>> SellEvents;
  public const float PlaceAnotherRange = 8f;

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringTitle")]
  public LocString Title { get; set; }

  [SyncToView(null, true)]
  public TradeOffer TradeOffer { get; set; }

  [Autogen]
  [SyncToView(null, true)]
  [Serialized]
  [EnvVar]
  [GuestHidden]
  public bool ForSale { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("ForSale")]
  public float Price { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("ForSale")]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("ForSale")]
  public BankAccount SellersAccount { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("HasDurability")]
  [LocDescription("When pulling from storage to supply a sale, only items matching this minimum durability will be chosen.")]
  public float MinDurability { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("HasIntegrity")]
  [LocDescription("When pulling from storage to supply a sale, only items matching this minimum durability will be chosen.")]
  public float MinIntegrity { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public string Note { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [GuestHidden]
  [VisibilityParam("ForSale")]
  [LocDescription("If this is set, when the object is purchased the display copy will be replenished immediately with a matching item from a linked inventory.")]
  public bool RestockFromStorage { get; set; }

  [SyncToView(null, true)]
  public bool HasDurability { get; }

  [SyncToView(null, true)]
  public bool HasIntegrity { get; }

  [Serialized]
  public ForSaleData SaleData { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public Vector3 TagPosition { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float TagRotation { get; set; }

  [RPC(AccessType.OwnerAccess)]
  public void SetForSale(User user, bool forSale);

  [RPC(AccessType.FullAccess)]
  public void SetCurrency(User user, Currency currency);

  [RPC(AccessType.FullAccess)]
  public void SetSellersAccount(User user, BankAccount account);

  /// <summary>Config how this for-sale component works.</summary>
  public void SetConfig(
    ForSaleComponent.SaleTypes saleType,
    Func<LocString> customDescription = null,
    Func<Item> itemPickedUp = null);

  /// <summary>Can only buy it if its for sale, has valid props, and user isnt already an owner (unless force enabled)</summary>
  [SyncToView(null, true)]
  [Notify]
  [EnvVar]
  [DependsOnSubMember("Parent", "AdminForceEnabled")]
  [DependsOnSubMember("Parent", "Owners")]
  [DependsOnMember("ForSale")]
  [DependsOnMember("Currency")]
  [DependsOnMember("SellersAccount")]
  public bool CanBuy { get; }

  /// <summary>A customer has no rights on the seller's property, and an item placed on a surface resolves its auth through the
  /// owner of that surface, so the trade would always be rejected. Only the trade itself passes: taking or using the object still needs real auth.</summary>
  public LazyResult ShouldOverrideAuth(IAlias alias, IOwned property, GameAction action);

  [Interaction(InteractionTrigger.RightClick, "Buy for %SalePriceString%", InteractionModifier.Ctrl, new string[] {"CanBuy"}, 0.0f, 10f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {})]
  public void BuyInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [EnvVar]
  [DependsOnMember("Price")]
  [DependsOnMember("Currency")]
  public string SalePriceString { get; }

  public object PersistentData { get; set; }

  [Interaction(InteractionTrigger.LeftClick, "Adjust Price", InteractionModifier.Ctrl, new string[] {"ForSale"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, Priority = -1f)]
  public void AdjustPrice(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public void MarkAllChanged();

  public Type CopyPasteGroup { get; }

  public Result CopyFrom(WorldObjectComponent source, Player player);

  [Interaction(InteractionTrigger.LeftClick, "Sell", InteractionModifier.Ctrl, null, 0.0f, -1f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, RequiredEnvVars = new string[] {"ShowSellInteraction"}, DisallowedEnvVars = new string[] {"ForSale"}, MinCaloriesRequired = 0.0f)]
  public void SetForSaleInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [EnvVar]
  public bool ShowSellInteraction { get; set; }

  public override void Initialize();

  public override void OnComponentAddedPostInit(WorldObjectComponent c);

  public override void OnAfterObjectMoved();

  [RPC(AccessType.None)]
  [Autogen]
  [VisibilityParam("CanBuy")]
  [UITypeName("BigButton")]
  [UnauthenticatedRpcJustification("Buying is public by nature: the customer holds no access on the seller's property. Gated by CanBuy (for sale, currency and seller account set), by the offer validation against the live stock, and by the buyer's own access check on the account they pay from.")]
  public Task Buy(User user);

  /// <summary>Sells one unit to a customer consuming it on the spot (a dish eaten off the table), delivering nothing to their inventory.
  /// It is served from linked stock while there is any, so the same display item keeps serving customers, and only the item on display once stock runs out.</summary>
  /// <returns>The item paid for, and whether it was the display item itself, which the caller then has to remove.</returns>
  public Task<(Result Result, Item Served, bool DisplayItemServed)> SellForConsumption(
    User user,
    LocString title,
    LocString description,
    LocString confirmLabel);

  /// <summary>Only offered while linked stock can supply the copy, since that stock is where it comes from.</summary>
  [EnvVar]
  public bool CanPlaceAnother { get; }

  [Interaction(InteractionTrigger.RightClick, "Place another from stock", InteractionModifier.Alt, new string[] {"CanPlaceAnother"}, 0.0f, 9f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void PlaceAnotherInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  /// <summary>Confirmation of the client-side placement started by <see cref="M:Eco.Gameplay.Components.ForSaleComponent.PlaceAnotherInteraction(Eco.Gameplay.Players.Player,Eco.Shared.SharedTypes.InteractionTriggerInfo,Eco.Shared.SharedTypes.InteractionTarget)" />: takes a matching item out of the
  /// linked stock and stands it where the player put the ghost, sale settings included, so a seller filling a counter doesn't have to
  /// fetch and price every item by hand.</summary>
  [RPC(AccessType.FullAccess)]
  public void PlaceAnother(
    Player player,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation,
    int placeOnSurfaceOfObjectID);

  /// <summary>Takes one item out of the linked stock without any sale, for an owner consuming their own display. Null when stock can't cover it,
  /// which is when the item on display is the one that has to be used.</summary>
  public Item TakeFromStock(User user);

  public override void Destroy();

  IEnumerable<TradeOffer> IHasTradeOffers.AllOffers { get; }

  float IHasTradeOffers.Balance { get; }

  WorldObject IHasTradeOffers.Parent { get; }

  bool IHasTradeOffers.IsBarter { get; }

  IAlias IHasTradeOffers.Owners { get; }

  bool IHasTradeOffers.EnabledForTrades { get; }

  LocString IHasTradeOffers.SourceName { get; }

  LocString IHasTradeOffers.SoldOutNotice { get; }

  public enum SaleTypes
  {
    PickupObject,
    PickupInventoryOfObject,
  }
}
