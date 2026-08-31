// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.AchievementManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Icons;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Achievements;

/// <summary>Handles management of achievements for users</summary>
[Serialized]
public class AchievementManager : 
  Singleton<
  #nullable disable
  AchievementManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IHasRequiredIcons
{
  public IReadOnlyList<AchievementDefinition> ModAchievements;
  public ConcurrentDictionary<string, AchievementDefinition> NameToAchievement;
  [Serialized]
  public ServerAchievements ServerAchievements;
  public ThreadSafeAction AchievementsChangedEvent;

  [SyncToView(SyncFlags.MustRequest)]
  public ControllerHashSet<AchievementInstance> WorldCompletedAchievementsCached { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  public LocString CitizenCompletedAchievements { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<AchievementDefinition> AllAchievements { get; }

  /// <summary>Returns an array of localized achievement names and their description that the server has obtained. Returns empty array if none available</summary>
  public Dictionary<string, string> GetServerAchievementNames();

  public void Initialize();

  /// <summary> This replays server-side progress to the client so platform SDKs (e.g., Steam) can resync. </summary>
  public void ResyncAchievementPlatforms(User user);

  /// <summary>Process achievement Progress</summary>
  public void OnAchievementProgress(AchievementProgressChange achievementProgressData);

  public static IEnumerable<(string Name, string Comment)> GetRequiredIcons();

  public static string IconsCategoryName { get; }

  public ref int ControllerID { get; }
}
