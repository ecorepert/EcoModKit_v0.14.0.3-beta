// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.WorldLayers.LayerRelationshipDTOUtil
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1.WorldLayers;

public static class LayerRelationshipDTOUtil
{
  public static LayerRelationshipV1 GetDTO(
    this IWorldLayerRelationship relationship,
    WorldArea area = default (WorldArea));

  public static IEnumerable<string> AllLayers(this IWorldLayerRelationship relationship);

  public static IEnumerable<string> RelevantLayersForFocus(
    this IWorldLayerRelationship relationship,
    string focusedLayer);
}
