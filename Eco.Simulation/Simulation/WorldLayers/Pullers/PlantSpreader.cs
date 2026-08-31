// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Pullers.PlantSpreader
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

#nullable disable
namespace Eco.Simulation.WorldLayers.Pullers;

/// <summary> Populates values of Seeds for plants.
/// Seeds works this way: every tick plants tries to send seed in base of internal timer in some range from them.
/// This seeds will be used to increase the population layer.
/// </summary>
public static class PlantSpreader
{
  public static void SpreadPlants();
}
