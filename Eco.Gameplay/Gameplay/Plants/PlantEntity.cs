// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Plants.PlantEntity
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Plants;

[Serialized]
public class PlantEntity : Plant
{
  public PlantEntity(PlantSpecies species, WorldPosition3i mapPos, PlantPack plantPack);

  public PlantEntity();

  /// <summary> The skill this plant should give EXP to when harvested. Null if it doesn't return anything</summary>
  public Type SkillType { get; }

  public Result CanScythe(Player player);

  public virtual Result CanHarvest(Player player, bool picked);

  /// <summary> Harvest a plant. </summary>
  /// <param name="player"></param>
  /// <param name="picked">True this picked directly (ie pressing E), or false if harvested with a tool.</param>
  /// <param name="pack"></param>
  /// <param name="changeSet"></param>
  /// <param name="tool"></param>
  public virtual Result TryHarvest(
    Player player,
    bool picked,
    GameActionPack pack,
    InventoryChangeSet changeSet,
    Item tool);

  public List<ItemStack> CalculateHarvestResources(Player player);

  public void ProcessSoilUnderneeth();
}
