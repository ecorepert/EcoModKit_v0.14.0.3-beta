// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.OccupancyInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System.Collections.Generic;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.Occupancy;

/// <summary> Contains information about the space that a world object occupies, in the form of a list of block occupancies, that in itself contain information about
/// the position relative to the world objects position, blocktype and occupancy type.
/// More detailed information can be found here: https://github.com/StrangeLoopGames/Eco/wiki/Occupancy-System.</summary>
public class OccupancyInfo
{
  public WorldRange Range;
  public 
  #nullable disable
  List<BlockOccupancy> Occupancies;

  public Vector3i Dimensions { get; }

  public Vector3 CenterOffset { get; }

  public static OccupancyInfo Create(List<BlockOccupancy> blocks);

  /// <summary> Returns <see cref="T:Eco.Shared.Math.WorldRange" /> at <paramref name="origin" /> position and with specified <paramref name="rotation" />. The range is exclusive.</summary>
  public WorldRange GetRange(Vector3i origin, Eco.Shared.Math.Quaternion rotation);

  /// <summary>Returns enumerable of occupancy blocks in world space for specified <paramref name="position" /> and <paramref name="rotation" />.</summary>
  public IEnumerable<WrappedWorldPosition3i> GetBlockPositions(
    Vector3i position,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Checks if object at <paramref name="origin" /> position rotated by <paramref name="rotation" /> and with range extended by <paramref name="extraExtents" /> contains <paramref name="position" />.</summary>
  public bool Contains(
    Vector3i origin,
    Eco.Shared.Math.Quaternion rotation,
    Vector3 position,
    Vector3i extraExtents = default (Vector3i));
}
