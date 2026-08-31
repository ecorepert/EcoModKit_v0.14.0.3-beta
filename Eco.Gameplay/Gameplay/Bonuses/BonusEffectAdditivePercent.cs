// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectAdditivePercent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Percentage effect that stacks ADDITIVELY across sources: every triggered instance pools its <see cref="P:Eco.Gameplay.Bonuses.BonusEffectAdditivePercent.Percent" />
/// during a <see cref="M:Eco.Gameplay.Bonuses.BonusManager.ApplyBonuses(Eco.Gameplay.Bonuses.BonusContext,System.Single)" /> pass, and the pooled sum is applied once as a combined (1 + sum) multiplier.
/// Two +10% effects thus give exactly +20%, where two 1.1x <see cref="T:Eco.Gameplay.Bonuses.BonusEffectMultiplicative" /> effects would compound
/// to +21% — the result never depends on source order, and multiplicative effects stack with the pooled total. </summary>
public class BonusEffectAdditivePercent : BonusEffect
{
  public float Percent { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override LocString Description(BonusContext context = null);
}
