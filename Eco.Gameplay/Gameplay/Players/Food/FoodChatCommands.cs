// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Food.FoodChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Players.Food;

[ChatCommandHandler]
public static class FoodChatCommands
{
  [ChatCommand("List of commands for food manipulations", ChatAuthorizationLevel.Admin)]
  public static void Food(User user);

  [ChatSubCommand("Food", "Force a craving on a given user (self if untargeted user, random food if not set)", "crave", ChatAuthorizationLevel.Admin)]
  public static void Crave(User user, User target = null, string foodName = null);

  [ChatSubCommand("Food", "Empties your stomach", "cs", ChatAuthorizationLevel.DevTier)]
  public static void ClearStomach(User user);

  [ChatSubCommand("Food", "Spends calories", "work", ChatAuthorizationLevel.Admin)]
  public static void Work(User user, int useCalories = 100000);

  [CITest(false)]
  [ChatSubCommand("Food", "Max your calories", "eat", ChatAuthorizationLevel.Admin)]
  public static void Eat(User user, int amount = -1);

  [ChatSubCommand("Food", "Turn calories into waste", ChatAuthorizationLevel.DevTier)]
  public static void Digest(User user);

  [ChatSubCommand("Food", "Sets nutrition to a value split evenly across all nutrients.", "nutrition", ChatAuthorizationLevel.Admin)]
  public static void Nutrition(User user, float value);

  [ChatSubCommand("Food", "Shows one food per taste preference for a player (self if no player given).", "tastes", ChatAuthorizationLevel.Admin)]
  public static void Tastes(User user, User target = null);
}
