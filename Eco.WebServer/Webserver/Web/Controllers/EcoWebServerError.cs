// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.EcoWebServerError
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using System;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

public class EcoWebServerError : Exception
{
  public int StatusCode { get; }

  public EcoWebServerError(string message, int statusCode);
}
