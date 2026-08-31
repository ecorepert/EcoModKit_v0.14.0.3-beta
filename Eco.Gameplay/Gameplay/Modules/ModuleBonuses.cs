// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModuleBonuses
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Bonuses;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Placeholder per-tier bonus definitions for plugin modules. Designer-tunable; flat-coded sample values intended to be replaced with TechTree-driven definitions later.</summary>
/// <remarks>Resolved at runtime by <see cref="P:Eco.Gameplay.Modules.PluginModule.Bonuses" /> -- the base class looks up which slot tag the item carries and returns the corresponding list. Specialty modules return an empty list here; per-profession Bonuses overrides go on the individual specialty item classes when the designer adds them.</remarks>
public static class ModuleBonuses
{
  public static readonly IReadOnlyList<Bonus> Basic;
  public static readonly IReadOnlyList<Bonus> Advanced;
  public static readonly IReadOnlyList<Bonus> Modern;
  public static readonly IReadOnlyList<Bonus> Specialty;

  /// <summary>Returns the registered default bonus list for the given slot tag name (core slots resolve to the lists above,
  /// modded slots to their <see cref="P:Eco.Gameplay.Modules.ModuleSlotDefinition.DefaultBonuses" />), or an empty list for an unrecognised name.</summary>
  public static IReadOnlyList<Bonus> ForSlot(string slotTagName);
}
