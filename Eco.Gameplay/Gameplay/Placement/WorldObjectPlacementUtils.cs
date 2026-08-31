// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.WorldObjectPlacementUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Placement;

/// <summary>Funcs for helping place world objects.</summary>
public static class WorldObjectPlacementUtils
{
  /// <inheritdoc cref="M:Eco.Gameplay.Placement.WorldObjectPlacementUtils.TryPlaceWorldObject(Eco.Gameplay.GameActions.GameActionPack,Eco.Gameplay.Players.Player,Eco.Gameplay.Items.IPlaceableItem,Eco.Gameplay.Items.ItemStack,System.Numerics.Vector3,Eco.Shared.Math.Quaternion,Eco.Gameplay.Objects.WorldObject)" />
  public static 
  #nullable disable
  Task<WorldObject> TryPlaceWorldObjectNow(
    Player player,
    IPlaceableItem item,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rot,
    int placeOnSurfaceOfObjectID);

  /// <summary>Do the steps for placing a world object from an IPlaceable.</summary>
  /// <param name="containingStack">Reduces this stack if it succeeds, if set.</param>
  /// <return>A function that will let the caller retreive the object that is finally placed in a PostEffect, which can then be used in subsequent PostEffects.</return>
  public static Task<Func<WorldObject>> TryPlaceWorldObject(
    GameActionPack pack,
    Player player,
    IPlaceableItem item,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rot,
    WorldObject attachedToWorldObject);

  /// <summary>Do notices for a finished placed world object. If an item doesnt create with 'ShouldCreate' flag, it needs to do this expliclty! Otherwise, it happens automaticall.</summary>
  public static void FinishPlacement(User user, WorldObject obj);

  /// <summary>
  /// Same as IsValidPlacement except that this version ignores the occupied block positions.
  /// Use this if it's not necessary to know what are the occupied blocks.
  /// </summary>
  public static Result IsValidPlacement(
    IPlaceableItem item,
    Vector3 position,
    Eco.Shared.Math.Quaternion rotation,
    WorldObject attachingTo);

  /// <summary>
  /// Given a world object, a position and a rotation, check if it's a valid placement position for the world object.
  /// <paramref name="occupiedBlockPositions" /> is a list that will be filled inside this function, containing every block position that is already occupied by an object.
  /// </summary>
  public static Result IsValidPlacement(
    IPlaceableItem item,
    Vector3 position,
    Eco.Shared.Math.Quaternion rotation,
    WorldObject attachingTo,
    out List<Vector3i> occupiedBlockPositions);
}
