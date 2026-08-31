// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GlobalTimer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Stats;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("System")]
[LocDescription("An effect that is run at a given interval.")]
[ExtendedDescriptionLocStr("Triggers laws on all founded settlements.")]
[CannotBePrevented]
[CustomConfig(typeof (TimerTriggerConfig))]
[NoStats]
public class GlobalTimer : TimerBase
{
  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
