// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.Organism
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation.Types;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Agents;

[Serialized]
public abstract class Organism : Tickable
{
  /// <summary> Born time in <see cref="P:Eco.Simulation.Time.WorldTime.Seconds" />. </summary>
  [Serialized]
  public double BornTime { get; set; }

  public virtual Species Species { get; protected set; }

  /// <summary>Home position is a position where it was spawned by simulation, it may be different from Position if Organism moved</summary>
  public virtual Vector2i WorldHomePos { get; }

  [Serialized]
  public float YieldPercent { get; set; }

  [Serialized]
  public virtual float GrowthPercent { get; set; }

  public float ClientBasedGrowthPercent { get; }

  [Serialized]
  public bool Dead { get; set; }

  [Serialized]
  public DeathType DeadType { get; set; }

  [Serialized]
  public virtual Vector3 Position { get; set; }

  [Serialized]
  public Vector3 Direction { get; set; }

  public bool Alive { get; }

  protected Organism();

  public Organism(Species species);
}
