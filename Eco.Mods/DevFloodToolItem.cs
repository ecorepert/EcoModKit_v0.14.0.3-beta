// Decompiled with JetBrains decompiler
// Type: DevFloodToolItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
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

#nullable enable
[Serialized]
[LocDisplayName("Dev Flood Tool")]
[LocDescription("Flood tool! Left click on the water to remove the top layer, or Right-click on a block to add a water layer.")]
[System.ComponentModel.Category("Hidden")]
public class DevFloodToolItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override 
  #nullable disable
  IDynamicValue SkilledRepairCost { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Liquid"})]
  public void RemoveTopLayerOfWater(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);

  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void AddTopLayerOfWater(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.Shift, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Liquid"})]
  public void RemoveAllConnectedWater(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);
}
