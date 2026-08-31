// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PickupBountyComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>Lets non-owners pick up items from a storage for a per-item bounty. Prices are entered unsigned and <see cref="P:Eco.Gameplay.Components.PickupBountyComponent.PaymentDirection" /> decides who pays;
/// internally a price stays signed, positive meaning the collector pays the owner.</summary>
[Serialized]
[Priority(100)]
[CreateComponentTabLoc("Pickup Bounty", false)]
[LocDescription("Allows setting per-item bounties for items stored in this container. Non-owners can pick up the items in exchange for the bounty.")]
[NoIcon]
public class PickupBountyComponent : 
  WorldObjectComponent,
  IHasEnvVars,
  IPersistentData,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  public 
  #nullable disable
  object PersistentData { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringTitle")]
  public LocString Title { get; set; }

  [Autogen]
  [AutoRPC]
  [SyncToView(null, true)]
  [EnvVar]
  [GuestHidden]
  public bool CollectionEnabled { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("CollectionEnabled")]
  [LocDescription("Who pays whom when someone else empties this container. Every price below is entered as a plain amount; this decides its direction.")]
  public PickupBountyDirection PaymentDirection { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("CollectionEnabled")]
  [LocDescription("Default per-item amount applied to items not listed in PricedItems. Set to 0 to require an explicit listing.")]
  [Range(0.0f, 10000f)]
  public float DefaultPricePerItem { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess, Serialized = false)]
  [VisibilityParam("CollectionEnabled")]
  public ControllerList<PricedItem> PricedItems { get; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("CollectionEnabled")]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  [VisibilityParam("CollectionEnabled")]
  public BankAccount BankAccount { get; set; }

  /// <summary>The set of item Types that have an explicit bounty entry.</summary>
  public IEnumerable<Type> PricedItemTypes { get; }

  /// <summary>True when the owner is the one paying, so every price is a payout to the collector.</summary>
  public bool OwnerPays { get; }

  /// <summary>Signed per-item bounty: explicit entry first, else <see cref="P:Eco.Gameplay.Components.PickupBountyComponent.DefaultPricePerItem" />.</summary>
  public float GetPriceForItemType(Type itemType);

  /// <summary>True if the item type has an explicit price entry, or the default price is non-zero.</summary>
  public bool HasPriceFor(Type itemType);

  /// <summary>Total bounty for a stack, priced purely by the stack's item type.</summary>
  public float GetPriceForStack(ItemStack stack);

  public override void OnCreate();

  /// <summary>True when the component is properly configured, on owned land, and the storage has at least one priced item in stock.</summary>
  [Notify]
  [DependsOnMember("CollectionEnabled")]
  [DependsOnMember("Currency")]
  [DependsOnMember("BankAccount")]
  public bool CollectionAvailable { get; }

  /// <summary>Per-user env var: true when collection is available and the querying user is not an owner.</summary>
  [EnvVar]
  public bool CanCollect(User user);

  /// <summary>Whole interaction label: carries the verb so the player reads which way the money goes before clicking.</summary>
  [EnvVar]
  [Notify]
  [DependsOnMember("CollectionAvailable")]
  [DependsOnMember("PaymentDirection")]
  [DependsOnMember("DefaultPricePerItem")]
  [DependsOnMember("Currency")]
  public string CollectionSummaryString { get; }

  public override void Initialize();

  public override void PostInitialize();

  public override void Destroy();

  [Interaction(InteractionTrigger.RightClick, "%CollectionSummaryString%", InteractionModifier.Ctrl, new string[] {"CanCollect"}, 0.0f, 10f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {})]
  public void CollectInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  /// <summary>Moves the requested quantity from storage to <paramref name="targetInventory" /> and runs the transfer. <paramref name="moveAction" /> is called per item-type group for routing.</summary>
  public Result DoCollectInto(
    User collector,
    BankAccount collectorAccount,
    int requestedQuantity,
    InventoryCollection targetInventory,
    Action<Item, InventoryChangeSet, Inventory, HashSet<ItemStack>, int> moveAction = null);

  private readonly struct BuyMaxPlan : IEquatable<PickupBountyComponent.BuyMaxPlan>
  {
    public BuyMaxPlan(int Total, float TotalPrice);

    public int Total { get; init; }

    public float TotalPrice { get; init; }

    [CompilerGenerated]
    public override string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      PickupBountyComponent.BuyMaxPlan left,
      PickupBountyComponent.BuyMaxPlan right);

    [CompilerGenerated]
    public static bool operator ==(
      PickupBountyComponent.BuyMaxPlan left,
      PickupBountyComponent.BuyMaxPlan right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(PickupBountyComponent.BuyMaxPlan other);

    [CompilerGenerated]
    public void Deconstruct(out int Total, out float TotalPrice);
  }
}
