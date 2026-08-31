// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ToolInteractAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Buffs;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(false)]
public abstract class ToolInteractAction : 
  InteractAction,
  IToolGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  ICalorieConsumingAction,
  IBuffable
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Calories consumed in performing the action.")]
  public float CaloriesToConsume { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The tool used in the interaction.")]
  [CanAutoAssign]
  public virtual Item ToolUsed { get; set; }

  public Vector3i Position { get; }
}
