// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.MoneyGameAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.Settlements;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
public abstract class MoneyGameAction : 
  AggregatableAction,
  ICurrencyGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public abstract BankAccount SourceBankAccount { get; set; }

  [SyncToView(null, true)]
  public abstract BankAccount TargetBankAccount { get; set; }

  [SyncToView(null, true)]
  public abstract Currency Currency { get; set; }

  [SyncToView(null, true)]
  public abstract float CurrencyAmount { get; set; }

  public MoneyGameAction();

  public MoneyGameAction(TransferData transferData);

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
