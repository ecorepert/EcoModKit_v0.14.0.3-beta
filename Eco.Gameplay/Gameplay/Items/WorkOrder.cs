// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.WorkOrder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Gameplay;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>An item that represents a work order being performed at a crafting table.</summary>
[Serialized]
[LocDescription("Work orders are made to indicate the beginning of a project. They can be completed by putting in the proper materials and labor.")]
public class WorkOrder : 
  SimpleEntry,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  ISharedWorkOrder,
  IHasPosition
{
  public static ThreadSafeAction<WorkOrder> StartedWorkOrderEvent;
  public static ThreadSafeAction<WorkOrder> CancelledWorkOrderEvent;
  public static ThreadSafeAction<WorkOrder> WorkOrderCompletedEvent;
  public const float MarkerVisibilityDistance = 5f;
  public ThreadSafeAction OnCollected;
  [Serialized]
  public ThreadSafeList<FractionalItemStack> AddedIngredients;

  public float LaborAndResourcePercentDoneForIteration { get; }

  public float LaborAndResourcePercentDoneTotal { get; }

  [DependsOn("CurrentRecipe")]
  public Item Product { get; }

  public Item? Byproduct { get; }

  [Notify]
  public CraftingComponent? CraftingComponent { get; }

  public WorldObject? WorldObject { get; }

  [Serialized]
  public Guid Guid { get; }

  [Serialized]
  [Notify]
  public User? Owner { get; }

  [Serialized]
  public WorkOrderState State { get; }

  [Serialized]
  [SyncToView(null, true)]
  public ImmutableCountdown ContributedCraftTime { get; }

  [Serialized]
  [SyncToView(null, true)]
  public WorkParty? WorkParty { get; set; }

  [Serialized]
  [Notify]
  public ControllerHashSet<User>? KnowledgeShare { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerHashSet<User> WatchingUsers { get; set; }

  [Serialized]
  public ThreadSafeList<ItemStack> CompletedProducts { get; set; }

  [Serialized]
  public ThreadSafeList<CompletedGarbage> CompletedGarbages { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int OriginalQuantity { get; }

  [Serialized]
  [SyncToView(null, true)]
  public int UncraftedQuantity { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float CraftTime { get; }

  [Serialized]
  public string? RecipeName { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool HasItemsToCollect { get; }

  [SyncToView(null, true)]
  public Vector3 Position { get; }

  [SyncToView(null, true)]
  public RecipeFamily? Recipe { get; }

  [SyncToView(null, true)]
  public LocString RecipeFriendlyName { get; }

  [SyncToView(null, true)]
  [DependsOn("CraftTime", new string[] {"OriginalQuantity"})]
  public double TotalTime { get; }

  [SyncToView(null, true)]
  [Serialized]
  [ThreadSafe]
  public List<string> ValidProducts { get; set; }

  [SyncToView(null, true)]
  public List<Eco.Gameplay.Items.Recipes.Recipe> AllProducts { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string CurrentProductName { get; set; }

  [SyncToView(null, true)]
  [DependsOn("CurrentProductName")]
  public Eco.Gameplay.Items.Recipes.Recipe? CurrentRecipe { get; }

  [SyncToView(null, true)]
  public bool BlockedForAwhile { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public bool AutoselectProduct { get; set; }

  [SyncToView(null, true)]
  public bool AllowAutoselect { get; }

  [SyncToView(null, true)]
  public bool IsOwner(Player player);

  [DependsOn("ContributedCraftTime")]
  public double TimeLeft { get; }

  [DependsOn("UncraftedQuantity")]
  public bool Finished { get; }

  public bool Blocked { get; }

  [Serialized]
  [SyncToView(null, true)]
  public CraftingBlockingType BlockingType { get; set; }

  public InventoryCollection DefaultInventory { get; }

  [Notify]
  public InventoryCollection DefaultInputInventory { get; }

  public InventoryCollection DefaultOutputInventory { get; }

  [Serialized]
  public CraftingFees? CraftingFees { get; set; }

  public void OnLinkedInventoryChange();

  protected WorkOrder();

  public WorkOrder(
    User creator,
    Inventory inventory,
    RecipeFamily recipe,
    int quantity,
    CraftingComponent parent);

  public void Start(Inventory inventory);

  public void ParentDisabled();

  internal void ApplyOperatingEfficiency(float efficiency);

  /// <summary> Checks if a work order should change state based on its internal timers. </summary>
  internal bool CheckTime(bool canBeActive);

  public override void Destroyed();

  public override void Initialize();

  /// <summary> Tries to link <see cref="T:Eco.Gameplay.Items.WorkOrder" /> to <see cref="P:Eco.Gameplay.Items.WorkOrder.CraftingComponent" /> (usually on load). It may fail if <see cref="T:Eco.Gameplay.Items.WorkOrder" /> is invalid. </summary>
  internal bool TryLinkToCraftingComponent(CraftingComponent craftingComponent);

  public void UpdateProduct();

  [RPC]
  public void StartRecipe(Player player, Eco.Gameplay.Items.Recipes.Recipe recipe, BankAccount bankAccount);

  [RPC]
  public void Cancel(Player player);

  public void SetCurrentProduct(Eco.Gameplay.Items.Recipes.Recipe recipe);

  public bool NeedsLiquid { get; }

  public int ConsumeLiquid(Type itemType, int amount);

  public void CancelIntoCollection();

  public override bool Equals(object? obj);

  public override int GetHashCode();

  public Result Verify();

  public void OnRemovingDueVerifyFailed();

  public override LocString UILinkContent(bool iconsOnly);

  [Serialized]
  public ThreadSafeList<IngredientItemFilter> IngredientItemFilters { get; }

  public void SetIngredientFilters(IEnumerable<IngredientItemFilter>? filters);

  public bool IsItemAllowedForIngredient(TagStack ingredient, Item item);

  [RPC]
  public Task EditIngredientFilter(Player player, string tagName);

  public void ApplyIngredientFiltersToDisplay();

  [Serialized]
  public float LaborPerIteration { get; }

  [Serialized]
  public float TotalContributedLabor { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float LaborPerformed { get; }

  [SyncToView(null, true)]
  [DependsOn("LaborPerIteration", new string[] {"LaborPerformed", "LaborFullCost"})]
  public float LaborPercentage { get; }

  [SyncToView(null, true)]
  [DependsOn("LaborPerIteration", new string[] {"OriginalQuantity"})]
  public float LaborFullCost { get; }

  [SyncToView(null, true)]
  public float AllowedLabor { get; }

  public float LaborOnCurrentIteration { get; }

  public double RealCraftTime { get; }

  public double TimeOnCurrentIteration { get; }

  public int CurrentIteration { get; }

  public float AvailableLabor { get; }

  public float LaborReservationMultiplier { get; }

  [RPC]
  public bool TryToContributeLabor(Player player, InteractionModifier modifier = InteractionModifier.None);

  public Result TryToContributeLabor(User user, float contributionMultiplier = 1f);

  public bool ContributedLabor(User user);

  /// <summary>
  /// Returns max iterations for which labor may be reserved.
  /// For short crafts (less than <see cref="F:Eco.Gameplay.Items.WorkOrder.CraftTimePerLaborReservationUnit" />) it will have more iterations per <see cref="P:Eco.Gameplay.Items.WorkOrder.LaborReservationMultiplier" /> unit.
  /// For long crafts (greater than or equal to <see cref="F:Eco.Gameplay.Items.WorkOrder.CraftTimePerLaborReservationUnit" />) it will have one iteration per <see cref="P:Eco.Gameplay.Items.WorkOrder.LaborReservationMultiplier" /> unit.
  /// </summary>
  public int GetMaxIterationsForLaborReservation();

  /// <summary> Returns max labor reservation. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float GetMaxLaborReservation();

  public ValResult<float> PossibleLaborContributeAmount(
    User user,
    float contributionMultiplier,
    bool checkCalAndIngredients,
    out float requiredCalories);

  [SyncToView(null, true)]
  public string LatestContribution { get; set; }

  /// <summary> Describes active talent/module bonuses affecting resource costs for this work order's crafting context. </summary>
  [SyncToView(null, true)]
  public LocString ActiveBonusDescriptions { get; }

  public LocString DisplayName { get; }

  public override LocString UILinkContent();

  public LocString DescribeNeededSkills { get; }

  public LocString BlockReason();

  public IEnumerable<IStack> IngredientsRemaningInAllIterations();

  public LocString DescribeLabor(float labor);

  public int CompletedQuantity { get; }

  public int TotalTimeSpent { get; }

  public WorkOrder.BottleneckType GetBottleneckType();

  public LocString OwnershipTooltip(bool userIsOwner, bool userHasFullAccess);

  public void SendNotification(LocString text, bool temporary = false);

  public override string ToString();

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<TagStack> MissingIngredients { get; }

  [Serialized]
  [SyncToView(null, true)]
  public TagStack[]? NeededTags { get; }

  [SyncToView(null, true)]
  [DependsOn("UncraftedQuantity", new string[] {"State", "NeededTags", "OriginalQuantity"})]
  [DependsOnController("MissingIngredients", true)]
  public float ResourcePercentage { get; }

  public bool AnyNeededInCurentIteration(ItemStack item);

  public static bool CanUseItemForCrafting(Item? item);

  public int NeededCount(ItemRepresentation item, WorkOrder.IterationDesc check);

  /// <summary> Return true if this or a future iteration needs the given item.</summary>
  public bool Needs(Item item);

  [RPC]
  public void TryToCollectItems(Player collector);

  [RPC]
  public int AddIngredientsToCurrentIteration(Player player, ItemStack stack, int maxToContribute = 2147483647 /*0x7FFFFFFF*/);

  public int AddIngredientsToCurrentIteration(User user, ItemStack stack, int maxToContribute = 2147483647 /*0x7FFFFFFF*/);

  internal Result TryDepositItems(
    Inventory destInventory,
    Inventory sourceInventory,
    User? performer = null);

  public void OnInventoryChanged(User actor, CraftingComponent craftingComponent);

  public Result ScanInventoryAndContribute(
    User? actor,
    Inventory inventory,
    WorkOrderContributionType contributionType);

  internal IEnumerable<(Item? Item, int Quantity)> GetItemsToRefund();

  [Serialized]
  public ThreadSafeList<FractionalItemStack> CraftingScrap { get; }

  public enum BottleneckType
  {
    None,
    Resources,
    Labor,
  }

  public enum IterationDesc
  {
    CurrentIteration,
    RemainingIterations,
  }
}
