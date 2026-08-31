// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.MatchesDeed
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Deeds")]
[LocDescription("Test if a deed matches one from a given list.")]
[NoAutogenCode]
public class MatchesDeed : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The deed to test.")]
  [Advanced]
  public GameValue<Eco.Gameplay.Property.Deed> Deed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Test if it matches one of the given deeds.")]
  public GamePickerList<Eco.Gameplay.Property.Deed> TargetDeed { get; set; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
