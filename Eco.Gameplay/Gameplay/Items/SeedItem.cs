// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SeedItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using Eco.Simulation.Types;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[Tag("Seeds")]
public abstract class SeedItem : 
  FoodItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public abstract LocString SpeciesName { get; }

  public PlantSpecies Species { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Tilled"}, Priority = 5f)]
  public bool Plant(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);
}
