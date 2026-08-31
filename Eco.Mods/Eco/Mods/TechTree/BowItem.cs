// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.BowItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

[Tag("Harvester")]
[Serialized]
[LocDisplayName("Bow")]
[Eco.Gameplay.Items.Weight(0)]
[System.ComponentModel.Category("Hidden")]
public abstract class BowItem : 
  RangeWeaponItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override IDynamicValue SkilledRepairCost { get; }

  public override ItemHandOrigin HandOrigin { get; }

  public override IDynamicValue CaloriesBurn { get; }

  public override IDynamicValue Damage { get; }

  public override Type ExperienceSkill { get; }

  public override IDynamicValue ExperienceRate { get; }

  public override Tag RepairTag { get; }

  public override int FullRepairAmount { get; }

  protected virtual Type ToolType { get; }

  [SyncToView(null, true)]
  public virtual float FireVelocity { get; }

  [SyncToView(null, true)]
  public virtual float DrawTime { get; }

  [SyncToView(null, true)]
  public virtual string ArrowPrefab { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.True, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Flags = InteractionFlags.NoTargetRequired)]
  public void ShootInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [RPC]
  public int Shoot(Player player, Vector3 position, Vector3 velocity);

  public override void UseTool(GameActionPack pack, MultiblockActionContext context);
}
