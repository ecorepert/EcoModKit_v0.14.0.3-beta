// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LegalActions.Money.Tax_LegalAction
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
[LocDisplayName("Tax")]
[LocDescription("Take money from a given citizen or group, applies to all accounts they manage (except government account).")]
public class Tax_LegalAction : TaxPayBase_LegalAction
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The citizens that will be getting taxed.")]
  public GameValue<IAlias> Targets { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If set, will attempt to target all bank accounts in the law's jurisdiction.  Otherwise it only targets the personal accounts of the given targets.")]
  public GameValue<bool> TaxFromAllAccounts { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account where the tax will be placed. Must specify a government account in the same jurisdiction.")]
  [GovernmentAccountsOnly]
  public GameValue<BankAccount> PayIntoGovernmentAccount { get; set; }

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
