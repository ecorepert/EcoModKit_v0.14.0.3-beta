// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.Internal.OccupancyInternalUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Occupancy.Internal;

/// <summary> Contains methods/logic related to specific implementations of occupancies and placement context calculations/processes. By being internal it means that they are used exclusively by the occupancy system. </summary>
internal static class OccupancyInternalUtils
{
  /// <summary> Return positions of wall blocks adjacent to the attachable occupancy blocks depend on Placement Side. (Absolute position which refers to world coordinates)</summary>
  public static 
  #nullable disable
  IEnumerable<Vector3i> GetBlocksAttachedToOneSide(
    OccupancyInfo occupancyInfo,
    Vector3i position,
    Quaternion rotation,
    DirectionAxis side);

  public static IEnumerable<Vector3i> GetBlocksAttachedToOneSide(
    IEnumerable<BlockOccupancy> blockOccupancies,
    Vector3i position,
    Quaternion rotation,
    DirectionAxis side);

  /// <summary> Return positions of wall blocks adjacent to the attachable occupancy blocks depend on Placement Side. (Relative positions to the world objects position)</summary>
  public static IEnumerable<Vector3i> GetBlocksAttachedToOneSide(
    OccupancyInfo occupancyInfo,
    DirectionAxis side);

  /// <summary> Calculate a surface that a world object can be attached to in one direction.
  /// It contains a list of blocks that have highest/lowest offset in one particular direction.
  /// The result should be cached in cachedAttachableSurface. </summary>
  public static List<BlockOccupancy> CalculateAttachableSurface(
    OccupancyInfo occupancyInfo,
    DirectionAxis axis);

  /// <summary> Return all possible placement string connected with or</summary>
  public static string GetPlacementString(DirectionAxisFlags sides);

  /// <summary> Returns name of side is referring to, e.g, walls, ground. ceiling etc.</summary>
  public static LocString CustomDirectionName(DirectionAxis axis);

  /// <summary>Reduce duplicate wall name in CustomDirectionName</summary>
  public static IEnumerable<LocString> CustomDirectionNamesDistinct(DirectionAxis[] axes);

  /// <summary> Goes through every position in PositionsRequirement and returns those that failed to meet the requirement function</summary>
  public static List<Vector3i> GetUnavailablePositions(
    Vector3i worldPos,
    Quaternion rotation,
    List<PositionsRequirement> positionsRequirements);

  /// <summary> Returns all the chunks that span the positions defined in Occupancy Info list of positions requirements.</summary>
  public static IEnumerable<Vector3i> GetRequirementRelevantChunkPositions(
    Vector3i worldPos,
    Quaternion rotation,
    List<PositionsRequirement> positionsRequirements);

  public static List<(bool IsValid, LocString PartName, LocString PlacementMsg)> IsValidCustomPlacementResults(
    Vector3i worldPos,
    Quaternion rotation,
    List<PositionsRequirement> positionsRequirements);

  /// <summary> Applies the requirement function to each position and whether or not they are all valid</summary>
  public static bool EvaluatePositionsRequirement(
    Vector3i worldPos,
    Quaternion rotation,
    PositionsRequirement positionRequirement);

  /// <summary> Similar to the placement logic for placing a buoy, it checks that it is placed on top of water and that a solid block is found at maximum depth,
  /// and if any of the two previous requirements fails it returns the said position</summary>
  public static List<Vector3i> WaterDepthUnavailablePositions(
    List<Vector3i> positionsToCheck,
    int depth);

  public static bool SearchSolidBlockUnderwater(Vector3i worldPos, int depth);

  public static Vector3i RotateBlock(
    Vector3i blockPosition,
    Quaternion rotation,
    Vector3i origin,
    bool worldPos,
    bool inverse = false);
}
