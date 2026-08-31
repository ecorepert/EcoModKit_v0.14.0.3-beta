// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.Tortoise
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Animals;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Mods.Organisms;

public class Tortoise : AnimalEntity
{
  public Tortoise(
    Animal parent,
    Vector3 pos,
    AnimalSpecies species,
    bool corpse,
    bool sick,
    int herdID);

  public static float BlockDamage(INetObject damager, float damage, AnimalEntity entity);

  public override GameActionPack TryApplyDamage(
    GameActionPack pack,
    INetObject damager,
    float damage,
    InteractionTarget target,
    Item tool,
    out float damageReceived,
    Type damageDealer = null,
    float experienceMultiplier = 1f);
}
