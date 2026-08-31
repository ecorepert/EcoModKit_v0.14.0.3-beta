// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.Internal.AnimalCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Simulation.Agents;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.Animals.Internal;

[ChatCommandHandler]
public static class AnimalCommands
{
  [CITest(false)]
  [ChatSubCommand("Sim", "Kills nearest animal", ChatAuthorizationLevel.Admin)]
  public static void OneShot(
  #nullable disable
  User user);

  [ChatSubCommand("Sim", "Toggles instakill mode for animals - hitting animals will do 1000x damage", "instakill", ChatAuthorizationLevel.Admin)]
  public static void InstakillAnimals(User user, User targetUser = null);

  [ChatSubCommand("Sim", "Kills all animals and disable animal spawn", "die", ChatAuthorizationLevel.DevTier)]
  public static void PoorBunnies(bool destroy = true);

  [ChatSubCommand("Sim", "Enable/Disable animal spawning", "anspawn", ChatAuthorizationLevel.Admin)]
  public static void AllowSpawn(User user, bool allow);

  [ChatSubCommand("Sim", "Spawns a number of animals without ecosystem checks", "fanimal", ChatAuthorizationLevel.DevTier)]
  public static Animal ForceSpawnAnimal(
    User user,
    string speciesName = "Hare",
    float distanceAhead = 0.0f,
    bool dead = false);

  [ChatSubCommand("Sim", "Spawns a number of animals", "animal", ChatAuthorizationLevel.Admin)]
  public static Animal SpawnAnimal(User user, string speciesName = "Hare", float distanceAhead = 0.0f, bool dead = false);

  [ChatSubCommand("Sim", "Spawns all animals in a grid based on look direction", "zoo", ChatAuthorizationLevel.DevTier)]
  public static void SpawnAllAnimals(User user, int spacing = 2);

  public static Animal SpawnAnimalInternal(
    User user,
    string speciesName = "Hare",
    float distanceAhead = 0.0f,
    bool dead = false,
    bool force = false,
    Vector3 spawnPosOverride = default (Vector3));

  [ChatSubCommand("Sim", "Toggle following the nearest animal.", "fola", ChatAuthorizationLevel.DevTier)]
  public static void FollowAnimal(User user, bool set = true);

  [ChatSubCommand("Sim", "Do an animal spawn as if the player is just logging in, using normal population rules.", "frens", ChatAuthorizationLevel.Admin)]
  public static void SpawnHerd(User user);

  [ChatSubCommand("Sim", "Spawns a herd of animals of the given species, elk by default", "herd", ChatAuthorizationLevel.Admin)]
  public static void SpawnHerd(
    User user,
    string animalToSpawn = "elk",
    int count = 3,
    bool destroyAllOthers = true,
    float distanceAhead = 1f);

  [ChatSubCommand("Sim", "Makes the current user not able to control animals.", "dnc", ChatAuthorizationLevel.DevTier)]
  public static void DoNotControl(User user, bool set = true);

  [ChatSubCommand("Sim", "Makes animals always choose to attack", "alwaysattack", ChatAuthorizationLevel.DevTier)]
  public static void AnimalAttack(User user, bool set = true);

  [ChatSubCommand("Sim", "Enables debug on the nearest animal, or disables it if already enabled. Destroys other animals and doesnt camera follow. Pauses behavior.", "dbb", ChatAuthorizationLevel.DevTier)]
  public static void DebugAnimalFocus(
    User user,
    float distanceAhead = 10f,
    string animalToSpawn = "elk",
    bool dead = false);

  [ChatSubCommand("Sim", "Toggles debugging for all animals on/off", "da", ChatAuthorizationLevel.DevTier)]
  public static void DebugAllAnimals(User user, bool set = true);

  [ChatSubCommand("Sim", "Enables debug on the nearest animal, or disables it if already enabled.", "dba", ChatAuthorizationLevel.DevTier)]
  public static void DebugAnimal(User user, bool follow = false, bool destroyAllOthers = false);

  [ChatSubCommand("Sim", "Delete all animals except the closest.", "foc", ChatAuthorizationLevel.DevTier)]
  public static void FocusAnimal(User user, int animalID = -1);

  [ChatSubCommand("Sim", "Make the nearest animal stop running behaviors, and delete their current path if they have one.", "freeze", ChatAuthorizationLevel.DevTier)]
  public static void FreezeAnimal(User user, bool set = true);

  [ChatSubCommand("Sim", "The animal that's currently being debugged will move toward the specified destination (just specifify the x and z coordinates).  If no coords passed, use cur position.", "run", ChatAuthorizationLevel.DevTier)]
  public static void RunTo(User user, bool targetPlayer = true);

  [ChatSubCommand("Sim", "The animal that's currently being debugged will move toward the specified destination (just specifify the x and z coordinates).  If no coords passed, use cur position.", "come", ChatAuthorizationLevel.DevTier)]
  public static void MoveTo(User user, bool targetPlayer = true);

  [ChatSubCommand("Sim", "Forces an update to path manager", "fpu", ChatAuthorizationLevel.DevTier)]
  public static void ForcePathUpdate(User user, bool targetPlayer = true);
}
