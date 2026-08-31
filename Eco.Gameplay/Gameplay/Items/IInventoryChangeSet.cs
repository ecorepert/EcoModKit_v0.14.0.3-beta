// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IInventoryChangeSet
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

public interface IInventoryChangeSet
{
  void AddItemNonUnique<T>(Inventory inventory = null);

  void AddItemNonUnique(Type itemType, Inventory inventory = null);

  void AddItemsNonUnique<T>(int quantity, Inventory inventory = null);

  void AddItemsNonUnique(Type itemType, int quantity, Inventory inventory = null);

  void RemoveItemByType<T>(Inventory inventory = null);

  void RemoveItemByType(Type itemType, Inventory inventory = null);

  void RemoveItemsByType<T>(int quantity, Inventory inventory = null);

  void RemoveItemsByType(Type itemType, int quantity, Inventory inventory = null);

  void AddItem(Item item, int count = 1, Inventory inventory = null);

  void ModifyStack(ItemStack stack, int delta);

  void MergeStack(ItemStack stack, int delta, Item newItem);

  void ClearStack(ItemStack stack);

  /// <summary> Move the source stack items to the destination, combining/swapping depending on the items. </summary>
  void MoveStacks(ItemStack source, ItemStack destination);

  void MoveStacks(ItemStack source, ItemStack destination, int requestedQuantity);

  void MoveItemsNonUnique(Type itemType, int quantity, Inventory source, Inventory destination);

  void MoveItemsNonUnique<TKey>(
    Type itemType,
    int quantity,
    Inventory source,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null);

  ValResult<int> MoveAllItems(
    Item sourceItem,
    int quantity,
    Inventory source,
    Inventory destination,
    bool allowPartial,
    Func<ItemStack, bool> sourceStackPredicate = null);

  void Clear(Inventory inventory = null);

  /// <summary>Removes one item of the given type from inventory, returning the split item reference.
  /// Uses SplitItem to properly redistribute per-instance data (e.g. FractionalBlockItem repartition).</summary>
  Item SplitFromStack(Type itemType, Inventory inventory = null);

  /// <summary>Same, from a stack the caller already picked (e.g. after inspecting its contents).</summary>
  Item SplitFromStack(ItemStack stack);
}
