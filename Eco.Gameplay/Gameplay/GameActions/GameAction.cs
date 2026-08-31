// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.View;
using Eco.Stats;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Stat("Player Actions", Unit.ActionsPerHour, StatType.EventValue)]
[LocDescription("An action that can happen in Eco.")]
[Eco.Shared.Networking.Eco(true)]
[HasIcon(null)]
public abstract class GameAction : 
  IController,
  IViewController,
  IHasUniversalID,
  IContextObject,
  IActionStat,
  IStat
{
  public const string StatKey = "Player Actions";
  [BsonIgnore]
  public bool AuthIgnored;

  [BsonId]
  public ObjectId _id { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Indexed]
  [LocDisplayName("Time")]
  [LocDescription("The time when the action takes place.")]
  public int Time { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [BsonIgnore]
  [NotATriggerConfig]
  [CanAutoAssign]
  [LocDisplayName("Current Settlement")]
  [LocDescription("The settlement the evaluating law belongs to.")]
  public Settlement CurrentSettlement { get; set; }

  [BsonIgnore]
  public abstract IEnumerable<Settlement> SettlementScopes { get; }

  [BsonIgnore]
  public LocString MarkedUpName { get; }

  [BsonIgnore]
  public virtual StatType StatType { get; }

  [BsonIgnore]
  public bool DryRun { get; set; }

  [BsonIgnore]
  public ref int ControllerID { get; }
}
