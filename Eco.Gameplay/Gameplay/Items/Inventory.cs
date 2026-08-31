// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Inventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

[AddINotifyPropertyChangedInterface]
[Serialized]
public abstract class Inventory : IController, IViewController, IHasUniversalID
{
  public static 
  #nullable disable
  ThreadSafeAction<Inventory> InventoryInitialized;
  public static ThreadSafeAction<Inventory> InventoryDestroyed;
  public static ThreadSafeAction<IEnumerable<ItemStack>> StacksChanged;
  public static ThreadSafeAction<Inventory> InventoryEffectsChanged;
  public LocString OverrideOwnerName;
  public readonly Guid LockID;
  public object LockObject;

  public ThreadSafeAction<User, IEnumerable<KeyValuePair<Item, int>>, Dictionary<ItemStack, ChangedStack>> OnChangedDetailed { get; }

  public ThreadSafeAction<User> OnChanged { get; }

  public virtual WorldObjectHandle Owner { get; }

  [SyncToView(null, true)]
  public virtual LocString OwnerName { get; }

  [SyncToView(null, true)]
  internal IEnumerable<InventoryComponent> Components { get; }

  [SyncToView(null, true)]
  public float ShelfLifeMultiplier { get; set; }

  /// <summary>Fraction of stored waste's ground pollution that escapes this storage, from the owning object's [WasteRetention]. 1 = no containment.</summary>
  [SyncToView(null, true)]
  public float WasteRetentionRatio { get; set; }

  internal void AddComponent(InventoryComponent component);

  internal T GetComponent<T>() where T : InventoryComponent;

  public ref int ControllerID { get; }

  protected virtual IEnumerable<Inventory> SubInventories { get; }

  public IEnumerable<Inventory> AllInventories { get; }

  [SyncToView(null, true)]
  public virtual IEnumerable<ItemStack> Stacks { get; }

  [SyncToView(null, true)]
  public bool IsFull { get; }

  [SyncToView(null, true)]
  public float FillPerCent { get; }

  /// <summary> If this inventory can receive item move events. Client can also filter this for drag and drop stuff </summary>
  [SyncToView(null, true)]
  public bool AvailableForItemInteractions { get; set; }

  /// <summary>
  /// Stacks that can be manipulated through linked inventories, in sub-inventories that have similar item restrictions, override in concrete InventoryView to exclude certain stacks that would appear in <see cref="P:Eco.Gameplay.Items.Inventory.Stacks" />
  /// <para>See <see cref="T:Eco.Gameplay.Items.UserInventory" /> example, excluding the <see cref="T:Eco.Gameplay.Items.ClothingInventory" /> as it's restricted to clothing items only, very different from <see cref="T:Eco.Gameplay.Items.ToolbarBackpackInventory" /></para>
  /// </summary>
  public virtual IEnumerable<ItemStack> ManipulatableStacks { get; }

  public Inventory Parent { get; }

  public Inventory Root { get; }

  public IEnumerable<Inventory> AllParents { get; }

  public IEnumerable<Inventory> AllParentsAndSelf { get; }

  protected void NotifyParentsStacksChanged();

  public virtual bool NeedsAuth { get; }

  public void SetOwner(WorldObject owner);

  internal bool IsParentOf(Inventory inventory);

  public virtual bool IsLeafInventory { get; }

  protected virtual void Initialize();

  /// <summary>We make sure to call OnChanged to apply all the necessary changes.</summary>
  public void ApplyChanges(
    User user,
    IEnumerable<Item> changes,
    Dictionary<ItemStack, ChangedStack> changedStacks);

  /// <summary>True once <see cref="M:Eco.Gameplay.Items.Inventory.Destroy" /> ran. The object stays reachable through stale client references (stacks resolve by controller id),
  /// so acceptance checks refuse destroyed inventories: anything added would exist nowhere reachable and silently vanish on the next load.</summary>
  public bool IsDestroyed { get; }

  public virtual void Destroy();

  public IEnumerable<ItemStack> NonEmptyStacks { get; }

  public IEnumerable<ItemStack> GroupedStacks { get; }

  public Dictionary<Type, int> TypeToCount { get; }

  public bool IsEmpty { get; }

