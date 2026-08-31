// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.IAnimalUtils
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.Agents;

/// <summary> Injector interface to communicate between Simulation and Gameplay namespace. Or in most cases get Gameplay data into Simulation, liek rooms, etc. </summary>
public interface IAnimalUtils
{
  bool IsPositionInClosedRoom(Vector3i pos);
}
