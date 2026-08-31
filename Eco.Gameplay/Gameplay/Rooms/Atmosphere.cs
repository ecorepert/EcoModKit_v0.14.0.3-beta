// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.Atmosphere
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Rooms;

[Serialized]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class Atmosphere : IController, IViewController, IHasUniversalID
{
  public float Oxygen { get; set; }

  public float CO2 { get; set; }

  public float Nitrogen { get; set; }

  [SyncToView(null, true)]
  public float RadiationCPM { get; set; }

  [SyncToView(null, true)]
  public float Temperature { get; set; }

  [SyncToView(null, true)]
  public float OxygenPercent { get; }

  [SyncToView(null, true)]
  public float CO2Percent { get; }

  [SyncToView(null, true)]
  public float NitrogenPercent { get; }

  [SyncToView(null, true)]
  public float Sum { get; }

  public ref int ControllerID { get; }

  public void Merge(Atmosphere other);

  public void CopyFrom(Atmosphere other);

  public Atmosphere Clone();

  public float this[Type itemType] { get; set; }

  public override string ToString();

  public static Atmosphere operator *(Atmosphere a, double val);
}
