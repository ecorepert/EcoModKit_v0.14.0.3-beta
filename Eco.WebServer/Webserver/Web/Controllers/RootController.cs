// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.RootController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Networking;
using Eco.WebServer.DataTransferObjects.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

#nullable enable
namespace Eco.WebServer.Web.Controllers;

/// <summary>Root Controller for the Eco Game API.</summary>
[Produces("application/json", new string[] {})]
[AllowAnonymous]
public class RootController : Controller
{
  [HttpGet("info")]
  public 
  #nullable disable
  ServerInfo GetInfo();

  [HttpGet("frontpage")]
  public FrontPageV1 FrontPage();

  /// <summary>Returns the server's configured administrative users.</summary>
  [HttpGet("admins")]
  public IEnumerable<string> GetAdmins();

  /// <summary>Return if the user is an admin and authentication is required.</summary>
  [HttpGet("isadmin")]
  public bool IsAdmin();
}
