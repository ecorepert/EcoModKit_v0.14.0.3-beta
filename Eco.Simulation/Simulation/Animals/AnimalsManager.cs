// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Animals.AnimalsManager
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System.ComponentModel;

#nullable disable
namespace Eco.Simulation.Animals;

[Serialized]
public class AnimalsManager : 
  Singleton<AnimalsManager>,
  ISimplePluginData,
  IStorage,
  ISerializable,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  /// <summary>Event triggered when animal population is reduced due to hunting or catching. Arguments: (species, hunter, worldPos, oldPopulation, newPopulation)</summary>
  public static readonly ThreadSafeAction<AnimalSpecies, INetObject, Vector2i, float, float> AnimalPopulationReducedEvent;
  public HerdManager HerdManager;
  public ThreadSafeList<Animal> Animals;
  public static ThreadSafeAction<AnimalSpecies, INetObject> SpeciesWentExtinctEvent;
  public static ThreadSafeAction<AnimalSpecies> SpeciesRecoveredEvent;
  public IAnimalUtils Utils;

  public IPersistent StorageHandle { get; set; }

  public ObserverManager ObserverManager { get; }

  public bool AllowSpawn { get; set; }

  [SyncToView(null, true)]
  public bool DebugAll { get; set; }

  [SyncToView(null, true)]
  public bool AlwaysAttack_Debug { get; set; }

  public void Initialize(IAnimalUtils utils);

  /// <summary>Reduces species population at a world position and checks for extinction. Used for hunted animals and entity-less catches (traps, nets).</summary>
  public void ReducePopulation(
    AnimalSpecies species,
    Vector2i worldPos,
    int amount = 1,
    INetObject source = null);

  /// <summary>Adds species population into habitable cells around a world position, nearest cell first, capped at each cell's habitability limit.
  /// The inverse of <see cref="M:Eco.Simulation.Animals.AnimalsManager.ReducePopulation(Eco.Simulation.Types.AnimalSpecies,Eco.Shared.Math.Vector2i,System.Int32,Eco.Shared.Networking.INetObject)" />, used to recover areas fished or hunted out. Returns the amount actually placed.</summary>
  public float RestockPopulation(
    AnimalSpecies species,
    Vector2i worldPos,
    float amount,
    int radiusBlocks);

  /// <summary>Refills every dead but habitable cell of the species layer to its full supportable population, world wide.
  /// A deliberate one time repair for populations that were drained in error: capacity is the strongest possible seed, since anything
  /// above it decays back off the cap. Natural extinction stays possible afterwards, since nothing reseeds without this being invoked again.</summary>
  public (int Cells, float Added) RestockDeadZones(AnimalSpecies species);

  public void Update();

  public void AnimalDestroyed(Animal animal);

  public void AnimalAdded(Animal animal);

  /// <summary> Gets state info for plugin manager </summary>
  public string GetDisplayText();

  public override string ToString();

  public string GetStatus();

  public string GetCategory();

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
