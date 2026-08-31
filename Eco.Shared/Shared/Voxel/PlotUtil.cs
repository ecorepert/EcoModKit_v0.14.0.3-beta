// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.PlotUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Voxel;

/// <summary> Functions for translating to/from property plot coordinates. </summary>
public static class PlotUtil
{
  public const int PlotSize = 5;
  public const int PropertyPlotLength = 5;
  public const int PropertyPlotArea = 25;

  /// <summary> Returns many plots exist in the x and z dimensions of the world. </summary>
  public static Vector2i WorldPlotDims { get; }

  /// <summary>Return the corner of whatever plot the position currently is in.</summary>
  public static Vector3i CornerOfCurrentPlot(this Vector3i pos);

  public static 
  #nullable disable
  IEnumerable<Vector2i> Corners(this PlotPos pos);

  /// <summary>Converts a position in world space to a position in plot space. Performs the wrap. Ignores 'y' value.</summary>
  public static PlotPos ToPlotPos(this Vector3i worldPos);

  /// <summary>Converts a position in world space to a position in plot space. Performs the wrap.</summary>
  public static PlotPos ToPlotPos(this Vector2i worldPos);

  /// <summary>Converts a Vector2i to a plotpos structure, with no coordinate transformation at all.  Careful with this one.  Asserts its pre-wrapped.</summary>
  public static PlotPos RawPlotPos(this Vector2i worldPos);

  /// <summary>Converts the raw value of a vector2i already in plot space to a plot pos, wrapping in the process. Needed to work with things that
  /// iterate on vector2is past world bounds, like WorldRange.</summary>
  public static PlotPos RawPlotPosWrap(this Vector2i vectorInPlotSpace);

  /// <summary> Get the list of Plot Positions for each plot that this range intersects. </summary>
  public static IEnumerable<PlotPos> IntersectingPlotsExc(this WorldRange range);

  public static IEnumerable<PlotPos> IntersectingPlotsInc(this WorldRange range);
}
