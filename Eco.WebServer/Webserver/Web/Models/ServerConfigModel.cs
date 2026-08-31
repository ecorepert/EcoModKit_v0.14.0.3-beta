// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Models.ServerConfigModel
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

#nullable disable
namespace Eco.WebServer.Web.Models;

public class ServerConfigModel
{
  public string Name { get; set; }

  public string UserId { get; set; }

  public bool IsPublic { get; set; }
}
