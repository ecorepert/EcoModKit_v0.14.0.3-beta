// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.MapV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Services;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class MapV1
{
  public string layerSelected { get; set; }

  public int frame { get; set; }

  public double timeStart { get; set; }

  public double timeEnd { get; set; }

  public double playSpeed { get; set; }

  public double currentTime { get; set; }

  public bool flat { get; set; }

  public bool pause { get; set; }

  public Vector3V1 camPos { get; set; }

  public MapV1();

  public MapV1(Map other);

  public Map Convert();
}
