// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Newtonsoft.Json.Linq;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements;

[Localized(true, false, "", false)]
public class SettlementConfig : 
  Singleton<
  #nullable disable
  SettlementConfig>,
  IController,
  IViewController,
  IHasUniversalID,
  ISettlementConfig,
  INotifyPropertyChanged,
  IMigratableConfig,
  IVersionedConfig,
  IValidatableConfig
{
  /// <summary>Randoms names for leaders, by settlement type.</summary>
  public static LocString[][] LeaderNames;
  /// <summary>These names will be appended when starting a town.</summary>
  public static LocString[][] DefaultSuffixes;
  /// <summary>The claim stake item for each settlement type.</summary>
  [JsonIgnore]
  public List<Type> ClaimStakeItems;
  /// <summary>The claim stake object for each settlement type.</summary>
  [JsonIgnore]
  public List<Type> ClaimStakeWorldObjects;
  [JsonIgnore]
  public SettlementConfig.CultureToInfluenceRadiusMapper CultureToInfluenceRadius;
  [Category("Culture")]
  [LocDescription("Maps player reputation to culture points.")]
  public LimitMapper.Config PlayerReputationToCultureFormula;
  [Category("Culture")]
  [LocDescription("Maps reputation of the artwork to culture points.")]
  public LimitMapper.Config ArtworkReputationToCultureFormula;
  [Category("Culture")]
  [LocDescription("Maps the culture bonus of a property's architecture to a multiplier for the value of that property, for Residential property type.")]
  public LimitMapper.Config CultureValueOnResidentialPropertyToHousingValueMultiplierFormula;
  /// <summary>This type of object associated with a settlement is queried for inventory to perform an annexation.</summary>
  [JsonIgnore]
  public Type InventorySourceForAnnexationCosts;

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("Landclaims made available on the settlement marker at each level of settlement. Defined per settlement type.")]
  [SyncToView(null, true)]
  public float[] SettlementClaimsPerCitizen { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("If a player enters the 'Abandoned' demographic, they will instead make this many claims available to Settlements they're a citizen of.")]
  [SyncToView(null, true)]
  public float[] SettlementClaimsPerAbandonedCitizen { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("Support claims (usable only at homesteads with no settlement), made available on the settlement marker at each level of settlement. Defined per settlement type.")]
  [SyncToView(null, true)]
  public float[] HomesteadSupportClaimsPerCitizen { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("If a player enters the 'Abandoned' demographic, they will instead make this many claims available to Settlements they're a citizen of.")]
  [SyncToView(null, true)]
  public float[] HomesteadSupportClaimsPerAbandonedCitizen { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("Claim stakes made available on the settlement marker at each level of settlement. Defined per settlement type.")]
  [SyncToView(null, true)]
  public float[] ClaimStakesPerCitizen { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("If a player enters the 'Abandoned' demographic, they will instead make this many stakes available to Settlements they're a citizen of.")]
  [SyncToView(null, true)]
  public float[] ClaimStakesPerAbandonedCitizen { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("The number of plots that a claim stake allows you to claim by default, specified by settlement type. Defined per settlement type.")]
  [SyncToView(null, true)]
  public int[] BasePlotsOnClaimStake { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("The number of plots that a settlement foundation allows you to claim by default, specified by settlement type. Defined per settlement type.")]
  [SyncToView(null, true)]
  public int[] BasePlotsOnFoundation { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("The number of plots that a homestead claim stake allows you to claim by default.")]
  [SyncToView(null, true)]
  public int BasePlotsOnHomesteadClaimStake { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("The number of plots that an outpost claim stake allows you to claim by default.")]
  [SyncToView(null, true)]
  public int BasePlotsOnOutpostClaimStake { get; set; }

  [Category("Property Crisis")]
  [PropertyExplanation]
  [LocDescription("If there are not enough citizens to support the claimed plots, a property crisis will happen after this amount of time. Defined per settlement type.")]
  [SyncToView(null, true)]
  public float[] HoursToResolvePropertyCrisis { get; set; }

  [Category("Settlement Property")]
  [PropertyExplanation]
  [LocDescription("Enabling this will add a new check inside immigrations policies that will give the players the option to prevent any child settlement from seceding.")]
  [Notify]
  public bool AllowOptionToPreventSettlementsFromSeceding { get; set; }

  [Category("Settlement Property")]
  [LocDescription("If the influence source position of a cultural deed is not within OtherDeedInfluenceRadius + (this * OtherDeedInfluenceRadius) then the deed will lose its influence (you must link properties together to cast influence).")]
  public float CultureDeedLinkPercentRequirement { get; set; }

  [LocDescription("Names of the settlement types, 0 is the lowest level settlement.")]
  [SyncToView(null, true)]
  public List<string> SettlementTypes { get; }

  [Category("Influence")]
  [PropertyExplanation]
  [LocDescription("A founded settlement foundation will provide this much influence, without any culture. Note: this is influenced by world size multiplier.")]
  [SyncToView(null, true)]
  public float[] SettlementFoundationBaseInfluence { get; set; }

  [Category("Influence")]
  [PropertyExplanation]
  [LocDescription("The influence gained from the different deeds that are created inside the settlement will be multiplied by this value.")]
  [SyncToView(null, true)]
  public float[] SettlementInfluenceMultiplier { get; set; }

  [Category("Influence")]
  [PropertyExplanation]
  [LocDescription("When set, the values for influence will be scaled based on the size of the world. At 100x100 chunks they'll be the same, and if larger or smaller they will be scaled to keep the same percentage size.")]
  [SyncToView(null, true)]
  public bool ScaleInfluenceBasedOnWorldSize { get; set; }

  [Category("Influence")]
  [PropertyExplanation]
  [LocDescription("This will determine how far the player can move the settlement foundation away from its founding position depending on the base influence of the settlement. Note that this will also be affected by the settlement influence multiplier")]
  [Notify]
  public int BaseInfluenceRadiusFoundationMovementAllowedAfterFounding { get; set; }

  [Category("Influence")]
  [PropertyExplanation]
  [LocDescription("Current World Size multiplier.")]
  public float CurrentWorldSizeMultiplier { get; }

  [Category("Citizenship")]
  [PropertyExplanation]
  [LocDescription("A country/federation's influence must overlap a child town/country by this percentage in order to be a child.")]
  [SyncToView(null, true)]
  public float SettlementMinRequiredPlotCoveragePercentage { get; set; }

  [Category("Citizenship")]
  [PropertyExplanation]
  [LocDescription("Minimum required ratio of homestead plots covered by settlement's influence to be a child.")]
  [SyncToView(null, true)]
  public float HomesteadMinRequiredPlotCoveragePercentage { get; set; }

  [Category("Founding")]
  [PropertyExplanation]
  [LocDescription("Determines how many subsettlements must be members of a settlement before it can be founded (first entry is ignored, since Homestead cant have sub-settlements). Defined per settlement type.")]
  [SyncToView(null, true)]
  public int[] MinSubSettlementsToFoundSettlement { get; set; }

  [Category("Founding")]
  [PropertyExplanation]
  [LocDescription("Determines how many subsettlements must be members of a settlement or else it goes invalid (first entry is ignored, since Homestead cant have sub-settlements). Defined per settlement type.")]
  [SyncToView(null, true)]
  public int[] MinSubSettlementsToMaintainSettlement { get; set; }

  [Category("Founding")]
  [PropertyExplanation]
  [LocDescription("Number of citizens that must be part of a roster before a settlement can be founded. Defined per settlement type.")]
  [SyncToView(null, true)]
  public int[] MinCitizensToFoundSettlement { get; set; }

  [Category("Founding")]
  [PropertyExplanation]
  [LocDescription("Number of citizens that must be part of a roster in order for a settlement to continue. Defined per settlement type.")]
  [SyncToView(null, true)]
  public int[] MinCitizensToMaintainSettlement { get; set; }

  [Category("Founding")]
  [PropertyExplanation]
  [LocDescription("Sum of culture from all children settlements required to form a new one. Defined per settlement type, starting with country.")]
  [SyncToView(null, true)]
  public float[] MinCultureToFoundSettlement { get; set; }

  [Category("Founding")]
  [PropertyExplanation]
  [LocDescription("Sum of culture from all children settlements required to continue a parent settlement. Defined per settlement type, starting with country.")]
  [SyncToView(null, true)]
  public float[] MinCultureToMaintainSettlement { get; set; }

  /// <summary>This is linked here so that it can be displayed in the ecopedia details, but its not used directly, the mapper above is called.
  /// Use calculator: https://www.desmos.com/calculator/czpu5xcrg3</summary>
  [Category("Culture")]
  [LocDescription("Maps culture (which can climb to infinity) to influence, which can have a different max for each type of settlement.  This will be scaled by world size, if Influence Scaling is enabled in the config.")]
  public LimitMapper.Config[] CultureToInfluenceMappingPerSettlementType { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("Max reputation a settlement can give/remove in total per day.")]
  public float[] MaxGivableReputationThroughLaws { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("Max reputation a settlement can give/remove to a single target per day.")]
  public float[] MaxGivableToSinglePartyPerDay { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("Max reputation a settlement can give/remove to a single target in aggregate.")]
  public float[] MaxGivableToSinglePartyTotal { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("Min reputation a settlement can give/remove to a single target in aggregate.")]
  public float[] MinGivableToSinglePartyTotal { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("Minimum culture values of the foundation deed. Defined per settlement type.")]
  public float[] MinCultureOfFoundationSettlements { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("Max number of cultural properties per settlement type. Defined per settlement type.")]
  public int[] MaxNumberOfCulturalProperties { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  [LocDescription("This will determine how long a cultural deed will take when its claim stake is far away from another valid influence before its influence gets disabled.")]
  public double HoursBeforeInvalidatingCultureDeed { get; set; }

  [Category("Culture")]
  [PropertyExplanation]
  public DinnerPartyConfig DinnerPartyConfig { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If set, a parent settlement's laws may withdraw from (tax, pay from, or transfer out of) the government accounts of its child settlements. When unset, only a settlement's own laws may withdraw from its accounts; money may always be sent into a settlement regardless.")]
  public bool MayTaxChildSettlements { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Can a settlement annex other settlements at the same level? Or does one have to be higher? Note: top-level settlement can always annex other top-levels.")]
  public bool MayAnnexSameLevel { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If set, sub-settlements can be captured out of a main settlement.")]
  public bool MayAnnexSubSettlements { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If settlement A is a parent type of Settlement B, a requirement of annexing Settlement B is that its culture power is this percent higher than it. Defined per settlement type.")]
  public float[] CultureAdvantagePercentRequiredToAnnexChildSettlement { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If settlement A is a parent type of Settlement B, a requirement of annexing Settlement B is that its culture power is this much higher than it. Defined per settlement type.")]
  public float[] CultureAdvantageAbsoluteRequiredToAnnexChildSettlement { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If settlement A is the same type as Settlement B, a requirement of annexing Settlement B is that its culture power is this percent higher than it. Defined per settlement type.")]
  public float[] CultureAdvantagePercentRequiredToAnnexSiblingSettlement { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If settlement A is the same type as Settlement B, a requirement of annexing Settlement B is that its culture power is this much higher than it. Defined per settlement type.")]
  public float[] CultureAdvantageAbsoluteRequiredToAnnexSiblingSettlement { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("If a homestead is abandoned (owned by abandoned citizens) then both the percentage and the absolute value needed to annex it will be reduced by this specified value (value between 0 - 1).")]
  public float ReductionPercentageWhenHomesteadIsAbandoned { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("The min value of the range is 'at this many neighboring plots or lower, the culture is weighted to 0', and max value of the range is 'at this many neighboring plots or lower, the culture is weighted to 100'. Values between are interpolated from 0 - 100.")]
  public Eco.Shared.Math.Range[] WeightCultureByPercentOfNeighboringPlotsChildSettlement { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Same as above param, but for sibling type settlements (ie, town annexing another town).")]
  public Eco.Shared.Math.Range[] WeightCultureByPercentOfNeighboringPlotsSiblingSettlement { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Defines what percent of citizens a source settlement must have more than, relative to a target settlement in order to annex (1 means 'same number', .5 means 'half')")]
  public float[] ActiveCitizensRequiredtoAnnexRelative { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("When an annexation happens, the resources used in the anneaxtion will have this percent destroyed, with the rest given to the non-abandoned citizens of the target of the annex.  These are wasted resources due to forcing an action rather than coming to an agreement. 1 means destroy everything, .5 means destroy half, 0 means destroy none.")]
  public float[] PercentOfAnnexationResourcesWasted { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("The resources that must be collected to annext with the given source")]
  public ResourceRequirement[][] AnnexationResourceRequirementPerCitizen { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Extra settlement papers that must be given to the annex target.  Each entry represents the level of target (homestead, town, etc)")]
  public int[] ExtraSettlementPapersToAnnexPerCitizen { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("After a settlement of the given type is annexed, it cannot secede until this many days have passed.")]
  public float[] PostAnnexationSecessionLockDays { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Boost in culture for target of annexation that has an unfounded parent settlement (like a homestead trying to start a town).")]
  public float AnnexTargetBoostWhenHasUnfoundedSettlementParent { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Boost in culture for target of annexation that has an unfounded parent settlement, per citizen past the first one.")]
  public float AnnexTargetBoostPerAdditionalCitizenInUnfoundedSettlementParent { get; set; }

  [Category("Annexation")]
  [PropertyExplanation]
  [LocDescription("Boost in culture for target of annexation that has an unfounded parent settlement, per child settlement past the first one.")]
  public float AnnexTargetBoostPerAdditionalChildSettlementInUnfoundedSettlementParent { get; set; }

  /// <summary>Supply the fully multiplied influence for each settlement type to the client, who needs it for rendering placement overlays.</summary>
  [DependsOnMember("ScaleInfluenceBasedOnWorldSize")]
  [SyncToView(null, true)]
  public IEnumerable<float> CurrentSettlementBaseInfluence();

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int LastConfigVersion { get; }

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int ConfigVersion { get; set; }

  public void Migrate(JObject json);

  /// <summary>Formula that determines the influence radius given the culture.</summary>
  public delegate ValResult<float> CultureToInfluenceRadiusMapper(
    Settlement settlement,
    Deed deed,
    float culture);
}
