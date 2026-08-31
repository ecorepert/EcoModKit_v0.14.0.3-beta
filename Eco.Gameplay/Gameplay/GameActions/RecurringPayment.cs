// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.RecurringPayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
using Eco.Shared.Localization;
using Eco.Stats;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[DontAggregate]
public abstract class RecurringPayment : InteractAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen or group who receive the payment.")]
  [CanAutoAssign]
  public IAlias Earner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency used.")]
  [CanAutoAssign]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount of payment.")]
  public float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account the money came from.")]
  [CanAutoAssign]
  public BankAccount SourceBankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account the money went to.")]
  public BankAccount TargetBankAccount { get; set; }
}
