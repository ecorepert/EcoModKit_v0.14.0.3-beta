// Decompiled with JetBrains decompiler
// Type: Eco.Mods.SimCommands
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Mods;

[ChatCommandHandler]
public static class SimCommands
{
  [ChatSubCommand("Sim", "Shows the last set of cached population changes with hourly and daily rate estimates", "popchanges", ChatAuthorizationLevel.User)]
  public static void ShowPopulationChanges(User user);

  [ChatSubCommand("Sim", "Lists animal populations at specified location (or current location), including animals with 0 population", "animalpop", ChatAuthorizationLevel.User)]
  public static void ListAnimalPopulations(User user, float x = -1f, float z = -1f);

  [ChatSubCommand("Sim", "Lists plant populations at specified location (or current location), including underwater plants and plants with 0 population", "plantpop", ChatAuthorizationLevel.User)]
  public static void ListPlantPopulations(User user, float x = -1f, float z = -1f);

  [ChatSubCommand("Sim", "Toggles animal population change notifications on/off to all users.", "animalnotify", ChatAuthorizationLevel.Admin)]
  public static void ToggleAnimalNotifications(User user);

  [ChatSubCommand("Sim", "Destroys a specified amount of a given species from surrounding area", "cull", ChatAuthorizationLevel.Admin)]
  public static void CullSpecies(User user, string speciesName, float amount = 10f, float distance = 50f);

  [ChatSubCommand("Sim", "Refills every dead but habitable spot of a species to its full capacity, world wide. All species when unset. A one time repair after erroneous population loss; extinction stays possible afterwards.", "restockdead", ChatAuthorizationLevel.Admin)]
  public static void RestockDeadZones(User user, string speciesName = null);

  [ChatSubCommand("Sim", "Adds population of a given species to the habitable area around you, filling each spot up to its capacity", "restock", ChatAuthorizationLevel.Admin)]
  public static void RestockSpecies(User user, string speciesName, float amount = 10f, int distance = 100);

  [CITest(false)]
  [ChatSubCommand("Sim", "Raises the sea level by a passed in amount.  Careful with this one!", ChatAuthorizationLevel.DevTier)]
  public static void RaiseSeaLevel(User user, float val = 1.5f);

  [CITest(false)]
  [ChatSubCommand("Sim", "Displays the current sea level and how much it has risen.", "sea", ChatAuthorizationLevel.User)]
  public static void SeaLevel(User user);

  [CITest(false)]
  [ChatSubCommand("Sim", "Forces a world layer simulation tick to update layers immediately.", "wtick", ChatAuthorizationLevel.Admin)]
  public static void ForceWorldTick(User user);

  /// <summary>Structure to hold population change data</summary>
  private struct PopulationChange
  {
    public string LayerName;
    public float PopulationBefore;
    public float PopulationAfter;
    public float TotalRounded;

    public float Change { get; }
  }
}
