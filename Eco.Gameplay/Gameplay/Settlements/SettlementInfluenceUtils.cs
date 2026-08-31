// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementInfluenceUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Gameplay;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Settlements;

public static class SettlementInfluenceUtils
{
  /// <summary>
  /// Determines if the settlement has satisfactory coverage of the given child settlement or homestead.
  /// This means it's influence covers a given percentage of the child's influence (or plots, in the case of homestead).
  /// Can also accept extra plots to consider as 'in the target' or 'out of the target' for calculating this coverage.
  /// </summary>
  public static LazyResult HasSatisfactoryCoverage(
    this Settlement settlement,
    IAnnexable target,
    out float percentCovered,
    IEnumerable<PlotPos>? considerExtraPlots = null,
    IEnumerable<PlotPos>? ignorePlots = null);

  public static LazyResult WillHaveSatisfactoryCoverage(
    this SettlementType setType,
    PlotPos pos,
    IAnnexable target,
    out float percentCovered,
    IEnumerable<PlotPos>? considerExtraPlots = null,
    IEnumerable<PlotPos>? ignorePlots = null);

  /// <summary>Return true if the influence could influence the given plot pos, if there wasnt other settlements/homesteads in the way.</summary>
  public static bool CouldInfluence(this Settlement set, PlotPos pos);

  public static bool CouldInfluence(this IEnumerable<RadPoint> pts, PlotPos pos);

  /// <summary>Get the nearest distance to an influence point of this settlement (anticipating the base influence if its not founded).</summary>
  public static float DistanceToNearestInfluence(this Settlement set, PlotPos pos);

  public static float DistanceToNearestInfluence(this Settlement set, Vector2i center);
}
