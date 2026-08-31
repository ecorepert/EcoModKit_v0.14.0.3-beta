// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryChangeSet
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.AtomicAction;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>A collection of modifications we wish to perform on an inventory</summary>
public sealed class InventoryChangeSet : 
  IInventoryChangeSet,
  IAtomicAction,
  IDisposable,
  IGameActionPackChangeSet
{
  public 
  #nullable disable
  Dictionary<ItemStack, ChangedStack> ChangedStacks;
  public bool IgnoreRestrictions;
  public InventoryAccessType InventoryAccessType;
  public AccessType AccessNeeded;
  public Action<IEnumerable<Item>> OnItemsMoved;
  public Action<IEnumerable<ItemStack>> OnStacksMoved;
  public static ConcurrentDictionary<int, string> StacktraceCreation;
  public int? CarriedStackSizeCap;

  public static InventoryChangeSet New(Inventory inventory, User user = null);

  public static InventoryChangeSet New(IEnumerable<Inventory> inventories, User user = null);

  internal InventoryChangeSet(Inventory inventory, User user = null);

  ~InventoryChangeSet();

  public void AddItemNonUnique<T>(Inventory inventory = null);

  public void AddItemNonUnique(Type itemType, Inventory inventory = null);

  public void AddItemsNonUnique<T>(int quantity, Inventory inventory = null);

  public void AddItemsNonUnique(Type itemType, int quantity, Inventory inventory = null);

  public void RemoveItemByType<T>(Inventory inventory = null);

  public void RemoveItemByType(Type itemType, Inventory inventory = null);

  public void RemoveItemsByType<T>(int quantity, Inventory inventory = null);

  public void RemoveItemsByType(Type itemType, int quantity, Inventory inventory = null);

  public void Clear(Inventory inventory = null);

  public User GetUser();

  public bool HasInventory(Inventory inventory);

  public Inventory GetTargetInventory(Inventory inventory = null);

  public void AddItem(Item item, int count = 1, Inventory inventory = null);

  public void AddItems(IEnumerable<ItemStack> stacks);

  /// <summary>Merges <paramref name="stack" /> with <paramref name="newItem" /> changing its quantity by <paramref name="delta" />.</summary>
  public void MergeStack(ItemStack stack, int delta, Item newItem);

  public void ModifyStack(ItemStack stack, int delta);

  public void ClearStack(ItemStack stack);

  /// <summary>Removes one item of the given type from inventory, returning the split item reference.
  /// Uses SplitItem to properly redistribute per-instance data (e.g. FractionalBlockItem repartition).</summary>
  public Item SplitFromStack(Type itemType, Inventory inventory = null);

  /// <summary>Removes one item from a specific stack, returning the split item reference.
  /// Uses SplitItem to properly redistribute per-instance data (e.g. FractionalBlockItem repartition).</summary>
  public Item SplitFromStack(ItemStack stack);

  public void MoveStacks(ItemStack source, ItemStack destination, int requestedQuantity);

  public void MoveItemsNonUnique(
    Type itemType,
    int quantity,
    Inventory source,
    Inventory destination);

  public void MoveItemsNonUnique<TKey>(
    Type itemType,
    int quantity,
    Inventory source,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null);

  public void MoveItems(
    Item item,
    int quantity,
    Inventory source,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null);

  /// <summary>Moves items with an optional source stack order, ordered by a given key</summary>
  public void MoveItems<TKey>(
    Item item,
    int quantity,
    Inventory source,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null);

  /// <summary>Try to move all items from src to dst inventory with move result.</summary>
  /// <remarks>Only returns failure when not a single item is moved otherwise success</remarks>
  public InventoryMoveResult MoveAllItems(
    Inventory source,
    Inventory destination,
    bool allowPartial,
    Func<ItemStack, bool> selector = null);

  /// <summary>Try to move all items from source to dst inventory with result.</summary>
  public ValResult<int> MoveAllItems(
    Item sourceItem,
    int quantity,
    Inventory source,
    Inventory destination,
    bool allowPartial,
    Func<ItemStack, bool> sourceStackPredicate = null);

  public ValResult<int> MoveAsManyItemsAsPossible(
    Type itemType,
    int quantity,
    Inventory source,
    Inventory destination,
    ItemStack destinationStack,
    Func<ItemStack, bool> sourceStackPredicate = null);

  public int RemoveItemsUnique(Item matchesItem, int quantity, Inventory inventory);

  /// <summary> Tries to remove as much as possible <paramref name="representation" /> up to <paramref name="requested" />. Returns in order of least
  /// durability first, if there is durability.</summary>
  /// <returns> Returns all removed items with count. </returns>
  public List<(Item Item, int Quantity)> RemoveAsMuchAsPossible(
    ItemRepresentation representation,
    int requested,
    Func<Item, bool> itemFilter = null);

  public void Dispose();

  public Result CanApplyNonDisposing();

  public Result TryApply();

  public Result Apply();

  public Result ApplyInternal(bool throwOnInvalid, bool consolidating = false);

  /// <summary>Return a comma-separated string of the recent items added to the inventory.</summary>
  public LocString DescribeWhatItAdds();

  /// <summary>Item.Merge mutates the target it's handed and the target here may still be the live stack's item, which must not change
  /// until Apply — a failed change set would otherwise leave the container corrupted. So merges work on a private copy of unique items;
  /// Apply installs the copy via ReplaceStack.</summary>
  internal static Item MergeOnCopy(Item incoming, Item target, int incomingCount, int targetCount);

  public Result PerformWithActionManager();

  public LocString GameActionPackPostEffect();

  public Result GameActionPackPretest();

  public void GameActionPackDispose();
}
