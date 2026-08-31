// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseFinanceBase
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
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[ForceCreateViewAllDerived]
public abstract class ContractClauseFinanceBase : 
  ContractClause,
  ICurrencyRelated,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IOpenHandler
{
  [Eco.Shared.Networking.Eco(true)]
  [GuestEditable]
  [OwnerHidden]
  [WatchSubMember("BalanceChanged", "AccountsBalanceUpdatedEvent", SubPropWatcherFlag.None)]
  public 
  #nullable disable
  BankAccount ContractorAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [WatchSubMember("BalanceChanged", "AccountsBalanceUpdatedEvent", SubPropWatcherFlag.None)]
  public BankAccount ClientAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  protected Range AllowedDebt { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Range(0.0f, 100f)]
  public float InterestPercent { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [GuestEditable]
  [OwnerHidden]
  public float Amount { get; set; }

  [Serialized]
  public Debt Debt { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [OwnerHidden]
  [Sort(1f)]
  [DependsOn("Amount", new string[] {"InterestPercent"})]
  public float PaybackAmount { get; }

  public abstract LoanOrBond LoanOrBond { get; }

  public abstract BankAccount LenderAccount { get; }

  public abstract BankAccount BorrowerAccount { get; }

  public abstract User Lender(User contractor, User client);

  public abstract User Borrower(User contractor, User client);

  protected abstract (User Lender, User Borrower) LenderAndBorrower(User contractor, User client);

  public IEnumerable<CurrencyInfo> NeededCurrencyToAccept { get; }

  public ThreadSafeAction AccountsBalanceUpdatedEvent { get; }

  public void OnOpen(User user);

  public override void OnCreate(User client);

  public override Result CanJoin(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override void TryPostJob(GameActionPack pack, User client);

  public override void TrySucceed(GameActionPack pack, User contractor, User client, bool forced);

  public override void TryFail(GameActionPack pack, User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);
}
