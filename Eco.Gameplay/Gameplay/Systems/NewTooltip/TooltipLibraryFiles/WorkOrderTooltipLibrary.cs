// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.WorkOrderTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class WorkOrderTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (WorkOrder), "Product", null, null)]
  [TooltipAffectedBy(typeof (WorkOrder), "CurrentProductName", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString WorkOrderTooltipTitle(this WorkOrder workOrder);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 80 /*0x50*/, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderCreator(this WorkOrder workOrder);

  [TooltipAffectedBy(typeof (WorkOrder), "Owner", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 90, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderOwner(this WorkOrder workOrder);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderCurrentRepetition(this WorkOrder workOrder);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 111, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderPendingCollection(this WorkOrder workOrder);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 112 /*0x70*/, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderSupplyThrottle(this WorkOrder workOrder);

  [TooltipAffectedBy(typeof (WorkOrder), "ActiveBonusDescriptions", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 115, TTCat.Default, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString WorkOrderActiveBonuses(this WorkOrder workOrder);

  /// <summary>Shows which talent unlocks the work order's recipe and whether the owner has it. Only for recipes with RequiresTalentUnlock. </summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 116, TTCat.Default, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString WorkOrderRequiredTalent(this WorkOrder workOrder);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Global, 120, TTCat.Default, TTFlags.None, typeof (WorkOrder), new Type[] {})]
  public static LocString WorkOrderHints();

  [TooltipAffectedBy(typeof (WorkOrder), "UncraftedQuantity", null, null)]
  [TooltipAffectedBy(typeof (WorkOrder), "LaborPerformed", null, null)]
  [TooltipAffectedBy(typeof (WorkOrder), "DefaultInputInventory", null, null)]
  [TooltipAffectedBy(typeof (WorkOrder), "MissingIngredients", null, null)]
  [TooltipAffectedBy("CraftingComponent", "LinkedInventoryContentChangeEvent", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 130, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderRemainigRepetition(this WorkOrder workOrder);

  /// <summary>Expected garbage output for the work order: per-craft amount (with talent bonuses applied) and cumulative amount for the remaining repetitions.
  /// Pulls from Recipe.TotalGarbages so recipe-declared waste and item-derived (SalvageCost × ratio) are both included.</summary>
  [TooltipAffectedBy(typeof (WorkOrder), "UncraftedQuantity", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 131, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderExpectedGarbage(this WorkOrder workOrder);

  [TooltipAffectedBy(typeof (WorkOrder), "KnowledgeShare", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 150, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString WorkOrderKnowledgeShared(this WorkOrder workOrder);
}
