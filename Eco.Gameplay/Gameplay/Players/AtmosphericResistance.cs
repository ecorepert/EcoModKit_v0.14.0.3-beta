// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.AtmosphericResistance
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Rooms;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class AtmosphericResistance : IController, IViewController, IHasUniversalID
{
  public AtmosphericResistance();

  public AtmosphericResistance(
    float percentOxygenMin,
    float percentOxygenMax,
    float pressureMin,
    float pressureMax,
    float radiationCPMMin,
    float radiationCPMMax);

  public ref int ControllerID { get; }

  public static AtmosphericResistance Human { get; }

  public bool Resists(Room room);

  public float Damage(Room room);

  public float OxygenDamage(Atmosphere atmosphere);

  public float PressureDamage(Room room);

  public float RadiationDamage(Atmosphere atmosphere);

  [SyncToView(null, true)]
  public float PercentOxygenMin { get; set; }

  [SyncToView(null, true)]
  public float PercentOxygenMax { get; set; }

  [SyncToView(null, true)]
  public float PressureMin { get; set; }

  [SyncToView(null, true)]
  public float PressureMax { get; set; }

  [SyncToView(null, true)]
  public float RadiationCPMMin { get; set; }

  [SyncToView(null, true)]
  public float RadiationCPMMax { get; set; }

  public float PercentOxygenRange { get; }

  public float PressureRange { get; }

  public float RadiationCPMRange { get; }
}
