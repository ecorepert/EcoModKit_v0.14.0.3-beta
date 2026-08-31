// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Constitutional;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Civics.Districts;
using Eco.Gameplay.Civics.Economy;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Immigration;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Civics.Titles;
using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Settlements.Culture;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Simulation.Time;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics;

[Serialized]
public class CivicsData : 
  Singleton<
  #nullable disable
  CivicsData>,
  IStorage,
  ISerializable,
  IThreadSafeSubscriptions,
  ISubscriptions<
  #nullable enable
  ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  public 
  #nullable disable
  ElectionManager ElectionManager;
  [Serialized]
  public LawManager LawManager;
  [Serialized]
  public DemographicManager DemographicManager;
  [Serialized]
  public ConstitutionManager ConstitutionManager;
  [Serialized]
  public AggregateUserAmountManager AggregateUserAmountManager;
  [Serialized]
  public CultureManager CultureManager;
  public CivicsManager CivicsManager;
  public ElectionProcessManager ElectionProcessManager;
  [Serialized]
  public Registrar<CivicArticle> CivicArticles;
  [Serialized]
  public Registrar<ElectionProcess> ElectionProcesses;
  [Serialized]
  public Registrar<Law> Laws;
  [Serialized]
  public Registrar<Eco.Gameplay.Civics.Elections.Election> Election;
  [Serialized]
  public Registrar<Title> Titles;
  [Serialized]
  public Registrar<District> Districts;
  [Serialized]
  public Registrar<DistrictMap> DistrictMaps;
  [Serialized]
  public Registrar<Demographic> Demographics;
  [Serialized]
  public Registrar<Constitution> Constitutions;
  [Serialized]
  public Registrar<ConstitutionalAmendment> ConstitutionalAmendments;
  [Serialized]
  public Registrar<ImmigrationPolicy> ImmigrationPolicies;
  [Serialized]
  public Registrar<Injunction> Injunctions;
  public PeriodicUpdateConfig UpdateTimer;
  public List<IRegistrar> CivicsRegistrars;

  [Serialized]
  [ForceSerializeFullObject]
  public ControllerList<Eco.Gameplay.UI.WorldMarker.WorldMarker> GlobalMarkerList { get; }

  public IPersistent StorageHandle { get; set; }

  public void InitializeRegistrars();

  /// <summary>Deactivate all proposables for a given settlement, or all settlement if null.</summary>
  public List<IProposable> DeactivateGovernment(
    Settlement settlement,
    bool notify,
    bool deactivateCoreProposables);

  public void Initialize();

  public void TickAll();

  public void QueueUpCivicsTick();

  public string Describe(bool showEmptyLists = true);

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
