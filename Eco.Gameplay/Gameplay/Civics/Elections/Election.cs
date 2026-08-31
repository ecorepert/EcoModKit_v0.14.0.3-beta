// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.Election
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[ForceCreateView]
[Ecopedia(null, "Elections", false, true, null)]
[LocDescription("A poll set to a group of citizens to determine a position or referendum.")]
public sealed class Election : 
  SimpleProposable,
  IProposable,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IHostedObject,
  ILinkable,
  IHasTeleportOption,
  ILinkableParameterized<bool>,
  ICustomValidity,
  IValidity,
  ISuffixName,
  ISingleEditingUser,
  IPlayerUseTracking,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  ISettlementAssociated
{
  /// <summary>Executed when somebody voted in any election.</summary>
  public static 
  #nullable disable
  ThreadSafeAction<UserRunoffVote> UserVotedEvent;
  /// <summary>Executed when a Twitch user voted on any election.</summary>
  public static ThreadSafeAction<Eco.Gameplay.Civics.Elections.TwitchVote> TwitchVotedEvent;
  /// <summary>Executed whenever an election completes.</summary>
  public static ThreadSafeAction<Election> ElectionFinishedEvent;
  /// <summary>Executed whenever an election's choice options change.</summary>
  public static ThreadSafeAction<Election> ElectionChoicesChangedEvent;
  /// <summary>Executed whenever an election's provisions change.</summary>
  public static ThreadSafeAction<Election> ElectionProvisionsChanged;
  public ThreadSafeAction ProvisionsChanged;

  /// <summary>Executed whenever voting for an election starts.</summary>
  [Notify]
  public static ThreadSafeAction<Election> ElectionStartedEvent { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The time the election started.")]
  public double TimeStarted { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The time the election ends or ended.")]
  public double TimeEnded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The election process used for voting.")]
  public ElectionProcess Process { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The title that is voted upon.")]
  [AllowNullInView]
  public ElectedTitle PositionForWinner { get; set; }

  /// <summary>Represents the election ending timestamp as <see cref="T:System.DateTime" /></summary>
  public DateTime EndDateTime { get; }

  /// <summary>
  /// The actions we run when the election succeeds.
  /// We dont scan the contents because CanStartForActions is called when an election starts, and that does a full consideration of what
  /// states should be allowed, ensures that referenced drafts are also in the election, etc.  (we could move that to be a Valid check in the election and
  /// then allow it to be scanned normally, but we'll leave that for now)
  /// </summary>
  [Serialized]
  [SyncToView(null, true)]
  [LocDescription("Actions that will occur once the election is completed.")]
  [AllowEmpty]
  [IgnoreValidity]
  public ControllerList<CivicAction> ActionsOnComplete { get; }

  [SyncToView(null, true)]
  public double MaxEndTime { get; }

  [SyncToView(null, true)]
  public IEnumerable<SimpleResult> SimpleResults { get; }

  [SyncToView(null, true)]
  public IEnumerable<SimpleResult> CurrentSimpleResults { get; }

  [SyncToView(null, true)]
  public bool Finished { get; }

  [SyncToView(null, true)]
  public bool BooleanElection { get; }

  [SyncToView(null, true)]
  public bool PollElection { get; }

  [SyncToView(null, true)]
  public string BooleanElectionYesMarkedUpName { get; }

  [SyncToView(null, true)]
  public string BooleanElectionNoMarkedUpName { get; }

  [Serialized]
  public ControllerList<ElectionChoice> Choices { get; set; }

  [Serialized]
  public ThreadSafeDictionary<User, UserRunoffVote> UserVotes { get; set; }

  [Serialized]
  public ThreadSafeDictionary<string, Eco.Gameplay.Civics.Elections.TwitchVote> RawTwitchVotes { get; set; }

  [Serialized]
  public ThreadSafeList<ElectionComment> Comments { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Set to true to make it not care about: no actions on completion")]
  public bool DebugElection { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When set, election will end as soon as the minimum number of voters has ben reached.")]
  public bool AllowEarlyEndWithEnoughVotes { get; set; }

  [Serialized]
  public ElectionResult CurrentResults { get; }

  public HandleEvent OnComplete { get; }

  public int TotalVotes { get; }

  public int PossibleWinners { get; }

  public override bool RequiresHost { get; }

  public IEnumerable<IProposable> ProposablesInElection { get; }

  public double Elapsed { get; }

  public double TimeLeft { get; }

  public LocString BriefStatus { get; }

  [Eco.Shared.Serialization.OnPostLoad]
  public void OnPostLoad();

  public bool HasProvisionFor(IProposable element);

  public bool Voted(User user);

  public Result CanJoinElection(User user);

  public bool Contains(User user);

  public ElectionChoice GetChoiceByName(string name);

  public ElectionChoice GetChoiceById(ElectionChoiceID id);

  public LocString GetChoiceName(ElectionChoiceID id);

  public string GetSpeech(ElectionChoiceID id);

  public User GetChoiceUser(ElectionChoiceID id);

  public ElectionChoice GetChoiceByUser(User user);

  public void AddChoice(ElectionChoice candidateChoice);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override void Initialize();

  public void AttachCivicAction(CivicAction actionPerformed);

  public void RemoveProvisionsWhere(Predicate<CivicAction> predicate);

  /// <summary>Return the finished results, or null if theyre not done.</summary>
  public ElectionResult GetFinishedResult();

  /// <summary>Generates the current results if theyre not set.</summary>
  public ElectionResult GetCurrentResults();

  /// <summary>Check the various things that determine if a user can vote or not.</summary>
  public Result CanVote(User user);

  /// <summary>Cast a vote from a twitch user.</summary>
  public Result TwitchVote(string twitchID, string twitchUserName, Eco.Gameplay.Civics.Elections.TwitchVote vote);

  public Result Vote(UserRunoffVote vote);

  public void Enter();

  public void Withdraw(User user);

  public void Veto(User user);

  [RPC]
  public Election Start(Player player);

  public Election Start(User user, bool notify = true, bool force = false);

  [RPC]
  public void CancelDraftElection(Player player);

  [SyncToView(null, true, Flags = SyncFlags.ClientCached)]
  public override LocString Description();

  public LocString FullDescribe();

  public void ForceUpdate();

  public void CheckFinishedAndProcess(bool forceUpdate = false);

  public void DebugForceFinish();

  /// <summary>Display a large text of all the votes.</summary>
  [RPC(AccessType.None)]
  [RPCAuthMaxProposableState(ProposableState.Failed)]
  public void ShowAllVotes(Player player);

  bool IProposable.RequiresCivicActionToActivate { get; }
}
