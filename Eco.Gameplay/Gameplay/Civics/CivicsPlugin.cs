// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Reflection;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Civics;

[Localized(true, false, "", false)]
[LocDisplayName("CivicsPlugin")]
[Priority(-100)]
public class CivicsPlugin : 
  Singleton<CivicsPlugin>,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IThreadedPlugin,
  IShutdownablePlugin,
  ISaveablePlugin,
  IInitializablePlugin,
  IContainsRegistrars,
  IConfigurablePlugin,
  IEditablePlugin
{
  public ThreadSafeAction OnOverthrowValueChanged;
  public ThreadSafeAction<PropertyInfo> OnBasicElectionValueChanged;

  public IPluginConfig PluginConfig { get; }

  public CivicsConfig Config { get; }

  public void Initialize(TimedTask timer);

  public void InitializeRegistrars(TimedTask timer);

  public string GetCategory();

  public string GetDisplayText();

  public string GetStatus();

  public override string ToString();

  public void Run();

  public Task ShutdownAsync();

  public void SaveAll();

  public object GetEditObject();

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public void OnEditObjectChanged(object o, string param);
}
