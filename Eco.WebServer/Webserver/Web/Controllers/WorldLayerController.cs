// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.WorldLayerController
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.WebServer.DataTransferObjects.V1.WorldLayers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

#nullable enable
namespace Eco.WebServer.Web.Controllers;

/// <summary>
/// The API controller that exposes world layers and their relationships.
/// </summary>
[Route("api/v1/worldlayers")]
[AllowAnonymous]
public class WorldLayerController : Controller
{
  /// <summary>Enumerates every world layer in the simulation.</summary>
  /// <returns>A list of all layers in the simulation.</returns>
  [HttpGet("layers")]
  public 
  #nullable disable
  IEnumerable<WorldLayerGroupV1> ListLayers();

  /// <summary>
  /// Enumerates the layers that should be displayed when the user is focused on a particular layer and world area.
  /// </summary>
  /// <param name="focusLayer">Name of the layer we're querying.</param>
  /// <param name="minX">The least x boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="minY">The least y boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="maxX">The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="maxY">The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <returns>
  /// An array of structures describing the layers that should be displayed.
  /// </returns>
  [HttpGet("layers/{focusLayer}")]
  public IEnumerable<WorldLayerV1> ListRelevantLayers(
    string focusLayer,
    [FromQuery] float minX = -1f,
    [FromQuery] float minY = -1f,
    [FromQuery] float maxX = -1f,
    [FromQuery] float maxY = -1f);

  /// <summary>Describes the area selected with a string.</summary>
  /// <param name="minX">The least x boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="minY">The least y boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="maxX">The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="maxY">The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <returns>An string describing the requested area.</returns>
  [HttpGet("relationships/areadescription")]
  public string AreaDescription([FromQuery] float minX = -1f, [FromQuery] float minY = -1f, [FromQuery] float maxX = -1f, [FromQuery] float maxY = -1f);

  /// <summary>
  /// Enumerates the layer relationships that should be displayed when the user is focused on a particular layer and world area.
  /// </summary>
  /// <param name="focusLayer">The name of the focused layer.</param>
  /// <param name="minX">The least x boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="minY">The least y boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="maxX">The greatest x boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <param name="maxY">The greatest y boundary of the viewed area, in world coordinates.  Should not be wrapped.</param>
  /// <returns>
  /// An array of structures describing the layer relationships that should be displayed.
  /// </returns>
  [HttpGet("relationships/{focusLayer}")]
  public IEnumerable<LayerRelationshipV1> ListRelevantRelationships(
    string focusLayer,
    [FromQuery] float minX = -1f,
    [FromQuery] float minY = -1f,
    [FromQuery] float maxX = -1f,
    [FromQuery] float maxY = -1f);
}
