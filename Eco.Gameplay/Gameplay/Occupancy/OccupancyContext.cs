// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.OccupancyContext
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

/// <summary> A class that contains the definitions of methods needed for placement related stuff, such as trying to place an object, which positions are invalid when placing an object,
/// which chunks does the placement affect, the current placement status of an object already placed.
/// More detailed information can be found here: https://github.com/StrangeLoopGames/Eco/wiki/Occupancy-System. </summary>
public abstract class OccupancyContext
{
  /// Evaluates give the current occupancy context as to whether or not the object can be placed.
  public abstract bool CanPlaceObject(
    Player player,
    IPlaceableItem item,
    Vector3 worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Returns a list of positions that are invalid when placing an object, e.g holding a workbench and trying to place it above empty space </summary>
  public abstract List<Vector3i> GetSurfaceUnavailablePositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Returns the chunks touched by world object occupancy</summary>
  public abstract IEnumerable<Vector3i> GetRelevantChunkPositions(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary> Evaluates if the the current world object placement is valid, and their respetive message status  e.g Placed on solid ground.</summary>
  public virtual IEnumerable<ValResult<bool>> CurrentPlacementStatus(
    Vector3i worldPos,
    Eco.Shared.Math.Quaternion rotation);
}
