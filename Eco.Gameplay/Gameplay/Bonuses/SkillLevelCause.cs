// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.SkillLevelCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Triggers when the user has a specific skill at or above a minimum level. </summary>
public class SkillLevelCause : BonusCause
{
  /// <summary> The skill type to check on <see cref="P:Eco.Gameplay.Bonuses.BonusContext.Source" />. </summary>
  public Type SkillType { get; init; }

  /// <summary> Minimum skill level required for this cause to trigger. </summary>
  public int MinLevel { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
