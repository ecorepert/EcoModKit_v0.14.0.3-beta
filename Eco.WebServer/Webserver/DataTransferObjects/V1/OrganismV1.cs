// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.OrganismV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Simulation.Agents;
using System.Numerics;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class OrganismV1 : EntityV1
{
  public int Id { get; }

  public float Age { get; }

  public OrganismV1(Organism organism, Vector3 pos);
}
