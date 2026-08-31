// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Money.MoneyCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Economy.Money;

[ChatCommandHandler]
public static class MoneyCommands
{
  [ChatCommand("Shows commands for manipulating money.")]
  public static void Money();

  [ChatSubCommand("Money", "Display all bank accounts in the game.", ChatAuthorizationLevel.User)]
  public static void Accounts(IChatClient chatClient);

  [ChatSubCommand("Money", "Create new bank accounts for each user.", ChatAuthorizationLevel.DevTier)]
  public static void SpawnAccounts(User user, int count);

  [CITest(false)]
  [ChatSubCommand("Money", "Give every player an amount of money", "gabe", ChatAuthorizationLevel.Admin)]
  public static void SteamSale(IChatClient chatClient, float amount = 1000f);

  [ChatSubCommand("Money", "List all currencies in the game.", ChatAuthorizationLevel.User)]
  public static void Currencies(IChatClient chatClient);
}
