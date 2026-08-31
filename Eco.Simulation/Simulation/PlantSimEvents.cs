// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.PlantSimEvents
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Simulation.Agents;

#nullable disable
namespace Eco.Simulation;

public static class PlantSimEvents
{
  public static ThreadSafeAction<object, object> TreeFelledEvent;
  public static ThreadSafeAction<object> OnLogChopped;
  public static ThreadSafeAction<Plant, object, bool> OnPlantDestroyedOrHarvested;
  public static ThreadSafeAction<Plant> AfterPlantKilled;
}
