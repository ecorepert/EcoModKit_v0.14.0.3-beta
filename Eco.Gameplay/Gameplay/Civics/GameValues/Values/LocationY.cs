// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.LocationY
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
[LocDescription("Gets the Y coordinate (elevation) of a location.")]
[LocCategory("Location")]
public class LocationY : GameValue<float>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The location to get the Y coordinate (elevation) from.")]
  public GameValue<Vector3i> Location { get; set; }

  public override LocString Description();

  protected override Eval<float> Evaluate(IContextObject action);
}
