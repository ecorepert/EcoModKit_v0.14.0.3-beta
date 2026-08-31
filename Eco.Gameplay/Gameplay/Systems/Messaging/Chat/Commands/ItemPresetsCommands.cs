// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.ItemPresetsCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class ItemPresetsCommands
{
  public static readonly string[] StoragesTypes;

  [ChatCommand("Shows commands for spawning a storage with predefined set of items in the game", ChatAuthorizationLevel.DevTier)]
  public static void Preset(User user);

  [ChatSubCommand("Preset", "Spawns vehicle items", ChatAuthorizationLevel.DevTier)]
  public static void Vehicles(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Generator items", ChatAuthorizationLevel.DevTier)]
  public static void Generators(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns CraftingStation items", ChatAuthorizationLevel.DevTier)]
  public static void Crafting(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Storage items", ChatAuthorizationLevel.DevTier)]
  public static void Storages(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Housing items", ChatAuthorizationLevel.DevTier)]
  public static void Housing(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns chair-related items", ChatAuthorizationLevel.DevTier)]
  public static void Chairs(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Housing industrial items", ChatAuthorizationLevel.DevTier)]
  public static void Industrial(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Housing cultural items", ChatAuthorizationLevel.DevTier)]
  public static void Cultural(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Housing seating items", ChatAuthorizationLevel.DevTier)]
  public static void Seating(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Housing main room items", ChatAuthorizationLevel.DevTier)]
  public static void Mainroom(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Lighting items", ChatAuthorizationLevel.DevTier)]
  public static void Lights(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Tools items", ChatAuthorizationLevel.DevTier)]
  public static void Tools(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Food items", ChatAuthorizationLevel.DevTier)]
  public static void Food(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Blocks items", ChatAuthorizationLevel.DevTier)]
  public static void Blocks(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Fuel items", ChatAuthorizationLevel.DevTier)]
  public static void Fuel(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Hidden items", ChatAuthorizationLevel.DevTier)]
  public static void Hidden(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Resources items", ChatAuthorizationLevel.DevTier)]
  public static void Resources(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns SkillScrolls items", ChatAuthorizationLevel.DevTier)]
  public static void Scrolls(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Clothing items", ChatAuthorizationLevel.DevTier)]
  public static void Clothes(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Economy items", ChatAuthorizationLevel.DevTier)]
  public static void Economy(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Power dependent items", ChatAuthorizationLevel.DevTier)]
  public static void Power(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns Housing items", ChatAuthorizationLevel.DevTier)]
  public static void Planter(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns table items that can have things placed on them", ChatAuthorizationLevel.DevTier)]
  public static void TableSurface(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns items that can be placed on tables", ChatAuthorizationLevel.DevTier)]
  public static void TablePlaceable(User user, int sType = 0);

  [ChatSubCommand("Preset", "Spawns All Presets (Exept hidden)", ChatAuthorizationLevel.DevTier)]
  public static void All(User user, int sType = 0);

  public static void SpawnStorage<T>(
    User user,
    string label,
    int sType,
    List<T> items,
    int randQuantityRange = 0)
    where T : Item;

  public static void SpawnStorage<T>(
    User user,
    string label,
    string name,
    List<T> items,
    int randQuantityRange = 0)
    where T : Item;
}
