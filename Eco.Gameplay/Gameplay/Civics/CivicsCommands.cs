// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics;

[ChatCommandHandler]
public static class CivicsCommands
{
  [ChatCommand("Performs a variety of government operations.")]
  public static void Civics(IChatClient chatClient);

  [ChatSubCommand("Civics", "Toggle debug display of civic processing. Pass 'false' to see for only yourself.", ChatAuthorizationLevel.Admin)]
  public static void Debug(User user, bool allUsers = true);

  [ChatSubCommand("Civics", "Lists the active elements of the government.", ChatAuthorizationLevel.User)]
  public static void ShowGovernment(IChatClient chatClient);

  [ChatSubCommand("Civics", "Show time until the next civics tick.", ChatAuthorizationLevel.User)]
  public static void ShowTick(IChatClient chatClient);

  [ChatSubCommand("Civics", "Force a tick on the civics system to happen immediately.", ChatAuthorizationLevel.Admin)]
  public static void TickNow(IChatClient chatClient);

  [ChatSubCommand("Civics", "Create an elected title for debugging and put in a test user.", ChatAuthorizationLevel.DevTier)]
  public static void MakeElectedTitle(IChatClient client);

  [ChatSubCommand("Civics", "List running elections.")]
  public static void Elections(IChatClient client);

  [ChatSubCommand("Civics", "Force a given citizen to always be a member of a given demographic even if they dont match the conditions.", "adddems", ChatAuthorizationLevel.Admin)]
  public static void WhitelistDemographic(
    IChatClient client,
    Demographic demo,
    bool set = true,
    User user = null);

  [ChatSubCommand("Civics", "Force a given citizen to be removed of a given demographic even if they dont match the conditions.", "removedems", ChatAuthorizationLevel.Admin)]
  public static void BlacklistDemographic(
    IChatClient client,
    Demographic demo,
    bool set = true,
    User user = null);

  public static void ChangeDemographic(
    IChatClient client,
    bool whitelist,
    Demographic demo,
    bool set = true,
    User user = null);

  [ChatSubCommand("Civics", "Force a given citizen to be in the abandoned demographic (self if none passed).", "makeabandoned", ChatAuthorizationLevel.Admin)]
  public static void MakeAbandoned(IChatClient client, User user = null);

  [ChatSubCommand("Civics", "Force a given citizen to be in the active demographic (self if none passed).", "makeactive", ChatAuthorizationLevel.Admin)]
  public static void MakeActive(IChatClient client, User user = null);

  [ChatSubCommand("Civics", "Force demographics to update immediately.", ChatAuthorizationLevel.Admin)]
  public static void UpdateDems(IChatClient chatClient);

  [ChatSubCommand("Civics", "List each demographic and who is in it.", ChatAuthorizationLevel.User)]
  public static void ListDems(IChatClient chatClient);

  [ChatSubCommand("Civics", "List each demographic and the status of the specified user (using the called if none specified).", ChatAuthorizationLevel.User)]
  public static void MyDems(User user, User otherUser = null);

  [ChatSubCommand("Civics", "Spawn a zoning office, passing the number of maps and districts in each. Defaults to a lot (3 maps with 100 districts each).", ChatAuthorizationLevel.DevTier)]
  public static void SpawnZoningOffice(User user, int maps = 3, int districtCount = 100);

  [CITest(false)]
  [ChatSubCommand("Civics", "Create all the government objects in their needed buildings near you, ratify the constitution, and add at least one of each civics object to their tables. Pass 'false' to make the constitution not require elections to make changes.", ChatAuthorizationLevel.DevTier)]
  public static void SpawnGov(IChatClient client, bool requireElections = true);

  /// <summary> Spawn a Government. It is possible to override the capitol object (used in settlements) </summary>
  public static List<WorldObject> SpawnGov(
    IChatClient client,
    Vector3i? spawnPos,
    bool requireElections = true,
    int tier = 1,
    bool showMessages = false,
    string capitolName = "CapitolObject");
}
