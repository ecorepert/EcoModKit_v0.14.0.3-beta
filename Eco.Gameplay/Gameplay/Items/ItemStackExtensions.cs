// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemStackExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

public static class ItemStackExtensions
{
  public static LocString NameAndNum(this 
  #nullable disable
  ItemRepresentation item, int count = 1);

  public static IEnumerable<IStack> ConsolidateIntoCopies(this IEnumerable<IStack> stackList);

  public static Dictionary<Type, int> ToDict(this IEnumerable<ItemStack> stackList);

  public static Dictionary<Tag, int> ToTagsDict(this Dictionary<Type, int> availableItems);

  public static Dictionary<Tag, int> ToTagsDict(this IEnumerable<ItemStack> stackList);

  public static int IncreaseItemQuantity(this IList<IStack> itemStacks, Item item, int quantity);

  public static int StackSum(this IEnumerable<ItemStack> stacks);

  /// <summary>Sumes quantities of items matching type.</summary>
  public static int CountItemsByType(this IEnumerable<ItemStack> stackList, Type type);

  /// <summary>Counts items that match a unique item.</summary>
  public static int CountItemsUnique(this IEnumerable<ItemStack> stackList, Item matchingItem);

  public static bool ContainsItems(
    this IEnumerable<ItemStack> stackList,
    IEnumerable<ItemStack> testList);

  public static void ModifyStack(
    this ItemStack itemStack,
    User user,
    int increment,
    Func<bool> test = null,
    Action onSuccess = null);

  public static bool TryModifyStack(
    this ItemStack itemStack,
    User user,
    int increment,
    Func<bool> test = null,
    Action onSuccess = null);

  public static void RemoveList(this IList<ItemStack> self, IList<ItemStack> list);

  public static void MergeInto(this ThreadSafeList<ItemStack> self, IList<ItemStack> list);
}
