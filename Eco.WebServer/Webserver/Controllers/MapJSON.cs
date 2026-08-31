// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Controllers.MapJSON
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Controllers;

public class MapJSON
{
  public string DistrictSuffix;
  public List<string[]> LayerNames;
  public Dictionary<string, List<Vector2i>> Plots;

  public float WaterLevel { get; }

  public double WorldTime { get; }
}
