// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.Stats.Population
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;
using Eco.Simulation.Types;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values.Stats;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Statistics")]
[LocDescription("Current population of a given species.")]
public class Population : StatGameValue
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The species which should have its population measured.")]
  public GamePickerList<Species> SpeciesTypes { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
