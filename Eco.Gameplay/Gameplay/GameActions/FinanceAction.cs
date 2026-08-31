// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.FinanceAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
public abstract class FinanceAction : WorkableAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was it a loan or bond?")]
  public LoanOrBond LoanOrBond { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who took the money.")]
  public User Borrower { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who offered the money.")]
  public User Lender { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A percentage to be charged.")]
  public float InterestRate { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Total amount to be charged.")]
  public float InterestValue { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Total amount to be repaid.")]
  public float PaybackAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Number of days for term of the debt.")]
  public float Term { get; set; }
}
