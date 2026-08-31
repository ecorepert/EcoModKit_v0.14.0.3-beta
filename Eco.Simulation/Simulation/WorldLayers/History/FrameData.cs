// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.History.FrameData
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Simulation.WorldLayers.History;

public sealed class FrameData : Array2D<byte>, IDisposable
{
  public int X;
  public int Y;

  public int Width { get; }

  public int Height { get; }

  public FrameData(int width, int height);

  public FrameData GetWindow(int xMin, int yMin, int xMax, int yMax);

  public void Dispose();
}
