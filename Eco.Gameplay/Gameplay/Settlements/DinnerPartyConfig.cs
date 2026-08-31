// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.DinnerPartyConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Ecopedia(null, "Dinner Parties", false, true, null)]
public class DinnerPartyConfig
{
  [LocDescription("Determines how long prepared food is considered fresh for dinner parties.")]
  [PropertyExplanation]
  public float FreshnessTimeMinutesPreparedFood { get; set; }

  [LocDescription("Determines how long prepared food is considered fresh for dinner parties.")]
  [PropertyExplanation]
  public float FreshnessTimeMinutesRawFood { get; set; }

  [LocDescription("To determine the amount of culture points a piece of food generaters, the summed nutrition will be multiplied by this value.")]
  [PropertyExplanation]
  public float NutritionToCulturePointsMultiplier { get; set; }

  [LocDescription("The multiplier for tastiness at a dinner party for each tastiness preference.")]
  [PropertyExplanation]
  public float[] MultiplierForTastiness { get; set; }

  [LocDescription("The multiplier number of different direct citizenships were held by attendees.")]
  [PropertyExplanation]
  public float[] SettlementCountMultiplier { get; set; }

  [LocDescription("The maximum number of days a dinner party will contribute to culture.")]
  [PropertyExplanation]
  public float DinnerPartyMaxDays { get; set; }

  [LocDescription("The duration of a dinner party in minutes.")]
  [PropertyExplanation]
  public float DinnerPartyMinutesDuration { get; set; }

  [LocDescription("The maximum number of courses a player can eat at a dinner party.")]
  [PropertyExplanation]
  public int MaxCoursesPerPlayer { get; set; }

  [LocDescription("Maximum number of finished dinner parties per day that can contribute to a player's nutrition bonus. The highest-value parties on that day are used. Set to 0 or less to count all parties that day.")]
  [PropertyExplanation]
  public int MaxDinnerPartiesPerDayCountedForBonus { get; set; }

  [LocDescription("Maximum number of dinner parties that can be started on a single claim (deed) per day. Set to 0 or less for no limit.")]
  [PropertyExplanation]
  public int MaxDinnerPartiesPerDayPerClaim { get; set; }

  [LocDescription("Maximum number of dinner parties that can be started within a single settlement per day. Set to 0 or less for no limit.")]
  [PropertyExplanation]
  public int MaxDinnerPartiesPerDayPerSettlement { get; set; }

  [LocDescription("Maximum number of dinner parties a single player can participate in per day. Set to 0 or less for no limit.")]
  [PropertyExplanation]
  public int MaxDinnerPartiesPerDayPerPlayer { get; set; }

  [LocDescription("Maps the culture bonus of a citizen's dinner parties to a multiplier for their nutrition value.")]
  [PropertyExplanation]
  public LimitMapper.Config DinnerPartyCultureToFoodValue { get; set; }

  [LocDescription("Function that determines how dinner parties decay in value over time, modifiable with code. Default is a linear decay function.")]
  public Func<float, float> DinnerPartyDaysToMultiplier { get; }
}
