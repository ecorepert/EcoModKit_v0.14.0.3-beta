// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.FuelSupplyComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using JetBrains.Annotations;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components.Storage;

/// <summary>Stores fuel and provides energy to consuming components. Persists the active fuel item across pickup/putdown.</summary>
[Serialized]
[LocDescription("View and set the fuel consumed by this object.")]
[RequireComponent(typeof (StatusComponent), null)]
[DefaultToUnlinked]
[Priority(100)]
[Ecopedia(null, "Power Component", false, true, null)]
[CreateComponentTabLoc("Power", false)]
[HasIcon("PowerComponent")]
public class FuelSupplyComponent : 
  StorageComponent,
  INotifyPropertyChanged,
  IHasEnvVars,
  IPersistentData,
  IItemConsumingComponent
{
  public 
  #nullable disable
  IEnumerable<Inventory> ConsumedInventories { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Item CurrentFuel { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public float Energy { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float PeakEnergy { get; }

  [Serialized]
  [SyncToView(SyncFlags.MustRequest)]
  public float ConsumptionRate { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float EnergyInSupply { get; }

  [SyncToView(null, true)]
  public string FuelTypesString { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  [PublicAPI]
  public IEnumerable<string> FuelTags { get; }

  public Item HighestValueFuel { get; }

  public override Inventory Inventory { get; }

  [DoNotNotify]
  public override bool Enabled { get; }

  public object PersistentData { get; set; }

  public FuelSupplyComponent();

  public FuelSupplyComponent(int numFuelSlots, params string[] fuelTags);

  [Interaction(InteractionTrigger.RightClick, "Put %SelectedNonTool% into fuel tank", InteractionModifier.Shift, new string[] {"SelectedNonTool", "CanPutIntoFuelTank"}, 0.0f, 1f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void PutItem(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [EnvVar]
  [Notify]
  [DependsOnMember("Inventory")]
  public bool CanPutIntoFuelTank(User user);

  public void Initialize(int numFuelSlots, string[] fuelTags);

  public override void Initialize();

  public override void Destroy();

  public override void LateTick();

  /// <summary> Checks whether it's possible for the component to burn provided amount of energy. </summary>
  public bool CanConsumeFuel(float joules);

  /// <summary>Consumes as much <paramref name="joules" /> as possible and returns actually consumed joules. It tries to load fuel from inventory when Energy fully consumed.</summary>
  public float ConsumeAsMuchAsPossible(float joules);
}
