// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserStats
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.DynamicValues;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Players;

public class UserStats
{
  public Dictionary<UserStatType, UserStat> Stats { get; set; }

  public void InvokeCallback(UserStatType type);

  public void RegisterCallback(UserStatType type, Action callback);

  public void BuildSkillModifiers(Dictionary<UserStatType, IDynamicValue> skillMods);

  public UserStats(User user);

  public UserStat GetStat(UserStatType type);

  public void UpdateClothingStats();
}
