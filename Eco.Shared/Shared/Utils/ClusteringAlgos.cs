// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ClusteringAlgos
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

public static class ClusteringAlgos
{
  /// <summary>Finds a list of clusters given the passed in settings.
  /// The algorithm here is Mean-Shift Clustering, described here: https://towardsdatascience.com/the-5-clustering-algorithms-data-scientists-need-to-know-a36d136ef68</summary>
  public static List<ClusteringAlgos.Cluster> CalculateClusters(
    Array2D<float> map,
    ClusteringAlgos.KMeansSettings settings);

  public struct KMeansSettings
  {
    public int ClusterRadius;
    public int Iterations;
    public float MaxCloseness;

    public KMeansSettings();
  }

  public struct Cluster
  {
    public Vector2 Pos;
    public float Sum;
  }
}
