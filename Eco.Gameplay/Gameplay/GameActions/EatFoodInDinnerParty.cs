// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.EatFoodInDinnerParty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Dinner Party")]
[LocDescription("A citizen ate a food item at a dinner party.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the deed and the citizen's settlements.")]
[CannotBePrevented]
public class EatFoodInDinnerParty : 
  DinnerPartyCitizenAction,
  IItemGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The food that was eaten.")]
  [CanAutoAssign]
  public Item ItemUsed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The table the food was eaten at.")]
  public Item Table { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The chair the citizen was seated on.")]
  public Item Chair { get; set; }
}
