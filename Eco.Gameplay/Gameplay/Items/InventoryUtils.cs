// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items.SearchAndSelect;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

public static class InventoryUtils
{
  /// <summary>How many more of <paramref name="item" /> this inventory could accept across its empty and same-type stacks.
  /// An approximation for capacity displays/warnings, ignores in-flight change sets.</summary>
  public static int RoomFor(this 
  #nullable disable
  Inventory inventory, Item item);

  public static void AddItemsWithVoidStorageFallback(
    LocString name,
    User user,
    Item item,
    int quantity);

  /// <summary>Move all items to destination, unless they dont all fit, then move all to void storage.</summary>
  /// <returns>We get the quantity moved.</returns>
  public static InventoryMoveResult MoveItemsWithVoidStorageFallback(
    LocString voidStorageName,
    Inventory source,
    Inventory dest,
    User user,
    Vector3i pos,
    Func<ItemStack, bool> testFunc = null);

  public static void AddItemsWithVoidStorageFallback(
    LocString name,
    User user,
    IEnumerable<ItemStack> stacks);

  public static IEnumerable<IStack> AggregateStacks(this IEnumerable<IEnumerable<IStack>> lists);

  public static void ApplyRandomInventory(
    this SearchAndSelectInventory inv,
    int itemTypes,
    bool? carried = null,
    int maxCount = 5);

  public static void ApplyRandomInventory(
    this Inventory inv,
    int itemTypes,
    bool? carried = null,
    int maxCount = 5,
    bool fixedCount = false);

  public static void Randomize(this SearchAndSelectItem item, int range = 5);

  public static IEnumerable<ItemStack> Intersection(
    this IEnumerable<ItemStack> stacksToCull,
    IEnumerable<ItemStack> contents);

  public static int SumQuantites(this IEnumerable<IStack> stacks);

  public static bool CanMoveItems(
    this Inventory inventory,
    Type itemType,
    int delta,
    User user,
    AccessType accessNeeded = AccessType.FullAccess);

  /// <summary> Checks whether it's possible for the <paramref name="user" /> to perform changes in this inventory. </summary>
  /// <param name="inventory"></param>
  /// <param name="itemType"> Some inventories can allow to move item of specific types (like in workables). </param>
  /// <param name="allowedQuantity"> Amount of items being moved, absolute value. The value may be adjusted by some restrictions (like in item distribution component). </param>
  /// <param name="delta"> Signed amount of items being moved. </param>
  /// <param name="user"></param>
  public static bool CanMoveItems(
    this Inventory inventory,
    Type itemType,
    int delta,
    User user,
    ref int allowedQuantity,
    AccessType accessNeeded = AccessType.FullAccess);

  public static InventoryAction MakeGameAction(
    this Inventory inventory,
    Type itemType,
    int delta,
    User user,
    AccessType accessNeeded);

  /// <summary>Tries to find first stack matching <paramref name="predicate" /> or if not found then uses first empty stack. It may fail if inventory is full.</summary>
  /// <returns><c>true</c> if either matching or empty stack was found; <c>false</c> if inventory is full and no matching stack.</returns>
  public static bool TryGetFirstStackMatchingOrEmpty(
    this Inventory inventory,
    Func<Item, bool> predicate,
    out ItemStack itemStack);

  /// <summary>Attempts to find a <see cref="T:Eco.Gameplay.Items.ItemStack" /> based on an <see cref="T:Eco.Gameplay.Items.Item" /> type instance inside the Inventory</summary>
  /// <param name="inventory">Inventory to search</param>
  /// <param name="searchItem"><see cref="T:Eco.Gameplay.Items.Item" /> type instance to search for</param>
  /// <returns>The first discovered <see cref="T:Eco.Gameplay.Items.ItemStack" /> instance if found. Otherwise null</returns>
  public static 
  #nullable enable
  ItemStack? FindItemStack(this Inventory inventory, Item searchItem);

  /// <summary>Checks if the inventory contains any instances of the requested search <see cref="T:Eco.Gameplay.Items.Item" /> type instance.</summary>
  /// <param name="inventory">Inventory to search</param>
  /// <param name="searchItem"><see cref="T:Eco.Gameplay.Items.Item" /> type instance to search for</param>
  /// <returns>True if an instance was found. Otherwise false</returns>
  public static bool ContainsItem(this Inventory inventory, Item searchItem);
}
