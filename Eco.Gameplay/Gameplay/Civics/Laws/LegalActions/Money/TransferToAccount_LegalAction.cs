// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LegalActions.Money.TransferToAccount_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.Laws.LegalActions.Money;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Transfer to Account")]
[LocDescription("Take money from one bank account and transfer it to another.")]
public class TransferToAccount_LegalAction : MoneyTransferBase_LegalAction
{
  [Eco.Shared.Networking.Eco(true)]
  [InJurisdiction]
  [LocDescription("Holdings of this bank account will be used to perform the transfer. May only take from bank accounts associated with the same settlement (or child) of the jurisdiction.")]
  public GameValue<BankAccount> SourceAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AccessNotNeeded]
  [LocDescription("Where the money goes to.")]
  public GameValue<BankAccount> TargetAccount { get; set; }

  protected override LocString DryRunDescription(Law law, GameAction action, AccountChangeSet acc);

  public override LocString Description();

  protected override PostResult DoTransfer(
    LocString description,
    IContextObject context,
    Settlement jurisdictionSettlement,
    float amount,
    Eco.Gameplay.Economy.Currency currency,
    bool preventIfUnableToPay,
    AccountChangeSet acc);
}
