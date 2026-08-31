// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.PositionsRequirementContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Occupancy;

/// <summary> Given a list of positions requirements it checks for each one to be valid, this means evaluating all of their positions by their requirement, such as being placed on solid ground, water, empty space.</summary>
public class PositionsRequirementContext : OccupancyContext
{
  public readonly List<PositionsRequirement> PositionsRequirements;

  public PositionsRequirementContext(List<PositionsRequirement> positionsRequirements);

  /// <summary> Evaluates each position requirements and returns it's current status as to whether is valid or not </summary>
  public override IEnumerable<ValResult<bool>> CurrentPlacementStatus(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Returns the chunks where all of the positions from the positions requirements are found </summary>
  public override IEnumerable<Vector3i> GetRelevantChunkPositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Returns all invalid positions which didn't met their respective requirement. e.g water, empty space, solid ground etc.</summary>
  public override List<Vector3i> GetSurfaceUnavailablePositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  public override bool CanPlaceObject(
    Player player,
    IPlaceableItem item,
    Vector3 worldPos,
    Eco.Shared.Math.Quaternion rotation);
}
