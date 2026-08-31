// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.OccupancyUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.SharedTypes;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.Occupancy;

/// <summary> Contains public functions related to the occupancy system.</summary>
public static class OccupancyUtils
{
  /// <summary>
  /// Check if a space (defined by occupancy, position and rotation) is empty or occupied.
  /// Returns all block positions(not wrapped) that are blocking the occupancy.
  /// Called when player is trying to place an object.
  /// <paramref name="blockers" /> represents the block types that can block the placement of an object (e.g. water, solid ground, etc.).
  /// </summary>
  public static IEnumerable<Vector3i> GetOccupancyUnavailableBlocks(
    IEnumerable<BlockOccupancy>? occupancy,
    Vector3i position,
    Eco.Shared.Math.Quaternion rotation,
    Type[]? blockers = null);

  public static bool IsBlockAvailable(WrappedWorldPosition3i blockPosition, Type[]? blockers);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsBlockAvailable(WrappedWorldPosition3i blockPosition);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsBlockAvailable(Block block);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsBlockOccupied(Vector3i blockPosition);

  /// <summary>Picks the voxel origin cell for an object placed at <paramref name="position" />. Free placement allows fractional positions, so plain rounding
  /// can voxelize an object into an adjacent solid block (e.g. a wall it merely leans against), silently losing its occupancy blocks and room membership.
  /// For freely-placed ground objects this prefers the nearest origin whose whole footprint avoids solid blocks; all other objects keep plain rounding.</summary>
  public static Vector3i PickOriginCell(
    Type worldObjectType,
    Vector3 position,
    Eco.Shared.Math.Quaternion rotation,
    List<BlockOccupancy> occupancy);

  /// <inheritdoc cref="M:Eco.Gameplay.Occupancy.OccupancyUtils.PickOriginCell(System.Type,System.Numerics.Vector3,Eco.Shared.Math.Quaternion,System.Collections.Generic.List{Eco.Gameplay.Occupancy.BlockOccupancy})" />
  public static Vector3i PickOriginCell(
    Vector3 position,
    Eco.Shared.Math.Quaternion rotation,
    List<BlockOccupancy> occupancy,
    WorldObjectPlacementRequirements? requirements);

  public static List<Vector3i> ToWorldPositions(
    Vector3i position,
    IEnumerable<BlockOccupancy> occupancy,
    Eco.Shared.Math.Quaternion rotation);

  public static Ray LocalToWorld(this WorldObject obj, Ray offset);

  public static Vector3i LocalToWorld(this WorldObject obj, Vector3i offset);

  /// <summary>True if <paramref name="fromPos" /> is within <paramref name="maxDistance" /> of the object's footprint (respecting world wrap),
  /// so large objects can be reached from anywhere along their footprint instead of only near their pivot. Measures to the closest point on
  /// the cached bounding box (<see cref="P:Eco.Gameplay.Objects.WorldObject.WorldRange" />): O(1), and a lower bound on the true nearest-block distance (the box
  /// contains every block), so it never wrongly reports "too far". Falls back to the pivot for freely-moving objects whose box isn't kept in
  /// sync (vehicles) or objects with no footprint.</summary>
  public static bool WithinDistanceOfNearestOccupancy(
    this WorldObject obj,
    WrappedPosition3 fromPos,
    float maxDistance);

  public static IEnumerable<Vector3i> GroundBelow(this WorldObject obj);

  /// <summary> Returns positions of ground blocks below the occupancy blocks that have Y offset of 0,
  /// if occupancy contains BuildingWorldObjectBlock types only return ground blocks below them </summary>
  public static IEnumerable<Vector3i> GroundBelow(
    OccupancyInfo occupancyInfo,
    Vector3i position,
    Eco.Shared.Math.Quaternion rotation);
}
