// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PayTax
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen paid tax.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of, as well as settlements (and their parent settlements) owning either bank account.")]
public class PayTax : MoneyGameAction, IUserGameAction, IController, IViewController, IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who paid.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account the tax came from.")]
  public override BankAccount SourceBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account the tax went to.")]
  public override BankAccount TargetBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The currency of the payment.")]
  [CanAutoAssign]
  public override Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of tax paid.")]
  public override float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of the transaction which was taxed.")]
  public float TotalBeforeTax { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The tax rate charged.")]
  public float TaxRate { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Settlement issuing the tax.")]
  public Settlement Settlement { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
