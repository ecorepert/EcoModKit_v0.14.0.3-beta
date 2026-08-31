// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PolluteAir
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
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

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Pollution")]
[LocDescription("Air pollution was released (triggered every 30 sec of operation).")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[Stat("Player Actions", Unit.CO2PPM, StatType.EventValue)]
public class PolluteAir : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPollutingGameAction,
  IAggregatableStat,
  ICountStat,
  IActionStat,
  IStat,
  IPositionGameAction
{
  public const double CheckPollutionTimeInterval = 30.0;

  public override float Count { get; set; }

  [BsonIgnore]
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who performed the pollution.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The location of the object doing the polluting.")]
  [PlotPositionKey]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount of carbon dioxide released into the atmosphere this interval (30 seconds) in Parts Per Million.")]
  [SumInAggregateGrouping]
  public float PollutionInPPM { get; set; }

  [BsonIgnore]
  [Eco.Shared.Networking.Eco(true)]
  [LocDisplayName("PPM Per Hour")]
  [LocDescription("The rate of carbon dioxide being released in Parts Per Million.")]
  public float PPMPerHour { get; set; }

  [BsonIgnore]
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The object doing the polluting.")]
  [RequiredTag("Polluter")]
  public Item PollutionSource { get; set; }

  [BsonIgnore]
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("What interval of time was spent polluting?  This is assigned '0' for the first pollution action, then 30 seconds for subsequent actions.")]
  public float TimePolluting { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
