// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.AnimalsPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Simulation.Animals;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Animals;

[Localized(false, true, "", false)]
public class AnimalsPlugin : 
  SimplePlugin<AnimalsManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  ICommandablePlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab
{
  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public void Run();

  public Task ShutdownAsync();
}
