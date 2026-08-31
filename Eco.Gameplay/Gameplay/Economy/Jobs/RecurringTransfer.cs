// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.RecurringTransfer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.Jobs;

[Eco.Shared.Networking.Eco(true)]
public class RecurringTransfer : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public static ThreadSafeAction<RecurringTransfer> ValuesUpdatedEvent;
  public static bool PayEveryTick;

  public event PropertyChangedEventHandler PropertyChanged;

  [Serialized]
  public string Title { get; set; }

  [Serialized]
  public User Customer { get; set; }

  [Serialized]
  public BankAccount UserAccount { get; set; }

  [Serialized]
  public BankAccount ServiceAccount { get; set; }

  [Serialized]
  public Currency Currency { get; set; }

  [Serialized]
  public GameValue<float> AmountPerHour { get; set; }

  [Serialized]
  public WageType PaymentType { get; set; }

  [Serialized]
  public bool Active { get; set; }

  [Serialized]
  public double TimeLastAttempt { get; set; }

  [Serialized]
  public double TimeLastPaid { get; set; }

  [Serialized]
  public RecurringPayment PayAction { get; set; }

  [DependsOn("ParentService", new string[] {"UserAccount", "ServiceAccount"})]
  public BankAccount SourceAccount { get; }

  [DependsOn("ParentService", new string[] {"UserAccount", "ServiceAccount"})]
  public BankAccount TargetAccount { get; }

  public IRecurringTransferService ParentService { get; }

  [SyncToView(null, true)]
  [DependsOn("ParentService")]
  public string ServiceMarkedUpName { get; }

  [SyncToView(null, true)]
  [DependsOn("Title", new string[] {"MoneyDesc", "SourceAccount", "TargetAccount"})]
  public string Description { get; }

  [DependsOn("AmountPerHour", new string[] {"Currency", "PayTypeDesc"})]
  public string MoneyDesc { get; }

  public bool IsInitialized { get; }

  /// <summary> Usually initialization is called when recurring transfer is created and its a moment when all data is setted.
  /// Some transfers are preserved over sessions and they have to be initializated only by setting service. It's a workaround for hotfix, should be refactored to have better archetecture. </summary>
  public void Initialize(IRecurringTransferService service);

  public Result Initialize(
    IRecurringTransferService service,
    User user,
    BankAccount userBankAccount);

  /// <summary>Calculate the values desired for the transfer and update them. Don't notify update during init, but if they're changed later do notify.</summary>
  public Result UpdateValues(
    IRecurringTransferService service,
    bool notifyUpdate,
    bool allowCurrencyChanges);

  public void SetActiveAndPayIfNeeded(bool recurringTransfersActive);

  public void TryPay(bool force = false);

  public void Pay();

  public override string ToString();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
