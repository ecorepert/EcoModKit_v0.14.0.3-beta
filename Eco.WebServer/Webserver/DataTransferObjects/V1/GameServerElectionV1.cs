// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.GameServerElectionV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

/// <summary>SimpleEntryV1 implementation for transfering data about game server elections over web services.</summary>
/// <seealso cref="T:Eco.WebServer.DataTransferObjects.V1.SimpleEntryV1" />
public class GameServerElectionV1 : SimpleEntryV1
{
  public ElectionChoiceV1[] Choices { get; set; }

  public int TotalVotes { get; set; }

  public double TimeEnd { get; set; }

  public double TimeEndAgo { get; set; }

  public double TimeStart { get; set; }

  public double TimeStartAgo { get; set; }

  public bool Finished { get; set; }

  public bool Passed { get; set; }

  public bool PendingVote { get; set; }

  public ElectionCommentV1[] Comments { get; set; }

  public List<CivicActionV1> Provisions { get; set; }

  public ElectionResultsV1 Results { get; set; }

  public ElectionProcessV1 ElectionProcess { get; set; }

  public ElectedTitleV1 PositionForWinner { get; set; }

  public bool BooleanElection { get; set; }

  public bool PollElection { get; set; }

  public string ElectionDescription { get; set; }

  public GameServerElectionV1();

  public GameServerElectionV1(Election election, User userWhoAsks);
}
