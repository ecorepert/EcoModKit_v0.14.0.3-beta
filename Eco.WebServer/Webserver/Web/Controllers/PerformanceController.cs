// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.PerformanceController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

/// <summary>
/// The API controller in charge of the plugins and config.
/// </summary>
[Route("api/v1/performance")]
[Authorize(Policy = "RequireAdmin")]
public class PerformanceController : Controller
{
  [HttpGet("performanceReport")]
  public string GetNetworkReport();
}
