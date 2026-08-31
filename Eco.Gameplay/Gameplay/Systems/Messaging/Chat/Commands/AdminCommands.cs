// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.AdminCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class AdminCommands
{
  [ChatCommand("List of different teleportation commands", ChatAuthorizationLevel.Admin)]
  public static void Teleport(
  #nullable disable
  IChatClient client);

  [ChatCommand("List of inventory related commands", ChatAuthorizationLevel.Admin)]
  public static void Inventory(IChatClient client);

  [ChatCommand("List of commands for time operating")]
  public static void Time(IChatClient client);

  [ChatCommand("List of commands for simulations")]
  public static void Sim(IChatClient client);

  [ChatCommand("List of commands for land manipulations")]
  public static void Land(IChatClient client);

  [ChatCommand("List of some helping commands")]
  public static void Util(IChatClient client);

  [ChatSubCommand("Manage", "Sends a warning to a citizen", ChatAuthorizationLevel.Admin)]
  public static void WarnUser(IChatClient chatClient, User warnUser, string warning = "");

  [ChatSubCommand("Manage", "Sets a user's overhead display name (cannot match any existing username).", "setoverheadname", ChatAuthorizationLevel.Admin)]
  public static void SetOverheadName(User user, User targetUser, string overheadName);

  [ChatSubCommand("Manage", "Clears a user's overhead display name (reverts to official name).", "clearoverheadname", ChatAuthorizationLevel.Admin)]
  public static void ClearOverheadName(User user, User targetUser);

  [ChatSubCommand("Manage", "Sends an announce to all players", ChatAuthorizationLevel.Admin)]
  public static void Announce(IChatClient chatClient, string announce = "");

  [ChatSubCommand("Manage", "Sends an alert to everybody", ChatAuthorizationLevel.Admin)]
  public static void Alert(IChatClient chatClient, string alert = "");

  [ChatSubCommand("QA", "Throws an exception, very useful", ChatAuthorizationLevel.DevTier)]
  public static void Exceptional();

  [ChatSubCommand("QA", "Disconnect client with a long message", ChatAuthorizationLevel.DevTier)]
  public static void Disconnect(User user);

  [ChatSubCommand("QA", "Send multiple chat messages over time to test scrolling", ChatAuthorizationLevel.DevTier)]
  public static void ReceiveChat(User user, int msgCounts);

  [ChatSubCommand("Manage", "Changes the spawn location to your current location", ChatAuthorizationLevel.Admin)]
  public static void SetSpawn(User user);

  [ChatSubCommand("Manage", "Clears a user's objective", ChatAuthorizationLevel.Admin)]
  public static void ClearObjective(IChatClient chatClient, User targetUser);

  [CITest(false)]
  [ChatSubCommand("Sim", "Tramples the surrounding ground", ChatAuthorizationLevel.Admin)]
  public static void Trample(User user);

  [ChatSubCommand("QA", "Spawns all world objects", ChatAuthorizationLevel.DevTier)]
  public static void AllWorldObjects(User user);

  [ChatSubCommand("Inventory", "Dumps all items from your inventory.", "dumpall", ChatAuthorizationLevel.Admin)]
  public static void DumpAll(User user);

  [ChatSubCommand("Inventory", "Dumps all items from your vehicle inventory.", "dumpvehicle", ChatAuthorizationLevel.Admin)]
  public static void DumpVehicle(User user);

  [ChatSubCommand("Inventory", "Allows carry items into any user inventory slot and removes weight check.  Pass false to reset to normal.", "carryall", ChatAuthorizationLevel.Admin)]
  public static void CarryAll(User user, bool allowCarryAll = true);

  [ChatSubCommand("Inventory", "Dumps all carried items.", "dumpcarried", ChatAuthorizationLevel.Admin)]
  public static void DumpCarried(User user);

  [ChatSubCommand("Inventory", "Dumps all items in your selected toolbar slot.", "dumpselected", ChatAuthorizationLevel.Admin)]
  public static void DumpSelected(User user);

  [ChatSubCommand("Util", "Toggles fly mode", "fly", ChatAuthorizationLevel.Admin)]
  public static void Fly(User user);

  [ChatSubCommand("Util", "Toggles record mode", "record", ChatAuthorizationLevel.Admin)]
  public static void Record(User user);

  [CITest(false)]
  [ChatSubCommand("QA", "Spam a bunch of stuff to chat", ChatAuthorizationLevel.DevTier)]
  public static void ChatTest(
    User user,
    int count = 10,
    int receiverCount = 10,
    bool gibberish = true,
    int minLength = 0);

  [CITest(false)]
  [ChatSubCommand("QA", "Spam a bunch of stuff to notifications", ChatAuthorizationLevel.DevTier)]
  public static void NotificationsTest(int count = 10);

  [CITest(false)]
  [ChatSubCommand("Sim", "Spawns random plants", ChatAuthorizationLevel.Admin)]
  public static void Greenthumb(User user, int radius = 10, bool trees = false);

  [CITest(false)]
  [ChatSubCommand("Sim", "Spawns a bunch of one plant", ChatAuthorizationLevel.Admin)]
  public static void MassPlant(
    User user,
    int radius = 10,
    string speciesName = null,
    float growthPercent = 1f,
    float yield = 0.8f,
    bool trees = false);

  [ChatSubCommand("Sim", "Kills all plants in an area. Pass false to not delete them.", "killplants", ChatAuthorizationLevel.Admin)]
  public static void KillPlants(User user, int radius = 75, bool destroy = true, string speciesName = null);

  [ChatSubCommand("Sim", "Clears debris in an area.", "cleardebris", ChatAuthorizationLevel.Admin)]
  public static void ClearDebris(User user, int radius = 75);

  [ChatSubCommand("Sim", "Spawns debris in an area.", "spawndebris", ChatAuthorizationLevel.Admin)]
  public static void SpawnDebris(User user, int radius = 7);

  [ChatSubCommand("Sim", "Activates/deactivates pollution layer updating.", ChatAuthorizationLevel.DevTier)]
  public static void SetPollutionActive(User user, bool isActive);

  [ChatSubCommand("Sim", "Unpollute an area. Remove dead plants and replace dirt on grass blocks.", ChatAuthorizationLevel.Admin)]
  public static void Unpollute(User user, bool fullReplacement = true, int radius = 20);

  [ChatSubCommand("Sim", "Removes dead plants in an area.", ChatAuthorizationLevel.Admin)]
  public static void RemoveDeadPlants(User user, int radius = 50, bool destroy = false);

  [CITest(false)]
  [ChatSubCommand("Sim", "Kills all trees in an area. Pass false to only cut them.", "killtrees", ChatAuthorizationLevel.Admin)]
  public static void KillTrees(User user, int radius = 10, bool destroy = true, string speciesName = null);

  public static void SpawnPlant(string speciesName, Vector3i pos);

  [CITest(false)]
  [ChatSubCommand("Sim", "Spawns a plant or plants in a row or grid", "plant", ChatAuthorizationLevel.Admin)]
  public static void SpawnPlant(
    User user,
    string speciesName = "Birch",
    int countX = 1,
    int countZ = 1,
    int space = 0,
    float age = 1f);

  [ChatSubCommand("Sim", "Force global stats to collect now. Updates world progress stats as well.", "globalstats", ChatAuthorizationLevel.Admin)]
  public static void ForceCollectGlobalStats(IChatClient chatClient);

  [ChatSubCommand("Sim", "Spawns plants of particular ages in a row", "allplants", ChatAuthorizationLevel.Admin)]
  public static void SpawnAllPlants(
    User user,
    int count = 1,
    float growth1 = 0.3f,
    float growth2 = 0.6f,
    float growth3 = 1f);

  [ChatSubCommand("Sim", "Spawns trees of particular ages in a row", "alltrees", ChatAuthorizationLevel.Admin)]
  public static void SpawnAllTrees(User user, bool mature = false);

  [ChatSubCommand("Test", "Spawns all the various parts of an economy.", ChatAuthorizationLevel.DevTier)]
  public static Task Economics(User user, int ordersPerStore = 20, int categoriesPerStore = 4, int stores = 5);

  [ChatSubCommand("QA", "Override all aggregated notifications delay. Using without specifiying delay will instead reset the value.", ChatAuthorizationLevel.DevTier)]
  public static void NotifDelay(int delay = -1);

  [ChatSubCommand("QA", "Spawns all blocks.  Optional integer parameter for how many rows to make the blocks in, default is 1 row.", ChatAuthorizationLevel.DevTier)]
  public static void AllBlocks(User user, int rows = 1);

  [ChatSubCommand("QA", "Spawns all plant blocks", ChatAuthorizationLevel.DevTier)]
  public static void AllPlants(User user, int rows = 1);

  [ChatSubCommand("QA", "Spawns all player constructible blocks", ChatAuthorizationLevel.DevTier)]
  public static void AllConstructed(User user, string blockType = null);

  [ChatSubCommand("QA", "Spawns all diggable blocks", ChatAuthorizationLevel.DevTier)]
  public static void AllTerrain(User user);

  [ChatSubCommand("Land", "Resets the world caches", ChatAuthorizationLevel.Admin)]
  public static void ResetWorldCaches(IChatClient chatClient);

  [ChatSubCommand("Build", "Spawns and shuffles different blocks", ChatAuthorizationLevel.DevTier)]
  public static void ShuffleBlocks(User user, int x = 10, int y = 10);

  [CITest(false)]
  [ChatSubCommand("Land", "Level the terrain around user", "levelcentered", ChatAuthorizationLevel.Admin)]
  public static void LevelCentered(User user, int x = 15, int y = 15, string blockType = "GrassBlock");

  [CITest(false)]
  [ChatSubCommand("Land", "Level the terrain", "level", ChatAuthorizationLevel.Admin)]
  public static void Level(User user, int x = 15, int y = 15, string blockType = "GrassBlock");

  public static void Level(Vector3i pos, User user, int x = 15, int y = 15, string blockType = "GrassBlock");

  [ChatSubCommand("Land", "Fills an area with world objects (defaults to fish traps) to stress-test client rendering. Placement matches the level command, so run level first then this over the same x and y.", "spawnobjects", ChatAuthorizationLevel.Admin)]
  public static Task SpawnObjects(User user, int x = 15, int y = 15, int perBlock = 1, string objectType = "FishTrap");

  [CITest(false)]
  [ChatSubCommand("Land", "Level the terrain with a wall", "levelwall", ChatAuthorizationLevel.Admin)]
  public static void LevelWithWall(
    User user,
    int x = 15,
    int y = 15,
    int wallHeight = 1,
    string groundType = "GrassBlock",
    string wallType = "StoneBlock");

  public static void LevelWithWall(
    Vector3i pos,
    User user,
    int x = 15,
    int y = 15,
    int wallHeight = 1,
    string groundType = "GrassBlock",
    string wallType = "StoneBlock");

  /// <summary>Make a wall that cuts into the landscape at the given height</summary>
  public static void MakeCutWall(
    Vector3i pos,
    User user,
    int x,
    int y,
    int wallHeight,
    string wallType);

  [CITest(false)]
  [ChatSubCommand("Land", "Remove block types within a specified area", "remove", ChatAuthorizationLevel.Admin)]
  public static void Remove(
    User user,
    string blockType = "GrassBlock",
    int x = 15,
    int y = 15,
    int z = 15,
    bool isTurnToGlass = false);

  [CITest(false)]
  [ChatSubCommand("Land", "Removes all block types except the specified type within a specified area", "removeallbut", ChatAuthorizationLevel.Admin)]
  public static void RemoveAllBut(
    User user,
    string blockType = "GrassBlock",
    int x = 15,
    int y = 15,
    int z = 15,
    bool isTurnToGlass = false);

  public static void RemoveLand(
    User user,
    string blockType,
    int x,
    int y,
    int z,
    bool isTurnToGlass,
    bool removeAllOtherBlocks);

  [ChatSubCommand("Time", "Stop the sun where it currently is, for every player.", ChatAuthorizationLevel.Admin)]
  public static void Freeze(User user);

  [ChatSubCommand("Time", "Start the sun moving again from where it was stopped, for every player.", ChatAuthorizationLevel.Admin)]
  public static void Resume(User user);

  [ChatSubCommand("Time", "Put the sky back on the world clock, for every player.", ChatAuthorizationLevel.Admin)]
  public static void Reset(User user);

  [ChatSubCommand("Time", "Move the sun to noon for every player.", "noon", ChatAuthorizationLevel.Admin)]
  public static void Noon(User user);

  [ChatSubCommand("Time", "Move the sun to midnight for every player.", ChatAuthorizationLevel.Admin)]
  public static void Midnight(User user);

  [ChatSubCommand("Time", "Move the sun to the specified hour for every player.", ChatAuthorizationLevel.Admin)]
  public static void Set(User user, float hour);

  [CITest(false)]
  [ChatSubCommand("Manage", "Displays a list of users and when they last logged in.", ChatAuthorizationLevel.User)]
  public static void UserActivity(User user);

  public static string UserLoginString(IEnumerable<User> users);

  [ChatSubCommand("Skills", "Give skillpoints to another player", ChatAuthorizationLevel.Admin)]
  public static void GivePointsTo(IChatClient chatClient, User otherPlayer, int number = 10);

  [ChatSubCommand("Util", "Fuels currently selected (driving) vehicle.", "fuel", ChatAuthorizationLevel.Admin)]
  public static void Fuel(User user, INetObject target);

  [ChatSubCommand("Teleport", "Teleport to an xyz coordinate or an xz coordinate. For two components Y is calculated automatically.", "tp", ChatAuthorizationLevel.Admin)]
  public static void ToWorldPosition(User user, int x = -1, int yOrZ = -1, int z = -2147483648 /*0x80000000*/);

  [ChatSubCommand("Teleport", "Teleport to a citizen.", "tpto", ChatAuthorizationLevel.Admin)]
  public static void ToPlayer(User user, User otherPlayer);

  [ChatSubCommand("Teleport", "Teleport to an xyz coordinate or an xz coordinate, preloading the destination chunks first so you don't arrive into void. For two components Y is calculated automatically.", "tpp", ChatAuthorizationLevel.Admin)]
  public static Task PreloadedToWorldPosition(User user, int x = -1, int yOrZ = -1, int z = -2147483648 /*0x80000000*/);

  [ChatSubCommand("Teleport", "Teleport to a citizen, preloading the destination chunks first so you don't arrive into void.", "tppto", ChatAuthorizationLevel.Admin)]
  public static Task PreloadedToPlayer(User user, User otherPlayer);

  [ChatSubCommand("Teleport", "Teleports player A to player B", ChatAuthorizationLevel.Admin)]
  public static void AToB(IChatClient chatClient, User targetA, User targetB);

  [ChatSubCommand("Teleport", "Teleports otherPlayer to an xyz coordinate", ChatAuthorizationLevel.Admin)]
  public static void TargetTo(IChatClient chatClient, User otherUser, int x = -1, int y = -1, int z = -1);

  [ChatSubCommand("Teleport", "Teleport to the opposite side of the World", ChatAuthorizationLevel.Admin)]
  public static void ToDark(User user);

  [ChatSubCommand("Inventory", "Set the integrity percent (0-1) of the item you are holding, if it has it.", "integ", ChatAuthorizationLevel.Admin)]
  public static void Integrity(User user, float integrity = 1f);

  [ChatSubCommand("Inventory", "Set the durability of the item you are holding", "dur", ChatAuthorizationLevel.Admin)]
  public static void Durability(User user, float durability = 1f);

  [ChatSubCommand("Inventory", "Give yourself an item (Forced, ignores restrictions)", "fgive", ChatAuthorizationLevel.Admin)]
  public static void ForceGive(User user, string itemName, int number = 1, bool replace = true);

  [ChatSubCommand("Inventory", "Shows creative item spawn menu", "spawner", ChatAuthorizationLevel.Admin)]
  public static void CreativeSpawner(User user);

  [ChatSubCommand("Inventory", "Give yourself an item", "give", ChatAuthorizationLevel.Admin)]
  public static void Give(User user, string itemName, int number = 1);

  [ChatSubCommand("Inventory", "Give yourself all items matching the given search.", "giveall", ChatAuthorizationLevel.Admin)]
  public static void GiveAll(User user, string itemName, int number = 1);

  [ChatSubCommand("Inventory", "Add an item to your void storage", ChatAuthorizationLevel.Admin)]
  public static void AddVoid(User user, string itemName = "baked meat", int number = 1, int distance = 0);

  [ChatSubCommand("Inventory", "Set the number of backpack slots. DO NOT persist after server restart.", "setbackpackslots", ChatAuthorizationLevel.DevTier)]
  public static void SetBackpackSlots(User user, int slots);

  [ChatSubCommand("Inventory", "Set the number of carried slots. DO NOT persist after server restart.", "setcarriedslots", ChatAuthorizationLevel.DevTier)]
  public static void SetCarriedSlots(User user, int slots);

  public static void GiveAll(User user, IEnumerable<string> names, int count = 1);

  /// <summary>Checks if an Item can be given by the requesting user.</summary>
  /// <param name="user">User attempting to give the item.</param>
  /// <param name="item">The item being given.</param>
  /// <returns>The <see cref="T:Eco.Core.Utils.Result" /> object representing the outcome.</returns>
  public static Result ItemSpawnCheck(User user, Item item);

  public static void ForceGive(User user, Item item, int number, bool replace = true);

  [ChatSubCommand("QA", "Toggles the show state of a UI, by UI prefab name", ChatAuthorizationLevel.DevTier)]
  public static void Toggle(User user, string uiName);

  [CITest(false)]
  [ChatSubCommand("Build", "Spawns a large number of WorldObjects of the given name.", ChatAuthorizationLevel.DevTier)]
  public static void WorldObjects(User user, string worldObjectItemName = "WorkbenchItem", int count = 10);

  [ChatSubCommand("Build", "Spawns a large number of random WorldObjects.", ChatAuthorizationLevel.DevTier)]
  public static void ShuffleObjects(User user, int count = 100);

  [CITest(false)]
  [ChatSubCommand("Manage", "Save the world!", ChatAuthorizationLevel.Admin)]
  public static Task Save(IChatClient chatClient);

  [ChatSubCommand("QA", "Stop drawing the regions ", "clrreg", ChatAuthorizationLevel.DevTier)]
  public static void ClearRegions(User user);

  [ChatSubCommand("QA", "Test and draw path graph grid of given type", "regi", ChatAuthorizationLevel.DevTier)]
  public static void Regions(User user, int regionType = 0, int lineRadius = 50, int pointRadius = 50);

  [ChatSubCommand("QA", "Test the spawn location", ChatAuthorizationLevel.DevTier)]
  public static void DebugSpawn(User user);

  [ChatSubCommand("Manage", "Schedules an automatic shutdown", ChatAuthorizationLevel.Admin)]
  public static void Maintenance(IChatClient client, string time, string message, string reason);

  [ChatSubCommand("Manage", "Clears currently scheduled user maintenance.", ChatAuthorizationLevel.Admin)]
  public static void ClearMaintenance(IChatClient client);

  [ChatSubCommand("World", "Destroys all rubble in the world", "clearallrubble", ChatAuthorizationLevel.Admin)]
  public static void ClearAllRubble(User user);

  [ChatSubCommand("World", "Inspect server block, container and occupancy at coords", "inspectblock", ChatAuthorizationLevel.Admin)]
  public static void InspectBlock(User user, int x, int y, int z);

  [ChatSubCommand("World", "Destroys all physical objects with illegal positions outside the world. (worldobjects, vehicles, trees, rubbles etc)", "fixobjects", ChatAuthorizationLevel.Admin)]
  public static void FixObjects(User user, bool teleportVehicles = true);

  [ChatSubCommand("World", "Destroys all trunks outside the world", "fixtrunks", ChatAuthorizationLevel.Admin)]
  public static void FixTrunks(User user);

  [ChatSubCommand("World", "Removes fallen trees", "clearfallentrees", ChatAuthorizationLevel.Admin)]
  public static void ClearFallenTrees(User user);
}
