// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.SpreadWorldLayer
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

[Serialized]
public class SpreadWorldLayer : WorldLayer
{
  public WorldLayer BaseLayer;
  public WorldLayer HeightLayer;
  public Func<Vector2i, float, float> TransformFunc;

  public SpreadLayerSettings SpreadSettings { get; }

  public override Type SettingsType { get; }

  public float BaseOrSpreadEntry(int x, int y);

  public float BaseOrSpreadEntry(Vector2i pos);

  protected override void TickSelf();

  protected override void PostLoadSelf();
}
