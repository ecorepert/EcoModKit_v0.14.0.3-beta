// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.DropOrPickupGarbage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
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

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Pollution")]
[LocDescription("A citizen dropped garbage.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
public class DropOrPickupGarbage : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IAuthGameAction
{
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who dropped/picked the garbage.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Position of the dropped/picked garbage.")]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the garbage dropped or picked up?")]
  public DroppedOrPickedUp DroppedOrPickedUp { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The item dropped/picked up.")]
  [CanAutoAssign]
  public Item ItemUsed { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
