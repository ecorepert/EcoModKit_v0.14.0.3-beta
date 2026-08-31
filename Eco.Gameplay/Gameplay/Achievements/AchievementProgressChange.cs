// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.AchievementProgressChange
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Achievements;

/// <summary>When Achievement progress is gained this data struct is created and passed to process</summary>
public struct AchievementProgressChange
{
  public readonly AchievementDefinition Definition;
  public readonly User User;
  public readonly Func<LocString> MakeDescr;
  public readonly float? ProgressDelta;
  public readonly float? ProgressAbsolute;

  public AchievementProgressChange(
    AchievementDefinition def,
    User user,
    Func<LocString> func,
    float? progressDelta = null,
    float? progressAbsolute = null);
}
