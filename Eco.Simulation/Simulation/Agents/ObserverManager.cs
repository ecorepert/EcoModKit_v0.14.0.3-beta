// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.ObserverManager
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Utils;
using Eco.Shared.Networking;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Agents;

public class ObserverManager
{
  public static ThreadSafeAction<IWorldObserver> ObserverJoinedEvent;
  public static ThreadSafeAction<IWorldObserver> ObserverLeftEvent;

  public static void ObserverJoined(IWorldObserver observer);

  public static void ObserverLeft(IWorldObserver observer);

  public static IEnumerable<IWorldObserver> Observers { get; }

  public static IWorldObserver GetObserver(int id);

  public ObserverManager();

  public ObserverManager(
    float alwaysWitnessedWithinRadius,
    float witnessIfFacingRadius,
    float fovToWitnessRad);

  public float ObservationLevel(Vector3 queryPos, float visibilityMult = 1f);
}
