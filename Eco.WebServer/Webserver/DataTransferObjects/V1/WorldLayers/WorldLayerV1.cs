// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.WorldLayers.WorldLayerV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1.WorldLayers;

public class WorldLayerV1
{
  public string LayerName { get; set; }

  public string LayerDisplayName { get; set; }

  public string Summary { get; set; }

  public string Tooltip { get; set; }

  public override string ToString();

  public string Category { get; set; }

  public int DisplayRow { get; set; }

  public WorldLayerV1(WorldLayer layer, WorldArea area = default (WorldArea));
}
