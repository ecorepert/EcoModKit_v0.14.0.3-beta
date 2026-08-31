// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.CivicActionV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Civics;
using Eco.Shared.Localization;
using Newtonsoft.Json;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class CivicActionV1
{
  public string ActionOnComplete { get; set; }

  public string ActionOnCompleteTableHeader { get; set; }

  [JsonProperty]
  public LocString[,] ActionOnCompleteTable { get; set; }

  public string ActionOnCompleteFullDescription { get; set; }

  public MapV1 DistrictMapBefore { get; set; }

  public MapV1 DistrictMapAfter { get; set; }

  public CivicActionV1();

  public CivicActionV1(CivicAction action);
}
