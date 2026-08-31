// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IPlaceableItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>For items that can be placed in the world.</summary>
[Serialized]
public interface IPlaceableItem : IController, IViewController, IHasUniversalID
{
  static readonly 
  #nullable disable
  Type[] WaterBlocksPlacement;
  static OccupancyContext singleBlockOccupancy;

  HomeFurnishingValue HomeValue { get; }

  [RPC]
  void Place(Player player, Vector3 pos, Eco.Shared.Math.Quaternion rotation, int placeOnSurfaceOfObjectID);

  /// <summary> Attempts to move the WorldObject that this item represents, from its existing point to specified position and rotation. </summary>
  [RPC]
  Task<bool> Move(
    Player player,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation,
    INetObject woNetObject,
    bool unstuck = false);

  /// <summary> Retrieves the initial info required for a WorldObject's movement, like deed/settlement restrictions and messages, calories required, etc. </summary>
  /// <remarks> Contains enough info for the client to do the necessary validations and display things properly. </remarks>
  [RPC]
  MoveWorldObjectActionInfo GetMoveInfo(Player player, INetObject woNetObject);

  /// <summary>This will check whether this item can be moved by the specified player to the specified position or not.</summary>
  Task<bool> CanMove(Player player, Vector3 pos, Eco.Shared.Math.Quaternion rotation, INetObject woNetObject);

  Task<bool> CanPlaceObject(Player player, Vector3 pos, Eco.Shared.Math.Quaternion rotation);

  Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation);

  bool ShouldCreate { get; }

  string Name { get; }

  LocString MarkedUpName { get; }

  OccupancyContext OccupancyContext { get; }

  Type WorldObjectType { get; }

  Type[] Blockers { get; }

  /// <summary>This is called immediately before placement, before initialization and net object activation.</summary>
  void OnPreWorldObjectPlaced(WorldObject placedObject);

  /// <summary>This called after the world object is placed, added to the world object manager and all its components initialized.</summary>
  void OnPostWorldObjectPlaced(WorldObject addedObject);

  void OnPickup(WorldObject placedObject);
}
