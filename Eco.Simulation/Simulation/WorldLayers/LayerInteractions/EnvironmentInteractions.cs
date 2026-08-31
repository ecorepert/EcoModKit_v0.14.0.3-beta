// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.EnvironmentInteractions
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

public static class EnvironmentInteractions
{
  public static double TramplePerSecond;
  public static Range SickChanceForPollution;
  public static Range DeadChanceForPollution;

  /// <summary>Apply a given amount of time trample at a location.</summary>
  public static void ApplyTrample(Vector3i pos, float timeSpent);

  public static float GetTrample(Vector2i pos);

  public static float GetPlayerActivity(Vector2i pos);

  public static bool SickChance(Vector2i pos);

  public static bool DeadChance(Vector2i pos);
}
