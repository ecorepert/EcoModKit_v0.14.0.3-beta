// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.DistrictV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.LegislationSystem;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class DistrictV1
{
  public byte ID { get; set; }

  public string Name { get; set; }

  public int R { get; set; }

  public int G { get; set; }

  public int B { get; set; }

  public DistrictV1();

  public DistrictV1(District gameplayObj);

  public District Convert();
}
