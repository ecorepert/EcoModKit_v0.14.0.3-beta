// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectSkillMultiplier
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Skill-based multiplier: scales the value using a mapper function that receives the base value and the user's current skill level. </summary>
public class BonusEffectSkillMultiplier : BonusEffect
{
  /// <summary> The skill type whose level drives the multiplier. </summary>
  public Type SkillType { get; init; }

  /// <summary> Maps (baseValue, skillLevel) → result. </summary>
  public Func<float, float, float> ValueMapper { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override float OrderOfOperations { get; }

  public override LocString Description(BonusContext context = null);
}
