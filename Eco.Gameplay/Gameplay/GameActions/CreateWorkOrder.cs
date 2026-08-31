// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.CreateWorkOrder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Crafting")]
[LocDescription("A work order was created.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of.")]
public class CreateWorkOrder : 
  WorkOrderAction,
  ICurrencyGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency used to pay the crafting fee.")]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount paid in fee to craft.")]
  public float CurrencyAmount { get; set; }
}
