// Decompiled with JetBrains decompiler
// Type: Eco.Webserver.Web.Controllers.DataExportController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

#nullable disable
namespace Eco.Webserver.Web.Controllers;

[Route("api/v1/exporter")]
[Authorize(Policy = "RequireAdmin")]
public class DataExportController : Controller
{
  [HttpPost("all")]
  public void PostExportAll();

  [HttpPost("chat")]
  public void PostExportChat();

  [HttpPost("species")]
  public void PostExportSpecies();

  [HttpPost("environment")]
  public void PostExportEnvironment();

  [HttpPost("actions")]
  public void PostExportActions();

  [HttpGet("species")]
  public string GetExportSpecies(string speciesName);

  [HttpGet("environment")]
  public string GetExportEnvironment(string category, string units = "PPM", string column = "Climate");

  [HttpGet("actions")]
  public string GetExportAction(string actionName);

  [HttpGet("actionlist")]
  public string GetActionList();

  [HttpGet("specieslist")]
  public string GetSpeciesList();

  [HttpGet("environmentlist")]
  public string GetEnvironmentList();
}
