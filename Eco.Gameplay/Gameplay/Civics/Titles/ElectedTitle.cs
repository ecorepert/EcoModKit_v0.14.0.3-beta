// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.ElectedTitle
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Titles;

[Serialized]
[Ecopedia(null, "Elected Titles", false, true, null)]
[LocDescription("Elected Titles are government officials that can be assigned permissions to manage government policy.")]
[Tag("CanBeInConstitution")]
public class ElectedTitle : 
  Title,
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
  ISettlementAssociated,
  IProvidesContext
{
  [Serialized]
  [DontClone]
  public 
  #nullable disable
  ThreadSafeList<PositionHistory> History { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The rules for how this election is run.  Election Processes are defined directly by the constitution.")]
  [AnyStateAllowed]
  public ElectionProcess ElectionProcess { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("Only candidates who are part of this group can run for this position.")]
  public IAlias EligibleCandidates { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A logic block that must be true for a given candidate to run for this office.")]
  [AllowNullInView]
  public GameValue<bool> RequiredOfCandidates { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("How many occupants may hold this title at once? After an election, this many candidates will be put into the position, choosing from those with the most votes.")]
  public override int MaxOccupants { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("In the event that the office holder of this position leaves office not through election, they will be automatically replaced with one or more players from this title, randomly chosen.")]
  [AllowNullInView]
  public IAlias Successor { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("Citizens in this group can remove occupants of this elected title immediately at any government office.")]
  [AllowNullInView]
  public IAlias WhoCanRemoveFromOffice { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("After a title has been held for this many days, a new election may be started for the position (if no election is started, the current occupants will remain until one is).")]
  public float TermLimitDays { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("An individual player may hold the position this many times, after which they will not be allowed to run for election.")]
  public int TotalTermsAllowed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Separate from how many total terms a citizen can serve, this value defines how many terms a citizen can have consecutively.")]
  public int ConsecutiveTermsAllowed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If this is true, elections can start before the end of the office holder's term, allowing only on the last hours of their term (when that amount is less than the hours an election takes, + 4 for a margin).")]
  public bool CanElectionsBeProposedDuringTerm { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Can holders of this position set world markers that will be seen by all citizens in this settlement?")]
  public bool CanSetSettlementMarkers { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Can holders of this position change treasury taxes?")]
  public bool CanSetTreasuryTaxes { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Can holders of this position use the treasury bank account?")]
  public bool CanUseTreasuryBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Allows title holders to set bank accounts as 'government accounts', performed at a bank object when creating a new entry. This allows them to be the source/target of tax funds from laws, and prevents them from contributing to the account ownership or wealth total of any managers that are set on it.")]
  public bool HasGovernmentBankingPrivileges { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Allows title holders to use Embassy Desk objects to determine cultural influence and annex other settlements, set the new-citizen message, and adjust border control in the foundation.")]
  public bool HasDiplomaticPrivileges { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Allows title holders to block child settlement influence on claim stakes from this settlements. This allows creation of 'federal land' where town laws do not apply, for example.")]
  public bool HasPropertyPrivileges { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ProposableState State { get; set; }

  [Serialized]
  public bool ScanPeriodically { get; set; }

  [Serialized]
  public double LastValidTime { get; set; }

  [SyncToView(null, true)]
  [DependsOnController("OccupantList", true)]
  public override IEnumerable<User> UserSet { get; }

  public override IEnumerable<User> DirectOccupants { get; }

  public bool IsActive { get; }

  public bool WasRemoved { get; }

  public override void Clear();

  public virtual void InitializeDraftProposable();

  [Serialized]
  [SyncToView(null, true)]
  public IProposable TargetToReplace { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Settlement Settlement { get; set; }

  [Serialized]
  public IProposable RevisionParent { get; set; }

  [Serialized]
  public Election Election { get; set; }

  [Serialized]
  public User RemovedBy { get; set; }

  [Serialized]
  public Election RemovalElection { get; set; }

  [Serialized]
  public WorldObjectHandle HostObject { get; protected set; }

  [Serialized]
  public bool RequiresHost { get; set; }

  [SyncToView(null, true)]
  public User CurrentEditingUser { get; set; }

  public ThreadSafeList<WeakReference> UsingPlayers { get; set; }

  public bool DescribedWithTable { get; }

  public bool Occupied { get; }

  public double TimeLeftInTerm();

  public double TermEnds { get; }

  [DependsOnMember("ElectionProcess")]
  [DependsOnMember("OccupantList")]
  [SyncToView(null, true)]
  public override LocString Description();

  public override void Initialize();

  public virtual void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  public Dictionary<IHasID, IHasID> GetPairsOfOldAndNewRevisions(IProposable old);

  public virtual void ApplyUpdatedProposable(IProposable old);

  public override void Destroyed();

  public override void AddOccupant(User user, LocString reason);

  public override void RemoveOccupant(User userRemoved, LocString reason);

  public void SetNewElected(Election election, IEnumerable<User> users);

  public override bool ContainsUser(User user);

  public override bool ContainsExactAlias(IAlias alias);

  public override Result Valid();

  public Result CanRun(User user);

  public override bool RecurringTransfersIsActive();

  public virtual void DisableHostedObject();

  public virtual void AssignHostObject(WorldObject newHost);

  public virtual bool CanBeAssignedTo(IOrphanAssignment container);

  /// <summary>Get list of current or latest holders of this office, if there is none we get an empty list</summary>
  public ThreadSafeList<User> GetLatestOfficeHolders();

  Settlement IHostedObject.HostingSettlement { get; }

  bool IHostedObject.CanBeEdited { get; set; }

  [Serialized]
  int IHostedObject.ExpirationWarningsIssued { get; set; }
}
