// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModKitPlugin
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Threading.Tasks;

#nullable enable
namespace Eco.ModKit;

[LocDisplayName("ModKitPlugin")]
public class ModKitPlugin : 
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  ICommandablePlugin,
  IConfigurablePlugin,
  IEditablePlugin,
  IInitializablePlugin,
  ICustomUIPlugin,
  ITabPage
{
  public static readonly 
  #nullable disable
  string ModDirectory;

  [Obsolete("Use TypesProvider instead", false)]
  public static ITypesProvider Compiler { get; }

  public static ITypesProvider TypesProvider { get; }

  public static ModContentSync ContentSync { get; }

  public static ModDataSync DataSync { get; }

  public static Eco.Core.Plugins.PluginConfig<ModKitConfig> Config { get; }

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public ImmutableList<Assembly> LoadedManagedAssemblies { get; }

  public ImmutableDictionary<Assembly, string> LoadedManagedAssemblyPaths { get; }

  public ModKitPlugin();

  public ModKitPlugin(ITypesProvider typesProvider);

  ~ModKitPlugin();

  /// <summary>Loads mods data.</summary>
  public Task LoadModsDataAsync();

  public void CacheRPC();

  public string GetDisplayText();

  public string GetStatus();

  public string GetCategory();

  public override string ToString();

  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public void Initialize(TimedTask timer);

  public object GetCustomUIControl();

  public string GetCustomUIName();

  public void OnEnter();

  public void OnLeave();
}
