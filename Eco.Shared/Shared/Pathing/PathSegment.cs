// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.PathSegment
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils.Binary;
using System;
using System.IO;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Pathing;

/// <summary>A waypoint along the route.</summary>
/// <remarks>WARNING: This struct must match exactly the AIPathSegment struct in AnimalAITargetSystem, change both if you edit.</remarks>
public readonly struct PathSegment : IEquatable<PathSegment>
{
  public readonly Vector3 EndPos;
  public readonly Vector3 EndDir;
  public readonly float DistanceSoFar;
  public readonly float AngleDelta;
  public readonly float TimeSoFar;
  public readonly float TurningTime;
  public readonly Vector3 ArcCenter;
  public readonly float ArcRadius;
  public readonly Vector3 ArcEnterPos;
  public readonly PathSegment.MovementType Movement;
  public readonly WaypointFlags Flags;

  public PathSegment(
    PathSegment.MovementType movement,
    float distanceSoFar,
    float angleDelta,
    Vector3 dir,
    float timeSoFar,
    float turningTime,
    Vector3 position,
    Vector3 arcCenter,
    Vector3 arcEnterPos,
    float arcRadius,
    WaypointFlags flags);

  public PathSegment(
    float distanceSoFar,
    float angleDelta,
    Vector3 dir,
    float timeSoFar,
    float turningTime,
    Vector3 position,
    WaypointFlags flags);

  public string DebugDesc { get; }

  public override string ToString();

  public override bool Equals(object obj);

  public bool Equals(PathSegment other);

  public override int GetHashCode();

  public static bool operator ==(PathSegment left, PathSegment right);

  public static bool operator !=(PathSegment left, PathSegment right);

  public void ToBytes(BinaryWriter writer);

  public static PathSegment FromBytes(ref ByteSpanReader reader);

  public enum MovementType
  {
    Idle,
    Straight,
    Step,
    Arc,
    TurnOnPlace,
  }
}
