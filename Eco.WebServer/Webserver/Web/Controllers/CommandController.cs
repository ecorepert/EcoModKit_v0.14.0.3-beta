// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.CommandController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.WebServer.DataTransferObjects.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Web.Controllers;

/// <summary>MVC <seealso cref="T:Microsoft.AspNetCore.Mvc.Controller" /> instance for accessing and interacting with the Eco server chat commands.</summary>
[Route("api/v1/command")]
[Authorize(Policy = "RequireAdmin")]
public class CommandController : Controller
{
  /// <summary>Executes a chat command on the server.</summary>
  [HttpPost("exec")]
  public 
  #nullable disable
  Task<CommandResultV1> ExecCommand([FromBody] ExecuteCommandV1 dto);
}
