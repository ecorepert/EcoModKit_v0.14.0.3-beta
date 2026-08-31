// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.EnumerableItemExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

public static class EnumerableItemExtensions
{
  /// <param name="allowEmptyStack">Sometimes we still want to return the stacks that are empty (quantity == 0).</param>
  public static IEnumerable<IStack> MakeSafe<TStack>(
    this IEnumerable<TStack> stacks,
    bool allowEmptyStack = false)
    where TStack : IStack;

  public static LocString Describe(this IEnumerable<Item> items);

  public static LocString Describe(this IEnumerable<KeyValuePair<Type, int>> items);

  public static void AddStacks(this ThreadSafeList<IStack> items, IEnumerable<IStack> newItems);

  public static void AddStack(this ThreadSafeList<IStack> items, IStack stack);

  public static void RemoveItems(this IEnumerable<IStack> origin, IEnumerable<IStack> other);

  public static void RemoveItems(
    this IEnumerable<IStack> items,
    ItemRepresentation toRemove,
    int quantity);

  public static IEnumerable<LocString> Descriptions(this IEnumerable<IStack> stacks, int multiplier = 1);

  public static LocString Describe(this IEnumerable<IStack> stacks, int multiplier = 1);

  public static LocString DescribeInline(this IEnumerable<IStack> stacks, int multiplier = 1, int max = 3);

  public static string DescribeTextOnly(this IEnumerable<IStack> stacks, int max);

  public static string DescribeNoText(this IEnumerable<IStack> stacks);

  public static string DescribeNoNum(this IEnumerable<IStack> stacks, bool plural);

  public static IEnumerable<Item> SortItems(this IEnumerable<Item> enumerable);
}
