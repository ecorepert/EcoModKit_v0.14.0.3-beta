// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.SkillTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

/// <summary>Tooltip library for all tooltips related to skills and their levels</summary>
[TooltipLibrary]
public static class SkillTooltipLibrary
{
  public static void Initialize();

  public static void BuildUnlocks();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SkillBookTooltip(this 
  #nullable disable
  SkillScroll scroll);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, typeof (SkillBook), new Type[] {})]
  public static LocString SkillBookDescription(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, typeof (SkillScroll), new Type[] {})]
  public static LocString SkillScrollDescription(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 450, TTCat.Default, TTFlags.None, typeof (SkillScroll), new Type[] {})]
  public static LocString LearnedSkill(Type scrollType, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 500, TTCat.Default, TTFlags.None, typeof (SkillScroll), new Type[] {})]
  public static LocString SkillScrollControlsTooltip(Type scrollType, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 500, TTCat.Controls, TTFlags.None, null, new Type[] {})]
  public static LocString SkillBookControlsTooltip(this SkillBook skillBook);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 160 /*0xA0*/, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString BenefitsDescription(Type type, User user, TooltipOrigin origin);

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString GetUserSkillTooltipTitle(this SkillTree skillTree);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString UserSkillTooltip(this SkillTree skillTree);

  [NewTooltipTitle(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, typeof (Skill), "")]
  public static LocString SkillTooltipTitle(Type skillType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 1, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString GeneralTooltip(Type skillType);

  [TooltipAffectedBy(typeof (Skill), "SkillTree", "DiscoveredEvent", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 140, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString DiscoveredTooltip(Type skillType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 2, TTCat.Default, TTFlags.ClearCacheForAllUsers, typeof (Skill), new Type[] {})]
  public static LocString LearnedTooltip(Type skillType, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 2, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString SkillNotDiscovered(Type skillType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 150, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString PrerequisitesTooltip(Type skillType, User user, TooltipOrigin origin);

  [TooltipAffectedBy(typeof (Skill), "SkillTree", "DiscoveredEvent", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 170, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString UnlocksDescription(Type skillType);

  /// <summary> Shows all talent groups available under this specialty, grouped by level. </summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 175, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString SkillTalentsAvailable(Type skillType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 180, TTCat.Default, TTFlags.ClearCacheForAllUsers, typeof (Skill), new Type[] {})]
  public static LocString SkillBenefits(Type skillType, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 90, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString CurrentSkillLevel(Type skillType, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 190, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString OtherPlayerSkillsTooltip(Type skillType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 191, TTCat.Default, TTFlags.None, typeof (Skill), new Type[] {})]
  public static LocString GlobalLevelUpsTooltip(Type skillType);

  /// <summary>Shows the bonus effects that each talent in the group provides. When the user has the talent, shows current values at their level. </summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 150, TTCat.Default, TTFlags.None, typeof (TalentGroup), new Type[] {})]
  public static LocString TalentGroupBonusEffects(Type type, User user);

  /// <summary> Shows all players who have learned any talent in this group, with their level. </summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 200, TTCat.Default, TTFlags.ForceInstantUpdate, typeof (TalentGroup), new Type[] {})]
  public static LocString TalentGroupPlayers(Type type, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 160 /*0xA0*/, TTCat.Default, TTFlags.None, typeof (RecipeFamily), new Type[] {})]
  public static LocString RecipeCraftingBenefits(Type type, User user, TooltipOrigin origin);

  /// <summary>Shows which talent unlocks a recipe and whether the current user has learned it. Only appears for recipes with RequiresTalentUnlock. </summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 105, TTCat.Default, TTFlags.None, typeof (RecipeFamily), new Type[] {})]
  public static LocString RecipeRequiredTalent(Type type, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 170, TTCat.Default, TTFlags.None, typeof (RecipeFamily), new Type[] {})]
  public static LocString RecipeTalentBenefits(Type type, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 101, TTCat.Default, TTFlags.None, typeof (RecipeFamily), new Type[] {})]
  public static LocString TableTooltip(Type type);

  /// <summary>Products, ingredients and process waste of the default recipe, one quantity+icon row per element with the quantity column
  /// aligned; alternative variants fold away under "Alternative Recipes", each foldout holding the same detail. Ingredient quantities
  /// reuse the crafting UI color code (yellow = static value, light blue = dynamic) — an outline there, the number color here.
  /// Labor/skill requirements are not repeated here — the "Labor needed" part covers them.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 120, TTCat.Default, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString RecipesSection(this RecipeFamily recipeFamily, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 110, TTCat.SpecialPart1, TTFlags.ClearCacheForAllUsers, typeof (RecipeFamily), new Type[] {})]
  public static LocString LaborTooltip(Type type, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 131, TTCat.Default, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString ExperienceTooltip(this RecipeFamily recipeFamily, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 111, TTCat.SpecialPart1, TTFlags.None, typeof (RecipeFamily), new Type[] {})]
  public static LocString ExpertsTooltip(Type type);

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString IngredientElementTooltipTitle(this IngredientElement ingredientElement);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 200, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TaggedItems(
    this IngredientElement ingredientElement,
    TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 160 /*0xA0*/, TTCat.Default, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString CraftingBenefits(
    this IngredientElement ingredientElement,
    User user,
    TooltipOrigin origin);

  /// <summary>Creates a tooltip section for talent benefits that apply to this ingredient's parent recipe.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 170, TTCat.Default, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString TalentBenefitsForItemOrTag(
    this IngredientElement ingredientElement,
    User user);
}
