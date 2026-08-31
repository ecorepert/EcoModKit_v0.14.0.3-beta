// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectMultiplicative
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Multiplicative effect: multiplies the input value by multiplier <see cref="P:Eco.Gameplay.Bonuses.BonusEffectMultiplicative.Value" />. </summary>
public class BonusEffectMultiplicative : BonusEffect
{
  public float Value { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override float OrderOfOperations { get; }

  public override LocString Description(BonusContext context = null);
}
