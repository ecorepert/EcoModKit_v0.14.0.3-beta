// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.GroundDistance
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Distance between two locations, ignoring vertical difference.")]
[LocCategory("World")]
public class GroundDistance : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("First location to check.")]
  public GameValue<Vector3i> Location1 { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Second location to check.")]
  public GameValue<Vector3i> Location2 { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
