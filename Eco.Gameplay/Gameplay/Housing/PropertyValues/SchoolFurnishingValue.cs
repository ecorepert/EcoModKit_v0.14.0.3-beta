// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.SchoolFurnishingValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Housing.PropertyValues.Internal;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

public class SchoolFurnishingValue : IFurnishingValue
{
  public PropertyType AppliesToProperty { get; }

  [LocDescription("If this is a teacher workstation, put the tier in this value.")]
  public float TeacherWorkstationOfTier { get; set; }

  [LocDescription("If this is a student workstation, put the tier in this value.")]
  public float StudentWorkstationOfTier { get; set; }

  [LocDescription("Each workstation needs 'support' matching its tier value.")]
  public float SupportProvided { get; set; }

  [LocDescription("For support objects, this many repeats will still provide value in a classroom.")]
  public int RepeatsAllowed { get; set; }

  [LocDescription("Increases learning speed by this multiplier, summing with other furnishings.")]
  public float LearningSpeedBoostPercent { get; set; }

  [LocDescription("Increase calorie efficiency for studying by this multiplier in this classroom.")]
  public float StudyingCalorieEfficiencyBoostPercent { get; set; }

  [LocDescription("Increase calorie efficiency for teaching by this multiplier in this classroom.")]
  public float TeachingCalorieEfficiencyBoostPercent { get; set; }
}
