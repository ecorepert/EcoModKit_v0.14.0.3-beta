// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.TitleCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Civics.Titles;

[ChatCommandHandler]
public static class TitleCommands
{
  [ChatCommand("Shows commands for viewing and manipulating player titles.")]
  public static void Titles(User user);

  [CITest(false)]
  [ChatSubCommand("Titles", "Lists all existing titles and info about them.", ChatAuthorizationLevel.User)]
  public static void List(User user);

  [ChatSubCommand("Titles", "Assigns a given user to a given title, assigning to yourself if none is specified.", ChatAuthorizationLevel.Admin)]
  public static void Assign(User user, Title title, User assignTo = null);

  [ChatSubCommand("Titles", "Removes a given user from a given title, removing from yourself if none is specified.", ChatAuthorizationLevel.Admin)]
  public static void Unassign(User user, Title title, User unassignUser = null);

  [ChatSubCommand("Titles", "Clears all occupants from a title.", ChatAuthorizationLevel.Admin)]
  public static void Clear(User user, Title title);

  [ChatSubCommand("Titles", "Permanently deletes a title.", ChatAuthorizationLevel.Admin)]
  public static void Delete(User user, Title title);

  [ChatSubCommand("Titles", "Rename a new title.", ChatAuthorizationLevel.Admin)]
  public static void Rename(User user, Title title, string newName);

  [ChatSubCommand("Titles", "Set values for a title.", ChatAuthorizationLevel.Admin)]
  public static void Set(User user, Title title, int maxOccupants);

  [CITest(false)]
  [ChatSubCommand("Titles", "Create a bunch of titles for testing.", ChatAuthorizationLevel.DevTier)]
  public static void Spawn(User user, int number = 5);

  [ChatSubCommand("Titles", "Assign the current player to a new title that has treasury rights.", ChatAuthorizationLevel.DevTier)]
  public static void GiveTreasuryRights(User user, Settlement settlement);

  [ChatSubCommand("Titles", "Allow the given user to change all world marker settlement types without permissions.", ChatAuthorizationLevel.Admin)]
  public static void GiveGlobalMarkerRights(User user, Settlement settlement, bool set = true);

  [ChatSubCommand("Titles", "Set a 'boost' that will add to all 'recent playtime' requests for the given player (yourself if null, 2 hours if unset).  Will make players instantly active if set high enough.", ChatAuthorizationLevel.Admin)]
  public static void SetPlaytimeBoost(IChatClient client, float hoursBoost = 2f, User user = null);
}
