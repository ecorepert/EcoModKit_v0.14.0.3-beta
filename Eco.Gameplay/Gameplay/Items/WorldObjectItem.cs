// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.WorldObjectItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;
using System.Numerics;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>An item that has a singular corresponding world object it drops when placed.</summary>
[Serialized]
[WorldSpaceItem]
[System.ComponentModel.Category("WorldObject")]
[ItemGroup("World Object")]
[Tag("World Object")]
public abstract class WorldObjectItem : 
  DurabilityItem,
  INotifyPropertyChanged,
  IPlaceableItem,
  IController,
  IViewController,
  IHasUniversalID
{
  public static readonly 
  #nullable disable
  Type[] AllowWaterPlacement;

  public new static void Initialize();

  public static WorldObjectItem GetCreatingItemTemplateFromType(Type type);

  public override bool IsStackable { get; }

  public abstract Type WorldObjectType { get; }

  public virtual HomeFurnishingValue HomeValue { get; }

  /// <summary> Generates tooltip displaying list of all world objects created from this item type in the world </summary>
  [RPC]
  public TooltipSection GetAllObjectsTooltip(Player player);

  /// <summary>If true, the system will automatically create the world object item when placed. If false, then the item must manually do it in 'PlacingObject'</summary>
  public virtual bool ShouldCreate { get; }

  /// <summary>If true, the tooltip of the item won't show the "ExistingObjects" section</summary>
  public virtual bool ShowLocationsInWorld { get; }

  public virtual Type[] GetBlockTypesForDirection(Vector3i direction);

  [Serialized]
  [SyncToView(null, true)]
  public float Durability { get; set; }

  public override float GetDurability();

  public override void SetDurability(float dur);

  public override Item Clone();

  /// <summary> RPC that attempts to place the WorldObject that is represented by this item. </summary>
  /// <remarks> Will still do server-side checks to see if it can indeed be placed, and can fail if it can't. </remarks>
  [RPC]
  public void Place(Player player, Vector3 pos, Eco.Shared.Math.Quaternion rotation, int placeOnSurfaceOfObjectID);

  /// <summary> Override this function if you want to have async processing for Place Object action (like asking a citizen for confirmation). </summary>
  public virtual Task<bool> CanPlaceObject(Player player, Vector3 pos, Eco.Shared.Math.Quaternion rotation);

  /// <summary>Do anything special that needs to be done when this thing is placed, by putting it into a game action pack.  The future placed object can be retreived by
  /// the passed func, inside posteffects (its assigned in a previous post effect, already setup to run when this is called)</summary>
  public virtual Task PlacingObject(
    GameActionPack pack,
    Player player,
    ItemStack containingStack,
    Vector3 pos,
    Eco.Shared.Math.Quaternion rotation);

  /// <summary>This is called immediately before placement, before initialization and net object activation.</summary>
  public virtual void OnPreWorldObjectPlaced(WorldObject placedObject);

  /// <summary>This called after the world object is placed, added to the world object manager and all its components initialized.</summary>
  public virtual void OnPostWorldObjectPlaced(WorldObject addedObject);

  public virtual void OnPickup(WorldObject placedObject);

  public OccupancyContext OccupancyContext { get; }

  /// <summary> Default occupancy config set to SideAttached </summary>
  protected virtual OccupancyContext GetOccupancyContext { get; }

  public virtual Type[] Blockers { get; }

  public virtual Task<bool> CanMove(
    Player player,
    Vector3i pos,
    Eco.Shared.Math.Quaternion rotation,
    INetObject woNetObject);
}
