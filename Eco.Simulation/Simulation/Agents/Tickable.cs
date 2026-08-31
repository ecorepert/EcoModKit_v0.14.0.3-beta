// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.Tickable
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using C5;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Simulation.Agents;

[Serialized]
public abstract class Tickable : ITickable, IComparable
{
  public virtual double NextTick { get; set; }

  public IPriorityQueueHandle<ITickable> QueueHandle { get; set; }

  public abstract void Tick();

  public abstract void Destroy();

  public int CompareTo(object other);

  public static bool operator <(Tickable l, Tickable r);

  public static bool operator >(Tickable l, Tickable r);

  public bool IsReady();
}
