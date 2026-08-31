// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Time.PeriodicUpdateConfig
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Simulation.Time;

[Serialized]
public class PeriodicUpdateConfig : PeriodicUpdate
{
  public PeriodicUpdateConfig();

  public PeriodicUpdateConfig(bool userRealTime = true);

  public void Initialize(IConfigurablePlugin plugin, Func<double> paramToMonitor);

  public LocString Describe();
}
