// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.CitizenshipTimeInHours
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Settlements")]
[LocDescription("Measure of how long a Citizen has been a member of a settlement.")]
[RelatedFeature("UseSettlementSystem", true)]
public class CitizenshipTimeInHours : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The person being checked.")]
  [CanAutoAssign]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The settlement to test.")]
  [CanAutoAssign]
  [Advanced]
  public GameValue<Eco.Gameplay.Settlements.Settlement> Settlement { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();
}
