// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.SettlementGovernmentFunds
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Settlements")]
[LocDescription("The total amount of a currency held across all government bank accounts of the given settlement.")]
[RelatedFeature("UseSettlementSystem", true)]
public class SettlementGovernmentFunds : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The settlement being queried.")]
  [CanAutoAssign]
  public GameValue<Eco.Gameplay.Settlements.Settlement> Settlement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The currency to total.")]
  public GameValue<Eco.Gameplay.Economy.Currency> Currency { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();
}
