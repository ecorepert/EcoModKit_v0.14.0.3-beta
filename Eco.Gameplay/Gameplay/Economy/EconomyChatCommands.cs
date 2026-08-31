// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.EconomyChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Tests;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy;

[ChatCommandHandler]
public static class EconomyChatCommands
{
  [ChatCommand("Shows commands for crafting process.", ChatAuthorizationLevel.DevTier)]
  public static void Craft(User user);

  public static void StartRecipe(
    User user,
    WorldObject obj,
    RecipeFamily recipe,
    bool provideItems,
    bool provideLabor,
    int count = 1);

  public static void FuelObject(WorldObject obj);

  [CITest(false)]
  [ChatSubCommand("Craft", "Creates a craft setup where output from one thing is input to another.", ChatAuthorizationLevel.DevTier)]
  public static Task SpawnCrafting(User user);

  [CITest(false)]
  [ChatSubCommand("Build", "Spawns a stockpile containing stacks of the listed items.", ChatAuthorizationLevel.Admin)]
  public static Task<StorageComponent?> Stockpile(
    User user,
    string item1 = "BirchLogItem",
    string? item2 = null,
    string? item3 = null,
    string? item4 = null,
    string? item5 = null);

  public static Task<StorageComponent?> SpawnStockpile(
    User user,
    Vector3i pos,
    string item1,
    string? item2 = null,
    string? item3 = null,
    string? item4 = null,
    string? item5 = null);

  public static void SpawnWindmill(User user, Vector3i pos);

  [ChatSubCommand("Build", "Spawns a store with storages and tools of different durability.", ChatAuthorizationLevel.DevTier)]
  public static Task ToolsStore(User user);

  [ChatSubCommand("Build", "Spawns a store with storages and carried items.", ChatAuthorizationLevel.DevTier)]
  public static Task CarriedStore(User user);

  [ChatSubCommand("Build", "Spawns a store with storages and random trade offers.", ChatAuthorizationLevel.DevTier)]
  public static Task Store(User user, int offers = 30, int categories = 8);
}
