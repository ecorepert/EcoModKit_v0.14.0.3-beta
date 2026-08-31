// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.InitialSpawn.InitialSpawnPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Systems.InitialSpawn;

/// <summary>Plugin that owns data for the InitialSpawnManager, handling choices when players enter a world.</summary>
[Localized(true, false, "", false)]
[Priority(100)]
public class InitialSpawnPlugin : 
  Singleton<InitialSpawnPlugin>,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IThreadedPlugin,
  IShutdownablePlugin,
  IInitializablePlugin,
  IContainsRegistrars,
  IConfigurablePlugin,
  IEditablePlugin
{
  public IPluginConfig PluginConfig { get; }

  public InitialSpawnConfig Config { get; }

  public void Initialize(TimedTask timer);

  public void InitializeRegistrars(TimedTask timer);

  public string GetCategory();

  public string GetDisplayText();

  public string GetStatus();

  public override string ToString();

  public void Run();

  public Task ShutdownAsync();

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public ThreadSafeAction<object, string> ParamChanged { get; set; }
}
