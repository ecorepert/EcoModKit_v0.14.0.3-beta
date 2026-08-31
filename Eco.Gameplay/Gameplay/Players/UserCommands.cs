// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Players;

[ChatCommandHandler]
public static class UserCommands
{
  public static LocString ExhaustionDisabled;
  public static LocString ExhaustionBankDisabled;

  [ChatCommand("Shows commands for changing things about users.", ChatAuthorizationLevel.Admin)]
  public static void User(Eco.Gameplay.Players.User user);

  [ChatSubCommand("User", "Provide a user with extra hours they can use to perform labor when exhauasted.  Can be negative to remove previously granted energy.", "en", ChatAuthorizationLevel.Admin)]
  public static void Energize(Eco.Gameplay.Players.User user, int hours = 10000, Eco.Gameplay.Players.User target = null);

  [ChatSubCommand("User", "Force a user to be exhausted for the remainder of the day.", "exhaust", ChatAuthorizationLevel.Admin)]
  public static void Exhaust(Eco.Gameplay.Players.User user, Eco.Gameplay.Players.User target = null);

  [ChatSubCommand("User", "Set exhaustion data to default, as if fresh start. It will allow first time bonuses again", "defaultexhaust", ChatAuthorizationLevel.Admin)]
  public static void DefaultExhaust(Eco.Gameplay.Players.User user, Eco.Gameplay.Players.User target = null);

  [ChatSubCommand("User", "Change last refresh day from target by days (positive to add and negative to remove) ", "givelastrefreshday", ChatAuthorizationLevel.Admin)]
  public static void SetLastRefreshDay(Eco.Gameplay.Players.User user, int days, Eco.Gameplay.Players.User target = null);
}
