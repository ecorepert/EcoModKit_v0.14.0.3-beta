// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModuleSlotRegistry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Modules;

/// <summary>Registry of plugin-module slot types and per-table slot sets. Mods register new slots and attach them to tables from mod
/// initialization (before world load); the registry freezes on first per-table resolution so slot indices stay stable for the session.
/// A table's base slot set comes from <see cref="P:Eco.Gameplay.Modules.AllowPluginModulesAttribute.Slots" /> on its creating item (null falls back to the core
/// slots the table's module allow-list can occupy -- all four without a list), extended by <see cref="M:Eco.Gameplay.Modules.ModuleSlotRegistry.AddSlotToTables(System.String,System.Func{System.Type,System.Boolean})" /> additions.
/// First registration of a tag name wins.</summary>
public static class ModuleSlotRegistry
{
  /// <summary>Registers a slot type. First write wins; registering after the registry froze (first table resolution) throws.</summary>
  public static void Register(ModuleSlotDefinition definition);

  /// <summary>Adds a registered slot to tables matching <paramref name="tableFilter" /> (null = every table with a modules component),
  /// on top of what the tables declare themselves. Lets mods extend existing tables without touching their classes.</summary>
  public static void AddSlotToTables(string slotTagName, Func<Type, bool>? tableFilter = null);

  /// <summary>All registered slots in canonical order: (SortOrder, TagName) - deterministic regardless of registration order.</summary>
  public static IEnumerable<ModuleSlotDefinition> All { get; }

  /// <summary>The four built-in slots in slot order; the default set for tables that don't declare their own.</summary>
  public static IReadOnlyList<ModuleSlotDefinition> CoreSlots { get; }

  public static ModuleSlotDefinition? Get(string tagName);

  /// <summary>The ordered slot set for a table type. Freezes the registry on first use and caches per type.</summary>
  public static IReadOnlyList<ModuleSlotDefinition> SlotsForTable(Type worldObjectType);

  /// <summary>The core slots a table with the given module allow-list exposes: those at least one allowed item carries the slot tag of, so
  /// no table shows a slot nothing can go into (e.g. RockerBox allows only the mining-basic specialty and the generic basic upgrade, so it
  /// exposes Basic + Specialty). A null list (no filter declared) exposes all four.</summary>
  internal static string[] CoreSlotNamesFor(IEnumerable<Type>? allowedItemTypes);

  /// <summary>Test hook: clears mod registrations and the freeze so fixtures run isolated. Core slots are re-registered.</summary>
  internal static void ResetForTests();
}
