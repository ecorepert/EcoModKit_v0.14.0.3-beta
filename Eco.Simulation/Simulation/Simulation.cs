// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Simulation
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.Agents;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation;

public abstract class Simulation
{
  public int NumTickables { get; }

  public IEnumerable<ITickable> All { get; }

  /// <summary> Queue an update to an element. Updates are applied on <see cref="M:Eco.Simulation.Simulation.TickAll(System.Int32)" /> or <see cref="M:Eco.Simulation.Simulation.GetNextSmallestTickSeconds" /> </summary>
  public void QueueElementUpdate(ITickable element);

  public virtual int TickAll(int maxTicksToRun = 10);

  public double GetNextSmallestTickSeconds();

  public virtual void AddTickable(ITickable element);

  public virtual void RemoveTickable(ITickable element);

  public virtual void Clear();

  public virtual void MarkAllDirty();
}
