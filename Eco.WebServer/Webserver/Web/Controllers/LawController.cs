// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Controllers.LawController
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

/// <summary> The API controller in charge of the law system. </summary>
[Route("api/v1/laws")]
[CustomSerializers]
public class LawController : Controller
{
  /// <summary> Returns all laws currently present in the game in the specified states, active by default.</summary>
  [AllowAnonymous]
  [HttpGet("byStates/{states}")]
  public IEnumerable<LawV1> List(string states);

  /// <summary> Returns all laws currently present in the game </summary>
  [AllowAnonymous]
  [HttpGet("")]
  public IEnumerable<LawV1> ListAll();

  [AllowAnonymous]
  [HttpGet("districtmap/{name}")]
  public DistrictMapV1 GetDistrictMap(string name);

  /// <summary> Returns the law with the specified id. </summary>
  [AllowAnonymous]
  [HttpGet("{id}")]
  public LawV1 GetLaw(int id);

  /// <summary> Genereate test laws. </summary>
  [HttpPost("generatetestdata")]
  [Authorize(Policy = "RequireDev")]
  public void GenerateTestData();
}
