// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.AchievementCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Gameplay.Achievements;

[ChatCommandHandler]
public static class AchievementCommands
{
  [ChatCommand("Shows commands for achievements.", ChatAuthorizationLevel.DevTier)]
  public static void Achievements(
  #nullable disable
  User user);

  [ChatSubCommand("Achievements", "Give an achievement to the given user", "chieve", ChatAuthorizationLevel.DevTier)]
  public static void GiveAchive(User user, string achievementname, int progress = 0, User target = null);

  [ChatSubCommand("Achievements", "Remove an achievement from the given user", ChatAuthorizationLevel.DevTier)]
  public static void Remove(User user, string achievementName, User target = null);

  [ChatSubCommand("Achievements", "Remove all achievements from the given user", ChatAuthorizationLevel.DevTier)]
  public static void Reset(User user, User target = null);

  [ChatSubCommand("Achievements", "List all achievements available.", "chieves", ChatAuthorizationLevel.User)]
  public static void ListAll(User user);

  [ChatSubCommand("Achievements", "List all achievements and progress for the given user, or self if none passed.", "mychieves", ChatAuthorizationLevel.User)]
  public static void Mine(User user, User targetUser = null);
}
