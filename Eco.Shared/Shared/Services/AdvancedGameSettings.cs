// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.AdvancedGameSettings
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Services;

/// <summary>A set of values that determine the difficulty of the game, generated from a formula in DifficultyCalculator with the option of being
/// further tweaked by the user.</summary>
[TypeConverter(typeof (ExpandableObjectConverter))]
[Serializable]
public class AdvancedGameSettings : ICloneable
{
  public const int NumProfessions = 10;
  public const int NumSpecialties = 33;
  [JsonIgnore]
  public float UMeteorImpactDays;
  [JsonIgnore]
  public float UMaxPercentOfProfessionsPerCitizen;
  [JsonIgnore]
  public float UMaxPercentOfSpecialtiesPerCitizen;
  [JsonIgnore]
  public float USkillCostMultiplier;
  [JsonIgnore]
  public float UCostPerAdditionalSpecialty;
  [JsonIgnore]
  public float UcraftResourceModifier;
  [JsonIgnore]
  public float UcraftTimeModifier;
  [JsonIgnore]
  public float UspecialtyRefundPercentage;
  [JsonIgnore]
  public float UplayerExperiencePerSpecialtyExperience;
  [JsonIgnore]
  public float UstackSizeModifier;
  [JsonIgnore]
  public float UweightModifier;
  [JsonIgnore]
  public float UfuelModifier;
  [JsonIgnore]
  public float UgrowthRateModifier;
  [JsonIgnore]
  public float UconnectionRangeModifier;
  [JsonIgnore]
  public float UShelfLifeMultiplier;
  [JsonIgnore]
  public bool UAllowDeepOceanBuilding;
  [JsonIgnore]
  public bool UCanAbandonSpecialties;
  [JsonIgnore]
  public bool URequireSkillsToReplaceParts;
  [JsonIgnore]
  public bool UBrokenPartsWillDisableVehicles;
  [JsonIgnore]
  public float UAnimalUnprovokedAttackFrequencyMultiplier;

  [LocDescription("How many days until the meteor would hit?")]
  [System.ComponentModel.DataAnnotations.Range(1, 10000)]
  public float MeteorImpactInDays { get; set; }

  [LocDescription("Each citizen may take professions until they have this percent of the total number. 10 total available in vanilla.")]
  [System.ComponentModel.DataAnnotations.Range(0, 100)]
  public float MaxProfessionsPerCitizen { get; set; }

  [LocDescription("Each citizen may take specialties until they have this percent of the total number. 33 total available in vanilla.")]
  [System.ComponentModel.DataAnnotations.Range(0, 100)]
  public float MaxSpecialtiesPerCitizen { get; set; }

  [LocDescription("Multiplier increasing the total experience required for the next star.")]
  [System.ComponentModel.DataAnnotations.Range(0.0099999997764825821, 3.4028234663852886E+38)]
  [Increment(0.05f)]
  public float SkillCostMultiplier { get; set; }

  [LocDescription("Additional star cost added per specialty the citizen already has. For example, with a value of 1 and 3 learned specialties, the next specialty costs 3 extra stars on top of the base cost. Set to 0 for flat cost (default behavior).")]
  [System.ComponentModel.DataAnnotations.Range(0.0, 100.0)]
  public float CostPerAdditionalSpecialty { get; set; }

  [LocDescription("Multiplier applied to crafting resource cost. Values below 1 decrease crafting resource cost, above 1 increase resource cost.")]
  [System.ComponentModel.DataAnnotations.Range(0.0099999997764825821, 3.4028234663852886E+38, ErrorMessage = "The value must be greater or equal than 0.01.")]
  [Increment(0.05f)]
  public float CraftResourceMultiplier { get; set; }

  [LocDescription("Multiplier applied to crafting time. Values below 1 decrease crafting time, above 1 increase crafting time.")]
  [System.ComponentModel.DataAnnotations.Range(0.0099999997764825821, 3.4028234663852886E+38, ErrorMessage = "The value must be greater or equal than 0.01.")]
  [Increment(0.05f)]
  public float CraftTimeMultiplier { get; set; }

  [Category("Property")]
  [LocDescription("How many claim stakes, if any, are granted to a player upon unlocking a new skill by reading a skillscroll. Decimals permitted (they aggregate and will be given in later scroll readings)")]
  public float ClaimStakesGrantedUponSkillscrollConsumed { get; set; }

  [Category("Property")]
  [LocDescription("How many claim papers, if any, are granted to a player upon unlocking a new skill by reading a skillscroll. Decimals permitted (they aggregate and will be given in later scroll readings)")]
  public float ClaimPapersGrantedUponSkillscrollConsumed { get; set; }

