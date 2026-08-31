// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Property;

public static class PropertyExtensions
{
  public static 
  #nullable disable
  IEnumerable<Vector3i> EachSurface(this IEnumerable<Vector2i> list, int maxDepth);

  public static IEnumerable<Vector2i> PositionsAtPlotPos(Vector2i plotPos);

  /// <summary> Converts provided plot pos vectors to OwnableHandles for deed operations.</summary>
  public static IEnumerable<IOwnableHandle> PlotPosToOwnableHandles(
    this IEnumerable<PlotPos> plotPos);
}
