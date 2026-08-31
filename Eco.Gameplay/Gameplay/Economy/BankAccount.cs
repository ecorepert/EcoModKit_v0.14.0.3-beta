// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.BankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy.Money;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Economy;

[Serialized]
[Ecopedia(null, "Bank Accounts", false, true, null)]
[LocDescription("Bank accounts serve as a storage and separation of currency for different uses by various citizens and government entities.")]
public class BankAccount : 
  SimpleEntry,
  IHasDualPermissions,
  ISettlementAssociated,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Notify]
  public static 
  #nullable disable
  ThreadSafeAction<BankAccount> PermissionsChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<BankAccount> CurrencyHoldingsChangedEvent { get; }

  [Notify]
  public static ThreadSafeAction<BankAccount> RenamedEvent { get; }

  [Notify]
  public static ThreadSafeAction<BankAccount> HostChangeEvent { get; }

  public static ThreadSafeAction<BankAccount, IEnumerable<User>> UserSetChangedEvent { get; set; }

  public static ThreadSafeAction<BankAccount, IEnumerable<User>> ManagerSetChangedEvent { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerDictionary<Currency, CurrencyHolding> CurrencyHoldings { get; }

  [Serialized]
  public AccountLedger Ledger { get; }

  [Serialized]
  [SyncToView(null, true)]
  [ScanProp]
  public DualPermissions DualPermissions { get; set; }

  [SyncToView(null, true)]
  public virtual bool IsPermanent { get; }

  [SyncToView(null, true)]
  public virtual bool CanBeSelected { get; }

  [SyncToView(null, true)]
  public virtual bool IgnoreDirectTransferTax { get; }

  [SyncToView(null, true)]
  public string AccountNameSuffix { get; }

  [SyncToView(null, true)]
  [Serialized]
  public virtual Settlement Settlement { get; set; }

  public bool ScanPeriodically { get; set; }

  public bool IsActive { get; }

  public ThreadSafeAction<Currency> BalanceChanged { get; }

  public virtual User AnyManager { get; }

  public virtual User AnyUser { get; }

  protected virtual bool CanHaveNullSettlement { get; }

  public virtual User AccountOwner { get; }

  public override void Initialize();

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override LocString UILinkContent();

  /// <summary>A UILink with the name truncated to a pixel width so it can't overflow a fixed-width column; only the tagless name is wrapped in truncate, so the link/icon tags survive and hover still shows the full name.</summary>
  public LocString UILinkTruncated(int widthPx);

  /// <summary>Check if we're able to add a new manager or user.</summary>
  protected virtual bool TryAddManagerOrUser(
    Player player,
    IAlias alias,
    PermissionsType permissionsChangeType);

  /// <summary>Check if we're able to remove an old manager or user.</summary>
  protected virtual bool TryRemoveManagerOrUser(
    Player player,
    IAlias alias,
    PermissionsType permissionsChangeType);

  /// <summary>Check if IAlias has an access to use this account./// </summary>
  public virtual bool CanAccess(IAlias alias, AccountAccess access = AccountAccess.Use, bool sendNoticeOnFail = false);

  /// <summary>Returns first found manager of the account</summary>
  public virtual User GetResponsibleUser(bool excludeGovCases = true);

  /// <summary>Return total amount of a currency for this account.</summary>
  public float GetCurrencyHoldingVal(Currency cur);

  /// <summary>Returns amount of a currency for this account owned by a user by percent ownership.</summary>
  public float GetCurrencyHoldingVal(Currency cur, User user);

  /// <summary>Returns string with description of currency amount on this account.</summary>
  public string DisplayAmount(Currency cur);

  /// <summary>Check if IAlias or any user of this IAlias can use this account.</summary>
  public bool CanAnyAccess(IAlias alias, AccountAccess access = AccountAccess.Use, bool sendNoticeOnFail = false);

  /// <summary>Adds amount of currency to this account. Will fallback to zero if holdings become negative (set assertNegativeAmount if that was intended, otherwise an error will be logged).</summary>
  public void AddCurrency(Currency currency, float amount, bool assertNegativeAmount = true);

  /// <summary>Reduces holdings to zero (by removing an infinite amount).</summary>
  [RPC]
  public void RemoveCurrency(Currency currency);

  /// <summary>Change an account name, will be validated at the same time.</summary>
  [RPC]
  public void SetAccountName(Player player, string newName);

  /// <summary>Returns user's percent ownership of this account for wealth calculation purposes.</summary>
  public virtual float PercentOwnership(User user);

  /// <summary> Returns a string with user's percent ownership of this account. </summary>
  public virtual LocString DescribeWealth(User user);

  /// <summary> Returns an entitled text block with this account's holdings. </summary>
  public LocString DescribeHoldings();

  public override bool CanBeDeleted { get; }

  public bool AnyMoney { get; }

  public bool Empty { get; }

  public override void Destroyed();

  /// <summary>Move all currencies, without law detection (for destruction of settlements primarily).</summary>
  public void MoveAllCurrencies(BankAccount targetAccount, LocString desc, float percent = 1f);
}
