// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.LeafBunch
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Simulation.Agents;

[Serialized]
public class LeafBunch
{
  [Serialized]
  public float Health { get; set; }

  [Serialized]
  public int BunchType { get; set; }
}
