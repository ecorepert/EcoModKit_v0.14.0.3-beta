// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectChance
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Chance-based effect: on each application, rolls <see cref="P:Eco.Gameplay.Bonuses.BonusEffectChance.Chance" /> probability. On success, adds <see cref="P:Eco.Gameplay.Bonuses.BonusEffectChance.SuccessValue" /> to the value (the chance-gated counterpart of <see cref="T:Eco.Gameplay.Bonuses.BonusEffectAdditive" />; use <see cref="T:Eco.Gameplay.Bonuses.BonusEffectOverride" /> for replacement). On failure, returns the input unchanged. Works for boolean-query talents like Logger's Luck (0 + 1 signals the proc) and count actions like chance-based extra yield. </summary>
public class BonusEffectChance : BonusEffect
{
  /// <summary> Probability of the effect firing, in [0, 1]. </summary>
  public float Chance { get; init; }

  /// <summary> The value added when the roll succeeds. </summary>
  public float SuccessValue { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override LocString Description(BonusContext context = null);
}
