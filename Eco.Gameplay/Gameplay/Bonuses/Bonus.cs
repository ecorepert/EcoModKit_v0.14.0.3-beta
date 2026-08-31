// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.Bonus
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Combines causes (when to trigger) with effects (how to transform values). Created directly with causes, effects, and a name. </summary>
public sealed class Bonus : IDescribable
{
  /// <summary> Display name for the bonus (Such as talent name, module name). </summary>
  public LocString Name { get; init; }

  /// <summary> Conditions that must ALL be met for this bonus to apply. </summary>
  public List<BonusCause> Causes { get; init; }

  /// <summary> Effects to apply when all causes are triggered. Applied in OrderOfOperations order. </summary>
  public List<BonusEffect> Effects { get; init; }

  /// <summary> Optional effect description stored on the bonus. When set, replaces auto-generated effect descriptions in <see cref="M:Eco.Gameplay.Bonuses.Bonus.Describe(Eco.Gameplay.Bonuses.BonusContext)" />.
  /// Keeps effects generic — avoids semantic subclasses like "BonusEffectFreshness" or "BonusEffectUnlock". </summary>
  public LocString EffectDescription { get; init; }

  /// <summary> Try to apply this bonus to a value. Checks all causes first — if any fail, the value is returned unchanged. </summary>
  public float TryApply(BonusContext context, float value);

  /// <summary> Check if this bonus would apply to the given context (without actually applying it). </summary>
  public bool WouldApply(BonusContext context);

  /// <summary> IDescribable auto-generated from cause and effect descriptions. </summary>
  public LocString Description();

  /// <summary> Returns the body text (effects + causes) without any Name/Foldout wrapper. Used by grouped displays where the header is provided externally (e.g. TalentGroup UILink). </summary>
  public LocString DescribeBody(BonusContext context);

  /// <summary> Describe this bonus for tooltips. Uses <see cref="P:Eco.Gameplay.Bonuses.Bonus.EffectDescription" /> when set, otherwise auto-generates from effects.
  /// Returns empty when no effect text is available (effects describe nothing and no <see cref="P:Eco.Gameplay.Bonuses.Bonus.EffectDescription" /> override). </summary>
  public LocString Describe(BonusContext context);
}
