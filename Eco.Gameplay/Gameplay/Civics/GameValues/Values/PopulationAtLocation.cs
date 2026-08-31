// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.PopulationAtLocation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using NLog.Config;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Residency")]
[LocDescription("Population values at given location.")]
public class PopulationAtLocation : PopulationGameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Location to query population.")]
  [Advanced]
  public GameValue<Vector3i> Location { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
