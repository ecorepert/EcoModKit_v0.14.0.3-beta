// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.RecipeFamily
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items.Recipes;

[ForceCreateViewAllDerived]
[ConstantView]
public abstract class RecipeFamily : IController, IViewController, IHasUniversalID, ILinkable
{
  public float ExperienceOnCraft;

  public bool Accepts(
  #nullable disable
  Item item);

  protected static IDynamicValue CreateLaborInCaloriesValue(float start);

  protected static IDynamicValue CreateCraftTimeValue(float start);

  protected static IDynamicValue CreateCraftTimeValue(
    Type beneficiary,
    float start,
    Type skillType,
    params Type[] talents);

  protected IDynamicValue CreateLaborInCaloriesValue(float start, Type skillType);

  public LocString DisplayName { get; }

  public override string ToString();

  [SyncToView(null, true)]
  public string RecipeName { get; protected set; }

  [SyncToView(null, true)]
  public IngredientElement[] Ingredients { get; }

  [SyncToView(null, true)]
  public bool CraftableDefault { get; set; }

  [SyncToView(null, true)]
  public Recipe DefaultRecipe { get; }

  [SyncToView(null, true)]
  public CraftingElement[] Product { get; }

  [SyncToView(null, true)]
  public List<Recipe> Recipes { get; protected set; }

  [SyncToView(null, true)]
  public Item CraftingTable { get; }

  [SyncToView(null, true)]
  public IDynamicValue CraftMinutes { get; protected set; }

  [SyncToView(null, true)]
  public RequiresSkillAttribute[] RequiredSkills { get; protected set; }

  [SyncToView(null, true)]
  public RequiresModuleAttribute[] RequiredModules { get; protected set; }

  [SyncToView(null, true)]
  public IDynamicValue LaborInCalories { get; set; }

  [SyncToView(null, true)]
  public float Labor { get; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  /// <summary>Can set a specific durability cost on recipes that overrides the table defaults.</summary>
  public virtual float? OverrideDurabilityUsedOnCraftingTablePerHour { get; }

  /// <summary> When true, requires a talent-based CraftUnlock bonus to be craftable. Recipes without this flag are always craftable. </summary>
  [SyncToView(null, true)]
  public bool RequiresTalentUnlock { get; protected set; }

  /// <summary> Display name of the talent group that unlocks this recipe, with UILink for tooltip. Lazy-computed on first access from BonusManager. </summary>
  [SyncToView(null, true)]
  public LocString RequiredTalentName { get; }

  /// <summary> Talent type names that can unlock this recipe. Lazy-computed on first access from BonusManager. </summary>
  [SyncToView(null, true)]
  public List<string> UnlockingTalentStrings { get; }

  public Recipe GetClosestMatchingProduct(List<FractionalItemStack> input, User user);

  public static float InputMatch(
    List<FractionalItemStack> actual,
    List<IngredientElement> target,
    User user);

  public IEnumerable<Type> RecipeItems { get; }

  public bool IsDiscovered { get; }

  /// <summary> Returns the skills that are needed to craft this recipe, as well as to craft the table this recipe is made on. </summary>
  public IEnumerable<Type> SkillsNeeded();

  protected void Initialize(LocString displayText, Type recipeType);

  public bool CanCraftNotify(User user, RoomStats roomStats);

  /// <summary> Evaluates an <see cref="T:Eco.Gameplay.DynamicValues.IDynamicValue" /> for recipe preview, applying both skill/module and talent bonuses. </summary>
  public float EvaluateWithBonuses(IDynamicValue value, User user, BonusAction action);

  /// <summary> Describes all talent bonuses that would apply to this recipe for preview. Groups by talent — one foldout per talent across all craft actions. </summary>
  public IReadOnlyList<LocString> DescribePreviewBonuses(User user);

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  public LocString LaborDesc();

  public LocString GetRequiredSkillsWrappedString(User user);

  public ref int ControllerID { get; }
}
