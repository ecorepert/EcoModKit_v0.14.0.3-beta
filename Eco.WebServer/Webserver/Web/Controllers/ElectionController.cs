// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.ElectionController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Core.Tests;
using Eco.Shared.Items;
using Eco.WebServer.DataTransferObjects.V1;
using Eco.WebServer.Web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

/// <summary> The API controller in charge of the election system. </summary>
[Route("api/v1/elections")]
public class ElectionController : Controller
{
  /// <summary> Returns all elected titles and their occupants matching the given state (active by default). </summary>
  [HttpGet("titles")]
  [AllowAnonymous]
  public IEnumerable<ElectedTitleV1> ListElectedTitles(ProposableState state = ProposableState.Active);

  /// <summary> Returns all elections that are either active or inactive.</summary>
  [HttpGet("")]
  [AllowAnonymous]
  public IEnumerable<GameServerElectionV1> ListElections(bool returnActive = true);

  /// <summary>Returns the election with the given id. </summary>
  [HttpGet("{id}")]
  [AllowAnonymous]
  public ActionResult<GameServerElectionV1> GetElectionById(int id);

  /// <summary>Returns the elected title with the given id. </summary>
  [HttpGet("titles/{id}")]
  [AllowAnonymous]
  public ActionResult<ElectedTitleV1> GetElectedTitleById(int id);

  /// <summary> Returns a list of votes that were made on the indicated election.
  /// If a user is logged in their own votes will be revealed when voting is anonymous. </summary>
  [HttpGet("votes")]
  [AllowAnonymous]
  public List<RunoffVoteV1> Votes([FromQuery] int id);

  /// <summary> Places a vote on behalf of the given player.  Can only be called if an election is currently running. </summary>
  /// <param name="vote">The player's vote.  Must contain a ranked list of all candidates for the current election.</param>
  /// <param name="forceVote">Force vote ignoring election process.</param>
  /// <returns>A failure code if the vote is invalid, the player is not authorized, or the vote cannot be placed for another reason.</returns>
  [HttpPost("vote")]
  [Authorize("RequiresEcoUser")]
  public void Vote([FromBody] RunoffVoteV1 vote, [FromQuery] bool forceVote);

  /// <summary> Forces the currently running election to end now, and for the current election winner to become the leader. Can only be called by an admin or dev. </summary>
  /// <param name="electionId">ID of the election.</param>
  [HttpPost("forceelectionend")]
  [Authorize(Policy = "RequireAdmin")]
  public void ForceElectionEnd([FromQuery] int electionId);

  /// <summary> Adds a comment to the currently running election, if any. </summary>
  /// <param name="comment">The comment to be added to the election.</param>
  /// <param name="electionId">ID of the election.</param>
  [HttpPost("addcomment")]
  [Authorize("RequiresEcoUser")]
  public void AddComment([FromBody] ElectionCommentV1 comment, [FromQuery] int electionId);

  /// <summary> List comments on the election. </summary>
  /// <param name="electionId">ID of the election.</param>
  [HttpGet("listcomments")]
  [AllowAnonymous]
  public IEnumerable<ElectionCommentV1> GetComments([FromQuery] int electionId);

  /// <summary> Spawn a whole government with some test elections.</summary>
  [CITest(false)]
  [DebugCall]
  [HttpPost("generatetestgovernment")]
  public IActionResult GenerateTestGovernment();

  /// <summary>Spawn some test elections with citizen and twitch votes both. The provision data for these elections will be blank.</summary>
  [CITest(false)]
  [DebugCall]
  [HttpPost("generatetestdata")]
  public IActionResult GenerateTestElections(int addUserVotes = 2, int addTwitchVotes = 5);

  [CITest(false)]
  [DebugCall]
  [HttpPost("finishelection")]
  public IActionResult FinishElection();
}
