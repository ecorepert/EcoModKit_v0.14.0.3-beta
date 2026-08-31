// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.Title
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Jobs;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Titles;

[Serialized]
[Ecopedia(null, "Titles", false, true, null)]
[LocDescription("Titles can be either appointed or elected titles, and are used to describe a citizen's job, social status, or responsibilities.")]
public abstract class Title : 
  SimpleEntry,
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
  IRecurringTransferService,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IHasClientControlledContainers,
  IProvidesContext,
  ICustomValidity,
  IValidity,
  IContainsDynamicFlags,
  IHasBackupOwner
{
  [Notify]
  public static 
  #nullable disable
  ThreadSafeAction<Title> SettingsChangedEvent { get; }

  public ThreadSafeAction<IEnumerable<User>> UserSetChangedEvent { get; set; }

  public static ThreadSafeAction<Title, IEnumerable<User>> TitleUserSetChangedEvent { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("All office holders must be in this demographic. If they cease to be, they will be removed from office.  (Note: for appointed titles, this will only remove directly specified users. Users that are part of a sub-title or demographic will be unaffected).")]
  [AllowNullInView]
  public GameValue<bool> RequiredOfOfficeHolders { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  [LocDescription("If this title is removed, then all the property that it owns will be transferred to this backup owner.  (Note: if this backup owner is invalid, then the property will become unowned.)")]
  public IAlias BackupOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Wages for being an occupant of this title.")]
  public RecurringTransferDefinition Wages { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account used to pay wages from.")]
  [AllowNullInView]
  [DynamicFlags]
  public BankAccount WagesSourceBankAccount { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  [SyncToView(null, true)]
  public Dictionary<string, ViewSelectorFlags> PropNameToDynamicFlags { get; set; }

  [SyncToView(null, true)]
  public abstract IEnumerable<User> UserSet { get; }

  public abstract IEnumerable<User> DirectOccupants { get; }

  public virtual int MaxOccupants { get; set; }

  [RPC]
  public abstract bool ContainsExactAlias(IAlias alias);

  [RPC]
  public abstract bool ContainsUser(User user);

  public IContextObject MakeContext(User user);

  [SyncToView(null, true)]
  public override LocString Description();

  public override void Initialize();

  [RPC]
  public void SetBackupOwner(User user, IAlias alias);

  public override void Destroyed();

  protected Result CanHoldOffice(User user);

  public bool CheckInvalidOccupants();

  public void UpdateOccupants();

  protected virtual bool SyncUp();

  protected virtual bool IsValidAndActive();

  public abstract void AddOccupant(User user, LocString reason);

  public abstract void RemoveOccupant(User user, LocString reason);

  public abstract void Clear();

  public abstract bool RecurringTransfersIsActive();

  public LocString NameAndOccupant { get; }

  [Notify]
  public virtual LocString OccupantString { get; }

  public override string ToString();

  public virtual Result Valid();

  bool IAlias.Valid { get; }

  public bool Equals(IAlias other);

  [RPC]
  public void MakeSelfOccupantDebug(User user);

  [RPC]
  public void RemoveAllOccupantsDebug(User user);

  [RPC]
  public void RemoveSelfOccupantDebug(User user);

  public IncomeOrExpense IncomeOrExpense { get; }

  public TransferType TransferType { get; }

  public LocString TransferTitle(User user);

  public RecurringTransferDefinition RecurringTransferDefinition { get; }

  public IList<RecurringTransfer> RecurringTransfers { get; }

  [Notify]
  public bool RecurringTransfersActive { get; }

  [Notify]
  [DependsOn("UserSet")]
  public IEnumerable<User> Customers { get; }

  public bool AutoCreateAndUpdateTransferProps { get; }

  public BankAccount TransferServiceAccount { get; }

  public object TransfersLock { get; }

  public void OnTransferFailed(RecurringTransfer transfer, LocString result);

  public RecurringPayment PayAction { get; }

  public Deed RecurringTransferExcludedDeed { get; }
}
