// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using System;

#nullable enable
namespace Eco.Gameplay.Skills;

[ChatCommandHandler]
public static class SkillCommands
{
  /// <summary>Find a skill type by any string</summary>
  public static 
  #nullable disable
  Type SkillTypeByName(User user, string skillName);

  [ChatSubCommand("Skills", "Set education value (0 to 1) for a skill (default to 1), giving the skill if the user doesn't have it.  If no target user is set, apply to self.", ChatAuthorizationLevel.Admin)]
  public static void Education(User user, string skillName, float value = 1f, User targetUser = null);

  [ChatSubCommand("Skills", "Gives a skill matching the given name. If no target user is set, apply to self.", ChatAuthorizationLevel.Admin)]
  public static void Give(User user, string skillName, User targetUser = null);

  [ChatSubCommand("Skills", "Displays or sets the current specialty cost multiplier (higher = specialties cost more stars, slowing progression without changing food/housing XP rates).", ChatAuthorizationLevel.Admin)]
  public static void Rate(User user, float skillRate = -1f);

  [ChatSubCommand("Skills", "Resets a specialization for a player. If the skill name is empty it will reset all specializations.", ChatAuthorizationLevel.Admin)]
  public static void Reset(User user, User targetUser, string skillName = "");

  [ChatSubCommand("Skills", "Grants a talent by name (or updates its level if already learned). If no target user is set, apply to self.", "givetalent", ChatAuthorizationLevel.Admin)]
  public static void GiveTalent(User user, string talentName, int level = 1, User targetUser = null);

  [ChatSubCommand("Skills", "Removes a talent by name. If no target user is set, apply to self.", "talentdel", ChatAuthorizationLevel.Admin)]
  public static void RemoveTalent(User user, string talentName, User targetUser = null);

  [ChatSubCommand("Skills", "Lists all talents and the target user's current levels (or self if none passed).", "listtalents", ChatAuthorizationLevel.Admin)]
  public static void ListTalents(User user, User targetUser = null);

  [ChatSubCommand("Skills", "Resets all talents for a specialization for a player. If the skill name is empty it will remove talents from all specialization", "notalents", ChatAuthorizationLevel.Admin)]
  public static void ClearTalents(User user, User targetUser, string skillName = "");

  [ChatSubCommand("Skills", "Resets all skills to unlearnt", ChatAuthorizationLevel.Admin)]
  public static void FullReset(User user, User targetUser = null);

  [ChatSubCommand("Skills", "Unlocks all skills", ChatAuthorizationLevel.Admin)]
  public static void All(User user, User targetUser = null);

  [CITest(true)]
  [ChatSubCommand("Skills", "Levels all skills up 1 level at a time (no chunks).", "allskills", ChatAuthorizationLevel.DevTier)]
  public static void LevelUpAll(User user);

  [ChatSubCommand("Skills", "Levels up a skill to a given level (max if omitted). Example: /levelup logging, 5", "levelup", ChatAuthorizationLevel.Admin)]
  public static void LevelUp(User user, string skillName, int level = -1, User targetUser = null);

  public static void LevelUp(User user, Type skillType, int level = -1);

  [ChatSubCommand("Skills", "Removes a specialty that matches the passed string.", "leveldown", ChatAuthorizationLevel.Admin)]
  public static void RemoveSpecialty(User user, string specialtyName, User targetUser = null);

  [CITest(false)]
  [ChatSubCommand("Skills", "Give skillpoints to another player. Give them to yourself if target user is empty", "AddPoint", ChatAuthorizationLevel.Admin)]
  public static void AddPointsTo(User user, User targetUser = null, int stars = 1);

  [ChatSubCommand("Skills", "Remove skillpoints from another player. Removes from yourself if target user is empty", "RemovePoint", ChatAuthorizationLevel.Admin)]
  public static void RemovePointsFrom(User user, User targetUser = null, int stars = 1);

  [ChatSubCommand("Skills", "Gives levels to another player. Gives to yourself if target user is empty", "AddLevel", ChatAuthorizationLevel.Admin)]
  public static void AddLevelTo(User user, User targetUser = null, int stars = 1);

  [ChatSubCommand("Skills", "Removes levels from another player. Removes from yourself if target user is empty", "RemoveLevel", ChatAuthorizationLevel.Admin)]
  public static void RemoveLevelFrom(User user, User targetUser = null, int stars = 1);

  [ChatSubCommand("Skills", "Make education tick every frame, accepet teachers and students regardless of skills, and allow teachers to be their own students.", ChatAuthorizationLevel.DevTier)]
  public static void DebugEdu(User user);
}
