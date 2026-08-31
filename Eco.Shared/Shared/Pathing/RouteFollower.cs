// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.RouteFollower
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Pathing;

public class RouteFollower
{
  public Route Route { get; }

  public double StartTime { get; }

  public Vector3 StartPosition { get; }

  public Vector3 TargetPosition { get; }

  public RouteFollower(Route route, double startTime);

  public RouteFollower();

  public float PercentThrough { get; }

  public float TotalDistance { get; }

  public float TravelTime { get; }

  public float EndTime { get; }

  public double Arrivaltime { get; }

  public IEnumerable<Vector3> GetRoutePoints();

  public void Reset();

  /// <summary>Returns previous waypoint, next waypoint and index of next waypoint.</summary>
  /// <param name="lookAhead">Add time here to look into the future.</param>
  public (PathSegment Before, PathSegment After, int Index) WaypointsAtTime(float lookAhead = 0.0f);

  /// <summary> Take the expected position at given time.</summary>
  /// <param name="lookAhead">Offset distance is adding to a calculated position.</param>
  public virtual Vector3 Position(float lookAhead = 0.0f);

  /// <summary> Take the expected position at given time.</summary>
  /// <param name="lookAhead">Offset distance is adding to a calculated position.</param>
  public virtual Vector3 PositionSmooth(float lookAhead = 0.0f);

  public Vector3 DesiredDirection(float lookAhead = 0.0f);

  public Vector3 DesiredVelocity { get; }

  public float RunningSpeed { get; }

  public float DesiredSpeed { get; }

  public float DesiredRotationSpeed { get; }

  public IEnumerable<(Vector3 Value, string Desc)> RouteAndDesc { get; }

  public void ToBSON(BSONObject obj, INetObjectViewer viewer);

  public bool FromBSON(BSONObject obj, INetObjectViewer viewer);
}
