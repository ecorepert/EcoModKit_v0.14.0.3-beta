// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.UserCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class UserCommands
{
  [CITest(true)]
  [ChatSubCommand("Util", "Attempts to unstuck your avatar", "unstuck", ChatAuthorizationLevel.User)]
  public static void Unstuck(User user);

  [ChatSubCommand("Util", "Make your character invisible", ChatAuthorizationLevel.Admin)]
  public static void Invisible(User user);

  [ChatSubCommand("Util", "Attempts to unstuck vehicle in target", "freecar", ChatAuthorizationLevel.User)]
  public static void UnstuckVehicle(User user, INetObject target);

  [ChatSubCommand("Util", "Evaluates provided math expression", "calc", ChatAuthorizationLevel.User)]
  public static void Calculate(IChatClient chatClient, string expression);

  [CITest(false)]
  [ChatSubCommand("Manage", "Returns a list of online players")]
  public static void Players(IChatClient chatClient);

  [ChatSubCommand("Time", "Reports the current time.")]
  public static void Now(IChatClient chatClient);

  [ChatSubCommand("Manage", "Lists the playtimes for a given user, or yourself if none passed.", "playtime", ChatAuthorizationLevel.User)]
  public static void Playtime(User user, User other = null);

  [ChatCommand("Reports residency for a given user, or yourself if none passed")]
  public static void Residence(User user, User other = null);

  [ChatSubCommand("Manage", "Displays your authorization level", ChatAuthorizationLevel.User)]
  public static void AuthLevel(User user);
}
