// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.Internal.TwitchElectionUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Elections.Internal;

public class TwitchElectionUtil
{
  /// <summary>Do the notification when a twich user votes.</summary>
  public static void NotifyTwitchVoterVoted(
    string twitchUserName,
    TwitchVote vote,
    Election election,
    Settlement settlement,
    Func<ElectionChoiceID, LocString> choiceToName);

  /// <summary>Output several lines describing a bunch of twitch votes in an election.</summary>
  public static LocString DescribeTwitchVotesInElection(
    IEnumerable<(string Name, TwitchVote Vote)> votes,
    Func<ElectionChoiceID, LocString> choiceToName,
    ElectionProcess process);

  /// <summary>Compile a dictionary of ElectionChoiceIDs to the numer of weighted votes it has, using the TwitchVote data, and output a string to describe the result.</summary>
  /// <param name="maxPercentTwitchVotes">Cap the twitch votes to this percent of the total votes in the election.</param>
  /// <param name="userVotes">count of user votes</param>
  public static Dictionary<ElectionChoiceID, float> GetTwitchVotes(
    IDictionary<string, TwitchVote>? votesByName,
    float maxPercentTwitchVotes,
    ElectionProcess process,
    int userVotes,
    out LocString reductionResult);

  /// <inheritdoc cref="M:Eco.Gameplay.Civics.Elections.Internal.TwitchElectionUtil.GetTwitchVotes(System.Collections.Generic.IDictionary{System.String,Eco.Gameplay.Civics.Elections.TwitchVote},System.Single,Eco.Gameplay.Civics.ElectionProcess,System.Int32,Eco.Shared.Localization.LocString@)" />
  /// <param name="election">Election to retrieve details from.</param>
  public static Dictionary<ElectionChoiceID, float> GetTwitchVotes(
    IDictionary<string, TwitchVote>? votesByName,
    Election election,
    out LocString reductionResult);
}
