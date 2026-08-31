// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.PollutionPenalty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Rooms;

[Localized(true, false, "", false)]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class PollutionPenalty
{
  [LocDescription("Enables or disables the application of a room value penalty based on surrounding ground pollution.")]
  public bool Enable { get; set; }

  [LocDescription("Average ground pollution value from which the penalty starts being applied. Below this value, no penalty is applied.")]
  public float PollutionValueWherePenaltyStarts { get; set; }

  [LocDescription("Average ground pollution value at which the penalty reaches its maximum. Pollution above this value does not increase the penalty further. GroundPollution is capped at 1, so the penalty maxes out at full pollution.")]
  public float PollutionValueWherePenaltyStopsIncreasing { get; set; }

  [LocDescription("Minimum penalty percentage applied when pollution is at or below the start threshold. A value of 0.0 means no penalty.")]
  public float MinPenaltyPercent { get; set; }

  [LocDescription("Maximum penalty percentage applied when pollution reaches the maximum threshold. A value of 1.0 represents a 100% penalty.")]
  public float MaxPenaltyPercent { get; set; }

  [LocDescription("Defines how the penalty percentage scales between the start and maximum pollution values. Possible values: Linear (penalty increases uniformly), Exponential (penalty increases slowly at first, then rapidly at high pollution), Logarithmic (penalty is strong at low pollution, then flattens at higher values), DoubleSigmoid (penalty increases strongly at low pollution, slows near mid-range, then increases strongly again near maximum pollution).")]
  public string PenaltyScalingMode { get; set; }
}
