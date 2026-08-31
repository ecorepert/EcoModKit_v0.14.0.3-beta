// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Bonuses;

/// <summary> Central entry point for bonus resolution and application. Callers build a <see cref="T:Eco.Gameplay.Bonuses.BonusContext" /> and call <see cref="M:Eco.Gameplay.Bonuses.BonusManager.ApplyBonuses(Eco.Gameplay.Bonuses.BonusContext,System.Single)" />.
/// Discovers bonuses from context entities that implement <see cref="T:Eco.Gameplay.Bonuses.IHasBonuses" />. Handles per-source level resolution (e.g. User's per-talent levels). </summary>
public static class BonusManager
{
  /// <summary> Apply all bonuses from context sources to a value. Handles per-talent level resolution for User sources. </summary>
  public static float ApplyBonuses(
  #nullable disable
  BonusContext context, float value);

  /// <summary> Apply bonuses from a single source directly (no source decomposition or level resolution). </summary>
  public static float ApplyBonusesFrom(IHasBonuses source, BonusContext context, float value);

  /// <summary> Describe all applicable bonuses from context sources. Handles per-talent level resolution so descriptions show context-aware values. </summary>
  public static IEnumerable<LocString> DescribeApplicableBonuses(BonusContext context);

  /// <summary> Describe applicable bonuses across multiple contexts (e.g. all craft actions), grouped by source name.
  /// Produces one foldout per talent instead of one per bonus×action, dramatically reducing tooltip text length. </summary>
  public static IEnumerable<LocString> DescribeApplicableBonusesGrouped(
    IEnumerable<BonusContext> contexts);

  /// <summary> Check whether any bonus unlocks a recipe for the given context. Convention: starts at 0 (locked), any override effect sets it to 1 (unlocked). </summary>
  public static bool IsRecipeUnlocked(BonusContext context);

  /// <summary>Find all talents whose bonuses would unlock the given recipe. Skips base template classes.</summary>
  public static IEnumerable<Talent> FindUnlockingTalents(RecipeFamily recipe);

  /// <summary> Describes applicable bonuses grouped by source talent, with TalentGroup UILinks as headers.
  /// Iterates the user's talents across all craft actions, deduplicates per-talent, and returns one entry per talent with applicable bonuses.
  /// <paramref name="contextFactory" /> creates a BonusContext for each <see cref="T:Eco.Gameplay.Bonuses.BonusAction" />; callers choose ForRecipePreview or ForWorkOrder. </summary>
  public static IReadOnlyList<LocString> DescribeTalentBonusesGrouped(
    User user,
    Func<BonusAction, BonusContext> contextFactory);

  /// <summary> Describe applicable bonuses with flat output: each entry is the talent's MarkedUpName followed by its effect description, no nested foldouts.
  /// For User sources, resolves the owning TalentGroup to display its MarkedUpName. Non-User sources fall back to the bonus Name. </summary>
  public static IReadOnlyList<LocString> DescribeApplicableBonusesFlat(BonusContext context);
}
