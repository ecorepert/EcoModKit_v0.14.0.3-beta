// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Internal.ElectionChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Civics.Internal;

[ChatCommandHandler]
public static class ElectionChatCommands
{
  [ChatCommand("Performs a variety of election operations.", ChatAuthorizationLevel.Admin)]
  public static void Elections(IChatClient chatClient);

  [ChatSubCommand("Elections", "Force-end the specified election, adding a vote if true is passed (default). If no election found, pass any, including draft ones.", "fin", ChatAuthorizationLevel.Admin)]
  public static void Finish(User user, Election election = null, bool addVote = true);

  [ChatSubCommand("Elections", "End and fail an election. Optionally provide election title or ID. Example: '/Elections Fail,(Election Title)' or '/Elections Fail,(Election ID)'", ChatAuthorizationLevel.Admin)]
  public static void Fail(User user, Election election = null, string electionIdentifier = null);

  [ChatSubCommand("Elections", "Vote in the given election for the given candidate. If null is passed for election, take first. Null for candidate, pick a random ordering. Null for voter, use self.", "vote", ChatAuthorizationLevel.Admin)]
  public static Result Vote(
    IChatClient user,
    Election election = null,
    User voteForCandidate = null,
    User voter = null);

  [ChatSubCommand("Elections", "Make a new user and force a vote in the given election for the given index of the election choices.", "voteindex", ChatAuthorizationLevel.DevTier)]
  public static Result NewVoteByIndex(IChatClient user, int index, Election election = null);

  [ChatSubCommand("Elections", "Create a bunch of test votes.", "votes", ChatAuthorizationLevel.DevTier)]
  public static void UserVotes(IChatClient user, Election election = null, int votesToAdd = 10);

  [ChatSubCommand("Elections", "Vote in the given election for the given candidate using the given twitch IDIChatClient Passing null will pick a random one.", ChatAuthorizationLevel.DevTier)]
  public static void TwitchVote(
    IChatClient user,
    Election election = null,
    string twitchVoter = null,
    bool subscriber = true);

  [ChatSubCommand("Elections", "Generate a few elections and fill all elections with random votes.", "elecs", ChatAuthorizationLevel.DevTier)]
  public static void Test(IChatClient user, int votesToAdd = 10, int twitchVotesToAdd = 1000);

  [ChatSubCommand("Elections", "Create many twitch votes with random users.", "twitchvotes", ChatAuthorizationLevel.DevTier)]
  public static void TwitchVotes(IChatClient user, int voteCount = 1000, Election election = null);

  [ChatSubCommand("Elections", "Force-win an election, either with the specified candidate, or 'yes' if it's a binary election.", ChatAuthorizationLevel.Admin)]
  public static void Win(User user, Election election = null, User winner = null);

  [ChatSubCommand("Elections", "Veto an election.", "veto", ChatAuthorizationLevel.Admin)]
  public static void Veto(User user, Election election = null);

  [ChatSubCommand("Elections", "Remove record of a specific election, or if none passed, all previous elections.", ChatAuthorizationLevel.Admin)]
  public static void ClearOld(IChatClient chatClient, Election election = null);

  [ChatSubCommand("Elections", "Force recalculation of all elections.", "recalcelec", ChatAuthorizationLevel.Admin)]
  public static void ForceRecalc(IChatClient chatClient);

  [ChatSubCommand("Elections", "Create an active election of candidates that does nothing for testing purposes.", "elec1", ChatAuthorizationLevel.DevTier)]
  public static void SpawnCandidate(IChatClient client, int candidates = 5, ElectionProcess process = null);

  [ChatSubCommand("Elections", "Create an active boolean election that does nothing for testing purposes.", "elec2", ChatAuthorizationLevel.DevTier)]
  public static void SpawnBoolean(IChatClient client, ElectionProcess process = null);

  [ChatSubCommand("Elections", "Open a dialog that allow starting a poll.", "poll", ChatAuthorizationLevel.Admin)]
  public static void CreatePoll(IChatClient client);
}
