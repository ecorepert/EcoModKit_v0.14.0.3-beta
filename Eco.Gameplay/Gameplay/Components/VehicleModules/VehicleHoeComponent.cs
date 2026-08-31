// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.VehicleModules.VehicleHoeComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Components.VehicleModules;

[Serialized]
[RequireComponent(typeof (VehicleComponent), null)]
[ForceCreateView]
[Tag("Plow")]
[NoIcon]
public class VehicleHoeComponent : WorldObjectComponent
{
  protected 
  #nullable disable
  VehicleComponent vehicle;

  public override WorldObjectComponentClientAvailability Availability { get; }

  public override void Initialize();

  /// <summary> Toggle 'Plowing' mode on or off. </summary>
  [RPC]
  public void EngagePlow(bool on);

  public void OnMoved();
}
