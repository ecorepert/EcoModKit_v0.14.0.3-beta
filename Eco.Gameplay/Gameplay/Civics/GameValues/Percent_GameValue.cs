// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Percent_GameValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("Percent")]
[LocCategory("Math")]
[LocDescription("Take a percentage of a given number.")]
public class Percent_GameValue : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [NegativeAllowed]
  [LocDescription("The value to take the percent from.")]
  public GameValue<float> Number { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [NegativeAllowed]
  [LocDescription("The percentage to take.  100 = 100%.")]
  public GameValue<float> Percent { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();
}
