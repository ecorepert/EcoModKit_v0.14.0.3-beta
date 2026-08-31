// Decompiled with JetBrains decompiler
// Type: Eco.Server.PluginManager
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Eco.Core.FileStorage;
using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Server;

[Priority(-200)]
public sealed class PluginManager : 
  Singleton<
  #nullable disable
  PluginManager>,
  IPluginManager,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  ICommandablePlugin
{
  public event Action InitComplete;

  public bool Initialized { get; }

  public IFileStorage BaseStorage { get; }

  public IFileStorage ConfigStorage { get; }

  public IFileStorage DefaultConfigStorage { get; }

  IEnumerable<IServerPlugin> IPluginManager.Plugins { get; }

  public Task InitializeAsync(StartupInfo startupInfo);

  public void RunIfOrWhenInited(Action action);

  public void FireShutdown(ApplicationExitCodes exitCode = ApplicationExitCodes.NormalShutdown);

  public Task ShutdownAsync();

  public void ForEach(Action<IServerPlugin> action);

  public void OrderedForEach(Action<IServerPlugin> action);

  public T GetPlugin<T>();

  public T AddPlugin<T>(params object[] p) where T : IServerPlugin;

  public IServerPlugin AddPlugin(Type pluginType, params object[] p);

  public Task AddPluginAsync<T>(params object[] p) where T : IServerPlugin;

  public T AddPlugin<TService, T>(params object[] p) where T : IServerPlugin, TService;

  public Task AddPluginAsync<TService, T>(params object[] p) where T : IServerPlugin, TService;

  public void InitializeRegistrars();

  public void InitializePlugins();

  public void StartPlugins();

  public string GetPluginsStatus();

  public void OpenServerUI();

  public Task CloseServerUIAsync();

  public string GetStatus();

  public override string ToString();

  public string GetCategory();

  public string GetDisplayText();

  public void GetCommands(Dictionary<string, Action> nameToFunction);
}
