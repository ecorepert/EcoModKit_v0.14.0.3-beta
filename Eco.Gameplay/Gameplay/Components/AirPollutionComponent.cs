// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.AirPollutionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[Tag("Polluter")]
[Priority(200)]
[NoIcon]
public class AirPollutionComponent : WorldObjectComponent
{
  public PeriodicUpdate PollutionThrottle;
  [Serialized]
  public float QueuedPollution;
  [Serialized]
  public float QueuedTimePollution;

  [Serialized]
  public float PollutionTonsPerHour { get; }

  [Serialized]
  public float TotalTonsPollution { get; }

  [Serialized]
  public double TotalTimeOperating { get; }

  public AirPollutionComponent();

  public AirPollutionComponent(float pollutionTonsPerHour);

  public void Initialize(float pollutionTonsPerHour);

  public AirPollutionComponent(IPolluter pollutingComponent);

  public void Initialize(IPolluter pollutingComponent);

  public override void Initialize();

  public override void Tick();

  public Result TryPollute(float tons, float timePolluting);

  public override void Destroy();
}
