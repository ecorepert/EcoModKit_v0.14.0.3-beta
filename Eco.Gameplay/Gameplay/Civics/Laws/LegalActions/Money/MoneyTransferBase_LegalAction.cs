// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LegalActions.Money.MoneyTransferBase_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws.ExecutiveActions;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Civics.Laws.LegalActions.Money;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Finance")]
public abstract class MoneyTransferBase_LegalAction : 
  LegalAction,
  IExecutiveAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDescribable,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Which currency to collect the tax in.")]
  public GameValue<Eco.Gameplay.Economy.Currency> Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount that is going to be taxed.")]
  public GameValue<float> Amount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Nothing will be performed if any related transaction fails.")]
  public GameValue<bool> PreventIfUnableToPay { get; set; }

  protected abstract PostResult DoTransfer(
    LocString description,
    IContextObject context,
    Settlement jurisdictionSettlement,
    float val,
    Eco.Gameplay.Economy.Currency currency,
    bool preventIfUnableToPay,
    AccountChangeSet acc);

  public Result Valid();

  public PostResult PerformExecutiveAction(
    User user,
    IContextObject context,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);

  protected override PostResult Perform(Law law, GameAction action, AccountChangeSet acc);

  protected abstract LocString DryRunDescription(Law law, GameAction action, AccountChangeSet acc);

  /// <summary>We check whether the specified account can be used with the specified context and if not we return false and an error message.
  /// When <paramref name="fundsWithdrawnFromAccount" /> is set, the account is the source of the money and a child settlement must have opted in to allow a parent to withdraw from it.</summary>
  protected bool CheckJurisdiction(
    Eval<BankAccount> account,
    Settlement jurisdictionSettlement,
    bool mustBeGovernmentAccount,
    out LocString errorMessage,
    bool fundsWithdrawnFromAccount = false);

  /// <summary>Whether a withdrawal-style legal action may take funds from an account. A settlement may always withdraw from its own accounts; a parent may only withdraw from a descendant's account when child taxation is enabled server-side.</summary>
  public static bool MayWithdrawFromAccount(
    bool accountOwnedByJurisdiction,
    bool childTaxationAllowed);

  protected LocString DescribeUnableToPay();
}
