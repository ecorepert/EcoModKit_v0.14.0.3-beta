// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.DinnerPartyStarted
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Dinner Party")]
[LocDescription("A dinner party has started.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the deed and the citizens' settlements.")]
[CannotBePrevented]
public class DinnerPartyStarted : DinnerPartyCitizenAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The second citizen to dine, whose arrival started the party.")]
  public User SecondCitizen { get; set; }

  protected override IEnumerable<User> InvolvedCitizens { get; }
}
