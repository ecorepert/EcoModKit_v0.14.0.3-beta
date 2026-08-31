// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseLoan
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("Loan a given amount for a set period to another citizen, with interest.\n\nThe borrower can specify the amount they want to borrow, which the lender defines in the 'allowed debt' range.")]
public class ContractClauseLoan : ContractClauseFinanceBase
{
  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override Result Valid(User contractor, User client);

  public override LoanOrBond LoanOrBond { get; }

  public override User Lender(User contractor, User client);

  public override User Borrower(User contractor, User client);

  public override BankAccount LenderAccount { get; }

  public override BankAccount BorrowerAccount { get; }

  protected override (User Lender, User Borrower) LenderAndBorrower(User contractor, User client);
}
