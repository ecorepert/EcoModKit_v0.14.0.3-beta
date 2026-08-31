// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.Path
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Pathing;

public sealed class Path : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public Vector3[] Waypoints;

  public Path();

  public Path(IEnumerable<Vector3> waypoints);

  /// <summary>Function to get the nearest point on the path and advance by a given distance.
  /// NOTE: Will only match ~same Y position, higher segments will not match for current position.
  /// Extra will be calculated until an up/down transition, where it will stop and return the POST-JUMP position (the end of the transition segment).
  /// Returns the point and the segment index (segment X starts at Waypoints[X])</summary>
  public (int AdvancedSeg, Vector3 AdvancedPos, int NearestSeg, Vector3 NearestPos) GetNearestPointWithExtra(
    int currentSegment,
    Vector3 position,
    float extra);

  /// <summary>Returns a vector representing the change in position for this segment</summary>
  public Vector3 SegmentDelta(int segmentIndex);

  public float DistanceToNextJump(int segmentIndex, Vector3 currentPos);

  public float DistanceToNextJump(int segmentIndex, Vector3 currentPos, out int segment);

  /// <summary>Returns true if we're on the last set of segments that will lead to the end, with no jumps.</summary>
  public bool OnFinalStretch();

  public bool VerticalTransitionSegment(int segment, int checkForward);

  /// <summary>Returns true if the given segment goes up/down</summary>
  public bool VerticalTransitionSegment(int segment);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
