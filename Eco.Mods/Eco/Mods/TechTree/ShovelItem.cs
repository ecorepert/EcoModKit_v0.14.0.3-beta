// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ShovelItem
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

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Shovel")]
[Eco.Gameplay.Items.Weight(0)]
[System.ComponentModel.Category("Hidden")]
[Tag("Excavation")]
[Tag("Harvester")]
[Eco.Gameplay.Items.CanAirInteraction]
public abstract class ShovelItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override GameActionDescription DescribeBlockAction { get; }

  public override IDynamicValue CaloriesBurn { get; }

  public override IDynamicValue Tier { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public override int FullRepairAmount { get; }

  public override int MaxTake { get; }

  public override bool IsValidForInteraction(Item item);

  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.True, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Priority = -1f, RequiredEnvVars = new string[] {"Carried"}, Flags = InteractionFlags.MustNotHaveTarget)]
  public bool Drop(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.True, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Diggable"})]
  public bool Dig(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);
}
