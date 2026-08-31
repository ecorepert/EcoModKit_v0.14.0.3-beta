// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.ChangeDetection.SettlementBuilders.InfluenceBuilder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.InfluenceObjects;
using Eco.Shared.Items;
using Eco.Shared.Voxel;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Settlements.Internal.ChangeDetection.SettlementBuilders;

public static class InfluenceBuilder
{
  public static void UpdateInfluenceMapsAndNotify(IEnumerable<SettlementType> types);

  /// <summary>Gets the point influencing the given position, considering only the influence points, not anything else like assigned settlement on stakes, which can affect it otherwise.
  /// Influence points to consider can be injected, or if null, use the settlement's.</summary>
  public static Settlement GetSettlementAccordingToInfluencePointsOnlyAtPos(
    PlotPos pos,
    SettlementType? settlementTypeBeingCalculated,
    Influence[] influences = null);
}
