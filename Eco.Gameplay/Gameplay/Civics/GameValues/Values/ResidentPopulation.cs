// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.ResidentPopulation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Residency")]
[LocDescription("Get number of residents within a set of districts.")]
public class ResidentPopulation : DistrictGameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Queries population overlapping or contained in specific districts.")]
  public DeedRelationToDistrict PropertyType { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
