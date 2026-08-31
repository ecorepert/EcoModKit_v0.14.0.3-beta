// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.MintCurrency
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Economy")]
[LocDescription("Money created at a mint.")]
[ChangeParentConfigLoc("ItemUsed", null, "Currency", null, false)]
[ChangeParentConfigLoc("WorldObjectItem", null, null, null, true)]
public class MintCurrency : 
  ItemInteractAction,
  ICurrencyGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IWorldObjectGameAction,
  IBankAccountGameAction
{
  [BsonIgnore]
  public override AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The currency in which the money was created.")]
  [CanAutoAssign]
  [LocDisplayName("Currency Created")]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of items converted into currency.")]
  [CanAutoAssign]
  public float CurrencyAmount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of new currency was created.")]
  [CanAutoAssign]
  public float NewCurrencyCreated { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of currency before the creation.")]
  [CanAutoAssign]
  public float TotalCurrencyBeforeCreation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of currency after the creation.")]
  [CanAutoAssign]
  public float TotalCurrencyAfterCreation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The account to which the new currency is minted.")]
  [CanAutoAssign]
  [LocDisplayName("Target Account")]
  public BankAccount BankAccount { get; set; }

  [BsonIgnore]
  [CanAutoAssign]
  public WorldObject WorldObject { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Serialized]
  [SyncToView(null, true)]
  [LocDescription("Mint")]
  public Item WorldObjectItem { get; }

  public bool OverrideHierarchyActionsToConsumer { get; }
}
