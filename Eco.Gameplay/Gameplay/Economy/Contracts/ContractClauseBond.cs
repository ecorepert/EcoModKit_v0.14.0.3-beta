// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseBond
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("Sell a bond for a given value, which will be paid back over a set period of time with interest.\n\nThe bond purchaser can choose what value of bond they want to buy, within a range set by the bond seller.")]
public class ContractClauseBond : ContractClauseFinanceBase
{
  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override LoanOrBond LoanOrBond { get; }

  public override User Lender(User contractor, User client);

  public override User Borrower(User contractor, User client);

  public override BankAccount LenderAccount { get; }

  public override BankAccount BorrowerAccount { get; }

  protected override (User Lender, User Borrower) LenderAndBorrower(User contractor, User client);
}
