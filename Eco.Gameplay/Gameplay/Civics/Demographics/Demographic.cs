// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Demographics.Demographic
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
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Jobs;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Eco.Gameplay.Civics.Demographics;

[Eco.Shared.Networking.Eco(true)]
[Ecopedia(null, "Demographics", false, true, null)]
[LocDescription("A citizen-defined group of people, determined by a set of rules.")]
[Tag("CanBeInConstitution")]
[DebuggerDisplay("{Name}")]
public class Demographic : 
  SimpleProposable,
  ISpecialRegistrarEntry,
  IAlias,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  INotifyPropertyChanged,
  IHasClientControlledContainers,
  ICustomValidity,
  IValidity,
  IProvidesContext,
  IRecurringTransferService,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IHasBackupOwner
{
  public static 
  #nullable disable
  ThreadSafeAction<IEnumerable<User>> DemographicUsersChangedEvent;
  public ThreadSafeAction<HashSet<User>> OnCitizenJoined;
  public ThreadSafeAction<HashSet<User>> OnCitizenLeft;
  public HashSet<User> EnteringUsers;
  public HashSet<User> LeavingUsers;
  [Serialized]
  public bool DefaultOn;

  public ThreadSafeAction<IEnumerable<User>> UserSetChangedEvent { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  [LocDescription("If this entry is removed, then all the property that belongs it will be transferred to this backup owner.  (Note: if this backup owner is invalid, then the property will become unowned.)")]
  public IAlias BackupOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("When a citizen matches all of these requirements, they will be a member of this demographic.")]
  [AllowNullInView]
  [AllowEmpty]
  public ControllerList<GameValue<bool>> Conditions { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Optional set of wages paid for citizens in this demographic.")]
  [AllowNullInView]
  public RecurringTransferDefinition Wages { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account used to pay wages from.")]
  [AllowNullInView]
  [InJurisdiction]
  public BankAccount WagesSourceBankAccount { get; set; }

  public string FullDescription { get; }

  [SyncToView(null, true)]
  public IEnumerable<User> UserSet { get; }

  public int Count { get; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  [Serialized]
  public int SpecialType { get; set; }

  public bool IsSpecial { get; }

  public bool SkipPropertyValidation { get; }

  bool IAlias.Valid { get; }

  public IContextObject MakeContext(User user);

  public Func<User, bool> ShouldNotify { get; set; }

  public override Result Valid();

  [SyncToView(null, true)]
  [DependsOnMember("Conditions")]
  public override LocString Description();

  public override void Initialize();

  public override void Destroyed();

  /// <summary>Force a user to be a permanent member of this demographic, regardless of whether they meet the conditions (can removed from whitelist also).</summary>
  public void SetWhitelist(User user, bool set);

  public void AddWhitelist(User user);

  public void RemoveWhitelist(User user);

  /// <summary>Force a user to be omited of this demographic, regardless of whether they meet the conditions (can removed from blacklist also).</summary>
  public void SetBlacklist(User user, bool set);

  public void SetDefaultOn();

  [RPC]
  [RPCAuthMaxProposableState(ProposableState.Active)]
  public bool ContainsExactAlias(IAlias alias);

  public bool ContainsUser(User user);

  public bool Equals(IAlias other);

  internal void ResetEnteringLeavingRecord();

  public string UserDemoDescription(User user);

  internal void CacheUsers();

  public override bool CanBeDeleted { get; }

  public IncomeOrExpense IncomeOrExpense { get; }

  public TransferType TransferType { get; }

  public LocString TransferTitle(User user);

  public RecurringTransferDefinition RecurringTransferDefinition { get; }

  public IList<RecurringTransfer> RecurringTransfers { get; }

  public bool RecurringTransfersActive { get; }

  public IEnumerable<User> Customers { get; }

  public bool AutoCreateAndUpdateTransferProps { get; }

  public BankAccount TransferServiceAccount { get; }

  public object TransfersLock { get; }

  public RecurringPayment PayAction { get; }

  public Deed RecurringTransferExcludedDeed { get; }

  public void OnTransferFailed(RecurringTransfer transfer, LocString result);
}
