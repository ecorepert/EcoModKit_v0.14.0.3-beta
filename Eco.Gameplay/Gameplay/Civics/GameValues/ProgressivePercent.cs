// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.ProgressivePercent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.View;
using JetBrains.Annotations;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Math")]
[LocDescription("Choose a percent based on increasing thresholds, like tax-brackets.")]
public class ProgressivePercent : 
  GameValue<float>,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [NonNegativeValue]
  [LocDescription("Value to query.")]
  public GameValue<float> Number { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowEmpty]
  [Advanced]
  [LocDescription("List of threshold to query progressive percent value.")]
  public ControllerList<ThresholdMileStone> Thresholds { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
