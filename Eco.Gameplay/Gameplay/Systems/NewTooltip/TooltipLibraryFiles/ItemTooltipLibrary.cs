// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.ItemTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Core.Stats;
using Eco.Gameplay.Components;
using Eco.Gameplay.EcopediaRoot;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements.ClaimStakes;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class ItemTooltipLibrary
{
  public static void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 150, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString CurrencyFromItem(
  #nullable disable
  Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 150, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TaggedItems(this TagStack stack);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 500, TTCat.Controls, TTFlags.ClearCacheForAllInstances, null, new Type[] {})]
  public static LocString ClothingTooltip(this ClothingItem clothItem, User user);

  /// <summary>Lists the flat stat modifiers a clothing item grants while equipped.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (ClothingItem), new Type[] {})]
  public static LocString ClothingStatsTooltip(Type clothingType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 10, TTCat.Default, TTFlags.None, typeof (WeaponItem), new Type[] {})]
  public static LocString DamageTooltip(Type weaponType, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 150, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TaggedItems(this Tag tag, TooltipOrigin origin);

  [TooltipAffectedBy("Settlement", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PropertyClaimTooltip(this ClaimPaperItemBase claimItem);

  [TooltipAffectedBy("Settlement", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, "")]
  public static LocString PropertyClaimTooltipTitle(this ClaimPaperItemBase claimItem);

  [TooltipAffectedBy("User", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString HomesteadClaimStakeOwnerTooltip(this HomesteadClaimStakeItem stakeItem);

  /// <summary>Tooltip section with information that this object has been used previously. Contains a clickable link to reset object's persistent data. When hovered, the button shows tooltips of stored entries.</summary>
  [TooltipAffectedBy(typeof (ItemPersistentData), "Entries", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 10, TTCat.Controls, TTFlags.None, null, new Type[] {})]
  public static LocString DataTooltip(this ItemPersistentData itemData);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 120, TTCat.Default, TTFlags.None, typeof (FertilizerItem), new Type[] {})]
  public static LocString FertilizerTooltip(Type type);

  [TooltipAffectedBy("IconName", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString PictureItemTooltipTitle(this PictureItem pictureItem);

  /// <summary>Hit to see full picture from tooltip</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 700, TTCat.Controls, TTFlags.None, null, new Type[] {})]
  public static LocString PictureItemTooltip(this PictureItem pic);

  [TooltipAffectedBy(typeof (PictureItem), "Picture", "ReviewState", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PictureReviewStateTooltip(this PictureItem pictureItem);

  [TooltipAffectedBy("Color", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Tooltip(this ColorItem item);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Global, 110, TTCat.Default, TTFlags.None, typeof (ColorItem), new Type[] {})]
  public static LocString PaintBenefitsTooltip();

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString TradeOfferTooltipTitle(this TradeOffer offer);

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString TagStackTooltipTitle(this TagStack stack);

  [NewTooltipTitle(CacheAs.SubType, 20, TTCat.Default, TTFlags.None, typeof (Item), "")]
  public static LocString ItemTitle(Type type);

  [NewTooltipTitle(CacheAs.SubType, 20, TTCat.Default, TTFlags.None, typeof (RecipeFamily), "")]
  public static LocString RecipeTitle(Type type);

  [NewTooltipTitle(CacheAs.Instance, 20, TTCat.Default, TTFlags.None, null, "")]
  public static LocString EcopediaPageTitle(this EcopediaPage page);

  [NewTooltipTitle(CacheAs.Instance, 20, TTCat.Default, TTFlags.None, null, "")]
  public static LocString StatTitle(this StatEntry stat);

  [TooltipAffectedBy(typeof (PictureItem), "MarkedUpName", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString PictureTooltipTitle(this PictureItem pic);

  [TooltipAffectedBy(typeof (ColorItem), "Color", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString ColorItemTitle(this ColorItem item);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.User | CacheAs.SubType, 161, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString TalentBenefitsDescription(Type type, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 105, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString FuelDescription(Type itemType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 106, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString WeightDescription(Type itemType);

  /// <summary>Lists the per-item garbage materials yielded when recycled — values are fractions of a MixedGarbage block.
  /// Recycler efficiency (per-device) is not factored in here; this shows the raw declared yield.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 108, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString SalvageCostTooltip(Type itemType);

  /// <summary>On a garbage item, lists every recipe that yields this material as a craft byproduct, with the per-craft amount (fraction of a block).
  /// Reads <see cref="P:Eco.Gameplay.Items.Recipes.Recipe.TotalGarbages" /> so both recipe-declared waste and item-derived salvage garbage are covered.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 109, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString GarbageFromCraftingTooltip(Type itemType, TooltipOrigin origin);

  /// <summary>On a garbage item, lists every item that yields this material when recycled (declares it in its <see cref="T:Eco.Gameplay.Items.SalvageCostAttribute" />), with the per-item amount.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 110, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString GarbageRecycledFromTooltip(Type itemType, TooltipOrigin origin);

  [TooltipAffectedBy(typeof (DiscoveryManager), "NewItemsDiscoveredEvent", null, null, OverridenType = typeof (Item))]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 1, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString UndiscoveredTooltip(Type itemType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 107, TTCat.Controls, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString CarriedDescription(Type itemType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 140, TTCat.Crafting, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString CraftingRequirementsTooltip(Type itemType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 150, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString SourceSpeciesTooltip(Type itemType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 170, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString UsedInTooltip(Type itemType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 175, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString RelatedTagsTooltip(Type itemType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 180, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString StoreUsable(Type itemType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 490, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString Components(Type type, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString TierTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 180, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString OccupancyTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 170, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString ExistingObjects(Type itemType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 140, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString TooltipRequirements(Type worldItemType);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 110, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString AirPollution(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 120, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString AllowedPluginModules(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 150, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString TooltipRecipes(Type worldItemType, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (WorldObjectItem), new Type[] {})]
  public static LocString HousingTooltip(Type type);

  /// <summary>Title for a <see cref="T:Eco.Gameplay.Items.Recipes.GarbageOutput" /> tooltip: shows the material's output-item icon and name (e.g. "Wood Scrap").</summary>
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString GarbageOutputTitle(this GarbageOutput output);

  /// <summary>Body of a <see cref="T:Eco.Gameplay.Items.Recipes.GarbageOutput" /> tooltip: shows the per-craft amount this recipe iteration produces as a fraction of a MixedGarbage block.
  /// Talent bonuses via <see cref="F:Eco.Gameplay.Bonuses.BonusAction.Garbage" /> are applied when the output has an owning recipe and the hovering user is known.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString GarbageOutputBody(this GarbageOutput output, User user);
}
