// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.AnimalEntity
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Animals;

[Serialized]
public class AnimalEntity : Animal, IDamageable, IHasInteractions
{
  public static Action<Player, AnimalEntity> OnAttackAnimal;

  public AnimalEntity(
    Animal parent,
    Vector3 pos,
    AnimalSpecies species,
    bool corpse,
    bool sick,
    int herdID);

  public virtual GameActionPack TryApplyDamage(
    GameActionPack pack,
    INetObject damager,
    float damage,
    InteractionTarget target,
    Item tool,
    out float damageReceived,
    Type damageDealer = null,
    float experienceMultiplier = 1f);

  public float InteractDistance { get; }

  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, new string[] {"isDead"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void PickUp(Player player, InteractionTriggerInfo trigger, InteractionTarget target);
}
