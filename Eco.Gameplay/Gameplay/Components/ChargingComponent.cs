// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ChargingComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(-2)]
[RequireComponent(typeof (StatusComponent), null)]
[NoIcon]
public class ChargingComponent : WorldObjectComponent, IOperatingWorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public int TargetID { get; }

  [SyncToView(null, true)]
  public float TimeToExpend { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public float TimeExpended { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public bool Activated { get; set; }

  public bool Operating { get; }

  public void Initialize(float timeToCharge, float timeToExpend);

  public override void Destroy();

  public override void Initialize();

  public override void Tick();

  public void Activate();

  public void Deactivate();
}
