// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ElectionProcess
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics;

[Serialized]
[Ecopedia(null, "Election Processes", false, true, null)]
[LocDescription("A set of rules for how an election is run.")]
[Tag("CanBeInConstitution")]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class ElectionProcess : SimpleProposable, ISpecialRegistrarEntry
{
  [Browsable(false)]
  public ThreadSafeAction VotersChanged { get; }

  [WatchSubMember("UserSetChangedEvent", "VotersChanged", SubPropWatcherFlag.None)]
  [Browsable(false)]
  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("Who can vote in elections of this type?")]
  public IAlias Voters { get; set; }

  [Browsable(false)]
  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("Who can veto elections of this type?")]
  [AllowNullInView]
  public IAlias Vetoers { get; set; }

  [Browsable(false)]
  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("Who can start elections of this type?")]
  [AllowNullInView]
  public IAlias WhoCanStartElections { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("How to proceed if there was a tie in the election.")]
  [DisplayName("How To Proceed If Elections End In A Tie")]
  public TiedElectionOptions HowToProceedIfElectionsEndInATie { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("After this many hours, the election will end with or without a winner.")]
  public float MaximumElectionHours { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The election will not produce a winner unless this percentage of eligible voters have cast their vote.")]
  public float MinimumPercentOfEligibleVotersRequired { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If this percent of *all possible voters* votes yes, the election will instant-finish.")]
  public float PercentOfAllVotersToInstantWin { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If this percent of *all possible voters* votes no, the election will instant-fail.")]
  public float PercentOfAllVotersToInstantLose { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If this percentage of voters have cast their vote, then the election will end early (but not sooner than the Minimum Election Time).")]
  public float EndElectionEarlyWhenThisPercentHaveVoted { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Once an election of this type completes, another of the same type cannot be started for this many days.")]
  public float MinimumDaysBetweenElectionsOfThisType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Should the way a citizen votes be hidden?")]
  public bool AnonymousVoting { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When using the Eco Twitch Plugin to allow your audience to participate in elections: The percent value a vote from a Twitch subscriber counts relative to vote from a player.")]
  public float TwitchSubscriberVoteWeight { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When using the Eco Twitch Plugin to allow your audience to participate in elections: The percent value a vote from a Twitch viewer (who does not subscribe) counts relative to vote from a player.")]
  public float TwitchNonSubscriberVoteWeight { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When using the Eco Twitch Plugin to allow your audience to participate in elections: The maximum percent contribution all combined Twitch voters can have in election.")]
  public float MaxPercentTwitchVotes { get; set; }

  [Serialized]
  public int SpecialType { get; set; }

  public override Result Valid();

  public override void Initialize();

  [DependsOnMember("Voters")]
  [DependsOnMember("Vetoers")]
  [DependsOnSubMember("Voters", "Name", typeof (SimpleEntry))]
  [DependsOnSubMember("Vetoers", "Name", typeof (SimpleEntry))]
  [SyncToView(null, true)]
  public override LocString Description();

  public Result TestCanStartElectionAndNotify(User user);

  public override bool CanBeDeleted { get; }
}
