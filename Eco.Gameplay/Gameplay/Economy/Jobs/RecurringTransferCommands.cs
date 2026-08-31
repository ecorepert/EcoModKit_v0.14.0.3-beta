// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.RecurringTransferCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Economy.Jobs;

[ChatCommandHandler]
public static class RecurringTransferCommands
{
  [ChatCommand("Shows commands related to the economy.")]
  public static void Economy(User user);

  [ChatSubCommand("Economy", "Display all recurring transfers paid in the game")]
  public static void AllRecurring(User user);

  [ChatSubCommand("Economy", "Display all recurring transfers for the given user")]
  public static void MyRecurring(User user, User specifiedUser = null);

  [ChatSubCommand("Economy", "Enable debug command to pay recurring transfers every tick.", ChatAuthorizationLevel.DevTier)]
  public static void PayEveryTick(User user);

  [ChatSubCommand("Economy", "Pay all current outstanding rents and wages.", "payall", ChatAuthorizationLevel.Admin)]
  public static void PayAll(User user);
}
