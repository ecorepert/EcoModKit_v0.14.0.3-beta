// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectCappedMultiplicative
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Level-aware multiplicative effect with a cap. Applies a fixed multiplier (<see cref="P:Eco.Gameplay.Bonuses.BonusEffectCappedMultiplicative.Value" />) per <see cref="P:Eco.Gameplay.Bonuses.BonusContext.SourceLevel" />,
/// but clamps the cumulative multiplier at <see cref="P:Eco.Gameplay.Bonuses.BonusEffectCappedMultiplicative.Cap" />. For cost reductions (LowerIsBetter=true), Cap is a floor (e.g. 0.5 = never below 50%).
/// For yield boosts (LowerIsBetter=false), Cap is a ceiling (e.g. 1.5 = never above 150%).
/// Once the cap is reached, further levels have no additional effect — pair with <see cref="T:Eco.Gameplay.Bonuses.BonusEffectDiminishing" /> on a separate bonus for post-cap scaling. </summary>
public class BonusEffectCappedMultiplicative : BonusEffect
{
  /// <summary> Per-level multiplier. Examples: 0.9f = 10% reduction per level, 1.1f = 10% increase per level. </summary>
  public float Value { get; init; }

  /// <summary> Cumulative multiplier limit. For costs (Value &lt; 1): floor; for yields (Value &gt; 1): ceiling. Defaults to 1 (no cap). </summary>
  public float Cap { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override float OrderOfOperations { get; }

  public override bool ScalesWithTalentLevel { get; }

  public override LocString Description(BonusContext context = null);
}
