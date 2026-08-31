// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.CollectForPayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary>Triggered when a citizen collects items from a storage for payment (collection fee).</summary>
[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Economy")]
[LocDescription("A citizen collected items from storage for payment.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
public class CollectForPayment : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IAuthGameAction,
  IWorldObjectGameAction,
  ICurrencyGameAction
{
  [BsonIgnore]
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen collecting.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Position of collection.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [BsonIgnore]
  [CanAutoAssign]
  public WorldObject WorldObject { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The object targeted.")]
  public Item WorldObjectItem { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Item type collected.")]
  public Item ItemCollected { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Quantity collected.")]
  public float Quantity { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency used.")]
  [CanAutoAssign]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Payment amount (negative = owner paid collector).")]
  public float CurrencyAmount { get; set; }

  public bool OverrideHierarchyActionsToConsumer { get; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
