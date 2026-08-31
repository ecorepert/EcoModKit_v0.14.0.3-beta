// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.BalanceConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems;

[Localized(true, false, "", false)]
public class BalanceConfig : Singleton<BalanceConfig>, IController, IViewController, IHasUniversalID
{
  [Category("Utility")]
  [Notify]
  [LocDescription("Sets the calorie multiplier rate of the move object function. This is multiplied towards the total weight in kilos which equals to the total calorie cost per tile moved.")]
  public int CalorieMultiplierOnMove { get; set; }

  [Category("Crafting")]
  [Notify]
  [LocDescription("Sets the quantity of work order queues that can be set on each workstation")]
  public int CraftingQueueQuantity { get; set; }

  [Category("Crafting")]
  [Notify]
  [LocDescription("Maintenance decay rate, this sets the default value for hourly consumption of durability.")]
  public int MaintenanceDecayPercentage { get; set; }

  [Category("Vehicles")]
  [Notify]
  [LocDescription("Maintenance decay rate, this sets the default value for hourly consumption of durability.")]
  public int VehicleMaintenanceDecayPercentage { get; set; }

  [Category("Utility")]
  [Notify]
  [LocDescription("Maintenance decay rate multiplier, this can be adjusted to increase or decrease the Part durability consumed.")]
  public int MaintenanceDecayMultiplier { get; set; }

  [Category("Tools")]
  [Notify]
  [LocDescription("The percentage rate of decay for tools that are repaired.")]
  public float ToolRepairPenalty { get; set; }

  [Category("Crafting")]
  [Notify]
  [LocDescription("Fraction of a consumed ingredient's SalvageCost that becomes garbage during crafting. 0.2 means 20% of the recycle value is produced as waste per unit of ingredient consumed.")]
  public float CraftGarbageRatio { get; set; }

  [Category("Players")]
  [LocDescription("Enables players that join later to earn experience based on the experience rate over days since start 0 indicates off and 12 is the base rate on high collaboration as example.")]
  public int RetroactiveExperienceRate { get; set; }

  [Category("Utility")]
  [LocDescription("Disables visibility of the Oil Layer unless Oil Drilling is researched and available.")]
  [SyncToView(null, true)]
  public bool ShowOilLayer { get; set; }

  [Category("Skills")]
  [LocDescription("The skill level will be multiplied by this number and squared to determine how much experience is needed to gain a level. ")]
  public float SpecialtyExperiencePerLevelSquared { get; set; }

  [Category("Skills")]
  [LocDescription("Percentage increased base experience required per level. ")]
  [Range(0.01f, 3.40282347E+38f)]
  [Increment(0.01f)]
  public float ExperienceGrowthPercentage { get; set; }

  [Category("Skills")]
  [LocDescription("Adds a flat value to the incursive experience cost on each stage.(This is added each time StarsRequiredPerStage is triggered) ")]
  [Range(0.0f, 2.14748365E+09f)]
  [Increment(1f)]
  public int ExperienceIncreaseAdditive { get; set; }

  [Category("Skills")]
  [LocDescription("The required stars for each stage incremental increase. (total earned stars / this value)")]
  [Range(1f, 2.14748365E+09f)]
  [Increment(1f)]
  public int StarsRequiredPerStage { get; set; }

  [Category("Modules")]
  [Notify]
  [LocDescription("Stars required to install a Basic-slot plugin module.")]
  [Range(0.0f, 2.14748365E+09f)]
  [Increment(1f)]
  public int BasicModuleStarCost { get; set; }

  [Category("Modules")]
  [Notify]
  [LocDescription("Stars required to install an Advanced-slot plugin module.")]
  [Range(0.0f, 2.14748365E+09f)]
  [Increment(1f)]
  public int AdvancedModuleStarCost { get; set; }

  [Category("Modules")]
  [Notify]
  [LocDescription("Stars required to install a Modern-slot plugin module.")]
  [Range(0.0f, 2.14748365E+09f)]
  [Increment(1f)]
  public int ModernModuleStarCost { get; set; }

  [Category("Modules")]
  [Notify]
  [LocDescription("Stars required to install a Specialty-slot plugin module.")]
  [Range(0.0f, 2.14748365E+09f)]
  [Increment(1f)]
  public int SpecialtyModuleStarCost { get; set; }

  [Obsolete("Deprecated: use Difficulty Settings -> Advanced -> SkillCostMultiplier (specialty cost multiplier) instead.")]
  [Browsable(false)]
  [Category("Skills")]
  [LocDescription("Deprecated. Previously multiplied food/housing character XP gain and was hard to balance. Use Difficulty Settings -> Advanced -> SkillCostMultiplier instead.")]
  [Range(0.01f, 3.40282347E+38f)]
  [Increment(0.01f)]
  public float SkillGainMultiplier { get; set; }

  public ref int ControllerID { get; }
}
