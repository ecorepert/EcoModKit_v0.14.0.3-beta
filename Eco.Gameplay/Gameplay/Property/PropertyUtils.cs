// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Property;

public static class PropertyUtils
{
  public static float GetRoadEfficiency(this Type type);

  public static bool MatchesRoadEfficiency(this Block block, float minValue);

  /// <summary>Force all the plots under the given rect in world space to be claimed, on the given settlement if set. Handles wrapping.</summary>
  public static Deed ForceClaim(Deed deed, User user, Rect worldPosXZRect);

  /// <summary>Find a plot thats not yet claimed starting from the given user.</summary>
  public static Vector3i GetUnclaimedPlotWorldPosNearUser(User user);

  /// <summary>Find a plot thats not yet claimed.</summary>
  public static Vector3i GetUnclaimedPlotWorldPos(PlotPos pos);

  /// <summary>Find a plot thats not yet claimed.</summary>
  public static PlotPos? GetUnclaimedPlotPos(PlotPos pos);

  public static RoadCheckResults RoadExists(
    WrappedPosition3i posA,
    WrappedPosition3i posB,
    Type roadItemType,
    int minWidth);

  public static IEnumerable<Vector3i> TopBlocksOnProperty(Vector2i pos, int depth = 1);

  /// <summary>Given a list of plots, return how many of the neighboring spaces are occupied by a plot from 'neighborPlots' as 'Count', and return the total number of
  /// neighboring plots as 'Total'.</summary>
  public static (int Count, int Total) GetNeighboringPlotCount(
    this HashSet<PlotPos> plots,
    HashSet<PlotPos> neighborPlots);
}
