// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.CitizenshipOfCitizen
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Settlements")]
[LocDescription("Provides the settlement influencing the given location.")]
[RelatedFeature("UseSettlementSystem", true)]
public class CitizenshipOfCitizen : GameValue<Settlement>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The type of settlement to query.")]
  public SettlementTypeIndicator_Hack SettlementType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The person being checked.")]
  public GameValue<User> Citizen { get; set; }

  protected override Eval<Settlement> Evaluate(IContextObject action);

  public override LocString Description();
}
