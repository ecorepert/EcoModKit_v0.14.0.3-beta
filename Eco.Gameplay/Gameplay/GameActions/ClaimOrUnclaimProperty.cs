// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ClaimOrUnclaimProperty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Stats;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen claimed or unclaimed property.")]
[DontAggregate]
[ExtendedDescriptionLocStr("Only triggers laws on settlements influencing the deed.")]
public class ClaimOrUnclaimProperty : 
  GameAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IAuthGameAction,
  ISyncedAction
{
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who claimed or unclaimed the land.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The owner of the deed on which the land was claimed.")]
  public IAlias PreviousDeedOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the property claimed or unclaimed?")]
  public ClaimedOrUnclaimed ClaimedOrUnclaimed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position of the claim.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("What the type of property is being initially set to.")]
  public PropertyType PropertyType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The deed being claimed to or unclaimed from.")]
  public Deed Deed { get; set; }

  [RelatedFeature("UseSettlementSystem", true)]
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Is this position being claimed for a new settlement?")]
  public bool NewSettlement { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  [JsonIgnore]
  [BsonIgnore]
  public object SyncObject { get; }
}
