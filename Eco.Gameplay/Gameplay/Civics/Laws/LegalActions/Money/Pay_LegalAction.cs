// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LegalActions.Money.Pay_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.Laws.LegalActions.Money;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Pay")]
[LocDescription("Give money to a given citizen or group.")]
public class Pay_LegalAction : TaxPayBase_LegalAction, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The account to send the funds from. Must specify a government account in the same jurisdiction.")]
  [GovernmentAccountsOnly]
  public GameValue<BankAccount> PayFromGovernmentAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The citizens that will be receiving the money.")]
  public GameValue<IAlias> Recipients { get; set; }

  public override LocString Description();

  protected override LocString DryRunDescription(Law law, GameAction action, AccountChangeSet acc);

  protected override PostResult DoTransfer(
    LocString description,
    IContextObject context,
    Settlement jurisdictionSettlement,
    float amount,
    Eco.Gameplay.Economy.Currency currency,
    bool preventIfUnableToPay,
    AccountChangeSet acc);
}
