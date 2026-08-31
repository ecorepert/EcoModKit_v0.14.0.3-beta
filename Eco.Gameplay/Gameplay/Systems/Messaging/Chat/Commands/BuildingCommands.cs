// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.BuildingCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class BuildingCommands
{
  [ChatCommand("Shows commands for building and tech tree manipulation", ChatAuthorizationLevel.Admin)]
  public static void Build(
  #nullable disable
  User user);

  [ChatSubCommand("Build", "Imports building from string. I.e.: bt:HewnLogCube;room:0:-1:0:3:4:3;bt:Empty;fplane:2:0:0:1:2", ChatAuthorizationLevel.DevTier)]
  public static void Import(User user, string importString);

  [ChatSubCommand("Build", "Spawn a few rooms with housing value.", ChatAuthorizationLevel.DevTier)]
  public static void Home(User user);

  [ChatSubCommand("Build", "Spawn a room for a test user, make us a tenant.", ChatAuthorizationLevel.DevTier)]
  public static void Landlord(User user);

  [ChatSubCommand("Build", "Evict the targeted user, or self if none is targeted.", "evict", ChatAuthorizationLevel.Admin)]
  public static void Evict(User user, User targetUser = null);

  [ChatSubCommand("Build", "Make the targeted user a resident on the deed at your current position.  Use 'self' if no target asset.", "res", ChatAuthorizationLevel.Admin)]
  public static void Resident(User user, User targetUser = null);

  [ChatSubCommand("Build", "Builds every WorldObject in an appropriate building and fills it with fuel", ChatAuthorizationLevel.DevTier)]
  public static void TechTree(User user);

  [CITest(false)]
  [ChatSubCommand("Build", "Spawns some things (objects, blocks, etc) at a certain tech tier", ChatAuthorizationLevel.DevTier)]
  public static bool Tech(User user, int tier = 1);

  [CITest(false)]
  [ChatSubCommand("TheMeteor", "Spawns the end-game lasers and power supplies, and drops their power needs.", ChatAuthorizationLevel.DevTier)]
  public static bool SpawnLasers(User user);

  [ChatSubCommand("Build", "Spawns boat at player position", "boat", ChatAuthorizationLevel.Admin)]
  public static bool SpawnBoat(User user, string boatName);

  [ChatSubCommand("QA", "Ride nearest vehicle", "ride", ChatAuthorizationLevel.Admin)]
  public static bool RideVehicle(User user);

  [ChatSubCommand("Build", "Spawns a building by specifying which tier. Example: '/bt 2,5,5,5,3' spawns Tier 2 building with 5x5x5 dimensions and 3 stories.", "bt", ChatAuthorizationLevel.Admin)]
  public static bool Building(
    User user,
    int type = 1,
    int x = 4,
    int y = 4,
    int z = 4,
    int roofType = 1,
    bool createWindows = true,
    int stories = 1);

  [ChatSubCommand("Build", "Spawns a building by specifying the material to use", "bm", ChatAuthorizationLevel.Admin)]
  public static bool BuildingOfMaterial(
    User user,
    string material,
    int x = 4,
    int y = 4,
    int z = 4,
    int roofType = 1,
    bool createWindows = true,
    bool levelGround = false);

  [ChatSubCommand("QA", "Spawns item in building", "spawn", ChatAuthorizationLevel.Admin)]
  public static void Spawn(User user, string itemName, bool claim = true);

  [ChatSubCommand("Build", "Spawns a village", ChatAuthorizationLevel.Admin)]
  public static bool Village(User user, int type, int count);

  [CITest(false)]
  [ChatSubCommand("Build", "Spawns a road", "road", ChatAuthorizationLevel.Admin)]
  public static bool Road(
    User user,
    int length = 25,
    int width = 4,
    int buildTypeVal = 0,
    int bottomType = 2,
    bool flatRoad = false);
}
