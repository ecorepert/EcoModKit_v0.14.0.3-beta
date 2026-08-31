// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Types.TreeSpecies
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Items;
using Eco.Shared.Localization;
using Eco.Stats;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Types;

[Localized(true, false, "", false)]
[Tag("Tree")]
[Stat("Trees", Unit.Organisms, StatType.ContinuousValue)]
public abstract class TreeSpecies : PlantSpecies
{
  [LocCategory("1 Lifetime")]
  public float TreeHealth { get; set; }

  [LocCategory("1 Lifetime")]
  public float LogHealth { get; set; }

  [LocCategory("6 Visuals")]
  [LocDescription("List of ranges where the corresponding branches begin to grow, as well as the rate of their growth")]
  public List<TreeBranchDef> BranchingDef { get; set; }

  [LocCategory("6 Visuals")]
  public int TopBranchLeafPoints { get; set; }

  [LocCategory("6 Visuals")]
  public int TopBranchHealth { get; set; }

  /// <summary>When set will use the branch rotations in order instead of randomly, useful for putting branches at the same height in a circle around the tree.</summary>
  [LocCategory("6 Visuals")]
  public bool SequentialBranchRotations { get; set; }

  [LocCategory("6 Visuals")]
  public float[] BranchRotations { get; set; }

  [LocCategory("6 Visuals")]
  [LocDescription("If true, spawned trees will be rotated at a random angle.")]
  public bool RandomYRotation { get; set; }

  [LocCategory("6 Visuals")]
  [LocDescription("If not using fully random rotations, spawned trees will be one of these rotations.")]
  public float[] RandomRotations { get; set; }

  [LocCategory("6 Visuals")]
  [LocDescription("The number of branches this tree will have.")]
  public Eco.Shared.Math.Range BranchCount { get; set; }

  [LocCategory("5 Resources")]
  public float ChanceToSpawnDebris { get; set; }

  [LocCategory("5 Resources")]
  public Type DebrisType { get; set; }

  [LocCategory("5 Resources")]
  public Dictionary<Type, Eco.Shared.Math.Range> DebrisResources { get; set; }

  [LocCategory("5 Resources")]
  public Dictionary<Type, Eco.Shared.Math.Range> TrunkResources { get; set; }

  public Eco.Shared.Math.Range XZScaleRange { get; set; }

  public Eco.Shared.Math.Range YScaleRange { get; set; }

  public float Density { get; set; }
}
