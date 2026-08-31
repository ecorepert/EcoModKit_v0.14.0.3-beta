// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Plants.PlantGameActions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Simulation.Types;

#nullable enable
namespace Eco.Gameplay.Plants;

/// <summary>Plant related game actions.</summary>
public static class PlantGameActions
{
  public static ThreadSafeAction<User, PlantSpecies> PlantSeededEvent;

  /// <summary>Creates <see cref="T:Eco.Gameplay.GameActions.GameActionPack" />, adds plant seed action to it and tries to perform.</summary>
  public static Result TrySeed(
    this PlantSpecies species,
    Vector3i spawnPos,
    User seeder,
    Item? tool = null);

  /// <summary>Creates <see cref="T:Eco.Gameplay.GameActions.GameActionPack" />, adds plant seed action to it, removes seed item from inventory and tries to perform.</summary>
  public static Result TrySeedFromInventory(
    this SeedItem seed,
    ItemStack stack,
    Inventory inventory,
    Vector3i spawnPos,
    User seeder,
    Item? tool = null);

  /// <summary>Adds plant seed action to <paramref name="pack" /> and spawn tended plant as post effect.</summary>
  public static void AddSeedAction(
    this GameActionPack pack,
    PlantSpecies species,
    Vector3i spawnPos,
    User seeder,
    Item? tool = null);
}
