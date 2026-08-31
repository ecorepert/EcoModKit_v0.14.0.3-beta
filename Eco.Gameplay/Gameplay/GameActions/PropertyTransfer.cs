// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PropertyTransfer
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

#nullable enable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen transferred property influenced by the settlement.")]
[DontAggregate]
[ExtendedDescriptionLocStr("Only triggers laws on settlements influencing the deed.")]
public class PropertyTransfer : 
  GameAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IAuthGameAction,
  IDeedAuthRelatedAction
{
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who transfered the property.")]
  [CanAutoAssign]
  public 
  #nullable disable
  User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Current owner of the property being transfered.")]
  public IAlias CurrentOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("New owner of the property being transfered.")]
  public IAlias NewOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position of the property.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  [BsonIgnore]
  [JsonIgnore]
  public IEnumerable<Deed> RelatedDeeds { get; set; }
}
