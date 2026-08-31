// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.AchievementCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary>Triggers when the user has earned a specific local achievement (matched by <see cref="P:Eco.Gameplay.Achievements.AchievementDefinition.Name" />). Lets modders use achievement unlocks as bonus gates (e.g. "+10% yield once you've earned First Forge"). Doesn't read Steam, just the in-game UserAchievements collection.</summary>
public class AchievementCause : BonusCause
{
  /// <summary>Internal name of the achievement (matches <see cref="P:Eco.Gameplay.Achievements.AchievementDefinition.Name" />, which is the display name with special characters stripped).</summary>
  public string AchievementName { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
