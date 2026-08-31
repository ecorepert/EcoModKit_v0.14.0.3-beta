// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.Route
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Pathing;

/// <summary>An immutable set of line segments determining a path. All routes must have at least two waypoints for start/finish.</summary>
public readonly struct Route
{
  public readonly PathSegment[] Waypoints;
  public readonly TraversalData TraversalData;
  public readonly Vector3 StartingFacingDir;
  public readonly bool IsSmoothened;

  public float TotalDistance { get; }

  public float TravelTime();

  public Vector3 EndPosition { get; }

  public Vector3 EndDirection { get; }

  public Vector3 StartPosition { get; }

  public Vector3 StartDirection { get; }

  public bool IsValid { get; }

  public Route(
    TraversalData traversal,
    Vector3 facing,
    PathSegment[] pathSegments,
    bool isSmoothened);

  /// <summary>Creates a new route that is an exact copy of this route, but with delay added to start.</summary>
  /// <param name="delay">Start of the route is delayed by this number of seconds by adding them to initial rotation time.</param>
  /// <remarks>If delay is set to 0 this method just retuns this instance of Route.</remarks>
  public Route WithDelay(float delay);

  /// <summary>Adding a start value, allows us to start searching for the next waypoint midway through the path.</summary>
  public (PathSegment Before, PathSegment After, int Index) WaypointsAtTime(float time, int start = 0);

  /// <summary>Finds <see cref="T:Eco.Shared.Pathing.PathSegment" /> index covering <paramref name="time" /> starting at path segment with index <paramref name="start" />.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int FindPathSegmentIndexAtTime(float time, int start = 0);

  public Route(ReadOnlySpan<byte> bytes);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void CheckPointsWrappedProperly(Vector3[] pts);

  public byte[] ToBytes();
}
