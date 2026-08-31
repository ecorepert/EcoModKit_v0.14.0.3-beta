// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.AdminController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.WebServer.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Web.Controllers;

/// <summary>Admin Controller.</summary>
[Route("api/v1/admin")]
[Authorize(Policy = "RequireAdmin")]
public class AdminController : Controller
{
  /// <summary>Sets how accessible this server is.</summary>
  /// <param name="value">Can be 'public' (listed in server browser, no password), 'private' (listed in server browser, with password) or 'hidden' (unlisted, without password).</param>
  /// <param name="password">If setting private, must set a password. If not set to private, this is unused.</param>
  [HttpPost("set/access")]
  public void PostSetAccess(
  #nullable disable
  string value, string password);

  [HttpGet("get/access")]
  public string GetGetAccess();

  [HttpPost("set/servername")]
  public void PostSetServerName(string name);

  [AllowAnonymous]
  [HttpGet("get/servername")]
  public string GetGetServerName();

  [HttpPost("game/export")]
  public Task<AdminReturnModel> PostGameExport(ExportGameModel request);
}
