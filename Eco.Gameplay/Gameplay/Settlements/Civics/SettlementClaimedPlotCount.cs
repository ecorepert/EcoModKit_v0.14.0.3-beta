// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.SettlementClaimedPlotCount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Settlements")]
[LocDescription("The number of plots claimed on deeds by the settlement.")]
[RelatedFeature("UseSettlementSystem", true)]
public class SettlementClaimedPlotCount : SettlementProperty<float>
{
  protected override Eval<float> GetProp(Eco.Gameplay.Settlements.Settlement set);

  public override LocString Description();
}
