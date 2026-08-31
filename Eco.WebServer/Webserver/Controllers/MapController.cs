// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Controllers.MapController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Math;
using Eco.Simulation.Types;
using Eco.WebServer.DataTransferObjects.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.Controllers;

/// <summary>
/// The API controller in charge of the map and entities found on it.
/// </summary>
[Route("api/v1/map")]
[AllowAnonymous]
public class MapController : Controller
{
  public static IEnumerable<Species> AllSpecies { get; }

  [HttpGet("mapstats")]
  public MapStatsV1 MapStats();

  /// <summary>
  /// Allows access to all species currently available in the simulation.
  /// </summary>
  /// <returns>A list of all species.</returns>
  [HttpGet("entitytypes")]
  public IEnumerable<string> EntityTypes();

  /// <summary>
  /// Allows access to all entities currently available in the simulation.
  /// </summary>
  /// <param name="entityTypes">A list of user type names that will be used to filter the response.</param>
  /// <param name="states">A list of Animal states that will be used to filter the response.</param>
  /// <returns>A list of the positions of all organisms.</returns>
  [HttpGet("entities")]
  public IEnumerable<EntityV1> Entities([FromQuery] string[] entityTypes, [FromQuery] string[] states);

  /// <summary>Returns the dimension of the world, in blocks.</summary>
  /// <returns>The world size as vector3.</returns>
  [HttpGet("dimension")]
  public Vector3i GetDimension();

  /// <summary>List Layer Names.</summary>
  /// <returns>A list of all layers.</returns>
  [HttpGet("layerList")]
  public IEnumerable<string> LayerList();

  /// <summary>One request to get all required web map data.</summary>
  /// <returns>layer names, property list, water level, world time and district maps.</returns>
  [HttpGet("map.json")]
  public IActionResult MakeMapJSON();

  /// <summary>Get water height.</summary>
  /// <returns>Water Level.</returns>
  [HttpGet("waterLevel")]
  public float WaterLevel();

  [HttpGet("property")]
  public IActionResult GetProperty();
}
