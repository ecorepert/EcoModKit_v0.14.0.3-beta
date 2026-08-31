// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.WorldObjectDebugUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay;

public static class WorldObjectDebugUtil
{
  public static 
  #nullable disable
  WorldObject GetOrCreateObject(string name, User user, Vector3i pos, float distance = 10f);

  public static WorldObject DeluxeSpawn(
    string name,
    User user,
    WrappedWorldPosition3i position,
    WorldObjectDebugUtil.DeluxeSpawnFlags flags = WorldObjectDebugUtil.DeluxeSpawnFlags.AllGoodies,
    bool findEmptySpace = false,
    int tier = 1);

  public static WorldObject DeluxeSpawn(
    Type worldObjectType,
    User user,
    WrappedWorldPosition3i position,
    WorldObjectDebugUtil.DeluxeSpawnFlags flags = WorldObjectDebugUtil.DeluxeSpawnFlags.AllGoodies,
    bool findEmptySpace = false,
    int tier = 1);

  /// <summary> Spawns a sign at specified position, optionally with custom material and look direction. </summary>
  public static void SpawnSignAtPos(
    User user,
    Vector3 position,
    string signText,
    string signObject = "SmallHangingStoneSignObject",
    Direction direction = Direction.Back);

  public static void AddWorkOrderForObject(WorldObject obj, StorageComponent storage, int quantity = 10);

  public static void EstablishTechTree(User user);

  public static void AddFuelForObject(WorldObject worldObject);

  public static StorageComponent AddStorageForObject(WorldObject worldObject);

  public static void ClearAbove(Vector3i pos, int countAbove = 10000);

  /// <summary> Replace terrain blocks on a certain block type. Works only for top blocks </summary>
  public static void ReplaceTerrain(
    Type blockTypeReplacement,
    WorldPosition3i center,
    int radius = 5,
    Type blockTypeOriginal = null,
    bool fullReplacement = false);

  /// <summary>Level ground with grass block</summary>
  public static void LevelTerrain(
    Vector2i size,
    WrappedWorldPosition3i position,
    Player player,
    int replaceUnderground = 0);

  /// <summary>Level ground with defined block.</summary>
  public static void LevelTerrain(
    Vector2i size,
    WrappedWorldPosition3i position,
    Type blockType,
    Player player,
    int replaceUnderground = 0);

  /// <summary>Levels the terrain using given parameters.</summary>
  /// <param name="size">The size at which the terrain should be levelled.</param>
  /// <param name="position">the position at which the iteration starts, the leveling starts at the position and increments both x and z values.</param>
  /// <param name="blockType">the type of the block to use while levelling, this need to be not solid.</param>
  /// <param name="player">the player who started the command.</param>
  /// <param name="replaceUnderground">should leveling replace underground to and to what levels, this is for clearing things such as pipes.</param>
  /// <returns>A task that the caller can wait for it or not.</returns>
  public static Task LevelTerrainAsync(
    Vector2i size,
    WrappedWorldPosition3i position,
    Type blockType,
    Player player,
    int replaceUnderground = 0);

  /// <summary>Smart block remove function which is aware of plants and world objects.</summary>
  public static void RemoveBlock(WrappedWorldPosition3i worldPos);

  public static void RemoveBlocksFromArea(
    Vector3i size,
    Vector3i position,
    Type blockType,
    bool isTurnToGlass,
    bool removeAllOtherBlocks = false);

  public static void CreateShaft(Vector2i size, Vector3i position, Player player, int depth = 0);

  /// <summary>Spawn the world object on flattened ground.</summary>
  public static WorldObject SpawnOnFlattenedGround(Type worldObjectType, User user, Vector3i pos);

  public static WorldObject SpawnAndClaim(
    Type worldObjectType,
    User creator,
    Vector3i position,
    Eco.Shared.Math.Quaternion rotation,
    Deed deed);

  /// <summary>Spawn the world object on flattened ground.</summary>
  public static WorldObject SpawnOnFlattenedGround(
    Type worldObjectType,
    User user,
    Vector3i pos,
    Eco.Shared.Math.Quaternion rotation);

  public static T SpawnAndClaim<T>(string name, User user, Vector2i pos);

  public static T SpawnAndClaim<T>(string name, User user, Vector3i? pos = null);

  public static WorldObject SpawnAndClaim(string name, User user, Vector2i pos);

  public static WorldObject SpawnAndClaim(string name, User user, Vector3i? pos = null);

  public static WorldObject Spawn(string name, User user, Vector2i pos);

  public static WorldObject Spawn(string name, User user, Vector3i pos);

  public static WorldObject Spawn(Type worldObjectType, User user, Vector2i pos);

  public static WorldObject Spawn(Type worldObjectType, User user, Vector3i pos);

  /// <summary> Function for spawning a list of WorldObjects on User's position. </summary>
  public static List<WorldObject> SpawnList(
    User user,
    List<string> namesOfItemsToSpawn,
    WorldObjectDebugUtil.DeluxeSpawnFlags flags = WorldObjectDebugUtil.DeluxeSpawnFlags.AllGoodies,
    int tier = 1);

  /// <summary> Function for spawning a list of WorldObjects in a custom position.</summary>
  /// <remarks> Calculates size first, and returns it together with a Func that confirms the spawning. </remarks>
  public static List<WorldObject> SpawnList(
    User user,
    Vector3i startPos,
    List<string> namesOfItemsToSpawn,
    WorldObjectDebugUtil.DeluxeSpawnFlags flags = WorldObjectDebugUtil.DeluxeSpawnFlags.AllGoodies,
    int tier = 1);

  public static IEnumerable<T> SpawnManyAndClaim<T>(
    string name,
    User user,
    int count,
    Vector3i pos,
    Vector3i increment);

  public static IEnumerable<WorldObject> SpawnManyAndClaim(
    string name,
    User user,
    int count,
    Vector3i pos,
    Vector3i increment);

  public static IEnumerable<T> SpawnManyAndClaim<T>(string name, User user, int count);

  public static IEnumerable<WorldObject> SpawnManyAndClaim(string name, User user, int count);

  public static void SpawnGround(WorldObject obj);

  public static void ThrowIfNotRunning(this WorldObject obj);

  /// <summary>Ensures world object enabled and throws exception if it not enabled after default timeout.</summary>
  public static Task EnsureWorldObjectEnabled(
    WorldObject worldObject,
    string name = null,
    CancellationToken cancellationToken = default (CancellationToken));

  /// <summary>Ensures world object enabled and throws exception if it not enabled after timeout.</summary>
  public static Task EnsureWorldObjectEnabled(
    WorldObject worldObject,
    TimeSpan timeout,
    TimeSpan checkInterval,
    string name = null,
    CancellationToken cancellationToken = default (CancellationToken));

  /// <summary>Ensures component enabled and throws exception if it not enabled after default timeout.</summary>
  public static Task EnsureComponentEnabled(
    WorldObjectComponent component,
    string name = null,
    CancellationToken cancellationToken = default (CancellationToken));

  /// <summary>Ensures component enabled and throws exception if it not enabled after timeout.</summary>
  public static Task EnsureComponentEnabled(
    WorldObjectComponent component,
    TimeSpan timeout,
    TimeSpan checkInterval,
    string name = null,
    CancellationToken cancellationToken = default (CancellationToken));

  [Flags]
  public enum DeluxeSpawnFlags
  {
    SpawnStorage = 1,
    ForceBuilding = 2,
    VerifyObjectEnabled = 4,
    DisableRoomReqs = 0,
    AllGoodies = VerifyObjectEnabled | ForceBuilding | SpawnStorage, // 0x00000007
  }
}
