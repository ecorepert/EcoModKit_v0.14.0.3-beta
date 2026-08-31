// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.SpoilageManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using JetBrains.Annotations;
using System;
using System.Threading;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary> Manager Responsible for ticking <see cref="T:Eco.Gameplay.Items.ItemStack" /> and creating it with <see cref="T:Eco.Gameplay.Items.ItemStack" /> that have <see cref="T:Eco.Gameplay.Items.SpoilageItem" /> and detecting it through <see cref="T:Eco.Gameplay.Items.Inventory" /> changes, See DurabilityItems.md </summary>
public class SpoilageManager
{
  public static readonly int DefaultInterval;
  /// <summary> Used to Force ticks for the plugin to update nearest time to tick when needed. </summary>
  public static AutoResetEvent Reset;

  /// <summary> Ticks the simulation returns plugin sleep time for the next simulation tick. </summary>
  /// <returns> Sleeping time. </returns>
  public int Tick();

  /// <summary>Used by <see cref="T:Eco.Gameplay.Garbage.SpoilageManager" /> to track the time at which <see cref="T:Eco.Gameplay.Items.SpoilageItem" /> is ready to spoil.</summary>
  private struct ItemStackTicker : IComparable
  {
    public ItemStack TargetStack;

    public double NextTick { get; set; }

    public ItemStackTicker(ItemStack stack, SpoilageItem spoilageItem);

    public bool IsReady { get; }

    public int CompareTo(object obj);
  }

  /// <summary> Responsible for converting spoiled items into <see cref="F:Eco.Gameplay.Garbage.SpoilageManager.ItemSpoiler.SpoiledFoodItem" /> item in batch <see cref="T:Eco.Gameplay.Items.InventoryChangeSet" />, this supports multithreaded by having locks on it in Spoilage Manager</summary>
  private class ItemSpoiler
  {
    public Item SpoiledFoodItem;

    /// <summary> Spoil all the stacks pending spoilage, in separate inventory change set actions so if one fails doesn't prevent others from happening. </summary>
    public void ApplySpoilage();

    /// <summary> Marks the given stack as spoiled to get ticked later, if the item inside is spoiled. </summary>
    public void QueueForConversion([NotNull] ItemStack stack);
  }
}
