// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Animals.AnimalPositionUtils
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.Agents;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Animals;

public static class AnimalPositionUtils
{
  /// <summary> Corrects death pos  that can be gotten from current server val or requested from client in async mode (if needed) Goal: Make sure animal dies not in air.</summary>
  public static Vector3 TryAdjustDeathPosition(Vector3 rawPos);

  /// <summary> Asks the controlling player for the current position of the animal, if there is a controlling player.</summary>
  public static void UpdatePosFromController(Animal a, Func<Vector3, Vector3> processor = null);
}
