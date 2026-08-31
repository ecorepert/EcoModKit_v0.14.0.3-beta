// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.PoissonDiscSampler
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System;
using System.Collections.Generic;
using System.Drawing;

#nullable enable
namespace Eco.WorldGenerator;

public class PoissonDiscSampler
{
  /// Create a sampler with the following parameters:
  ///             
  ///              width:  each sample's x coordinate will be between [0, width]
  ///              height: each sample's y coordinate will be between [0, height]
  ///              radius: each sample will be at least `radius` units away from any other sample, and at most 2 * `radius`.
  public PoissonDiscSampler(int width, int height, float radius, 
  #nullable disable
  Random r);

  public IEnumerable<PointF> Samples();

  /// Helper struct to calculate the x and y indices of a sample in the grid
  private struct GridPos
  {
    public int x;
    public int y;

    public GridPos(PointF sample, float cellSize);
  }
}
