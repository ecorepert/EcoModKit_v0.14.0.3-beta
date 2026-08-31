// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.PluginModule
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Bonuses;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Modules;

/// <summary> Base abstract class for plugin modules which may be used as plugin for a table to enhance it in some way (like increase efficiency, extend labor queue etc). </summary>
[System.ComponentModel.Category("Modules")]
[Tag("Upgrade")]
public abstract class PluginModule : Item, IModule, IHasBonuses
{
  /// <summary>Category flags passed by every autogen module class via its base constructor; does not influence slot identity. Slot identity comes from the item's slot tag (<see cref="T:Eco.Gameplay.Modules.ModuleTags" />).</summary>
  public ModuleTypes ModuleTypes { get; }

  protected PluginModule(ModuleTypes moduleTypes);

  protected PluginModule(ModuleTypes moduleTypes, float materialTierBump, int? starCost = null);

  [SyncToView(null, true)]
  public abstract IEnumerable<LocString> Benefits { get; }

  /// <summary>This module's contribution to the host's required room material tier. Set via constructor or override on per-module subclasses to differ from the default 1.</summary>
  public virtual float MaterialTierBump { get; }

  /// <summary>Per-item star cost, taking precedence over the slot's cost when set. Lets specific upgrades cost more, less, or nothing (0). Null defers to the slot.</summary>
  public virtual int? StarCostOverride { get; }

  /// <summary>Power this module requires of its host. The host adopts the highest type across its installed modules; <see cref="F:Eco.Gameplay.Modules.ModulePowerType.None" /> (default) leaves the host's power as-is.</summary>
  public virtual ModulePowerType PowerType { get; }

  /// <summary>Watts the host draws once this module's <see cref="P:Eco.Gameplay.Modules.PluginModule.PowerType" /> wins, since each power type runs a different scale (mechanical tens, electric hundreds). 0 keeps the host's built-in draw.</summary>
  public virtual float PowerConsumption { get; }

  /// <summary> Modified <paramref name="value" /> using the module. I.e. if <see cref="P:Eco.Gameplay.DynamicValues.ModuleModifiedValue.ValueType" /> is <see cref="F:Eco.Gameplay.DynamicValues.DynamicValueType.Efficiency" /> then it may be decreased by some percent. </summary>
  public abstract float Modify(ModuleModifiedValue value);

  /// <summary>Bonuses provided by this module, resolved at runtime by the module's slot tag. Subclasses may override for per-item customisation (Specialty items typically do).</summary>
  public virtual IEnumerable<Bonus> Bonuses { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString PluginBenefitsDescription();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 113, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString RoomRequirementDescription();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 115, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString PowerRequirementDescription();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 200, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString CompatibleTablesDescription();

  public new static void Initialize();
}
