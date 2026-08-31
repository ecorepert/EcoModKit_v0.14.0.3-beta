// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.FertilizerItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Items;

[System.ComponentModel.Category("Hidden")]
[Eco.Gameplay.Items.MaxStackSize(50)]
public abstract class FertilizerItem : 
  Item,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public abstract FertilizerNutrients Nutrients { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 5f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Samplable", "Clearable"})]
  public bool ApplyFertilizer(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);
}
