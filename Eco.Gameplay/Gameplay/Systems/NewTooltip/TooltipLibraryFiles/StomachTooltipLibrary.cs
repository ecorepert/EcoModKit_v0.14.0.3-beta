// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.StomachTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class StomachTooltipLibrary
{
  public const int NutritionInfoPosition = 25;

  public static void Initialize();

  [NewTooltipTitle(CacheAs.Global, 100, TTCat.Default, TTFlags.None, typeof (Stomach), "Nutrition")]
  public static LocString StomachTooltipTitle { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Global, 99, TTCat.Default, TTFlags.None, typeof (Stomach), new Type[] {})]
  public static LocString StomachTooltipSubtitle { get; }

  [TooltipAffectedBy("Nutrients", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString FoodStatus(this Stomach stomach);

  [TooltipAffectedBy(typeof (Stomach), "Nutrients", null, null)]
  [TooltipAffectedBy(typeof (Stomach), "BalancedDietMult", null, null)]
  [TooltipAffectedBy(typeof (Stomach), "VarietyMult", null, null)]
  [TooltipAffectedBy(typeof (Stomach), "TastinessMult", null, null)]
  [TooltipAffectedBy(typeof (Stomach), "CravingMult", null, null)]
  [TooltipAffectedBy(typeof (Stomach), "CravingMultDesc", null, null)]
  [TooltipAffectedBy(typeof (Stomach), "DinnerPartyMult", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 101, TTCat.Default, TTFlags.ForceInstantUpdate, null, new Type[] {})]
  public static LocString StomachNutritionTooltip(this Stomach stomach);

  [TooltipAffectedBy(typeof (Stomach), "Nutrients", null, null)]
  [TooltipAffectedBy("Craving", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 103, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StomachContentsTooltip(this Stomach stomach);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 110, TTCat.Default, TTFlags.None, typeof (FoodItem), new Type[] {})]
  public static LocString FoodNutrientTooltip(Type foodType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 110, TTCat.Default, TTFlags.None, typeof (FoodItem), new Type[] {})]
  public static LocString FoodTasteTooltip(Type type, User user);
}
