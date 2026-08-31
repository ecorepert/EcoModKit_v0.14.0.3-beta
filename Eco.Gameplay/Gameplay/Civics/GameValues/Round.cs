// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Round
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Math")]
[LocDescription("Rounds a value to the nearest whole number.")]
public class Round : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The value to round.")]
  public GameValue<float> Number { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("How to round it.")]
  public RoundOperation RoundType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("Which multiple to round to. (IE, enter '50' and 'Round Down' to round 180 to 150)")]
  public GameValue<float> RoundToMultiple { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
