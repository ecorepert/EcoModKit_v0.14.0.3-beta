// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Types.Species
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Simulation.WorldLayers.Layers;
using Eco.Stats;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Types;

[StartsDiscovered]
[Localized(true, false, "", false)]
[ForceCreateViewAllDerived]
[SerializedDerived]
[Stat("Populations", Unit.Population, StatType.ContinuousValue)]
[HasIcon(null)]
public abstract class Species : IController, IViewController, IHasUniversalID, IStat
{
  public static ThreadSafeAction<Species> PopulationChangedEvent;
  public const string SpeciesStatCategory = "Populations";
  public static Dictionary<string, Type> MinNameToType;

  public Type InstanceType { get; set; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public LocString DisplayName { get; set; }

  [SyncToView(null, true)]
  public LocString DisplayDescription { get; set; }

  [SyncToView(null, true)]
  public float MaturityAgeDays { get; set; }

  [SyncToView(null, true)]
  public float CalorieValue { get; set; }

  [SyncToView(null, true)]
  public float ResourceBonusAtGrowth { get; set; }

  [SyncToView(null, true)]
  public int VoxelsPerEntry { get; set; }

  [SyncToView(null, true)]
  public string[] Tags { get; set; }

  [SyncToView(null, true)]
  public float HerdRadius { get; set; }

  [SyncToView(null, true)]
  public float MinDistanceWithinHerd { get; set; }

  [SyncToView(null, true)]
  public SpeciesFlags Flags { get; set; }

  [SyncToView(null, true)]
  public Type ResourceItemType { get; }

  public List<SpeciesResource> ResourceList { get; set; }

  public float ReleasesCO2TonsPerDay { get; set; }

  public string UniqueAbbreviation { get; }

  public void Initialize();

  public override string ToString();

  public virtual string GetErrorDescription();

  public LocString GetWorldLayerMinimapName();

  public Eco.Shared.Math.Range ResourceRange { get; }

  public void OnBirth();

  public void OnDeath(int amount = 1);

  public SpeciesLayer Layer { get; }

  public ref int ControllerID { get; }
}
