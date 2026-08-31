// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.Catchers.SpeciesLayeredCatchPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.Animals.Catchers.Internal;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Animals.Catchers;

/// <summary>
/// Plugin that registers and updates species catchers.
/// It will tick active valid ones. Can be used for any kind of automatic species gather:
/// Animals traps, fishing traps, crab pots, trawler passive catch, etc
/// This moves gather logic (fishing/catching/etc) away from client and we secure it around server
/// </summary>
[LocDisplayName("SpeciesLayeredCatchPlugin")]
[Priority(100)]
public class SpeciesLayeredCatchPlugin : 
  Singleton<SpeciesLayeredCatchPlugin>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IConfigurablePlugin,
  IEditablePlugin,
  IInitializablePlugin
{
  public IPluginConfig PluginConfig { get; }

  public SpeciesLayeredCatchConfig Config { get; }

  /// <summary> Adds catcher to tracking list and dills data from configs </summary>
  public void AddLayeredCatcher(object key, LayeredCatchEntry catcher);

  public void Run();

  public Task ShutdownAsync();

  public void Initialize(TimedTask initializeTask);

  public string GetStatus();

  public string GetCategory();

  public string GetDisplayText();

  public override string ToString();

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public ThreadSafeAction<object, string> ParamChanged { get; set; }
}
