// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusEffectDiminishing
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Diminishing-returns effect using project-standard <see cref="T:Eco.Shared.Utils.LimitMapper" /> on <see cref="P:Eco.Gameplay.Bonuses.BonusContext.SourceLevel" />.
/// Output approaches <see cref="P:Eco.Shared.Utils.LimitMapper.Config.OutputLimit" /> via half-life scaling. Designed for "Final Talent" infinite-stacking star sinks. </summary>
public class BonusEffectDiminishing : BonusEffect
{
  public LimitMapper.Config Scaling { get; init; }

  public override float TransformValue(BonusContext context, float val);

  public override float OrderOfOperations { get; }

  public override bool ScalesWithTalentLevel { get; }

  public override LocString Description(BonusContext context = null);
}
