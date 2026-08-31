// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Settlement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Immigration;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Reputation;
using Eco.Gameplay.InfluenceObjects;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements.Internal;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>A settlement defines 'influence' in the world upon which its government is applied and land can be claimed.
/// It also maintains a list of citizens associated with the government, and polices for changing citizens.</summary>
[Serialized]
[ExactlyOnePerHost]
public sealed class Settlement : 
  SimpleEntry,
  IInitializationSubscribable,
  IInfluencer,
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
  IAnnexable,
  IGivesReputation,
  IReputationAssociated,
  ICachesValidity,
  INotifyPropertyChanged
{
  public ThreadSafeAction FoundedEvent;
  [Serialized]
  public ThreadSafeList<User> Founders;
  /// <summary>Tracks all world objects that have a jurisdiction which is assigned to us.</summary>
  public ThreadSafeHashSet<WorldObject> WorldObjectsWithAssignedJurisdiction;

  [Notify]
  public static ThreadSafeAction<Settlement> LeaderAndCitizensUpdatedEvent { get; }

  [Notify]
  public static ThreadSafeAction AllowBrandNewPeopleChangedEvent { get; }

  [Notify]
  public ThreadSafeAction SettlementLineageNameChangedEvent { get; }

  public ThreadSafeAction<IProposable> ProposableUpdatedEvent { get; }

  [Serialized]
  [SyncToView(null, true)]
  public SettlementParentage Parentage { get; }

  [Serialized]
  [SyncToView(null, true)]
  public SettlementType SettlementType { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Vector3i Position { get; }

  [Serialized]
  [Notify]
  public WorldObjectHandle HostObject { get; }

  [Serialized]
  public double LastValidTime { get; set; }

  [Serialized]
  [Notify]
  public bool Enabled { get; set; }

  [WatchSubMember("CitizensChangedEvent", "RaiseLeaderAndCitizensUpdated", SubPropWatcherFlag.None)]
  [Serialized]
  [NewTooltipChildren(CacheAs.Instance)]
  public SettlementCitizenship Citizenship { get; set; }

  [Serialized]
  [NewTooltipChildren(CacheAs.Instance)]
  public SettlementProperty Property { get; set; }

  [Serialized]
  [NewTooltipChildren(CacheAs.Instance)]
  public SettlementInfluence Influence { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public SettlementCachedData CachedData { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public SettlementTaxes Taxes { get; set; }

  [Serialized]
  public SettlementLegal Legal { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AllowNullInView]
  public PictureItem? Picture { get; }

  [WatchSubMember("UserSetChangedEvent", "RaiseLeaderAndCitizensUpdated", SubPropWatcherFlag.None)]
  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public ElectedTitle? Leader { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public ImmigrationPolicy? ImmigrationPolicy { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public ElectionProcess? ElectionProcess { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public Constitution? Constitution { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public Demographic? CitizenDemographic { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public BankAccount? TreasuryBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public Currency? DefaultCurrency { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  [AllowNullInView]
  public string AdvertisementToNewPeopleEnteringWorld { get; set; }

  public bool ScanPeriodically { get; set; }

  [Serialized]
  public bool IgnoreRequiresHost { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public bool Founded { get; }

  [Serialized]
  [Notify]
  public Vector3i FoundingPosition { get; }

  [Serialized]
  public double TimeFounded { get; }

  [Serialized]
  public Election? FoundingElection { get; set; }

  [SyncToView(null, true)]
  public Color Color { get; }

  [Serialized]
  public ControllerList<Eco.Gameplay.UI.WorldMarker.WorldMarker> Markers { get; }

  [Serialized]
  [Notify]
  public float CultureBoost { get; set; }

  [Serialized]
  public string? OriginalName { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.Admin)]
  public double LastAnnexedTime { get; set; }

  [Serialized]
  ThreadSafeDictionary<int, int>? IAnnexable.SettlementIDtoAnnexWarningIssued { get; set; }

  Settlement IHostedObject.HostingSettlement { get; }

  /// <summary>The cultrual properties chosen on a diplomacy desk, foreced to be part of the set of influencing deeds.</summary>
  [Serialized]
  [Notify]
  public ThreadSafeList<Deed> AssignedCulturalDeeds { get; set; }

  /// <summary>The current cached list of influence source deeds, which can change when none are assigned. It uses all the assigned ones, then takes remaining ones in descending order to reach the max count.</summary>
  [Notify]
  [SyncToView(null, true)]
  public ControllerList<Deed> InfluenceSourceDeeds { get; set; }

  /// <summary>All the active articles, from both the constitution and any amendments that modify that list.  Will contain invalid articles too.</summary>
  [SyncToView(null, true)]
  public IEnumerable<CivicArticle> AllCurrentCivicArticlesCached { get; set; }

  [DependsOn("Parentage")]
  [WatchSubMember("MarkedUpName", "SettlementLineageNameChangedEvent", SubPropWatcherFlag.None)]
  public Settlement? ParentSettlement { get; }

  public bool IsActive { get; }

  public bool WasRemoved { get; }

  public bool RequiresHost { get; }

  [SyncToView(null, true)]
  public bool AllowAnyUnaffiliatedHomesteadDeedToExpandWithinOurInfluence { get; }

  public Initializer Initializer { get; }

  /// <summary>The type of settlement prepending the name. IE, "Town Johnkville"</summary>
  [Notify]
  public LocString TypeAndName { get; }

  public override string IconName { get; }

  public Settlement();

  public Settlement(SettlementType type, Vector3i position, WorldObject host);

  public void FoundSettlement(IEnumerable<User> founders, Election? election = null);

  /// <summary>Revert to unfounded, which happens when annexed into the same type of settlement.</summary>
  public void UnfoundSettlement();

  public override LocString UILinkContent(bool param);

  public void UpdatedProposable(IProposable element);

  public void OnCreationCompleted();

  public override void Initialize();

  [SyncToView(null, true)]
  public bool HasAuth(User user);

  [SyncToView(null, true)]
  public LocString PositionTooltip();

  /// <summary>Assign Picture to the Settlement from its Foundation and notify clients.</summary>
  public void SetSettlementPicture(PictureItem picture);

  public ThreadSafeHashSet<User>? Citizens { get; }

  public bool HasCitizen(User user);

  public LocString FounderDesc();

  /// <summary> Returns false when where is currently no active and valid constitution. </summary>
  public bool HasValidConstitution { get; }

  public override LocString CreatorText(Player reader);

  /// <summary>Returns true if the given proposable is one our special ones listed above.</summary>
  public bool IsSettlementCoreProposable(IProposable proposable);

  /// <summary>Provides any of the built-in proposables the settlement makes.</summary>
  public IHasID? GetCoreProposable(Type type);

  /// <summary>Itrerates through the linked parts of the settlement.</summary>
  public IEnumerable<IHasID> GetCoreSettlementParts();

  /// <summary>Remove all references to the core proposables, as in cases of annexing where we dont want them to get updated.</summary>
  public void ClearCoreProposables();

  public void HostObjectSetup(WorldObject hostObject);

  /// <summary>Returns true if the settlement influences the given position.</summary>
  public bool Influences(Vector2i pos);

  public bool Influences(PlotPos pos);

  public void FastTick();

  public void Tick();

  public override void Destroyed();

  public void DisableHostedObject();

  void IHostedObject.ReenableHostedObject();

  public void AssignHostObject(WorldObject newHost);

  public bool CanBeAssignedTo(IOrphanAssignment container);

  public override bool CanBeDeleted { get; }

  int IInfluencer.Priority { get; }

  float IGivesReputation.GivableReputationPerDay { get; }

  float IGivesReputation.GivableReputationPerDayPerTarget { get; }

  Eco.Shared.Math.Range IGivesReputation.GivableReputationToSingleTargetTotal { get; }

  int IGivesReputation.DisplayPriority { get; }

  bool IHostedObject.CanBeEdited { get; set; }

  HashSet<PlotPos> IAnnexable.PlotPosSet { get; }

  LocString IAnnexable.TypeDisplayName { get; }

  SettlementType? IAnnexable.SettlementType { get; }

  float IAnnexable.CultureTotal { get; }

  void IAnnexable.Notify(LocString s);

  IEnumerable<User> IAnnexable.Citizens();

  Settlement? IAnnexable.Parent { get; }

  float IAnnexable.DistanceTo(Vector2i worldPos);

  public bool HasAncestor(Settlement settlement);

  float IAnnexable.ReductionPercentageForAnnexation { get; }

  bool ICachesValidity.IgnoreValidity { get; }

  [Serialized]
  int IHostedObject.ExpirationWarningsIssued { get; set; }
}
