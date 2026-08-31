// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.BasicSimulation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary> Simulation responsible for ticking inventories for spoiling food, and gathering performance stats. </summary>
public class BasicSimulation : Eco.Simulation.Simulation
{
  public double NextTickTimeMs;

  public BasicSimulation(LocString managerName);

  /// <summary> Tick Inventories and gather stats about running time, and update the next tick time. </summary>
  public override int TickAll(int maxTicksToRun = 10);

  public string GetStatus();
}
