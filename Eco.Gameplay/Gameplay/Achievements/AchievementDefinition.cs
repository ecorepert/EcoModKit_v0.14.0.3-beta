// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.AchievementDefinition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System;

#nullable disable
namespace Eco.Gameplay.Achievements;

/// <summary>The definition for an achievement, which can be in the base list or externally created via mods. See <see href="ModAchievements.cs" /></summary>
public class AchievementDefinition : 
  UnserializedEntry,
  IHasIcon,
  IController,
  IViewController,
  IHasUniversalID,
  ILinkable
{
  public static ThreadSafeAction<AchievementProgressChange> AchievementProgressEvent;
  public const float DefaultNotifyCooldownMinutes = 10f;
  public const float DefaultServerNotifyCooldownMinutes = 30f;

  public LocString DisplayName { get; set; }

  public LocString Description { get; set; }

  public float RequiredProgress { get; set; }

  public float NotifyEvery { get; set; }

  public float NotifyCooldownMinutes { get; set; }

  public bool IsServerAchievement { get; set; }

  public float NotifyCooldownSeconds { get; }

  [SyncToView(null, true)]
  [DependsOn("DisplayName")]
  public string Name { get; }

  [SyncToView(null, true)]
  [DependsOn("Name")]
  public string IconName { get; }

  [SyncToView(null, true)]
  public string MarkedUpName { get; }

  public string IconComment { get; }

  /// <summary>Trigger the achievement or add progress to cumulative one</summary>
  public void TriggerAchievementProgress(
    User user,
    Func<LocString> description,
    float? progressDelta = null,
    float? progressAbsolute = null);

  public override LocString UILinkContent();

  /// <param name="displayName">The name of the achievement that will be shown to the player.</param>
  /// <param name="notifyCooldownMinutes">Minutes between progress announcements. Raise it for achievements that take a long time to earn.</param>
  public static AchievementDefinition CreateAchievementDefinition(
    LocString displayName,
    LocString desc,
    Action<AchievementDefinition> setup,
    bool isServerAchievement,
    float requiredAmountOfProgress = 0.0f,
    int? notifyEvery = null,
    float? notifyCooldownMinutes = null);
}