  [LocDescription("Can citizens abandon stars they spent on specialties, allowing them to choose other specialties? Note: specialties cannot be abandoned when there are active work orders which the citizen contributed to using that specialty.")]
  public bool CanAbandonSpecialties { get; set; }

  [LocDescription("If set, area benefit buildings dedicated to a profession only apply their bonuses while enough citizens hold that profession.")]
  public bool AreaBonusRequiresProfessionCitizens { get; set; }

  [LocDescription("How many citizens holding the dedicated profession are required before an area benefit building applies its bonuses.")]
  [System.ComponentModel.DataAnnotations.Range(1, 100)]
  public int AreaBonusMinProfessionCitizens { get; set; }

  [DefaultValue(0.5f)]
  [LocDescription("Percentage to refund the player when they remove a specialty.")]
  [System.ComponentModel.DataAnnotations.Range(0.0, 1.0, ErrorMessage = "The value must be between 0.01 and 1.")]
  [Increment(0.05f)]
  public float SpecialtyRefundPercentage { get; set; }

  [LocDescription("Percentage of speciality experience that is also gained as character level experience (which otherwise only comes from food/housing). Not recommended for public servers.Multiplied by a factor of 0.01 Default: 0")]
  [System.ComponentModel.DataAnnotations.Range(0.0, 100.0)]
  [Increment(0.1f)]
  public float GainCharacterExperienceWithSpecialtyExperience { get; set; }

  [LocDescription("Multiplier applied to item max stack size. Values below 1 decrease max size, above 1 increase max size. A server restart is required for correct calculation.")]
  [System.ComponentModel.DataAnnotations.Range(0.25, 100.0, ErrorMessage = "The value must be between 0.25 and 100.")]
  [Increment(0.05f)]
  public float StackSizeMultiplier { get; set; }

  [LocDescription("Multiplier applied to item weight. Values below 1 decrease item weight, above 1 increase item weight. A server restart is required for correct calculation.")]
  [System.ComponentModel.DataAnnotations.Range(0.0099999997764825821, 100.0, ErrorMessage = "The value must be between 0.01 and 100.")]
  [Increment(0.05f)]
  public float WeightMultiplier { get; set; }

  [LocDescription("Multiplier applied to fuel yield per unit. Values above one make fuel last longer, below 1 make fuel last shorter. A server restart is required for correct calculation.")]
  [System.ComponentModel.DataAnnotations.Range(0.0099999997764825821, 100.0, ErrorMessage = "The value must be between 0.01 and 100.")]
  [Increment(0.05f)]
  public float FuelEfficiencyMultiplier { get; set; }

  [LocDescription("Global scale for how quick plants mature. The higher the value, the faster the plant will grow. Default: 1")]
  [System.ComponentModel.DataAnnotations.Range(0.0099999997764825821, 100.0, ErrorMessage = "The value must be between 0.01 and 100.")]
  [Increment(0.05f)]
  public float GrowthRateMultiplier { get; set; }

  [LocDescription("Multiplier applied to storage connection range. Values below 1 decrease range, above 1 increase range. A server restart is required for correct calculation.")]
  [System.ComponentModel.DataAnnotations.Range(0.5, 10.0, ErrorMessage = "The value must be between 0.5 and 10.")]
  [Increment(0.05f)]
  public float ConnectionRangeMultiplier { get; set; }

  [LocDescription("Adjusts the default shelf life of all foods, with higher values causing food to last longer. For example, setting to 2 doubles the shelf life while setting to 0.5 halves the shelf life.")]
  [System.ComponentModel.DataAnnotations.Range(0.01, 1000000.0)]
  public float ShelfLifeMultiplier { get; set; }

  [LocDescription("Allows or prevents building in deep ocean biome. Prevents building ocean-bridges to make boats more necessary.")]
  public bool AllowDeepOceanBuilding { get; set; }

  [LocDescription("If set, some objects will have a required skill in order to swap out parts (ie, mechanic skills to change sparkplugs).")]
  public bool RequireSkillsToReplaceParts { get; set; }

  [LocDescription("If set, vehicles that have a broken part will be totally disabled. Otherwise they will be penalized instead.")]
  public bool BrokenPartsWillDisableVehicles { get; set; }

  [LocDescription("Determines how often animals attack randomly when unprovoked. Higher values increase the attack chance of all animals based on each species' individual base attack chance, lower values reduce it.")]
  public float AnimalUnprovokedAttackFrequencyMultiplier { get; set; }

  public object Clone();
}
