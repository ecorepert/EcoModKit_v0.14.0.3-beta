// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserHelpers.UserAchievements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Achievements;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Players.UserHelpers;

[Serialized]
public class UserAchievements : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  public 
  #nullable disable
  ThreadSafeDictionary<string, HashSet<Type>> TypesCraftedByAchievement;

  public ThreadSafeAction AchievementsChangedEvent { get; }

  [Serialized]
  public ThreadSafeList<AchievementInstance> OfflineAchievements { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<AchievementInstance> Achievements { get; }

  public int AchievementCount { get; }

  public bool RemoveAchievement(string achievementName);

  public AchievementInstance GetAchievement(string name);

  public void Initialize(User user);

  /// <summary>Goes over cached achievements for this user and grants them, called when they enter the world</summary>
  public void EnterWorld();

  /// <summary>
  /// Attempts to an achievmeent to the appropriate list.
  /// This method will return false if the achievement already exists in the user's achievement list
  /// </summary>
  /// <param name="achievementInstance">Achievement to add.</param>
  /// <returns>True on success, otherwise false.</returns>
  public void SetAchievement(AchievementInstance achievementInstance);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
