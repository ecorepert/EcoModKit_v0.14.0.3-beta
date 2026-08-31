// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LegalActions.Money.TaxPayBase_LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Laws.LegalActions.Money;

public abstract class TaxPayBase_LegalAction : MoneyTransferBase_LegalAction
{
  protected 
  #nullable disable
  PostResult GovernmentTransferUsers(
    LocString description,
    float amount,
    Eco.Gameplay.Economy.Currency currency,
    BankAccount governmentAccount,
    GameValue<IAlias> target,
    IContextObject context,
    Settlement jurisdictionSettlement,
    bool canTransferNonCitizens,
    bool taxing,
    bool preventIfUnableToPay,
    AccountChangeSet acc,
    bool taxAll);

  protected virtual IEnumerable<BankAccount> GetBankAccounts(
    bool taxing,
    User user,
    bool taxFromAll,
    Settlement jurisdiction,
    IContextObject context);
}