  public int TotalNumberOfItems<T>() where T : Item;

  public int TotalNumberOfItems(Type itemType);

  public int TotalNumberOfItems(Tag itemTag);

  public int TotalNumberOfItems(ItemRepresentation representation);

  public int TotalNumberOfItems(string displayName);

  public bool Contains(IEnumerable<ItemStack> stacks);

  /// <summary>Returns non-empty stacks where item is typeof(T) and fits filter</summary>
  public IEnumerable<ItemStack> GetStacks<T>(Func<T, bool> filter) where T : Item;

  public IEnumerable<ItemStack> GetItemsWithTags(Tag tag, int num);

  public void Clear(User user = null);

  public void ClearItemStack(ItemStack stack, User user = null);

  public Result TryClearItemStack(ItemStack stack, User user = null);

  /// <summary>We get all the items stacks inside this inventory and then we make sure to empty it.</summary>
  public List<ItemStack> GetStacksAndClear();

  /// <summary>This method make sure to clear all stacks content and then replace them with the content of the specified new stacks.</summary>
  public void ReplaceItems(IEnumerable<ItemStack> newStacks, bool ignoreRestrictions);

  public void AddItem(Item item, User user = null);

  public Result TryAddItem(Item item, User user = null);

  public void AddItemNonUnique<T>(User user = null) where T : Item;

  public void AddItemNonUnique(Type itemType, User user = null);

  public Result TryAddItemNonUnique<T>(User user = null) where T : Item;

  public Result TryAddItemNonUnique(Type itemType, User user = null);

  public void AddItemsNonUnique<T>(int quantity, User user = null) where T : Item;

  public void AddItemsNonUnique(Type itemType, int quantity, User user = null);

  public bool AddItems(Item item, int quantity, User user = null);

  public bool AddItems(ItemStack stack, User user = null);

  public bool AddItems(IEnumerable<ItemStack> stacks, User user = null);

  public Result TryAddItemsNonUnique<T>(int quantity, User user = null) where T : Item;

  public Result TryAddItemsNonUnique(Type itemType, int quantity, User user = null);

  public void RemoveItem<T>(User user = null) where T : Item;

  public void RemoveItem(Type itemType, User user = null);

  public Result TryRemoveItem<T>(User user = null) where T : Item;

  public Result TryRemoveItem(Type itemType, User user = null);

  public void RemoveItems<T>(int quantity, User user = null);

  public void RemoveItems(ItemStack stack, User user = null);

  public void RemoveItems(Type itemType, int quantity, User user = null);

  public List<(Item Item, int Quantity)> RemoveAsMuchAsPossible(
    ItemRepresentation stackable,
    int quantity,
    User user = null,
    Func<Item, bool> itemFilter = null);

  public Result TryRemoveItems<T>(int quantity, User user = null);

  public Result TryRemoveItems(ItemStack stack, User user = null);

  public Result TryRemoveItems(IEnumerable<ItemStack> stacks, User user = null);

  public Result TryRemoveItems(Type itemType, int quantity, User user = null);

  /// <summary>Remove as much as we can, up to desired quantity, and return results.</summary>
  public ValResult<int> TryRemoveItemsAsManyAsPossibleByType(
    Type itemType,
    int quantity,
    User user = null);

  /// <summary>Remove as much as we can, up to desired quantity, and return results.  Respects unique properties of item.</summary>
  public ValResult<int> TryRemoveItemsAsManyAsPossibleUnique(
    Item mustMatchItem,
    int quantity,
    User user = null);

  public void MoveItems(Type type, int quantity, Inventory destination, User user = null);

  public void MoveItems<T>(int quantity, Inventory destination, User user = null);

  public void MoveItems<T, TKey>(
    int quantity,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null,
    User user = null);

  public void MoveItems<TKey>(
    Type itemType,
    int quantity,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null,
    User user = null);

  public void MoveItems<TKey>(
    Item sourceItem,
    int quantity,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null,
    User user = null);

  public Result TryMoveItems(Type type, int quantity, Inventory destination, User user = null);

  public Result TryMoveItems(Item sourceItem, int quantity, Inventory destination, User user = null);

  public Result TryMoveItems<T>(int quantity, Inventory destination, User user = null);

