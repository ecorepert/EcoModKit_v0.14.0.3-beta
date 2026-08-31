// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.WaterDepthContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System.Collections.Generic;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.Occupancy;

/// <summary> It makes sure that the object is placed on water, it checks for a solid block within the given depth</summary>
public class WaterDepthContext : OccupancyContext
{
  public readonly int Depth;
  public readonly 
  #nullable disable
  List<Vector3i> PositionsToCheck;

  /// <summary> Allows to create water depth context from occupancy info, it caches the blocks attached to its down side as the positions to check depth. </summary>
  public WaterDepthContext(int depth, OccupancyInfo occupancyInfo);

  /// <summary> Allows to create water depth context by manually setting the positions to check. </summary>
  public WaterDepthContext(int depth, List<Vector3i> positionsToCheck);

  /// <summary> Returns chunks related to the generated downward columns of positions from the positions to check and depth. </summary>
  public override IEnumerable<Vector3i> GetRelevantChunkPositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Returns invalid positions on surface if it isn't placed on water, and also the columns of positions in case the depth check is invalid. </summary>
  public override List<Vector3i> GetSurfaceUnavailablePositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Placement logic for placing water depth, it checks that it is placed on top of water and that a solid block is found at maximum depth </summary>
  public override bool CanPlaceObject(
    Player player,
    IPlaceableItem item,
    Vector3 worldPos,
    Eco.Shared.Math.Quaternion rotation);
}
