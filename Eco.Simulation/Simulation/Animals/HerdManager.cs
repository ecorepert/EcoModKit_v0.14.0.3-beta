// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Animals.HerdManager
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Simulation.Agents;
using Eco.Simulation.Pathfinding.Internal;
using Eco.Simulation.Types;

#nullable disable
namespace Eco.Simulation.Animals;

public class HerdManager : Singleton<HerdManager>
{
  public ThreadSafeDictionary<int, Herd> Herds;

  public (float Closest, float ClosestOfType) GetNearbyHerds(Vector2i pos, AnimalSpecies species);

  public Herd CreateNewHerd(int controllingPlayerID, AnimalSpecies animalSpecies);

  public Herd SpawnAndAdd(
    AnimalSpecies species,
    IWorldObserver closestPlayer,
    Vector3i rawHerdPos,
    PathRegion region,
    int overrideCount = 0);

  public void RemoveFromHerd(Animal a);

  public void RemoveHerd(Herd herd);
}