  public Result TryMoveItems<T, TKey>(
    int quantity,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null,
    User user = null);

  public Result TryMoveItems<TKey>(
    Type itemType,
    int quantity,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null,
    User user = null);

  public Result TryMoveItems<TKey>(
    Item sourceItem,
    int quantity,
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    Func<ItemStack, TKey> sourceStackOrder = null,
    User user = null);

  public ValResult<int> MoveAllItems(
    Item itemSource,
    int quantity,
    Inventory destination,
    bool allowPartial,
    Func<ItemStack, bool> sourceStackPredicate = null,
    User user = null);

  public ValResult<int> FillTargetStack(Type itemType, ItemStack targetStack, User user = null);

  public ValResult<int> FillTargetStack(
    Type itemType,
    ItemStack targetStack,
    int quantity,
    User user = null);

  public ValResult<int> FillTargetStack(
    Type itemType,
    ItemStack targetStack,
    int quantity,
    Func<ItemStack, bool> sourceStackPredicate = null,
    User user = null);

  public ValResult<int> MoveAsManyItemsAsPossible(
    Inventory destination,
    User user = null,
    InventoryAccessType accessType = InventoryAccessType.Player);

  public ValResult<int> MoveAsManyItemsAsPossible(
    Inventory destination,
    Func<ItemStack, bool> sourceStackPredicate = null,
    User user = null,
    InventoryAccessType accessFromVehicle = InventoryAccessType.Player);

  public void Modify(Action<IInventoryChangeSet> callback, User user = null);

  public Result TryModify(Action<IInventoryChangeSet> callback, User user = null);

  public static ValResult<int> SuccessMoveWrapper(
    User user,
    Inventory source,
    Inventory target,
    Item item,
    int quantity);

  public static Result MoveItems(
    ItemStack sourceStack,
    ItemStack targetStack,
    User user,
    int quantityOverride = -1);

  [RPC]
  public virtual BSONObject MoveItems(Player player, ItemStack sourceStack, ItemStack targetStack);

  [RPC]
  public BSONObject MoveItems(
    Player player,
    ItemStack sourceStack,
    Inventory target,
    int quantity = -1);

  public Result MoveItems(ItemStack sourceStack, Inventory target, int quantity = -1, User user = null);

  /// <summary> Moves items to a given target stack, and if that fails, just drop it in the inventory in general. </summary>
  [RPC]
  public BSONObject MoveItemsDoublePass(
    Player player,
    ItemStack sourceStack,
    ItemStack targetStack,
    Inventory alternativeInventoryTarget);

  public Result MoveItemsDoublePass(
    ItemStack sourceStack,
    ItemStack targetStack,
    Inventory alternativeInventoryTarget,
    User user = null);

  [RPC]
  public virtual void MoveItems(Player player, Inventory source, Inventory target, Item itemType);

  [RPC]
  public virtual BSONObject MoveSomeItems(
    Player player,
    ItemStack sourceStack,
    ItemStack targetStack,
    int quantity);

  [RPC]
  public virtual string UseStack(Player player, ItemStack stack);

  [RPC]
  protected virtual void SelectStack(Player player, ItemStack stack);

  public virtual void ReplaceStack(
    Player player,
    ItemStack originalStack,
    int itemTypeID,
    int count);

  /// <summary>Short text next to the inventory name, such as "Food" or "Carried Only". Empty when the inventory takes anything.</summary>
  [SyncToView(null, true)]
  public LocString RestrictionLabel { get; }

  /// <summary>Icon drawn faintly in the empty slots and beside the label.</summary>
  [SyncToView(null, true)]
  public string RestrictionIcon { get; }

  /// <summary>Full wording of every restriction, for the tooltip behind the label.</summary>
  [SyncToView(null, true)]
  public LocString RestrictionDetails { get; }

  /// <summary>How many times an item's regular stack size fits in a stack here. 1 when the inventory grants no bonus.</summary>
  [SyncToView(null, true)]
  public float StackMultiplier { get; }

  /// <summary>Stack cap of a stockpile, equal to the pile's physical height in blocks. 0 when stacks aren't tied to a real height.</summary>
  [SyncToView(null, true)]
  public int StackHeight { get; }

