// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CraftingComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Modules;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[LocDescription("View and create build orders from this crafting table.")]
[Priority(-150)]
[RequireComponent(typeof (CreditComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
[HasIcon(null)]
[Tag("Crafting Table")]
[Ecopedia(null, null, false, true, null)]
public class CraftingComponent : 
  WorldObjectComponent,
  IOperatingWorldObjectComponent,
  INotifyPropertyChanged,
  IHasEnvVars,
  IPersistentData
{
  public WorkOrder? ActiveWorkOrder;
  public ThreadSafeAction OnActiveWorkOrderChanged;
  public static Dictionary<Type, HashSet<Type>> WorldObjectToSkillsUsed;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  public object PersistentData { get; set; }

  public int? OverrideMaxQueuedOrders { get; set; }

  public float DefaultDurabilityReduction { get; }

  /// <summary>Determines how fast durability reduces, based on work order. By default, looks for a recipe durability override then locks to a default of 30</summary>
  public virtual double ReducePartDurabilityPerHourOfUse(WorkOrder order);

  public virtual LocString DecayDescription { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 145, TTCat.Crafting, TTFlags.None, null, new Type[] {})]
  [TooltipAffectedBy("Parent", "OperatingEfficiency", null)]
  public LocString OperatingEfficiencyTooltip();

  [SyncToView(null, true)]
  public IEnumerable<RecipeFamily> Recipes { get; }

  [SyncToView(null, true)]
  public static IEnumerable<RecipeFamily> AllRecipes { get; }

  [SyncToView(null, true)]
  public IEnumerable<string> ValidTalents { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public ControllerList<WorkOrder> WorkOrders { get; }

  [SyncToView(null, true)]
  [Serialized]
  [Notify]
  public ImmutableCountdown TotalCraftTime { get; }

  public WorkOrder? CurrentWorkOrder { get; }

  public WorkOrder? GetWorkOrder(Guid guid);

  public WorkOrder? CurrentUnfinishedWorkOrder { get; }

  [SyncToView(null, true)]
  public PluginModule? ResourceEfficiencyModule { get; }

  [SyncToView(null, true)]
  public PluginModule? SpeedEfficiencyModule { get; }

  [SyncToView(null, true)]
  public PluginModule? LaborReservationModule { get; }

  [WatchSubMember("OnInventoryContentsChanged", "LinkedInventoryContentChangeEvent", SubPropWatcherFlag.None)]
  public LinkComponent? Link { get; set; }

  public ThreadSafeAction LinkedInventoryContentChangeEvent { get; }

  [Serialized]
  [Notify]
  public bool BottleNecked { get; }

  [RPC]
  public string GetSelectedFilter(Player player);

  [RPC]
  public void SetSelectedFilter(Player player, string filterKey);

  [RPC]
  public List<string> GetIngredientFilters(Player player, Recipe recipe);

  [RPC]
  public void SetIngredientFilter(
    Player player,
    Recipe recipe,
    string tagName,
    List<string> allowedItemNames);

  [RPC]
  public Task ApplyIngredientFilterToAllRecipes(Player player, string recipeId, string tagName);

  [RPC]
  public List<string> GetTagsWorthApplyingToOthers(Player player, Recipe recipe);

  public static 
  #nullable disable
  IEnumerable<RecipeFamily> RecipesOnWorldObject(Type worldObjectType);

  public static IEnumerable<Type> TablesForRecipe(Type recipeType);

  public static IEnumerable<RecipeFamily> RecipesForItem(Type itemType);

  public static void AddTagProduct(
  #nullable enable
  Type tableType, Type recipeType, Recipe product);

  public static void AddRecipe(Type tableType, RecipeFamily recipeFamily);

  public static void SortRecipes();

  public bool Operating { get; }

  public double TimeLeft { get; }

  /// <summary>Contributes carried or selected item to the workorder</summary>
  /// 
  ///             interactionContextTODO: Implement parameter updating for the 'ActiveWorkOrder' instead of passing UILink from server.
  [Interaction(InteractionTrigger.RightClick, "Contribute %Selected% to %WorkOrderNeedsSelectedItems%", InteractionModifier.None, new string[] {"WorkOrderNeedsSelectedItems"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void ContributeSelectedItem(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  /// <summary>gets all valid inventories we can take/put items</summary>
  /// <param name="user"></param>
  /// <param name="input">require take ability from inventories</param>
  /// <param name="output">require put ability from inventories</param>
  public InventoryCollection GetConnectedInventories(User user, bool input, bool output);

  public override void Initialize();

  /// <summary>Refreshes the status line that reports the pending garbage: fill ratio, a per-material breakdown (rendered like a
  /// tooltip) and the block the current contents would form. Called whenever the accumulator is mutated (merge after a craft
  /// cycle, flush when a full block is produced).</summary>
  public void UpdateGarbageStatus();

  public override void Destroy();

  internal void InventoryChanged();

  public WorkOrder? ProcessWorkOrders();

  public override void Tick();

  internal void Tick(float deltaTime);

  [RPC]
  public void GetValidTalents();

  [RPC]
  public Task<bool> CreateWorkOrder(
    Player player,
    Recipe recipe,
    int quantity,
    BankAccount account);

  public Result CreateWorkOrderResult(User user, Recipe recipe, int quantity, BankAccount account);

  public Result CreateWorkOrderResult(
    User currentUser,
    RecipeFamily recipeFamily,
    int quantity,
    BankAccount bankAccount,
    bool automatic);

  [RPC]
  public void CancelPendingWorkOrder(Player player);

  /// <summary>Returns the bonus-adjusted craft time in seconds for one iteration of a recipe at this crafting table. Mirrors
  /// <see cref="T:Eco.Gameplay.Items.WorkOrder" />'s start-iteration math (module speed context, then CraftTime bonuses) so the preview matches the queued order.</summary>
  [RPC]
  public float GetBonusAdjustedCraftTime(Player player, Recipe recipe);

  /// <summary>Returns bonus-adjusted ingredient quantities for a recipe at this crafting table. Includes module and talent bonuses so the client can display accurate costs.</summary>
  [RPC]
  public float[] GetBonusAdjustedIngredients(Player player, Recipe recipe);

  /// <summary>Returns bonus-adjusted product quantities for a recipe at this crafting table. Includes module and talent yield bonuses so the client can display accurate output.
  /// Ingredient refunds mirror the work order's math: they scale with the resource-cost discount and skip yield bonuses.</summary>
  [RPC]
  public float[] GetBonusAdjustedProducts(Player player, Recipe recipe);

  /// <summary>Returns bonus-adjusted garbage quantities for a recipe at this crafting table, aligned to <see cref="P:Eco.Gameplay.Items.Recipes.Recipe.TotalGarbages" />.
  /// Applies talent/module bonuses via <see cref="F:Eco.Gameplay.Bonuses.BonusAction.Garbage" /> to each material's base per-iteration quantity.</summary>
  [RPC]
  public float[] GetBonusAdjustedGarbages(Player player, Recipe recipe);

  [RPC]
  public bool AddWorkOrderToBench(Player player, WorkOrder workOrder, BankAccount account);

  public Result AddWorkOrderToBench(User user, WorkOrder workOrder, BankAccount account);

  [RPC]
  public void ReorderWorkOrders(Player player, List<WorkOrder> sortedWorkOrders);

  [RPC]
  public Task CancelWorkOrder(Player player, WorkOrder workOrder);

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);

  public void EvictPickup(User user, Inventory inv);

  [Interaction(InteractionTrigger.RightClick, "Add 100 Labor to %WorkOrderNeedsLabor%", InteractionModifier.Shift, new string[] {"WorkOrderNeedsLabor"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void Add100Labor(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.RightClick, "Add all Labor to %WorkOrderNeedsLabor%", InteractionModifier.Alt, new string[] {"WorkOrderNeedsLabor"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void AddAllLabor(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [EnvVar]
  public string? WorkOrderNeedsLabor(User user);

  [EnvVar]
  public string? WorkOrderNeedsSelectedItems(User user);
}
