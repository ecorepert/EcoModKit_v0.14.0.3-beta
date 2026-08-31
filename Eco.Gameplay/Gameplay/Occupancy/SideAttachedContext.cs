// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.SideAttachedContext
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

#nullable enable
namespace Eco.Gameplay.Occupancy;

/// <summary> Given a side(s), it checks for solid ground placement at the attached positions of the occupancies position, e.g think of the side of a box, where the box is composed of the occupancies position</summary>
public class SideAttachedContext : OccupancyContext
{
  public readonly DirectionAxisFlags RequiresSurfaceOnSides;
  public readonly 
  #nullable disable
  OccupancyInfo OccupancyInfo;

  public SideAttachedContext(DirectionAxisFlags directionAxis, OccupancyInfo occupancyInfo);

  /// <summary> Evaluates the current placement status of the world object, by using OccupancyHelper.CanPlace() which checks the blocks attached to the defined side</summary>
  public override IEnumerable<ValResult<bool>> CurrentPlacementStatus(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Returns the chunks where all of the object's occupancy positions are found</summary>
  public override IEnumerable<Vector3i> GetRelevantChunkPositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Checks through all blocks attached to the sides and returns invalid positions where the blocks aren't solid ground</summary>
  public override List<Vector3i> GetSurfaceUnavailablePositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Tries to place object on solid ground at one of the sides defined</summary>
  public override bool CanPlaceObject(
    Player player,
    IPlaceableItem item,
    Vector3 worldPos,
    Eco.Shared.Math.Quaternion rotation);
}
