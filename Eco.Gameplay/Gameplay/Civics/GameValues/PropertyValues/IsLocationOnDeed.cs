// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.IsLocationOnDeed
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Deeds")]
[LocDescription("Test if a given location is on one of the given deeds.")]
[NoAutogenCode]
public class IsLocationOnDeed : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The location to check.")]
  [Advanced]
  public GameValue<Vector3i> Location { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Test if the location is on one of these deeds.")]
  public GamePickerList<Deed> TargetDeed { get; set; }

  public override LocString Description();

  protected override Eval<bool> Evaluate(IContextObject action);
}
