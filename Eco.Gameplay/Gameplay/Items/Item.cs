// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Item
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Base class for all items inside Eco.</summary>
/// <remarks>
/// Items are objects that can be stored in stacks inside inventories.
/// <see cref="T:Eco.Gameplay.Skills.Skill" /> is an exception to that rule, violates Liskov substitution principle and should be fixed in the future.
/// </remarks>
[Serialized]
[ItemGroup("Items")]
[ForceCreateViewAllDerived]
[HasIcon(null)]
[ReadOnlyController]
public abstract class Item : 
  ItemRepresentation,
  IItem,
  ILinkableParameterized<LinkConfig>,
  ILinkable,
  IHasIcon,
  IController,
  IViewController,
  IHasUniversalID
{
  public static 
  #nullable disable
  ThreadSafeAction ItemsInitialized;

  [SyncToView(null, true)]
  public virtual 
  #nullable enable
  string IconName { get; }

  public virtual string IconComment { get; }

  [SyncToView(null, true)]
  public virtual int TypeID { get; }

  public Type Type { get; }

  /// <summary> Returns display name for given item. This name same as class Display Name and should be specified as [LocDisplayName] attribute. </summary>
  [Notify]
  public override LocString DisplayName { get; }

  public override string Name { get; set; }

  public bool IsUnique { get; }

  public float Fuel { get; }

  public bool IsFuel { get; }

  /// <summary>Represents the original weight of this item, in grams.</summary>
  public int WeightWithoutModifiers { get; }

  /// <summary>Represents the <see cref="P:Eco.Gameplay.Items.Item.WeightWithoutModifiers" /> if this item with player defined modifiers attached, in grams.</summary>
  public int Weight { get; }

  /// <summary>Flag determining if this item instance has associated weight.</summary>
  public bool HasWeight { get; }

  public bool IsCarried { get; }

  public bool IgnoreAuth { get; }

  public SkillModifiedValue? Yield { get; }

  public bool HasYield { get; }

  public bool HasCrop { get; }

  public bool CanBeCurrency { get; }

  public bool MakesRoads { get; }

  public bool Compostable { get; }

  public bool ResourcePile { get; }

  public bool CanAirInteraction { get; }

  public string Category { get; }

  public bool Hidden { get; }

  public string Group { get; }

  public int MaxStackSize { get; }

  /// <summary>Is this item a waste return from crafting?</summary>
  public bool IsWasteProduct { get; }

  /// <summary>
  /// Checks if this instance has the same type and in case of unique items whether its unique properties,
  /// like durability level or associated settlement, match using rules defined for that specific item type.
  /// </summary>
  /// <remarks>
  /// Use this method if you need custom comparison rules for unique items, like similar durability levels or same associated settlement.
  /// If only item type is relevant, use <see cref="M:Eco.Gameplay.Items.Item.RepresentsItemType(System.Type)" /> instead.
  /// </remarks>
  public override bool RepresentsItem(Item other);

  /// <summary>Checks if this item instance represents item of the given type.</summary>
  /// <remarks>
  /// This method of checking for item match ignores any unique properties an item instance might have and only checks the type.
  /// If matching some conditions other than type for a unique item, like durability level or associated settlement, is necessary use <see cref="M:Eco.Gameplay.Items.Item.RepresentsItem(Eco.Gameplay.Items.Item)" /> instead.
  /// </remarks>
  public sealed override bool RepresentsItemType(Type itemType);

  /// <summary>Checks if two items can be stored in one stack.</summary>
  /// <remarks>When overriding this method remember to check if you need to override <see cref="P:Eco.Gameplay.Items.Item.IsStackable" />.</remarks>
  public virtual bool CanStack(Item? other);

  /// <summary>False if <see cref="M:Eco.Gameplay.Items.Item.CanStack(Eco.Gameplay.Items.Item)" /> will always return false for this item.</summary>
  /// <remarks>
  /// All items are stored in stacks, but for items that are not stackable stack size will always be 1 and <see cref="M:Eco.Gameplay.Items.Item.CanStack(Eco.Gameplay.Items.Item)" /> should always return false.
  /// By default unique items are not stackable, so the ones that implement custom stacking logic should override both <see cref="M:Eco.Gameplay.Items.Item.CanStack(Eco.Gameplay.Items.Item)" /> and this property.
  /// </remarks>
  public virtual bool IsStackable { get; }

  /// <summary>
  /// Items that can stack together always share this hash, so it can pre-group candidates cheaply — but the reverse does not hold:
  /// two items with the same hash may still refuse <see cref="M:Eco.Gameplay.Items.Item.CanStack(Eco.Gameplay.Items.Item)" /> (e.g. repairable parts whose durabilities differ within
  /// one quality group), so consumers must confirm with <see cref="M:Eco.Gameplay.Items.Item.CanStack(Eco.Gameplay.Items.Item)" /> before actually merging.
  /// </summary>
  public virtual int StackingHash { get; }

  /// <summary>Returns an item instance that should be used to represent this item in a stack created by merging this item's stack with another one.</summary>
  /// <param name="mergingInto">Item stored in a stack into which the stack that contains this item is being merged.</param>
  /// <param name="thisCount">Count of this item that is stored in its stack.</param>
  /// <param name="otherCount">Count of the other item in its own stack.</param>
  /// <remarks>
  /// By default items are non unique and same instance is always used to represent them.
  /// Item types that have unique properties should override this method.
  /// Splitting is handled separately by <see cref="M:Eco.Gameplay.Items.Item.SplitItem(System.Int32,System.Int32)" /> before calling Merge.
  /// </remarks>
  public virtual Item Merge(Item? mergingInto, int thisCount, int otherCount);

  /// <summary>Splits internal per-instance data when a stack is divided. Returns (moved, remaining).</summary>
  public virtual (Item Moved, Item Remaining) SplitItem(int movedCount, int remainingCount);

  [SyncToView(null, true)]
  public LocString GetDescription { get; }

  [SyncToView(null, true)]
  public virtual ItemHandOrigin HandOrigin { get; }

  [SyncToView(null, true)]
  public virtual bool CanBeHeld { get; }

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  /// <summary>
  /// Clear the max stack size cache, typically called when item modifiers change
  /// </summary>
  public static void ClearMaxStackSizeCache();

  /// <summary> Returns MaxStackSize with  server stack size multiplier </summary>
  public static int GetMaxStackSize(Type? itemType);

  /// <summary> Returns MaxStackSize without server stack size multiplier. As its cached - we remember raw values and only after caching we apply modifiers </summary>
  public static int GetMaxStackSizeRaw(Type? itemType);

  /// <param name="quantity">The quantity of the stack that's related to this item.</param>
  public virtual void Destroy(int quantity = 1);

  [SyncToView(null, true)]
  public bool IsTool { get; }

  [SyncToView(null, true)]
  public virtual bool CustomHighlight { get; }

  public virtual Item Clone();

  public override string ToString();

  /// <summary>This get called whenever a unique item is destroyed. This method will make sure that if the item is unique and has some subscriptions it will unsubscribe from them all.</summary>
  public virtual void UnsubscribeUnique();

  public virtual string OnUsed(Player player, ItemStack itemStack);

  public virtual void OnLeftClicked(Player player, ItemStack itemStack);

  public virtual void OnSelected(Player player);

  public virtual void OnDeselected(Player player);

  public static 
  #nullable disable
  Item[] AllItemsIncludingHidden { get; }

  public static Item[] AllItemsExceptHidden { get; }

  public static Item Get(IRepresentsItem itemProxy);

  public static Item Get(int itemTypeID);

  public static T Get<T>() where T : Item;

  public static Item Get(Type type);

  public static Item Get(string typename);

  public static string ShowName(Type type, float count = 1f);

  public static string ShowName(Type type, int count = 1);

  public static string ShowName<T>(int count = 1) where T : Item;

  public static LocString NameAndNum(Type type, int count = 1);

  public static SkillBook GetSkillbookForSkillType(Type type);

  public static Item CreatingItem(Type type);

  public static Item RandomItem { get; }

  public static Type GetCreatedObj(Type itemType);

  public static bool TypeIsUnique(Type itemType);

  /// <summary>If the item is unique, we create a new item and return it of that type. Otherwise, for non unique items where theyre all identical, we just reference the static item and return that.</summary>
  public static Item GetNonUniqueOrClone(int itemType);

  public static Item GetNonUniqueOrClone(Type type);

  public static LocString NameAndNum(Type type, float count);

  public static void Initialize();

  public static Item GetItemByString(User user, string item);

  public static int GetID(Item item);

  public static int GetID(Type itemType);

  public static bool HasID(Type type);

  public static int GetID<T>();

  public static Type GetType(int itemTypeID);

  public static Type GetType(string typename);

  public static Item[] Create<T>(int count = 1) where T : Item;

  public static Item[] Create(Type itemType, int count = 1);

  public static T Create<T>() where T : Item;

  public static Item Create(Type itemType);
}
