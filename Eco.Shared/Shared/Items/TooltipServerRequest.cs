// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipServerRequest
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Represents a request for contents of several tooltip parts.</summary>
public struct TooltipServerRequest
{
  /// <summary>If request is sent because tooltip is being opened for some specific view this should contain this view's ControllerID. Otherwise should be 0.</summary>
  public int MainTargetControllerID;
  /// <summary>If request is sent because tooltip is being opened for some specific view this should contain this view type's ID. Otherwise should be 0.</summary>
  public int MainTargetTypeID;
  /// <summary>Requests for specific tooltip parts.</summary>
  public List<TooltipPartServerRequest> PartRequests;

  public TooltipServerRequest(
    int mainTargetControllerID,
    int mainTargetTypeID,
    List<TooltipPartServerRequest> partRequests);
}
