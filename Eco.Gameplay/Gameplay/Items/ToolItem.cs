// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ToolItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

[Serialized]
[ItemGroup("Tools")]
[Tag("Tools")]
[Eco.Gameplay.Items.MaxStackSize(1)]
[Tag("CanBeOnSurface")]
public abstract class ToolItem : 
  RepairableItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID,
  IPlaceableItem
{
  protected static SkillModifiedValue CreateCalorieValue(
    float startValue,
    Type skillType,
    Type beneficiary);

  protected static SkillModifiedValue CreateDamageValue(
    float startValue,
    Type skillType,
    Type beneficiary);

  protected static SkillModifiedValue CreateSkillModifiedValue(
    float startValue,
    ModificationStrategy strategy,
    Type skillType,
    Type beneficiary,
    LocString benefitText,
    DynamicValueType valueType);

  public virtual Type? ExperienceSkill { get; }

  public virtual IDynamicValue ExperienceRate { get; }

  public virtual IDynamicValue CaloriesBurn { get; }

  public virtual IDynamicValue DurabilityBurn { get; }

  public virtual IDynamicValue PerkDamage { get; }

  public virtual IDynamicValue Tier { get; }

  public virtual IDynamicValue Damage { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public override bool CanBeHeld { get; }

  public virtual IDynamicValue AnimalDamage { get; }

  public virtual int MaxTake { get; }

  [SyncToView(null, true)]
  public virtual bool CanBeUsedWithEmotes { get; }

  public virtual GameActionDescription DescribeBlockAction { get; }

  public virtual bool IsValidForInteraction(Item item);

  public override void UseDurability(float amountToConsume, Player player, bool notify = true);

  public float NeededCalories(Player? player, float calorieMultiplier = 1f);

  protected void BurnCaloriesNow(Player player, float calorieMultiplier = 1f);

  public void AddExperience(User user, float multiplier, GameActionDescription desc);

  public void AddExperience(User user, float multiplier, LocString desc);

  public virtual void UseTool(GameActionPack pack, MultiblockActionContext context);

  public override bool IsStackable { get; }

  public override bool CanStack(Item? other);

  public virtual bool CanPickUpItemStack(ItemStack stack);

  public virtual LocString GetNoSuitablePickupTargetFailureMessage(Inventory inventory);

  public List<Item>? GetItemsUserCanTake(WorldObject worldObject, Item carriedItem, bool takeAll = false);

  [RPC]
  public void UseToolRPC(Player p);

  protected Inventory? GetPreferredInventoryToPullFrom(WorldObject worldObject);

  public override LocString BrokenDescription { get; }
}
