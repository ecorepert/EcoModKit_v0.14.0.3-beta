// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageMaterialUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>Read-only registry queries used by both the sorting UI (per-residual line) and the tooltip libraries (per-residual item).
/// Centralizing the lookup keeps the "what feeds into this residual?" answer DRY across server tooltip and client UI.</summary>
public static class GarbageMaterialUtils
{
  /// <summary>All registered <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" />s whose <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.DegradedForm" /> equals <paramref name="targetType" />.</summary>
  public static IEnumerable<GarbageMaterial> SourcesDegradingInto(Type targetType);

  /// <summary>Comma-separated UILink list of the OutputItemTypes of every material that degrades into <paramref name="residualType" />.
  /// Returns <see cref="F:Eco.Shared.Localization.LocString.Empty" /> when no source has a registered output item — handled gracefully by callers (UI hides the row, tooltip section is suppressed).</summary>
  public static LocString FormatSourcesLine(Type residualType);
}
