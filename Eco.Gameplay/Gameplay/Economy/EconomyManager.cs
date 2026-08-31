// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.EconomyManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
[LocDisplayName("EconomyManager")]
[ChatCommandHandler]
public class EconomyManager : 
  Singleton<EconomyManager>,
  IStorage,
  ISerializable,
  IController,
  IViewController,
  IHasUniversalID
{
  [Serialized]
  public Registrar<Currency> CurrencyRegistrar;
  [Serialized]
  public Registrar<BankAccount> BankAccountsRegistrar;
  [Serialized]
  public Registrar<WorkOrder> WorkOrderRegistrar;
  [Serialized]
  public Registrar<WorkParty> WorkPartyRegistrar;
  [Serialized]
  public Registrar<Contract> ContractRegistrar;

  public static ContractManager Contracts { get; }

  public static FinanceManager Finance { get; }

  public IPersistent StorageHandle { get; set; }

  public Initializer Init { get; }

  public ref int ControllerID { get; }

  public void InitializeRegistrars(TimedTask timer);

  public void Initialize();

  /// <summary>Create the personal bank account and currency for this user if needed.</summary>
  public void SetupUserEconomySystems(User user);

  public void Tick();

  [ChatSubCommand("Money", "Create debt between two players in a currency that matches the given name.", ChatAuthorizationLevel.Admin)]
  public static void CreateDebt(
    User user,
    User lender,
    User borrower,
    float paybackAmount,
    float interest,
    float daysTillDue,
    Currency currency);

  [ChatSubCommand("Money", "Cancel debt that a particular player has accumulated.", ChatAuthorizationLevel.Admin)]
  public static void CancelAllDebtFromPlayer(User user, string otherPlayer);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void MarkDirty();

  public void SaveAll();

  public string GetStatus();

  public override void ClearSingleton();
}
