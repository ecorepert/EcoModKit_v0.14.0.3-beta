// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClausePayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("This clause provides a payment, with the option of collecting a deposit from the contractor.\n\nDeposits and payments are held in escrow for the duration of the contract. The amount in escrow is given to the contractor if the contract is successfully completed, or it goes to the client if the contract is marked as failed.")]
public class ContractClausePayment : 
  ContractClause,
  IOpenHandler,
  ICurrencyRelated,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  [OwnerHidden]
  [OwnerReadOnly]
  [GuestEditable]
  [WatchSubMember("BalanceChanged", "AccountsBalanceUpdatedEvent", SubPropWatcherFlag.None)]
  internal 
  #nullable disable
  BankAccount ContractorBankAccount { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Currency", new string[] {"Payment"})]
  public string PaymentTaxString { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public Currency Currency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float Payment { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float Deposit { get; set; }

  public ThreadSafeAction AccountsBalanceUpdatedEvent { get; }

  public IEnumerable<CurrencyInfo> NeededCurrencyToAccept { get; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public LocString AmountString { get; }

  public LocString DepositString { get; }

  public override void OnCreate(User client);

  public override Result Valid(User contractor, User client);

  public override Result CanJoin(User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override void TrySucceed(GameActionPack pack, User contractor, User client, bool forced);

  public override void TryFail(GameActionPack pack, User contractor, User client);

  public void OnOpen(User user);

  public void FlushEscrow();
}
