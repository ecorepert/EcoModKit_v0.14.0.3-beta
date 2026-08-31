// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.TreeBranch
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Serialization;
using Eco.Simulation.Types;

#nullable disable
namespace Eco.Simulation.Agents;

[Serialized]
public class TreeBranch
{
  [Serialized]
  public float Health { get; set; }

  [Serialized]
  public LeafBunch[] Leaves { get; set; }

  [Serialized]
  public double SpawnAge { get; }

  [Serialized]
  public double MatureAge { get; }

  [Serialized]
  public float Orientation { get; set; }

  public TreeBranch(float health, int numLeaves);

  public TreeBranch(TreeBranchDef branchDef);
}