  /// <summary>Tags an item may carry to be accepted. Empty when tags don't decide.</summary>
  [SyncToView(null, true)]
  public List<string> AcceptedTags { get; }

  /// <summary>Names of the item types accepted on top of <see cref="P:Eco.Gameplay.Items.Inventory.AcceptedTags" />. Empty when types don't decide.</summary>
  [SyncToView(null, true)]
  public List<string> AcceptedTypes { get; }

  [SyncToView(null, true)]
  public InventoryCarryRule CarryRule { get; }

  /// <summary>True when the three fields above fully describe what gets refused, letting the client dim this inventory mid-drag.
  /// False leaves it lit: a wrong refusal reads far worse than a missing one.</summary>
  [SyncToView(null, true)]
  public bool RejectionIsPredictable { get; }

  public IEnumerable<InventoryRestriction> Restrictions { get; }

  public void ClearRestrictions();

  public void RemoveLastRestriction();

  public void RemoveAllRestrictions(Predicate<InventoryRestriction> removeTest);

  public void RemoveAllRestrictions();

  public void AddInvRestriction(InventoryRestriction restriction);

  public void AddInvRestrictions(IEnumerable<InventoryRestriction> restrictions);

  public bool HasRestriction<T>() where T : InventoryRestriction;

  public int GetMaxAcceptedVal(Item item, int currentQuantity, User user = null, Inventory pickupTarget = null);

  public ValResult<int> GetMaxPickup(
    Item item,
    int currentQuantity,
    InventoryChangeSet changeSet,
    Inventory otherInventory = null,
    int totalMoved = 0);

  /// <summary>
  /// Get the maximum amount of item are allowed to put into this inventory
  /// </summary>
  /// <param name="item"></param>
  /// <param name="currentQuantity">Current quantity of the Item in the Inventory</param>
  /// <param name="changeSet">Data of the current transfer</param>
  /// <param name="sourceInventory"></param>
  public ValResult<int> GetMaxAccepted(
    Item item,
    int currentQuantity,
    InventoryChangeSet changeSet,
    Inventory sourceInventory = null);

  public ValResult<int> GetMaxAccepted(
    Item item,
    int currentQuantity,
    InventoryChangeSet changeSet,
    Inventory sourceInventory,
    out InventoryRestriction strongestRestriction);

  /// <summary>
  /// Check restrictions based on general data (for use outside changesets, some general pre-checks, etc).
  /// Get the maximum amount of items are allowed to pick up from the current Item stack
  /// </summary>
  /// <param name="item">Items that are being transferred</param>
  /// <param name="currentQuantity">Current quantity of the Item in the Inventory</param>
  /// <param name="user"></param>
  /// <param name="targetInventory"></param>
  public ValResult<int> GetMaxPickup(
    Item item,
    int currentQuantity,
    User user = null,
    Inventory targetInventory = null);

  public ValResult<int> GetMaxAccepted(
    Item item,
    int currentQuantity,
    User user = null,
    Inventory sourceInventory = null);

  /// <summary>Determines if the given item is accepted by the inventory regardless of the count.</summary>
  public bool AcceptsItem(Item item);

  /// <summary>Given a set of violated restrictions, will try to resolve a message that best describes all restrictions altogether.
  /// TODO: This was introduced as a quick fix for Store. Eventually inventory moves/restrictions/messages have to be rebuilt to keep a context of the initiating action.</summary>
  /// <param name="violatedRestrictions">A set of violated restrictions to use for resolution.</param>
  /// <param name="message">The generated message.</param>
  /// <returns>If a specialized message could be produced or not.</returns>
  public static bool TryGetBestRestrictionMessage(
    IEnumerable<InventoryRestriction> violatedRestrictions,
    out LocString message);

  /// <summary>Snapshot of everything the restriction list says about this inventory, rebuilt only when that list changes.</summary>
  private class Profile
  {
    public LocString Label;
    public string IconName;
    public LocString Details;
    public float StackMultiplier;
    public int StackHeight;
    public List<string> Tags;
    public List<string> Types;
    public InventoryCarryRule CarryRule;
    public bool IsPredictable;
  }

  private enum RestrictionCheckType
  {
    MaxPickup,
    MaxAccepted,
  }
}
