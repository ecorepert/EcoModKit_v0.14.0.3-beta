// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.SimStats
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using System;
using System.Collections.Concurrent;

#nullable disable
namespace Eco.Simulation.WorldLayers;

public static class SimStats
{
  public static object LockObj;
  public static ConcurrentBag<Func<object>> GetStatHolders;

  public static event Action OnStatsCollected;

  public static void CollectStats(double delta);

  public static void RecordStatProps(int timeSeconds, object statHolder);
}
