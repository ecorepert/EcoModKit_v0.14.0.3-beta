// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.Interactors.HandsInteractor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Interactions.Interactors;

[ForceCreateView]
public sealed class HandsInteractor : 
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.Harvest, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"FastPickupable"}, Priority = 1f, MinCaloriesRequired = 1f, CanHoldToTrigger = TriBool.True)]
  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.Harvest, 0, true, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Pickupable"}, MinCaloriesRequired = 0.0f)]
  public bool Take(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, new string[] {"HasDebrisPickup"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"DebrisPickupable"}, MinCaloriesRequired = 1f)]
  public bool PickupDebris(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, null, 0.0f, -1f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {"Usable"}, MinCaloriesRequired = 0.0f)]
  public void Use(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
