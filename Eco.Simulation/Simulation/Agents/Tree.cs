// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.Tree
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Simulation.Types;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Simulation.Agents;

[Serialized]
[Tag("Choppable")]
public abstract class Tree : Plant, INetObjectPosition, INetObject, IPositionAndBounds
{
  [Serialized]
  protected TreeBranch[] branches;
  [Serialized]
  protected float stumpHealth;
  [Serialized]
  protected float health;
  [Serialized]
  protected float rotation;
  [Serialized]
  protected float scaleRandomValue;

  public TreeSpecies Species { get; }

  public abstract IEnumerable<Vector3> TrunkPositions { get; }

  protected NetObject NetObj { get; set; }

  public int ID { get; }

  public bool Active { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }

  public double NetObjectCreationRealtime { get; set; }

  public Rect Bounds { get; }

  /// <inheritdoc cref="P:Eco.Simulation.Agents.Organism.WorldHomePos" />
  public override Vector2i WorldHomePos { get; }

  public bool Fallen { get; }

  public bool IsStump { get; }

  public bool IsSapling { get; }

  public virtual float SaplingGrowthPercent { get; }

  protected Tree();

  public Tree(TreeSpecies species, WorldPosition3i position, PlantPack plantPack);

  public virtual void Initialize();

  /// <summary> Base method to execute tree fall sequence. On Base abstract tree its regular destroy </summary>
  public virtual void FellTree(INetObject killer);

  protected void InitializeScale();

  public override bool WillDecay { get; }

  public override void Destroy();

  public static bool TreeRootsBlockDigging(WrappedWorldPosition3i blockPosition);

  public override string NetTrafficCategory { get; }

  public virtual void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);

  public void ReceiveInitialState(BSONObject bsonObj);

  public virtual void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer);

  public virtual void ReceiveUpdate(BSONObject bsonObj);

  public virtual bool IsRelevant(INetObjectViewer viewer);

  public virtual bool IsNotRelevant(INetObjectViewer viewer);

  public virtual bool IsUpdated(INetObjectViewer viewer);

  [Eco.Shared.Serialization.OnDeserialized]
  protected void OnDeserialized();
}
