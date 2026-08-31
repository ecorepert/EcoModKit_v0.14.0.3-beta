// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Bonuses;

/// <summary> Rich context object containing everything needed for bonus evaluation. Passed to BonusCause.IsTriggered() and BonusEffect.TransformValue(). </summary>
public class BonusContext
{
  /// <summary> All crafting-related <see cref="T:Eco.Gameplay.Bonuses.BonusAction" /> values. Used to iterate when describing bonuses across all aspects. </summary>
  public static readonly 
  #nullable disable
  IReadOnlyList<BonusAction> CraftActions;

  /// <summary> The type of action being performed. </summary>
  public BonusAction Action { get; init; }

  /// <summary> The user performing the action. </summary>
  public User Source { get; init; }

  /// <summary> The tool being used (if any). </summary>
  public ToolItem Tool { get; init; }

  /// <summary> The block type being targeted (if any). </summary>
  public Type BlockType { get; init; }

  /// <summary> The recipe being crafted (if any). </summary>
  public RecipeFamily Recipe { get; init; }

  /// <summary> The work order being processed (if any). </summary>
  public WorkOrder WorkOrder { get; init; }

  /// <summary> The item involved in the action (if any). </summary>
  public Item Item { get; init; }

  /// <summary> The world object involved (if any). </summary>
  public WorldObject WorldObject { get; init; }

  /// <summary> Level of the bonus source being evaluated (such as per-user talent level). 0 = no source level context. </summary>
  public int SourceLevel { get; set; }

  /// <summary> Percentages pooled by <see cref="T:Eco.Gameplay.Bonuses.BonusEffectAdditivePercent" /> during an apply pass; the manager applies the
  /// sum once as a combined multiplier, so those effects stack additively regardless of source order. </summary>
  internal float AdditivePercentSum { get; set; }

  /// <summary> All <see cref="T:Eco.Gameplay.Bonuses.IHasBonuses" /> sources discoverable from this context. Uses yield to avoid allocations on hot paths. </summary>
  public IEnumerable<IHasBonuses> Sources();

  /// <summary> Creates a context from a work order for a specific crafting action. </summary>
  public static BonusContext ForWorkOrder(WorkOrder workOrder, BonusAction action);

  /// <summary> Creates a preview context for recipe browsing (no work order or world object). Applies user talent bonuses only. </summary>
  public static BonusContext ForRecipePreview(User user, RecipeFamily recipe, BonusAction action);

  /// <summary>Creates a preview context for a specific crafting table. Includes the world object so area bonuses and table-specific bonuses apply.</summary>
  public static BonusContext ForCraftingPreview(
    User user,
    RecipeFamily recipe,
    WorldObject worldObject,
    BonusAction action);
}
