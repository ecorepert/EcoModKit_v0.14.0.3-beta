// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModuleSlotDefinition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Bonuses;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Modules;

/// <summary>Describes one plugin-module slot type: its identity tag (items route in via <c>[Tag(TagName)]</c>), display name, ordering,
/// star cost and the slot-wide default bonuses applied when an installed module doesn't override <see cref="P:Eco.Gameplay.Modules.PluginModule.Bonuses" />.</summary>
public class ModuleSlotDefinition
{
  public string TagName { get; init; }

  public LocString DisplayName { get; init; }

  /// <summary>Slot ordering: drives sub-inventory flattening, star-cost indexing and UI layout. Core slots use 0-3; mods should use 10+.</summary>
  public int SortOrder { get; init; }

  /// <summary>Client icon name of a representative module, rendered semi-opaque inside the empty slot so players can tell what fits.
  /// Empty (or a name with no registered sprite) shows no hint.</summary>
  public string IconName { get; init; }

  /// <summary>Deferred so config edits (e.g. BalanceConfig) apply without re-registration.</summary>
  public Func<int> StarCost { get; init; }

  /// <summary>Slot-wide default bonuses; deferred for the same reason.</summary>
  public Func<IReadOnlyList<Bonus>> DefaultBonuses { get; init; }
}
