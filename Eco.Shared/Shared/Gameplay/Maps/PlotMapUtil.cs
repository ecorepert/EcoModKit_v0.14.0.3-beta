// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.Maps.PlotMapUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Gameplay.Maps;

public static class PlotMapUtil
{
  public static Array2D<T> Make<T>(Func<PlotPos, T> plotPosToVal);

  public static Array2D<T> Assign<T>(Array2D<T> map, Func<PlotPos, T> plotPosToVal);

  /// <summary>Assign values to the map using the given function, and return a list of any positions that were changed.</summary>
  public static List<PlotPos> AssignDetectChanges<T>(Array2D<T> map, Func<PlotPos, T> plotPosToVal) where T : IComparable;
}
