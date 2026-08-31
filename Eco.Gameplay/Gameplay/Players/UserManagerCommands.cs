// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserManagerCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Players;

[ChatCommandHandler]
public static class UserManagerCommands
{
  [ChatCommand("Shows commands for users administration.")]
  public static void Manage();

  [ChatSubCommand("Manage", "Shows list of banned users or bans user by account id, steamid, slgid, or username. Ban forever by default with empty time. Time format: 1m, 1h, 1d, 1w.", "ban", ChatAuthorizationLevel.Admin)]
  public static void Ban(IChatClient client, string nameOrID = "", string reason = "", string time = "");

  [ChatSubCommand("Manage", "Unbans user by account id, steamid, slgid, or username", "unban", ChatAuthorizationLevel.Admin)]
  public static void UnBan(IChatClient client, string nameOrID = "", string reason = "");

  [ChatSubCommand("Manage", "Shows list of muted users or mutes user by account id, steamid, slgid, or username. Mute forever by default with empty time. Time format: 1m, 1h, 1d, 1w.", "mute", ChatAuthorizationLevel.Admin)]
  public static void Mute(IChatClient client, string nameOrID = "", string reason = "", string time = "");

  [ChatSubCommand("Manage", "Unmutes user by account id, steamid, slgid, or username", "unmute", ChatAuthorizationLevel.Admin)]
  public static void UnMute(IChatClient client, string nameOrID = "", string reason = "");

  [ChatSubCommand("Manage", "Shows list of whitelisted users or adds user to the whitelist by account id, steamid, slgid, or username", ChatAuthorizationLevel.Admin)]
  public static void Whitelist(IChatClient client, string nameOrID = "", string reason = "");

  [ChatSubCommand("Manage", "Removes user from the whitelist by account id, steamid, slgid, or username", ChatAuthorizationLevel.Admin)]
  public static void UnWhitelist(IChatClient client, string nameOrID = "", string reason = "");

  [ChatSubCommand("Manage", "Shows list of admins or adds user as an Admin by account id, steamid, slgid, or username", "admin", ChatAuthorizationLevel.Admin)]
  public static void Admin(IChatClient client, string nameOrID = "", string reason = "");

  [ChatSubCommand("Manage", "Removes user as an Admin by account id, steamid, slgid, or username", ChatAuthorizationLevel.Admin)]
  public static void RemoveAdmin(IChatClient client, string nameOrID, string reason = "");

  [ChatSubCommand("Manage", "Kicks user", "kick", ChatAuthorizationLevel.Admin)]
  public static void Kick(IChatClient client, User kickUser, string reason = "");

  [CITest(false)]
  [ChatSubCommand("Manage", "Shows your user ID", ChatAuthorizationLevel.User)]
  public static void WhoAmI(User user);

  [ChatSubCommand("Manage", "Shows the user ID of the requested user.", ChatAuthorizationLevel.Admin)]
  public static void WhoIs(User user, User otherUser);

  [ChatSubCommand("Manage", "Hide player position in tooltip and/or minimap", ChatAuthorizationLevel.Admin)]
  public static void HidePlayerPosition(User user, bool tooltip, bool minimap);

  [CITest(false)]
  [ChatSubCommand("Manage", "Displays a list of all known users, showing username and ID.", ChatAuthorizationLevel.Admin)]
  public static void ListUsers(IChatClient client);

  [CITest(false)]
  [ChatSubCommand("Manage", "Displays a list of all administrators.", ChatAuthorizationLevel.User)]
  public static void ListAdmins(IChatClient client);

  [ChatSubCommand("Manage", "Shows your Ignore List or adds the player to the Ignore List by the name or remove if the player is on the list already", "ignore", ChatAuthorizationLevel.User)]
  public static void Ignore(User user, User ignoreUser = null);
}
