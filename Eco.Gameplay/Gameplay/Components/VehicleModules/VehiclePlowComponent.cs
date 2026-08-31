// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.VehicleModules.VehiclePlowComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components.VehicleModules;

/// <summary>Carries the furrow-width setting for a steam tractor plow attachment, toggled by the module's control binding.</summary>
[Serialized]
[ForceCreateView]
[NoIcon]
public class VehiclePlowComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool WideFurrow { get; set; }

  [RPC]
  public void SetWideFurrow(bool value);
}
