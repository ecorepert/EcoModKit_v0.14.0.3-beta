// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.PluginsController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.WebServer.DataTransferObjects.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

/// <summary>
/// The API controller in charge of the plugins and config.
/// </summary>
[Route("api/v1/plugins")]
[Authorize(Policy = "RequireAdmin")]
public class PluginsController : Controller
{
  [HttpGet("config/{name}")]
  public IActionResult GetPluginConfig(string name);

  /// <summary>Sets the configuration options for the given plugin.</summary>
  /// <param name="name">The name of the plugin.</param>
  /// <param name="body">New plugin config.</param>
  [HttpPost("config/{name}")]
  public void PostPluginConfig(string name, [FromBody] JObject body);

  /// <summary>
  /// Gets the list and status of all running plugins on the server.
  /// </summary>
  [HttpGet]
  [AllowAnonymous]
  public IEnumerable<PluginInfoV1> GetPlugins();

  [HttpGet("web")]
  [AllowAnonymous]
  public IEnumerable<WebPluginInfoV1> GetWebPlugins();
}
