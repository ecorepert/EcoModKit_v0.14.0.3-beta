// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.StatsController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Stats;
using Eco.WebServer.Web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Web.Controllers;

/// <summary> The API controller in charge of anything stats-y. </summary>
[Route("datasets")]
[CustomSerializers]
[AllowAnonymous]
public class StatsController : Controller
{
  /// <summary>/// Returns the timerange of the simulation, in days///. </summary>
  [HttpGet("timerange")]
  public IEnumerable<float> GetTimeRange();

  /// <summary> Returns all dataset keys, formatted as a tree. ///. </summary>
  [HttpGet("treelist")]
  public StatCategory GetTreeList();

  /// <summary> /// Returns all stat infos that contain data, formatted as a list, where each key is a list of strings. ///. </summary>
  [HttpGet("flatlist")]
  public IEnumerable<StatInfo> GetFlatList();

  /// <summary> /// Returns <see cref="F:Eco.WebServer.Web.Controllers.StatsController.MaximumSamples" /> data points between <paramref name="dayStart" /> and <paramref name="dayEnd" /> of the selected data.
  /// If there are more than <see cref="F:Eco.WebServer.Web.Controllers.StatsController.MaximumSamples" /> samples, it will be averaged out to contain exactly <see cref="F:Eco.WebServer.Web.Controllers.StatsController.MaximumSamples" />.///. </summary>
  /// <param name="dataset">dataset to take the data from.</param>
  /// <param name="dayStart">Day from which on data is returned. Default is 0.</param>
  /// <param name="dayEnd">Day until which data is returned. Default is now.</param>
  /// <returns>A list of floats that returns the data. Might be averaged out if there were too many data points.</returns>
  [HttpGet("get")]
  public ActionResult<StatReturn> Get([FromQuery] string dataset, [FromQuery] double dayStart = 0.0, [FromQuery] double dayEnd = -1.0);

  /// <summary> Returns a "package" of multiple statistics in the order of their request. </summary>
  /// <param name="dayStart">Day from which the data should be taken from. Default is 0.</param>
  /// <param name="dayEnd">Day until which data is returned. Default is now.</param>
  /// <param name="requestedSets">A list of statistics that should be returned.</param>
  /// <returns>The statistics to each of the sets, in the order of their request; unknown stats yield an empty entry (null arrays, zero interval).</returns>
  [HttpGet("getlist")]
  public IEnumerable<StatReturn> GetList(
    [FromQuery] List<string> requestedSets,
    [FromQuery] double dayStart = 0.0,
    [FromQuery] double dayEnd = -1.0);

  /// <summary> Returns the list of premade graphs to be displayed on the front page. </summary>
  [HttpGet("graphs")]
  public List<NamedGraph> Graphs();

  /// <summary>Generates fake stat data for testing.</summary>
  /// <param name="days">The number of days to simulate.</param>
  /// <param name="users">The number of users to simulate.</param>
  /// <param name="generateClimateData">Whether to generate climate data. Default is false.</param>
  /// <param name="pollutionMultiplier">How much pollution to generate. Default is 1.</param>
  /// <returns></returns>
  [DebugCall]
  [HttpGet("generatetestdata")]
  public IActionResult GenerateTestData(
    float days,
    int users,
    bool generateClimateData = false,
    float pollutionMultiplier = 1f);
}
