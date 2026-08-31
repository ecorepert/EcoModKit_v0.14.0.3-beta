// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.HouseValueAtDistricts
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.LegislationSystem;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Residency")]
[LocDescription("Get a value related to housing at given districts.")]
public class HouseValueAtDistricts : HouseValueGameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The list of districts to query.")]
  public GamePickerList<District> Districts { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Defines what analysis of the data you want to perform.")]
  public AnalysisValue AnalysisType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The relation of resident's property and the districts.")]
  public DeedRelationToDistrict PropertyRelationType { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
