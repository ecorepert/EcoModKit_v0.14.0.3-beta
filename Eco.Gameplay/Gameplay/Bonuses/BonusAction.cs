// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Types of actions that can trigger bonuses. Crafting and harvesting aspects are flattened into distinct actions. </summary>
public enum BonusAction
{
  None,
  ResourceCost,
  LaborCost,
  CraftTime,
  Yield,
  Pollution,
  [LocDisplayName("power consumption")] Power,
  Unlock,
  Durability,
  Integrity,
  CompleteWorkOrder,
  Garbage,
  HarvestYield,
  HarvestFreshness,
  TargetBlock,
  PickupDebris,
  UseTool,
  ConsumeFood,
  AutoProcessLog,
  PlantMaturity,
  FertilizerNutrient,
  RepairPenalty,
}
