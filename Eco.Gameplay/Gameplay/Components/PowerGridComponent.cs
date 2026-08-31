// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PowerGridComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.PowerGrids;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using PropertyChanged;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[LocDescription("View the production of this generator and the status of the power grid.")]
[RequireComponent(typeof (StatusComponent), null)]
[Eco.Core.Utils.Priority(0)]
[Ecopedia(null, "Power Component", false, true, null)]
[CreateComponentTabLoc("Power", false)]
[HasIcon("PowerComponent")]
public class PowerGridComponent : WorldObjectComponent
{
  public const int Priority = 0;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public PowerGrid PowerGrid { get; set; }

  [SyncToView("EnergyType", true)]
  [DependsOn("EnergyType")]
  public string ViewEnergyType { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  public float Load { get; }

  public float Efficiency { get; }

  public float DurabilityUsedPerHourOfUse { get; set; }

  public float Radius { get; protected set; }

  public bool AlwaysEnabled { get; protected set; }

  [NewTooltipChildren(CacheAs.Instance)]
  [Notify]
  public IPowerEnergyType EnergyType { get; }

  public float EnergyDemand { get; set; }

  public float EnergySupply { get; set; }

  public bool EnergySelfSupply { get; set; }

  public float EnergyAccumalated { get; set; }

  public float AccumulatorCapacity { get; set; }

  public ThreadSafeAction OnChanged { get; }

  public override bool Enabled { get; }

  public int OperatingPriority { get; }

  [SyncToView(null, true)]
  public bool IncludedInGrid { get; }

  public PowerGridComponent();

  public PowerGridComponent(float radius, IPowerEnergyType energyType, bool alwaysEnabled);

  public void Initialize(
    float radius,
    IPowerEnergyType energyType,
    int operationPriority = 0,
    bool alwaysEnabled = false);

  public override void Initialize();

  public override void Destroy();

  /// <summary>Switch to a different energy type at runtime and re-slot onto a grid of the new type. Used when an installed module raises a table's power requirement.</summary>
  public void ChangeEnergyType(IPowerEnergyType newType);

  public override void Tick();

  public override void LateTick();

  public void UpdateEnabled(bool powered, bool isIncludedInGrid);
}
