// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PlantSeeds
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
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Simulation.Types;
using LiteDB;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Farming")]
[LocDescription("A citizen planted a plant.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
public class PlantSeeds : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IAuthGameAction,
  ISpeciesGameAction,
  IToolGameAction
{
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen planting the plant.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The species of plant.")]
  [Derives(typeof (PlantSpecies))]
  [CanAutoAssign]
  [RequiredTag("Plants")]
  public Type Species { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position of the new plant.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The tool used to plant.")]
  [CanAutoAssign]
  [RequiredTag("Planter")]
  public virtual Item ToolUsed { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
