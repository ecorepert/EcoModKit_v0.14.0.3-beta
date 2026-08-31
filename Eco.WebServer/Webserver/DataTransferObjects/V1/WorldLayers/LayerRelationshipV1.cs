// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.WorldLayers.LayerRelationshipV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Shared.Math;
using Eco.Simulation.WorldLayers;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1.WorldLayers;

public class LayerRelationshipV1
{
  public string Name;
  public string RelationshipType;
  public string Output;
  public List<LayerInputV1> Inputs;
  public List<string> HiddenInputs;
  public string Tooltip;

  public string Guid { get; }

  public override string ToString();

  public LayerRelationshipV1(IWorldLayerInteraction interaction, WorldArea area);

  public LayerRelationshipV1(IWorldLayerPuller puller, WorldArea area);

  public LayerRelationshipV1(IWorldLayerPusher pusher, WorldArea area);

  public void Combine(IEnumerable<LayerRelationshipV1> outputsToInLayer);

  public void CullToRelevantLayers(HashSet<string> relevantLayers);
}
