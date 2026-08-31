// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.TransferMoney
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen transfered money.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of, as well as settlements (and their parent settlements) owning either bank account.")]
public class TransferMoney : 
  MoneyGameAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who transfered the money. Note: Can only be taxed if they are a citizen of the settlement of the law executing.")]
  [CanAutoAssign]
  [MustBeCitizenToTax]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who received the money.")]
  [CanAutoAssign]
  [MustBeCitizenToTax]
  public User Receiver { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account the money came from.")]
  [CanAutoAssign]
  public override BankAccount SourceBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account the money went to.")]
  public override BankAccount TargetBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The currency of the transfer.")]
  [CanAutoAssign]
  public override Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of money transfered.")]
  public override float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The reason of the transfer.")]
  public TransferType Reason { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public TransferMoney();

  public TransferMoney(TransferData transferData);
}
