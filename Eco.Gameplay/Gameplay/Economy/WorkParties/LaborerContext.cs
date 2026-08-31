// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.LaborerContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public class LaborerContext : IContextObject, IController, IViewController, IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The laborer applying to be in this work party.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  public ref int ControllerID { get; }
}
