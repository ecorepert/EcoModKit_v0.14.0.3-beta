// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.AtomicActions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Shared.Voxel;
using Eco.Simulation;
using Eco.Simulation.Types;
using System;
using System.Collections.Generic;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.GameActions;

/// <summary>
/// Atomic actions are anything that has must be performed in a single transaction.
/// Performing an atomic action builds up the ActionPack, which consists of a set of things to test at first, game actions to run
/// through laws and contracts, and then post-effects that are run if everything in the action pack succeeds, and finally things that
/// are disposed when the pack is finished.
/// All atomic actions should check the early-out failure on the pack before doing anything
/// (not necessary for actions that utilize <see cref="M:Eco.Gameplay.GameActions.AtomicActions.PerformMultiblockToolAction(Eco.Gameplay.GameActions.GameActionPack,Eco.Gameplay.GameActions.MultiblockActionContext,System.Func{Eco.Shared.Math.WrappedWorldPosition3i,System.Type,Eco.Core.Utils.Result},System.Boolean)" /> since the check will be performed there).
/// </summary>
public static class AtomicActions
{
  /// <summary> Tries to remove block item from the inventory to spawn it as a loose rubble. Burns player's calories if needed. </summary>
  public static void DropRubble(
    this GameActionPack pack,
    Player player,
    BlockItem blockItem,
    Inventory inventory,
    Vector3 position,
    float caloriesNeeded);

  public static bool PickupRubbles(
    this GameActionPack pack,
    Player? player,
    Inventory inventory,
    IEnumerable<RubbleObject> rubbles,
    Type itemType,
    INetObject? tool = null,
    bool notificate = true);

  /// <summary> Efficiently explodes area. </summary>
  public static bool ExplodePositions(
    this GameActionPack pack,
    Player? player,
    IEnumerable<Vector3i> positions,
    WorldObject obj,
    Action<IEnumerable<Vector3i>> validPositionsAction,
    float pollutionTons);

  /// <summary> Burn calories or fail if not enough available. </summary>
  public static void BurnCaloriesAndCheckExhaustion(
    this GameActionPack pack,
    User? user,
    bool canPerformWhenExhausted,
    float needed,
    bool allowDepletingLastCalories = true);

  /// <summary> Burn fuel or fail if not enough available. </summary>
  public static void BurnFuel(
    this GameActionPack pack,
    FuelSupplyComponent? fuelComponent,
    float needed);

  /// <summary> See if we can remove an item, and queue it for post if so. </summary>
  public static void RemoveFromInventory(
    this GameActionPack pack,
    User? user,
    Inventory inventory,
    Type itemType);

  /// <summary> See if we can remove an item, and queue it for post if so. </summary>
  public static void RemoveUniqueFromInventory(
    this GameActionPack pack,
    User? user,
    Inventory inventory,
    Item item);

  public static void AddToInventory(
    this GameActionPack pack,
    Inventory? inventory,
    Item item,
    int amount = 1,
    User? user = null);

  public static Result ClaimPropertyNow(
    Deed deed,
    User actor,
    PlotPos plotPos,
    ClaimedOrUnclaimed actionType = ClaimedOrUnclaimed.ClaimingLand,
    bool isAdminCommand = false,
    bool notify = false,
    bool usePlotCount = false,
    bool newSettlement = false,
    IAlias? initialOwner = null,
    LocString? deedName = null,
    PropertyType propertyType = PropertyType.Residence);

  public static Result ClaimOrUnclaimPropertiesNow(
    Deed deed,
    User actor,
    IEnumerable<PlotPos>? plotPosToClaim,
    IEnumerable<PlotPos>? plotPosToUnclaim,
    bool isAdminCommand = false,
    bool notify = false,
    bool usePlotCount = false,
    bool newSettlement = false,
    IAlias? initialOwner = null,
    LocString? deedName = null,
    PropertyType propertyType = PropertyType.Residence,
    Type? itemUsedToClaim = null);

  /// <summary>Claim/unclaim combo operation for lists for plot positions in PLOT-SPACE to claim/unclaim.
  /// If initialOwner is null, will default to claimer.
  /// If actor is null, then delete the things removed.</summary>
  public static GameActionPack ClaimOrUnclaimProperties(
    this GameActionPack pack,
    Deed? deed,
    User claimingUser,
    IEnumerable<PlotPos>? attemptClaimList,
    IEnumerable<PlotPos>? attemptUnclaim,
    bool isAdminCommand,
    bool notify,
    bool usePlotCount,
    bool newSettlement,
    IAlias? initialOwner,
    LocString? deedName,
    PropertyType? propertyType,
    Type? itemUsedToClaim);

  public static GameActionPack ClaimProperty(
    this GameActionPack pack,
    Deed deed,
    User actor,
    PlotPos plotPos,
    ClaimedOrUnclaimed actionType = ClaimedOrUnclaimed.ClaimingLand,
    bool isAdminCommand = false,
    bool notify = false,
    bool usePlotCount = false,
    bool newSettlement = false,
    IAlias? initialOwner = null,
    LocString? deedName = null,
    PropertyType propertyType = PropertyType.Residence,
    Type? itemUsedToClaim = null);

  /// <summary> Uses tool to place blocks of provided type on the target area. </summary>
  public static void PlaceBlock(
    this GameActionPack pack,
    MultiblockActionContext context,
    Type blockType,
    Type? targetBlockType = null,
    bool createBlockAction = false,
    Inventory? removeFromInv = null,
    Type? itemToRemove = null);

