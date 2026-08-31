// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.HoeItem
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
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Hoe")]
[LocDescription("Used to till soil and prepare it for planting.")]
[System.ComponentModel.Category("Hidden")]
[Hoer]
[Tag("Plow")]
public abstract class HoeItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override GameActionDescription DescribeBlockAction { get; }

  public override int FullRepairAmount { get; }

  public override Item RepairItem { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public override IDynamicValue CaloriesBurn { get; }

  public override IDynamicValue Tier { get; }

  public override Type ExperienceSkill { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Tillable"})]
  public bool Hoe(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);
}
