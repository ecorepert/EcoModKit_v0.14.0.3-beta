// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PickaxeItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Pickaxe")]
[Eco.Gameplay.Items.Weight(0)]
[System.ComponentModel.Category("Hidden")]
[Tag("Excavation")]
public abstract class PickaxeItem : 
  WeaponItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override IDynamicValue CaloriesBurn { get; }

  public override Item RepairItem { get; }

  [SyncToView(null, true)]
  public override IDynamicValue Damage { get; }

  [SyncToView(null, true)]
  public override IDynamicValue Tier { get; }

  [SyncToView(null, true)]
  public override IDynamicValue PerkDamage { get; }

  public override int FullRepairAmount { get; }

  public override bool CanPickUpItemStack(ItemStack stack);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Minable"}, AnimationDriven = true)]
  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, "#FFFF00", AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"MinableRubble"}, AnimationDriven = true)]
  public bool Mine(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);
}
