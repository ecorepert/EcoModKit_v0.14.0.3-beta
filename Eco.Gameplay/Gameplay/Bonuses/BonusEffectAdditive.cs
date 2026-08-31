// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectAdditive
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Additive effect: adds a flat <see cref="P:Eco.Gameplay.Bonuses.BonusEffectAdditive.Value" /> to the input. Applied at default order (after multiplicative, before overrides). </summary>
public class BonusEffectAdditive : BonusEffect
{
  public float Value { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override LocString Description(BonusContext context = null);
}
