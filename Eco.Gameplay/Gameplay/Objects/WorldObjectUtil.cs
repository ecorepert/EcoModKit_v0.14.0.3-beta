// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObjectUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Objects;

public static class WorldObjectUtil
{
  public static float SimTickDelta(this 
  #nullable disable
  WorldObject obj);

  public static void Changed(object controller, PropertyChangedEventArgs args);

  /// <summary>Subscribes every [Serialized] inventory of the object and its components so applied change-sets mark the object for persistence.
  /// Inventory mutations bypass property setters, so the property-changed funnel can't see them. Components installed dynamically after init
  /// are not covered here and must mark dirty themselves (the reconciliation sweep reports any that forget).</summary>
  public static void WireInventoryPersistence(this WorldObject obj);

  public static LazyResult ShouldOverrideAuth(WorldObject obj, GameAction action);

  public static IEnumerable<WorldObjectHandle> Handles(this IEnumerable<WorldObject> objs);

  public static void ActionPerformed(WorldObject obj, GameAction action);

  public static IEnumerable<T> AllObjsWithComponent<T>() where T : WorldObjectComponent;

  /// <summary>Gets all attached objects recursively (including self).</summary>
  public static IEnumerable<WorldObject> AllAttachedRecursiveAndSelf(this WorldObject obj);

  public static bool RequiresComponentNonRecursive<T>(this WorldObjectItem item) where T : WorldObjectComponent;

  public static bool RequiresComponentRecursive<T>(this WorldObjectItem item) where T : WorldObjectComponent;

  public static bool RequiresComponentRecursive<T>(Type type) where T : WorldObjectComponent;

  /// <summary> Confirms with the player pick up decision based on <see cref="M:Eco.Gameplay.Objects.WorldObjectUtil.PickupConfirmation(Eco.Gameplay.Objects.WorldObject)" /> and <see cref="T:Eco.Gameplay.Economy.Contracts.Contract" />s that depend on it. </summary>
  public static Task<bool> CheckForPickUpAsync(this WorldObject obj, Player player, bool confirm = true);

  /// <summary>Return ourselves and any component that derives from the given interface.</summary>
  public static IEnumerable<T> SelfAndComponentsWithInterface<T>(this WorldObject obj);

  public static IEnumerable<Type> RecursiveRequiredComponents(Type worldObjectType);

  public static void GetRequiredComponents(
    Type type,
    string name,
    HashSet<(Type Type, string Name)> componentSet);

  public static void GetMayHaveComponents(
    Type type,
    string name,
    HashSet<(Type Type, string Name)> mayHaveComponentsSet);

  /// <summary>Destroy the object, returning all inventory items and the object item to a creator with void storage fallback.</summary>
  public static void DestroyAndReturnInventories(this WorldObject obj, LocString reason);

  /// <summary>Return all inventories on this object to a creator with void storage fallback.</summary>
  public static void ReturnAllInventoriesToCreator(this WorldObject obj, LocString reason);

  /// <summary>Remove property object (e.g. claim stake), returning the papers and claim stake to their sources.</summary>
  public static void ForceReturnPropertyObject(this WorldObject hostObj);

  public static Result TryPickUpNow(
    this WorldObject obj,
    Player player,
    Inventory targetInventory,
    float caloriesNeeded,
    bool force);

  public static GameActionPack TryPickUp(
    this WorldObject obj,
    GameActionPack actionPack,
    Player player,
    Inventory targetInventory,
    float caloriesNeeded,
    bool force,
    AccessType accessType = AccessType.FullAccess);

  /// <summary> Calls TryPickup for components in the WorldObject, and adds them to the inventory when possible. </summary>
  /// <remarks> If any component 'TryPickup' instance succeeds, the actionPack won't fail and valid items will be moved.
  /// Changeset will be created in actionpack if null is passed</remarks>
  public static (InventoryMoveResult Result, GameActionPack Pack) TryPickupComponents(
    this WorldObject obj,
    WorldObjectUtil.PickupType pickupType,
    Inventory targetInventory,
    User user,
    GameActionPack actionPack,
    AccessType accessNeeded,
    bool force);

  /// <summary>Clears place for world object of type <paramref name="worldObjectType" /> at specified position an rotation.</summary>
  internal static void ClearPlace(
    Type worldObjectType,
    Vector3i position,
    Quaternion rotation,
    WorldObject attachedToWorldObject);

  public static bool HasAttributeOnItemObjectOrComponent<T>(Type worldObjectType) where T : Attribute;

  public static IEnumerable<T> AllAttributesOnItemObjectOrComponent<T>(Type worldObjectType) where T : Attribute;

  public enum PickupType
  {
    PickupAllComponents,
    PickupInventoryComponentsOnly,
  }
}
