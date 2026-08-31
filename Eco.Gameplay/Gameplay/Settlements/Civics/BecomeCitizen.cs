// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.BecomeCitizen
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Settlements")]
[LocDescription("Triggered when citizenship is gained.")]
[CannotBePrevented]
public class BecomeCitizen : 
  GameAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Is this the first time they're becoming a citizn of this settlement (direct or indirect)?")]
  public FirstTimeOrNotFirstTime FirstTimeJoining { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Is the citizen becoming a direct citizen, or are they becoming a citizen of a child settlement?")]
  public bool DirectCitizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The person becoming a citizen.")]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The settlement they became a direct citizen of.")]
  public Settlement Settlement { get; set; }

  public override IEnumerable<Settlement> SettlementScopes { get; }
}
