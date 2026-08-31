// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.IsCitizenOfSettlement
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
[LocCategory("Citizens")]
[LocDescription("Is this citizen currently a member of the given settlement?")]
[RelatedFeature("UseSettlementSystem", true)]
public class IsCitizenOfSettlement : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The person has direct citizenship or can be in a children settlements.")]
  public CitizenshipType CitizenshipType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The settlement they must be a member of.")]
  public GameValue<Eco.Gameplay.Settlements.Settlement> Settlement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("The person being checked.")]
  public GameValue<User> Citizen { get; set; }

  protected override Eval<bool> Evaluate(IContextObject action);

  public override LocString Description();
}