  /// <summary> Add the deletion of blocks to the passed action pack and use tool, if able. </summary>
  public static void DeleteBlock(
    this GameActionPack pack,
    MultiblockActionContext context,
    Inventory? addToInventory = null,
    Item? fallbackGiveItem = null,
    bool spawnRubble = true,
    bool deleteWholeStack = false,
    bool harvestPlantsAbove = false);

  /// <summary> Add the deletion of blocks to the passed action pack and use tool, if able. </summary>
  public static void DeleteBlock(
    this GameActionPack pack,
    MultiblockActionContext context,
    Func<WrappedWorldPosition3i, bool> harvestPlantsAbove,
    Inventory? addToInventory = null,
    Item? fallbackGiveItem = null,
    bool spawnRubble = true,
    bool deleteWholeStack = false);

  /// <summary> Uses tool to change type of blocks in the area. </summary>
  public static void ChangeBlock(
    this GameActionPack pack,
    MultiblockActionContext context,
    Type newType,
    bool genericNotify = true);

  /// <summary>Consume energy, use durability and gain XP if related params are provided.</summary>
  public static void UseTool(
    this GameActionPack pack,
    MultiblockActionContext context,
    float multiplier = 1f);

  public static void PaintBlock(
    this GameActionPack pack,
    MultiblockActionContext context,
    ByteColor byteColor,
    byte coat,
    List<ItemStack> bucketStacks);

  public static void ClearBlockPaint(this GameActionPack pack, MultiblockActionContext context);

  public static void ClearObjectPaint(
    this GameActionPack pack,
    MultiblockActionContext context,
    WorldObject obj,
    int channel);

  public static void PaintObject(
    this GameActionPack pack,
    MultiblockActionContext context,
    WorldObject obj,
    ByteColor color,
    byte coat,
    int channel,
    List<ItemStack> bucketStacks);

  /// <summary> Destroy plants in the area. Will use the tool (i.e. reduce durability, try give XP and burn calories). </summary>
  ///  // Use DestroyPlantInternal if you don't want to trigger UseTool.
  public static void DestroyPlant(
    this GameActionPack pack,
    MultiblockActionContext context,
    DeathType deathType = DeathType.Harvesting,
    Inventory? harvestTo = null,
    Func<PlantSpecies, bool> plantSpeciesChecked = null);

  /// <summary> Harvest a PlantEntity into provided inventory. </summary>
  public static void HarvestPlant(
    this GameActionPack pack,
    MultiblockActionContext context,
    Inventory harvestTo,
    bool reapableOnly = true,
    bool genericNotify = true);

  /// <summary> Helper for calling the 'Now' functions immediately. </summary>
  public static Result DoNow(Action<GameActionPack> func, User? user, bool notify = true);

  public static Result DropRubbleNow(
    Player player,
    BlockItem blockItem,
    Inventory inventory,
    Vector3 position,
    float calories,
    bool notify = true);

  public static Result PickupRubblesNow(
    Player player,
    Inventory inventory,
    IEnumerable<RubbleObject> rubble,
    Type itemType,
    INetObject? tool = null,
    bool notify = true);

  public static Result ChangeBlockNow(
    MultiblockActionContext context,
    Type newType,
    bool notify = true,
    bool genericNotify = true);

  public static Result DestroyPlantNow(
    MultiblockActionContext context,
    DeathType deathType = DeathType.Harvesting,
    Inventory? harvestTo = null,
    bool notify = true,
    Func<PlantSpecies, bool> plantSpeciesChecked = null);

  public static Result HarvestPlantNow(
    MultiblockActionContext context,
    Inventory harvestTo,
    bool reapableOnly = true,
    bool notify = true,
    bool genericNotify = true);

  public static Result UseToolNow(MultiblockActionContext context, float multiplier = 1f, bool notify = true);

  public static Result DeleteBlockNow(
    MultiblockActionContext context,
    Inventory? addTo = null,
    Item? fallbackItem = null,
    bool spawnRubble = true,
    bool wholeStack = false,
    bool harvestPlantsAbove = false,
    bool notify = true);

  public static Result PlaceBlockNow(
    MultiblockActionContext context,
    Type blockType,
    Type? targetBlockType = null,
    bool createBlockAction = false,
    Inventory? removeFrom = null,
    Type? removeItem = null,
    bool notify = true);

  public static Result PaintBlockNow(
    MultiblockActionContext context,
    ByteColor color,
    byte coat,
    List<ItemStack> buckets,
    bool notify = true);

  public static Result ClearBlockPaintNow(MultiblockActionContext context, bool notify = true);

  public static Result PaintObjectNow(
    MultiblockActionContext context,
    WorldObject obj,
    ByteColor color,
    byte coat,
    int channel,
    List<ItemStack> buckets,
    bool notify = true);

  public static Result ClearObjectPaintNow(
    MultiblockActionContext context,
    WorldObject obj,
    int channel,
    bool notify = true);

  public static Result ExplodePositionsNow(
    Player? player,
    IEnumerable<Vector3i> positions,
    WorldObject obj,
    Action<IEnumerable<Vector3i>> validPositionsAction,
    float pollutionTons = 0.0f,
    bool notify = true);
}
