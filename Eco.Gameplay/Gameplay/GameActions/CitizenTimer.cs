// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.CitizenTimer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Stats;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("System")]
[LocDescription("An effect that is run on each specified citizen of the given settlement at intervals.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of.")]
[CannotBePrevented]
[CustomConfig(typeof (CitizenTimerTriggerConfig))]
[NoStats]
public class CitizenTimer : 
  TimerBase,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen currently being processed for the timer event.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position of the user when the timer triggers.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
