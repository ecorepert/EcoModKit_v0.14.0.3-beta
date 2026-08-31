// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.Animal
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Monitoring;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Simulation.Animals;
using Eco.Simulation.Types;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Agents;

public abstract class Animal : 
  Organism,
  INetObject,
  INetObjectPosition,
  IPositionAndBounds,
  INetTrafficCategory,
  ICanTakeDamage
{
  public static readonly ThreadSafeAction<Animal> PosUpdatedEvent;
  public static readonly ThreadSafeAction<Animal, INetObject> AnimalHuntedEvent;
  public readonly ThreadSafeAction<Animal> Destroyed;
  public string Behavior;
  public bool Male;
  public bool Sick;
  public bool Freeze;
  public int HerdID;
  public int ControllingPlayerID;

  public static void AlertNearbyAnimals(Vector3 position, float v);

  public int TargetNetID { get; }

  public float Health { get; set; }

  public List<NetEntity> AttachedEntities { get; set; }

  public NetworkChannel UpdateChannel { get; }

  public override double NextTick { get; set; }

  public double MinimumNextTick { get; set; }

  public Rect Bounds { get; }

  public Vector3 GroundPosition { get; }

  public AnimalSpecies Species { get; }

  public Herd Herd { get; }

  [Serialized]
  public DamageSourceType KillerSource { get; set; }

  protected Animal(AnimalSpecies species, Vector3 pos, bool dead, bool sick, int herdID);

  public override void Tick();

  public override void Destroy();

  public bool TryDamage(INetObject source, float amount, DamageSourceType sourceType);

  public void Die(DamageSourceType sourceType = DamageSourceType.Undefined);

  public void SetControllingPlayer(int id);

  public string NetTrafficCategory { get; }

  public int ID { get; }

  public bool Active { get; }

  public double NetObjectCreationRealtime { get; set; }

  public bool IsRelevant(INetObjectViewer viewer);

  public bool IsNotRelevant(INetObjectViewer viewer);

  public bool IsUpdated(INetObjectViewer viewer);

  public void SendInitialState(BSONObject obj, INetObjectViewer viewer);

  public void SendUpdate(BSONObject obj, INetObjectViewer viewer);

  public virtual void ReceiveUpdate(BSONObject bsonObj);

  public void ReceiveInitialState(BSONObject bsonObj);

  /// <summary>When an animal damages another.</summary>
  [RPC]
  public void TryDamageByAnimal(float amount);

  [RPC]
  public void KillAndDestroy(DamageSourceType sourceType);

  [RPC]
  public void Kill(DamageSourceType sourceType);

  [RPC]
  public void RequestPathAndUpdateState(
    string behavior,
    Vector3 animalpos,
    Vector3 animaldir,
    Vector3 desiredDirOfPath,
    PathfindFlags flags,
    float desiredDistanceMin,
    float desiredDistanceMax,
    AnimalSpecies species);

  [RPC]
  public void GetPathTo(
    string behavior,
    int targetNetID,
    Vector3 animalpos,
    Vector3 animalDir,
    Vector3 targetPos,
    PathfindFlags flags);

  [RPC]
  public void DoServerUpdateAnimalData(
    string behavior,
    Vector3 animalpos,
    Vector3 animaldir,
    bool doTeleport,
    bool notifyOthers);

  [RPC]
  public void EatFromHand(IWorldObserver observer);
}
