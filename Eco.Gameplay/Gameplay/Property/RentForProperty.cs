// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RentForProperty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Jobs;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Property;

[Eco.Shared.Networking.Eco(true)]
public class RentForProperty : 
  INotifyPropertyChanged,
  IRecurringTransferService,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IHasClientControlledContainers,
  IProvidesContext,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("One-time or periodic payments from residents, for the use of your property and its objects.")]
  [AllowNullInView]
  public 
  #nullable disable
  RecurringTransferDefinition Rent { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Optional amount charged upon move-in for new residents.")]
  [AllowNullInView]
  public GameValue<float> MoveInFee { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency charged for the move-in fee.")]
  [AllowNullInView]
  public GameValue<Currency> MoveInFeeCurrency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Bank account where move-in fees and rent payments will go.")]
  [AllowNullInView]
  public BankAccount ReceivedRentAccount { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  [SyncToView(null, true)]
  [DependsOn("Rent", new string[] {"MoveInFee", "MoveInFeeCurrency"})]
  public string Description { get; }

  [SyncToView(null, true)]
  [DependsOn("MoveInFee", new string[] {"MoveInFeeCurrency"})]
  public string MoveInCompactDescription { get; }

  [SyncToView(null, true)]
  [DependsOn("Rent")]
  public string RentCompactDescription { get; }

  public Result Valid();

  public void Initialize(
    Deed deed,
    Func<LocString> getMarkedUpName,
    Func<IAlias> owners,
    ControllerHashSet<User> rentersHashSet,
    Action<GameActionPack, User> evict,
    Func<Settlement> getSettlement);

  [RPC]
  public void EditRent(Player player);

  public Task<RentForProperty.FeeInfo?> ValidateAndGetFeeInfo(User user);

  public void Destroy();

  public LocString SetupMoveInFee(
    GameActionPack pack,
    User user,
    Deed deed,
    RentForProperty.FeeInfo feeInfo);

  public IncomeOrExpense IncomeOrExpense { get; }

  public TransferType TransferType { get; }

  public LocString TransferTitle(User user);

  public RecurringTransferDefinition RecurringTransferDefinition { get; }

  public IList<RecurringTransfer> RecurringTransfers { get; }

  public bool RecurringTransfersActive { get; }

  public IEnumerable<User> Customers { get; }

  public bool HasCustomer(User member);

  public bool AutoCreateAndUpdateTransferProps { get; }

  public BankAccount TransferServiceAccount { get; }

  public object TransfersLock { get; }

  public LocString MarkedUpName { get; }

  public Deed RecurringTransferExcludedDeed { get; }

  public RecurringPayment PayAction { get; }

  public void OnTransferFailed(RecurringTransfer transfer, LocString result);

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  public struct FeeInfo
  {
    public BankAccount UserAccount;
    public float MoveInFee;
    public Currency MoveInFeeCurrency;
    public float Rent;
    public Currency RentCurrency;
  }
}
