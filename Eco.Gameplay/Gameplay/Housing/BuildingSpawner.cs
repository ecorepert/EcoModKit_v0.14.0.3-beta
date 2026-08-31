// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.BuildingSpawner
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Housing.Internal;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System;

#nullable disable
namespace Eco.Gameplay.Housing;

/// <summary>Functions for spawning buildings and objects contained in them.</summary>
public static class BuildingSpawner
{
  /// <summary>Spawn a building for the given object, creating a new deed and claiming on it.</summary>
  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObjectAndClaim(
    string name,
    User creator,
    Vector3i position,
    bool levelGround = true);

  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObjectAndClaim(
    Deed deed,
    string name,
    User user,
    Vector2i worldPos,
    bool levelGround = true);

  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObjectAndClaim(
    Deed deed,
    string name,
    User user,
    Vector3i worldPos,
    bool levelGround = true);

  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObject(
    Type objType,
    User user,
    PlotPos pos,
    bool levelGround = true);

  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObject(
    Type objType,
    User user,
    Vector2i pos,
    bool levelGround = true);

  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObject(
    string name,
    User user,
    Vector3i pos,
    bool levelGround = true);

  public static (WorldObject Obj, WorldRange BuildingSize) SpawnBuildingWithObject(
    Type objType,
    User user,
    Vector3i pos,
    bool levelGround = true);

  public static void SpawnBuilding(
    User user,
    string materialName,
    Vector3i interiorSize,
    Vector3i position,
    RoofType roofVal = RoofType.Flat,
    bool windows = true,
    bool levelGround = true);

  /// <summary>Spawns building with given tier, size and options.</summary>
  public static WorldRange SpawnBuilding(
    User user,
    int tier,
    Vector3i interiorSize,
    Vector3i position,
    RoofType roofVal = RoofType.Flat,
    bool windows = true,
    bool levelGround = true);

  /// <summary>Spawn building for given <paramref name="roomSpecification" /> at given <paramref name="position" />.</summary>
  public static WorldRange SpawnBuilding(
    User user,
    Vector3i position,
    RoomSpecification roomSpecification,
    bool levelGround = true);
}
