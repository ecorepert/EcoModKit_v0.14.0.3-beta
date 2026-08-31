// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.ChatController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.WebServer.DataTransferObjects.V1;
using Eco.WebServer.Results;
using Eco.WebServer.Web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

/// <summary>MVC <seealso cref="T:Microsoft.AspNetCore.Mvc.Controller" /> instance for accessing and interacting with the Eco server Chat system.</summary>
[Route("api/v1/chat")]
[Authorize(Policy = "RequireAdmin")]
public class ChatController : Controller
{
  /// <summary>Returns all non-private player chat messages sent within the given time range.</summary>
  /// <param name="startDay">The lower bound on the time range. Default is 0.</param>
  /// <param name="endDay">The upper bound on the time range. Default is now.</param>
  [HttpGet("")]
  public JsonStreamResult GetChat(double startDay = 0.0, double endDay = -1.0);

  /// <summary>Returns all non-private player chat messages sent to the given tag within the given time range.</summary>
  /// <param name="tag">The tag name in question.</param>
  /// <param name="startDay">The lower bound on the time range. Default is 0.</param>
  /// <param name="endDay">The upper bound on the time range. Default is now.</param>
  [HttpGet("tag")]
  public JsonStreamResult GetChatByTag(string tag, double startDay = 0.0, double endDay = -1.0);

  /// <summary>Returns all non-private chat messages sent by the given user within the given time range.</summary>
  /// <param name="username">The user in question.</param>
  /// <param name="startDay">The lower bound on the time range. Default is 0.</param>
  /// <param name="endDay">The upper bound on the time range. Default is now.</param>
  [HttpGet("{username}")]
  public JsonStreamResult GetChatMessagesSentBy(string username, double startDay = 0.0, double endDay = -1.0);

  /// <summary>Gets the. <code>numNextMessages</code> chat messages sent after the given message on the same tag.</summary>
  /// <param name="message">The message in question.</param>
  /// <param name="numNextMessages">The number of following messages to return.</param>
  [HttpPost("next")]
  public JsonStreamResult GetNext([FromBody] ChatMessageV1 message, [FromQuery] int numNextMessages);

  /// <summary>Gets the. <code>numPreviousMessages</code> chat messages sent before the given message on the same tag.</summary>
  /// <param name="message">The message in question.</param>
  /// <param name="numPreviousMessages">The number of preceding messages to return.</param>
  [HttpPost("previous")]
  public JsonStreamResult GetPrevious([FromBody] ChatMessageV1 message, [FromQuery] int numPreviousMessages);

  /// <summary>Sends a chat message attributed to the named user. Requires admin auth (inherited from the controller-level policy).
  /// If the message is a command (starts with '/'), it executes at the impersonated user's actual auth level — no
  /// privilege elevation happens here. To run admin commands remotely, use <c>/api/v1/command/exec</c> instead.</summary>
  /// <param name="message">The message to send.</param>
  /// <param name="username">User to attribute the message to. Must already exist.</param>
  [DebugCall]
  [HttpGet("sendChat")]
  public IActionResult SendChat(string username, string message);
}
