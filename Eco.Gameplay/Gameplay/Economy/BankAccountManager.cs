// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.BankAccountManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Economy;

[Serialized]
[ChatCommandHandler]
public class BankAccountManager : 
  Singleton<
  #nullable disable
  BankAccountManager>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public ThreadSafeAction OnBankAccountChanged;
  public int MaxAccountsPerUser;

  public event PropertyChangedEventHandler PropertyChanged;

  public Eco.Core.Systems.Registrar<BankAccount> Registrar { get; }

  [Notify]
  public IEnumerable<BankAccount> Accounts { get; }

  [RPC]
  public BankAccount Treasury();

  [RPC]
  public BankAccount Escrow();

  [RPC]
  public void DisplayGovernmentAccounts(Player player, Settlement settlement);

  public void SpawnMoney(Currency currency, User user, float amount);

  public void Initialize();

  public PersonalBankAccount GetPersonalBankAccount(string name);

  public BankAccount GetBankAccount(int accountID);

  public BankAccount GetBankAccount(int accountID, User user, AccountAccess access = AccountAccess.Use);

  /// <summary>Create a personal bank account for them with infinite amount of that currency.</summary>
  public void TryCreateUserAccount(User user);

  public IEnumerable<(BankAccount Account, CurrencyHolding Holding)> GetAccountsForCurrency(
    Currency currency);

  /// <summary>Return a tuple of accounts and holdings for all backed currencies.</summary>
  public IEnumerable<(BankAccount Account, CurrencyHolding Holding)> GetAccountsOfBackedCurrency();

  /// <summary> Public acessor for game action tests. Use <see cref="M:Eco.Gameplay.Economy.Transfer.Transfers.Transfer(Eco.Gameplay.GameActions.GameActionPack,Eco.Gameplay.Economy.Transfer.TransferData)" /> instead. </summary>
  public Result DirectTransfer(
    User user,
    BankAccount source,
    BankAccount target,
    Currency currency,
    float amount);

  [ChatSubCommand("Money", "Adds user as manager to bank account with ID.", ChatAuthorizationLevel.Admin)]
  public static void AddAccountManager(User user, BankAccount account, User target);

  [ChatSubCommand("Money", "Remove user as manager from bank account with ID.", ChatAuthorizationLevel.Admin)]
  public static void RemoveAccountManager(User user, BankAccount account, User target);

  [ChatSubCommand("Money", "Adds user to bank account with ID.", ChatAuthorizationLevel.Admin)]
  public static void AddAccountUser(User user, BankAccount account, User target);

  [ChatSubCommand("Money", "Removes user from bank account with ID.", ChatAuthorizationLevel.Admin)]
  public static void RemoveAccountUser(User user, BankAccount account, User target);

  [ChatSubCommand("Money", "Creates an account with specified name.", ChatAuthorizationLevel.Admin)]
  public static void CreateAccount(User user, string name = null);

  [ChatSubCommand("Money", "Deletes an account even if there is still currency on it.", ChatAuthorizationLevel.Admin)]
  public static void DeleteAccount(User user, BankAccount account);

  [ChatSubCommand("Money", "Manually set an account creator.", ChatAuthorizationLevel.Admin)]
  public static void SetAccountOwner(User user, BankAccount account, User target);

  public ref int ControllerID { get; }
}
