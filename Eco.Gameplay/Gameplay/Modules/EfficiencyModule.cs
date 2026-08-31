// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.EfficiencyModule
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Modules;

/// <summary>
/// Abstract class for efficiency modules (both resource and speed) which may be used to enhance a table.
/// It may only <see cref="M:Eco.Gameplay.Modules.EfficiencyModule.Modify(Eco.Gameplay.DynamicValues.ModuleModifiedValue)" /> values which associated to same <see cref="P:Eco.Gameplay.Modules.EfficiencyModule.SkillType" /> or if <see cref="P:Eco.Gameplay.Modules.EfficiencyModule.SkillType" /> not specified then apply to any value.
/// </summary>
/// <sample>
/// This code creates Hewing Efficiency Module which modifies both resource and speed efficiency and only applies to values associated with HewingSkill.
/// <code>
/// class HewingEfficiency1 : EfficiencyModule
/// {
///    public HewingEfficiency1() : base(ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency, typeof(HewingSkill), 0.9f) { }
/// }
/// </code></sample>
[System.ComponentModel.Category("Efficiency Modules")]
[ItemGroup("Upgrade")]
public abstract class EfficiencyModule : PluginModule
{
  /// <summary> Module will only be applied to values associated with same <see cref="P:Eco.Gameplay.Modules.EfficiencyModule.SkillType" /> if specified. </summary>
  [SyncToView(null, true)]
  public Type? SkillType { get; }

  /// <summary> Module efficiency generic multiplier (applies to all recipes). Dynamic value in <see cref="M:Eco.Gameplay.Modules.EfficiencyModule.Modify(Eco.Gameplay.DynamicValues.ModuleModifiedValue)" /> will be multiplied on this to get final value. </summary>
  [SyncToView(null, true)]
  public float GenericMultiplier { get; }

  /// <summary> Module efficiency skill-related multiplier (only applies to recipes for <see cref="P:Eco.Gameplay.Modules.EfficiencyModule.SkillType" />). Dynamic value in <see cref="M:Eco.Gameplay.Modules.EfficiencyModule.Modify(Eco.Gameplay.DynamicValues.ModuleModifiedValue)" /> will be multiplied on this to get final value. </summary>
  [SyncToView(null, true)]
  public float SkillMultiplier { get; }

  [SyncToView(null, true)]
  [UsedImplicitly]
  public int SkillTypeID { get; }

  protected EfficiencyModule(ModuleTypes moduleTypes, float multiplier);

  protected EfficiencyModule(
    ModuleTypes moduleTypes,
    float multiplier,
    float materialTierBump,
    int? starCost = null);

  protected EfficiencyModule(
    ModuleTypes moduleTypes,
    float genericMultiplier,
    Type skillType,
    float skillMultiplier);

  protected EfficiencyModule(
    ModuleTypes moduleTypes,
    float genericMultiplier,
    Type skillType,
    float skillMultiplier,
    float materialTierBump,
    int? starCost = null);

  /// <summary>Bonuses derived from this module's own configured multipliers, so the item's values drive the effect instead of the slot defaults.
  /// Skill-scoped recipes get <see cref="P:Eco.Gameplay.Modules.EfficiencyModule.SkillMultiplier" /> exclusively (the generic bonus excludes the skill, matching the old Modify semantics);
  /// modules with no configured multipliers fall back to the slot-wide defaults.</summary>
  public override IEnumerable<Bonus> Bonuses { get; }

  /// <summary>Descriptions come straight from <see cref="P:Eco.Gameplay.Modules.EfficiencyModule.Bonuses" />, so the item tooltip, the table tooltip and the applied effect can
  /// never disagree (a hand-written duplicate drifted from the real numbers before). Unconfigured modules describe their slot defaults.</summary>
  public override IEnumerable<LocString> Benefits { get; }

  /// <inheritdoc cref="M:Eco.Gameplay.Modules.PluginModule.Modify(Eco.Gameplay.DynamicValues.ModuleModifiedValue)" />
  public override float Modify(ModuleModifiedValue value);
}
