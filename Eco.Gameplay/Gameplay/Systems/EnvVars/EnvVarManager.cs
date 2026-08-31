// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.EnvVars.EnvVarManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Systems.EnvVars;

public class EnvVarManager : 
  Singleton<
  #nullable disable
  EnvVarManager>,
  IInitializablePlugin,
  IServerPlugin,
  IController,
  IViewController,
  IHasUniversalID
{
  /// <summary>Check the cache to see if the given user is recorded as having cached the needed object.</summary>
  public bool UserHasEnvVarsForObj(User user, IController obj);

  /// <summary>Gets the env vars for the world object and all its components.</summary>
  public IEnumerable<EnvVar> GetEnvVarsSelfAndComponents(User user, WorldObject worldObj);

  void IInitializablePlugin.Initialize(TimedTask timer);

  public string GetStatus();

  public string GetCategory();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
