// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.PathFinding.PathFindingPlugin
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Simulation.Pathfinding;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Simulation.PathFinding;

[Localized(false, true, "", false)]
public class PathFindingPlugin : 
  SimplePlugin<PathManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  ICommandablePlugin
{
  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public void Run();

  public Task ShutdownAsync();
}
