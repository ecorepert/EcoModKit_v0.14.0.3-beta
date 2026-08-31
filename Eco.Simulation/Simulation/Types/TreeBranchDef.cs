// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Types.TreeBranchDef
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System.ComponentModel;

#nullable disable
namespace Eco.Simulation.Types;

[TypeConverter(typeof (ExpandableObjectConverter))]
public struct TreeBranchDef
{
  public string Name { get; set; }

  public float Health { get; set; }

  public Range GrowthStartTime { get; set; }

  public Range GrowthEndTime { get; set; }

  public int LeafPoints { get; set; }

  public override string ToString();
}
