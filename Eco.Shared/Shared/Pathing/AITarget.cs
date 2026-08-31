// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.AITarget
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Pathing;

public class AITarget
{
  public TraversalData TraversalData { get; }

  public double NextTick { get; }

  /// <summary>Stop moving along any routes, and clear targets.</summary>
  public void Clear();

  public RouteFollower RouteFollower { get; }

  public Vector3? OverridePos { get; }

  public int TargetObjID { get; }

  public Vector3 Position(float timeOffset = 0.0f);

  public float RunningSpeed { get; }

  public float PathingRotationSpeed { get; }

  public float DesiredSpeed { get; }

  public double ArrivalTime { get; }

  public float TravelTime();

  public double StartTime();

  public IEnumerable<Vector3> Route { get; }

  public IEnumerable<(Vector3 Route, string Desc)> RouteAndDesc { get; }

  /// <summary> Returns either the target object position (if available) and updates <see cref="F:Eco.Shared.Pathing.AITarget.targetPos" /> to last known position or returns <see cref="F:Eco.Shared.Pathing.AITarget.targetPos" /> with fallback to default value otherwise. </summary>
  public Vector3? TargetPosition { get; }

  public Vector3 DesiredVelocity { get; }

  public bool HasLookTarget { get; }

  /// <summary> Returns <paramref name="targetObj" /> if it is set and available in <see cref="T:Eco.Shared.Networking.NetObjectManager" />. </summary>
  public bool TryGetTargetObject(out INetObjectPosition targetObj);

  public Vector3 DesiredDirection(float lookAhead = 0.0f);

  /// <summary>Sets route this agent will follow.</summary>
  /// <param name="targetOrganism">Object this agent should be looking at when following the route.</param>
  /// <param name="delay">Start of the route is delayed by this number of seconds by adding them to initial rotation time.</param>
  public void SetRoute(Eco.Shared.Pathing.Route route, INetObjectPosition targetOrganism = null, float delay = 0.0f);

  public void SetFacing(Vector3 dir);

  /// <summary> Clear the route and set the position as passed. </summary>
  public void SetPosition(Vector3 pos);

  /// <summary> Sets look to <paramref name="followingTarget" />. If <paramref name="followingTarget" /> is null then resets look target. </summary>
  public void SetLook(INetObjectPosition followingTarget);

  /// <summary> Sets look to fixed <paramref name="pos" />. </summary>
  public void SetLook(Vector3i pos);

  public string Describe();

  public BSONObject ToBSON(INetObjectViewer viewer);

  public void FromBSON(BSONObject obj, INetObjectViewer viewer);
}
