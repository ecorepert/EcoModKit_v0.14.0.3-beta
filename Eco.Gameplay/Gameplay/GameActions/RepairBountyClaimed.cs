// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.RepairBountyClaimed
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Economy")]
[LocDescription("A citizen repaired a table for a payment.")]
public class RepairBountyClaimed : 
  WorldObjectInteractAction,
  ICurrencyGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IBankAccountGameAction,
  IWorldObjectGameAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The repairer's bank account.")]
  public BankAccount BankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency used in the transaction.")]
  [CanAutoAssign]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount used in the transaction.")]
  public float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Percent repaired overall.")]
  public float PercentRepaired { get; set; }
}
