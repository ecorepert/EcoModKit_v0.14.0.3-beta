// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.FinanceManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
public class FinanceManager : IController, IViewController, IHasUniversalID
{
  [Serialized]
  public ThreadSafeDictionary<Currency, float> TransferSum;

  [SyncToView(null, true)]
  public float TotalDebt { get; }

  public IEnumerable<Debt> AllDebts { get; }

  public IEnumerable<Debt> DebtsBetween(string lender, string borrower);

  public void DebtChanged();

  public float GetCurrencyDebt(Currency currency);

  public void RemoveDebt(Debt debt);

  public Debt AddDebt(
    Currency currency,
    string lender,
    string borrower,
    float interestPercent,
    float paybackAmount,
    double dueDate,
    BankAccount payIntoAccount);

  public string DescribeDebts(Currency currency);

  public ref int ControllerID { get; }
}
