// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.UsersController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.WebServer.DataTransferObjects.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

/// <summary> The API controller for collecting users by parameters. </summary>
[Route("api/v1/users")]
[Authorize(Policy = "RequireAdmin")]
public class UsersController : Controller
{
  [HttpGet("")]
  public List<UserV1> GetUsers(int hoursPlayedGte);
}
