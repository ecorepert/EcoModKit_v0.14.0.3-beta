// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.GroundPolluterContainer
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.World.Blocks;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public class GroundPolluterContainer
{
  public int ParentId;
  public float Soil;
  public float HeavyMineral;
  public float Chemical;

  public GroundPolluterContainer(int parentId);

  public float Get(GroundPollutionType type);
}
