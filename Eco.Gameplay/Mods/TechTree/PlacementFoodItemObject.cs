// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PlacementFoodItemObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Mods.TechTree;

[Serialized]
[Tag("Usable")]
public class PlacementFoodItemObject : PlacementSpoilageItemObject, IHasInteractions, IHasEnvVars
{
  [Interaction(InteractionTrigger.RightClick, "%EatOrBuyLabel%", InteractionModifier.None, new string[] {"CanBuy"}, 0.0f, 3f, ClientPredictedBlockAction.None, 0, false, TriBool.False, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, DisallowedEnvVars = new string[] {"IsSpoiled"})]
  [Interaction(InteractionTrigger.RightClick, "%EatOrBuyLabel%", InteractionModifier.None, null, 0.0f, 2f, ClientPredictedBlockAction.None, 0, false, TriBool.False, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, DisallowedEnvVars = new string[] {"IsSpoiled", "CanBuy"}, Flags = InteractionFlags.SurfacePlacedSpecialHierarchyAuth)]
  public void Eat(
  #nullable disable
  Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, "Take", InteractionModifier.None, null, 0.0f, 1f, ClientPredictedBlockAction.None, 0, false, TriBool.False, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, DisallowedEnvVars = new string[] {"CanBuy"}, Flags = InteractionFlags.SurfacePlacedSpecialHierarchyAuth)]
  public Task<bool> TakeFood(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  /// <summary>Right click label, resolved per viewer: a customer is told what the dish costs, and everyone how it tastes to them.</summary>
  [EnvVar]
  public string EatOrBuyLabel(User user);
}
