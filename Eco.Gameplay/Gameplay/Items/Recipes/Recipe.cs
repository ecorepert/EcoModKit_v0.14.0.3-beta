// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.Recipe
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

public class Recipe : IController, IViewController, IHasUniversalID, ILinkable
{
  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls)]
  [SyncToView(null, true)]
  public List<CraftingElement> Products { get; protected set; }

  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls)]
  [SyncToView(null, true)]
  public List<GarbageOutput> Garbages { get; protected set; }

  /// <summary>When true, suppresses the item-derived garbage contribution (SalvageCost × CraftGarbageRatio × quantity) from this recipe.
  /// Recipe-declared process waste in <see cref="P:Eco.Gameplay.Items.Recipes.Recipe.Garbages" /> is unaffected. Use for recipes that legitimately consume no salvageable material.</summary>
  [SyncToView(null, true)]
  public bool ZeroSalvageCost { get; set; }

  /// <summary>True when a tag ingredient makes the previewed item-derived garbage an estimate: the item actually contributed, and thus its salvage cost, is unknown until craft time.</summary>
  public bool GarbageIsApproximate { get; }

  /// <summary>Union of <see cref="P:Eco.Gameplay.Items.Recipes.Recipe.Garbages" /> (recipe-specific process waste) and item-derived garbage (each ingredient's
  /// <see cref="T:Eco.Gameplay.Items.SalvageCostAttribute" /> scaled by <see cref="P:Eco.Gameplay.Items.SalvageCostUtil.CraftGarbageRatio" /> × that ingredient's base quantity),
  /// grouped by material. Exposes base per-iteration floats; talent/module bonuses are applied on top via
  /// CraftingComponent.GetBonusAdjustedGarbages (BonusContext with BonusAction.Garbage).</summary>
  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls)]
  [SyncToView(null, true)]
  public List<GarbageOutput> TotalGarbages { get; }

  [SyncToView(null, true)]
  public string Name { get; protected set; }

  [SyncToView(null, true)]
  public LocString DisplayName { get; set; }

  [SyncToView(null, true)]
  public List<IngredientElement> Ingredients { get; protected set; }

  [SyncToView(null, true)]
  public RecipeFamily Family { get; internal set; }

  /// <summary>When true, this recipe will require the user to possess the strange blueprint with the corresponding name.</summary>
  [SyncToView(null, true)]
  public bool RequiresStrangeBlueprint { get; set; }

  /// <summary>When false,this recipe will not use player inventory on craft. Can be useful for dangerous recipes like tool scrap, etc.</summary>
  [SyncToView(null, true)]
  public bool UsesPlayerInventory { get; set; }

  public ref int ControllerID { get; }

  public Recipe();

  public Recipe(
    string name,
    LocString displayName,
    IngredientElement[] ingredients,
    GarbageOutput[] garbages,
    params CraftingElement[] outputs);

  public void Init(
    string name,
    LocString displayName,
    List<IngredientElement> ingredients,
    List<GarbageOutput> garbages,
    List<CraftingElement> items);

  public void Init(
    string name,
    LocString displayName,
    List<IngredientElement> ingredients,
    List<CraftingElement> items);

  /// <summary>Activates <see cref="T:Eco.Gameplay.Items.Recipes.RecipeVariant" /> for this recipe.</summary>
  public void ActivateVariant(RecipeVariant variant);

  /// <summary>Checks if the inventory has any of the required ingredients.</summary>
  public bool HasIngredients(User user, Inventory inv);

  /// <summary>True when the product is a partial refund of one of this recipe's ingredients (e.g. molds returned by a kiln recipe).
  /// Auto-detected by item/tag match unless the product sets <see cref="P:Eco.Gameplay.Items.Recipes.CraftingElement.RefundsIngredient" /> explicitly.
  /// Refunds skip yield bonuses, so perks can't return more of an ingredient than the craft consumed.</summary>
  public bool IsIngredientRefund(CraftingElement product);

  /// <summary>True when the product refunds an ingredient whose cost is bonus-eligible (non-constant quantity). Such refunds must scale
  /// with the crafter's resource-cost discount to keep returned and consumed amounts in balance.</summary>
  public bool IsDiscountedIngredientRefund(CraftingElement product);

  public int MainProductQuantity();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();
}
