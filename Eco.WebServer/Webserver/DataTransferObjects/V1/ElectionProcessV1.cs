// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.ElectionProcessV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Civics;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class ElectionProcessV1 : SimpleEntryV1
{
  public LocString[,] Table;

  public string[] OccupantNames { get; set; }

  public ElectionProcessV1();

  public ElectionProcessV1(ElectionProcess process);
}
