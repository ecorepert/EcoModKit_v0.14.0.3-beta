// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ResidencyChanged
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
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
[LocDescription("A citizen became a resident of a property, or left residency of a property.")]
[DontAggregate]
[ExtendedDescriptionLocStr("Only triggers laws on settlements influencing the deed.")]
public class ResidencyChanged : 
  GameAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IAuthGameAction
{
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Is the citizen becoming a resident or leaving?")]
  public ResidencyChange ResidencyChange { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDisplayName("Resident")]
  [LocDescription("The citizen who became a resident or left residency.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen or group owning the property.")]
  public IAlias Landlord { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Total number of residents prior to joining.")]
  public float ExistingOccupants { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position of the residency.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The fee charged for moving in.")]
  public float MoveInFee { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The currency the move-in fee was charged in.")]
  public Currency MoveInFeeCurrency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The reason for the residency change.")]
  public ResidencyChangeReason ResidencyChangeReason { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The rent that they will be charged/were charged.")]
  public float Rent { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The currency the rent was charged in.")]
  public Currency RentCurrency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The deed residency was changed in.")]
  public Deed Deed { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
