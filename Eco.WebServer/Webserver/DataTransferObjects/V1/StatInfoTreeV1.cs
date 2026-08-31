// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.StatInfoTreeV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class StatInfoTreeV1
{
  public LocString DisplayName { get; set; }

  public string KeyFragment { get; set; }

  public string Unit { get; set; }

  public List<StatInfoTreeV1> Children { get; set; }
}
