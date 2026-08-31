// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.MatchesCitizen
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("Test a citizen is as expected.")]
[NoAutogenCode]
public class MatchesCitizen : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen to test.")]
  [Advanced]
  public GameValue<User> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Test if it matches one of the given citizens.")]
  public GamePickerList<User> MatchesTarget { get; set; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
