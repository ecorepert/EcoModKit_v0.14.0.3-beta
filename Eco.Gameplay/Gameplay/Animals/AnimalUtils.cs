// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.AnimalUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using Eco.Simulation.Agents;

#nullable disable
namespace Eco.Gameplay.Animals;

public class AnimalUtils : IAnimalUtils
{
  /// <summary>
  /// Checks if a position is inside a closed room (not outdoor room).
  /// Returns true if the position is in a closed room, false otherwise.
  /// </summary>
  public bool IsPositionInClosedRoom(Vector3i pos);
}
