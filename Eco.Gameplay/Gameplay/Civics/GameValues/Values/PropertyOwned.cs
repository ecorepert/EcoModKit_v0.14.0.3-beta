// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.PropertyOwned
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("How many property plots a person owns or is a manager of. Multiple owners yields a pro-rated ownership amount.")]
public class PropertyOwned : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The person whose property is being checked. Leave blank to count property owned by anyone.")]
  [AllowNullInView]
  public GameValue<IAlias> Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Districts to check with property.  Leave empty to ignore districts.")]
  [AllowEmpty]
  public GamePickerList<District> Districts { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Limit to properties under the influence of this settlement.  Leave empty to ignore settlements.")]
  [AllowNullInView]
  public GameValue<Settlement> InSettlement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Will only count plots not influenced by the given settleemnt.  Leave empty to ignore settlements.")]
  [AllowNullInView]
  public GameValue<Settlement> NotInSettlement { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Must be inside or outside the listed districts?")]
  [Advanced]
  public InsideOrOutside Requirements { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Ignores property owned by demographics or elected titles.")]
  public bool IgnoreGovernmentOwned { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If multiple people own a property (titles), this will weight ownership evenly among them.")]
  public bool WeightByPercentOwned { get; set; }

  protected override Eval<float> Evaluate(IContextObject action);

  public override LocString Description();
}
